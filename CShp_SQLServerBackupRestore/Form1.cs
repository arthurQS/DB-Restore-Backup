using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace CShp_SQLServerBackupRestore
{
    public partial class Form1 : Form
    {
       
        //enumera uma lista de instâncias locais disponíveis do SQL Server
        DataTable tabelaServidores = SmoApplication.EnumAvailableSqlServers(true);
        //define o objeto do tipo Server
        private static Server servidor;
        //define o caminho para o backup/restore
        private string DBpath = Application.StartupPath;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            WindowState = FormWindowState.Normal;
            cboServidor.Enabled = false;
            cboDataBase.Enabled = false;

            try
            {
                chkIntegratedSecurity.Checked = true;

                // Se existerem servidores
                if (tabelaServidores.Rows.Count > 0)
                {
                    // Percorre cada servidor na tabela
                    foreach (DataRow drServer in tabelaServidores.Rows)
                    {
                        cboServidor.Items.Add(drServer["Name"]);
                        cboServidor.Text = Convert.ToString(drServer["Name"]);
                    }
                }
            }
            catch (Exception)
            {
                // Inicie o serviço do SQL Server Browser se não conseguir carregar os servidores.(http://msdn.microsoft.com/en-us/library/ms165734(v=sql.90).aspx
                MessageBox.Show("ERROR: Não existem servidores disponíveis.\nOu ocorreu um erro ao carregar os servidores", "Servidor Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                this.Cursor = Cursors.Default;
            }
            this.Cursor = Cursors.Default;
        }

        private void chkIntegratedSecurity_CheckedChanged(object sender, EventArgs e)
        {
            //verifica se o checkbox esta marcado ou desmarcado e altera as propriedades dos TextBox
            if (chkIntegratedSecurity.CheckState == CheckState.Checked)
            {
                txtUsuario.Enabled = false;
                txtUsuario.Text = string.Empty;

                txtSenha.Enabled = false;
                txtSenha.Text = string.Empty;
            }
            if (chkIntegratedSecurity.CheckState == CheckState.Unchecked)
            {
                txtUsuario.Enabled = true;
                txtSenha.Enabled = true;
            }
        }

        private void cboServidor_Click(object sender, EventArgs e)
        {
            //habilita o combobox do servidor
            cboServidor.Enabled = true;
        }

        private void cboDataBase_Click(object sender, EventArgs e)
        {
            //limpa o combobox dos databases
            cboDataBase.Items.Clear();
            try
            {
                //se foi selecionado um servidor
                if (cboServidor.SelectedItem != null && cboServidor.SelectedItem.ToString() != "")
                {
                    this.Cursor = Cursors.WaitCursor;
                    // Cria uma nova conexão com o servidor selecionado
                    ServerConnection srvConn = new ServerConnection(cboServidor.SelectedItem.ToString());
                    // Faz o Login usando a autenticacao SQL ao invés da autenticação do Windows
                    srvConn.LoginSecure = true;

                    //tipo de conexão não exige usuário e senha(usa a autenticação do windows)
                    if (chkIntegratedSecurity.CheckState == CheckState.Checked)
                    {
                        // Cria um novo objeto SQL Server usando a conexão criada
                        servidor = new Server(srvConn);
                        // percorre a lista de banco de dados
                        foreach (Database dbServer in servidor.Databases)
                        {
                            // Adiciona o banco de dados na combobox
                            cboDataBase.Items.Add(dbServer.Name);
                        }
                    }

                    //tipo de conexão exige usuário e senha
                    if (chkIntegratedSecurity.CheckState == CheckState.Unchecked)
                    {
                        // atribui o nome do usuário
                        srvConn.Login = txtUsuario.Text;
                        // atribui a senha
                        srvConn.Password = txtSenha.Text;
                        // Cria um novo objeto SQL Server usando a conexão criada
                        servidor = new Server(srvConn);
                        // percorre a lista de banco de dados
                        foreach (Database dbServer in servidor.Databases)
                        {
                            // Adiciona o banco de dados na combobox
                            cboDataBase.Items.Add(dbServer.Name);
                        }
                    }
                }
                else
                {
                    // Um servidor não foi selecionado exibe um erro
                    MessageBox.Show("ERROR: Contate o Administrador!!", "Servidor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                // Inicie o serviço do SQL Server Browser se não conseguir carregar os servidores.(http://msdn.microsoft.com/en-us/library/ms165734(v=sql.90).aspx
                MessageBox.Show("ERROR: Ocorreu um erro durante a carga dos banco de dados disponíveis", "Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Arrow;
            }
        }

        private void cboServidor_SelectedValueChanged(object sender, EventArgs e)
        {
            //habilita o combobox dos servidores
            cboServidor.Enabled = false;
        }

        private void cboDataBase_SelectedValueChanged(object sender, EventArgs e)
        {
            //habilita o combobox dos databases
            cboDataBase.Enabled = false;
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            //verifica se um banco de dados foi selecionado
            if (cboDataBase.SelectedIndex.ToString().Equals(""))
            {
                MessageBox.Show("Selecione um Database", "Server", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //se o objeto servidor for diferente de null temos uma conexão
            if (servidor != null)
            {
                try
                {
                    //desabilita os botões
                    btnBackup.Enabled = false;
                    btnRestore.Enabled = false;
                    btnAlterarDatabase.Enabled = false;
                    btnAlterarServidor.Enabled = false;

                    //Este codigo é usado se você já criou o arquivo de backup.
                    File.Delete(DBpath + "\\backup.bak");
                    this.Cursor = Cursors.WaitCursor;
                    // se o usuário escolheu um caminho onde salvar o backup
                    // Cria uma nova operação de backup
                    Backup bkpDatabase = new Backup();
                    // Define o tipo de backup type para o database
                    bkpDatabase.Action = BackupActionType.Database;
                    // Define o database que desejamos fazer o backup
                    bkpDatabase.Database = cboDataBase.SelectedItem.ToString();
                    // Define o dispositivo do backup para : file
                    BackupDeviceItem bkpDevice = new BackupDeviceItem(DBpath + "\\Backup.bak", DeviceType.File);
                    // Adiciona o dispositivo de backup ao backup
                    bkpDatabase.Devices.Add(bkpDevice);
                    // Realiza o backup
                    bkpDatabase.SqlBackup(servidor);
                    MessageBox.Show("Backup do Database " + cboDataBase.Text + " criado com sucesso", "Servidor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception x)
                {
                    MessageBox.Show("ERRO: Ocorreu um erro durante o BACKUP do DataBase" + x, "Erro no Servidor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    this.Cursor = Cursors.Arrow;
                    //habilita os botões
                    btnBackup.Enabled = true;
                    btnRestore.Enabled = true;
                    btnAlterarDatabase.Enabled = true;
                    btnAlterarServidor.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("ERRO: Não foi estabelecida uma conexão com o SQL Server", "Servidor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Arrow;
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            //verifica se foi selecoinado um banco de dados
            if (cboDataBase.SelectedIndex.ToString().Equals(""))
            {
                MessageBox.Show("Escolha um banco de dados", "Servidor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            // Se existir um conexão SQL Server criada
            if (servidor != null)
            {
                try
                {
                    //desabilita os botões
                    btnBackup.Enabled = false;
                    btnRestore.Enabled = false;
                    btnAlterarDatabase.Enabled = false;
                    btnAlterarServidor.Enabled = false;

                    this.Cursor = Cursors.WaitCursor;
                    // Se foi escolhido o arquivo o arquivo que deseja ser restaurado
                    // Cria uma nova operação de restore
                    Restore rstDatabase = new Restore();
                    // Define o tipo de restore para o banco de dados
                    rstDatabase.Action = RestoreActionType.Database;
                    // Define o database que desejamos restaurar
                    rstDatabase.Database = cboDataBase.SelectedItem.ToString();
                    // Define o dispostivo de backup a partir do qual vamos restaurar o arquivo
                    BackupDeviceItem bkpDevice = new BackupDeviceItem(DBpath + "\\Backup.bak", DeviceType.File);
                    // Adiciona o dispositivo de backup ao tipo de restore
                    rstDatabase.Devices.Add(bkpDevice);
                    // Se o banco de dados ja existe então subsititui
                    rstDatabase.ReplaceDatabase = true;
                    // Realiza o Restore
                    rstDatabase.SqlRestore(servidor);
                    MessageBox.Show("Database " + cboDataBase.Text + " RESTAURADO com sucesso", "Servidor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("ERRO: Ocorreu um erro durante a restauração do banco de dados", "Erro na aplicação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    this.Cursor = Cursors.Arrow;
                    //habilita os botões
                    btnBackup.Enabled = true;
                    btnRestore.Enabled = true;
                    btnAlterarDatabase.Enabled = true;
                    btnAlterarServidor.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("ERRO: Não foi estabelecida uma conexão com o SQL Server", "Servidor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Arrow;
            }
        }

        private void btnAlterarDatabase_Click(object sender, EventArgs e)
        {
            cboDataBase.Enabled = true;
        }

        private void btnAlterarServidor_Click(object sender, EventArgs e)
        {
            cboServidor.Enabled = true;
        }

        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Encerrar o programa?", "Encerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
