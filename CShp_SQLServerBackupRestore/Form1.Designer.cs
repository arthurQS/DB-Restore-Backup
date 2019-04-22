namespace CShp_SQLServerBackupRestore
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboDataBase = new System.Windows.Forms.ComboBox();
            this.cboServidor = new System.Windows.Forms.ComboBox();
            this.chkIntegratedSecurity = new System.Windows.Forms.CheckBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pb_status = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAlterarDatabase = new System.Windows.Forms.Button();
            this.btnAlterarServidor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnEncerrar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_status)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEncerrar);
            this.groupBox1.Controls.Add(this.cboDataBase);
            this.groupBox1.Controls.Add(this.cboServidor);
            this.groupBox1.Controls.Add(this.chkIntegratedSecurity);
            this.groupBox1.Controls.Add(this.txtUsuario);
            this.groupBox1.Controls.Add(this.txtSenha);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.pb_status);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnAlterarDatabase);
            this.groupBox1.Controls.Add(this.btnAlterarServidor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnRestore);
            this.groupBox1.Controls.Add(this.btnBackup);
            this.groupBox1.Location = new System.Drawing.Point(16, 38);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(791, 342);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opções";
            // 
            // cboDataBase
            // 
            this.cboDataBase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDataBase.FormattingEnabled = true;
            this.cboDataBase.Location = new System.Drawing.Point(431, 242);
            this.cboDataBase.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboDataBase.Name = "cboDataBase";
            this.cboDataBase.Size = new System.Drawing.Size(234, 28);
            this.cboDataBase.TabIndex = 15;
            this.cboDataBase.SelectedValueChanged += new System.EventHandler(this.cboDataBase_SelectedValueChanged);
            this.cboDataBase.Click += new System.EventHandler(this.cboDataBase_Click);
            // 
            // cboServidor
            // 
            this.cboServidor.FormattingEnabled = true;
            this.cboServidor.Location = new System.Drawing.Point(431, 46);
            this.cboServidor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboServidor.Name = "cboServidor";
            this.cboServidor.Size = new System.Drawing.Size(234, 28);
            this.cboServidor.TabIndex = 14;
            this.cboServidor.SelectedValueChanged += new System.EventHandler(this.cboServidor_SelectedValueChanged);
            this.cboServidor.Click += new System.EventHandler(this.cboServidor_Click);
            // 
            // chkIntegratedSecurity
            // 
            this.chkIntegratedSecurity.AutoSize = true;
            this.chkIntegratedSecurity.Location = new System.Drawing.Point(431, 192);
            this.chkIntegratedSecurity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkIntegratedSecurity.Name = "chkIntegratedSecurity";
            this.chkIntegratedSecurity.Size = new System.Drawing.Size(153, 24);
            this.chkIntegratedSecurity.TabIndex = 13;
            this.chkIntegratedSecurity.Text = "Integrated Security";
            this.chkIntegratedSecurity.UseVisualStyleBackColor = true;
            this.chkIntegratedSecurity.CheckedChanged += new System.EventHandler(this.chkIntegratedSecurity_CheckedChanged);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(431, 98);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(234, 27);
            this.txtUsuario.TabIndex = 12;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(431, 151);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(234, 27);
            this.txtSenha.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(317, 155);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Senha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(317, 103);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Usuário";
            // 
            // pb_status
            // 
            this.pb_status.BackColor = System.Drawing.Color.White;
            this.pb_status.Image = ((System.Drawing.Image)(resources.GetObject("pb_status.Image")));
            this.pb_status.Location = new System.Drawing.Point(8, 31);
            this.pb_status.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pb_status.Name = "pb_status";
            this.pb_status.Size = new System.Drawing.Size(301, 291);
            this.pb_status.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_status.TabIndex = 8;
            this.pb_status.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(317, 246);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Database";
            // 
            // btnAlterarDatabase
            // 
            this.btnAlterarDatabase.Location = new System.Drawing.Point(673, 242);
            this.btnAlterarDatabase.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAlterarDatabase.Name = "btnAlterarDatabase";
            this.btnAlterarDatabase.Size = new System.Drawing.Size(91, 31);
            this.btnAlterarDatabase.TabIndex = 3;
            this.btnAlterarDatabase.Text = "Alterar";
            this.btnAlterarDatabase.UseVisualStyleBackColor = true;
            this.btnAlterarDatabase.Click += new System.EventHandler(this.btnAlterarDatabase_Click);
            // 
            // btnAlterarServidor
            // 
            this.btnAlterarServidor.Location = new System.Drawing.Point(673, 45);
            this.btnAlterarServidor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAlterarServidor.Name = "btnAlterarServidor";
            this.btnAlterarServidor.Size = new System.Drawing.Size(91, 28);
            this.btnAlterarServidor.TabIndex = 3;
            this.btnAlterarServidor.Text = "Alterar";
            this.btnAlterarServidor.UseVisualStyleBackColor = true;
            this.btnAlterarServidor.Click += new System.EventHandler(this.btnAlterarServidor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(317, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Servidor";
            // 
            // btnRestore
            // 
            this.btnRestore.BackColor = System.Drawing.Color.LawnGreen;
            this.btnRestore.Location = new System.Drawing.Point(553, 286);
            this.btnRestore.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(112, 46);
            this.btnRestore.TabIndex = 0;
            this.btnRestore.Text = "Restore";
            this.btnRestore.UseVisualStyleBackColor = false;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnBackup
            // 
            this.btnBackup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnBackup.Location = new System.Drawing.Point(431, 286);
            this.btnBackup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(114, 46);
            this.btnBackup.TabIndex = 0;
            this.btnBackup.Text = "Backup";
            this.btnBackup.UseVisualStyleBackColor = false;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnEncerrar
            // 
            this.btnEncerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEncerrar.Location = new System.Drawing.Point(673, 286);
            this.btnEncerrar.Name = "btnEncerrar";
            this.btnEncerrar.Size = new System.Drawing.Size(91, 46);
            this.btnEncerrar.TabIndex = 16;
            this.btnEncerrar.Text = "Encerrar";
            this.btnEncerrar.UseVisualStyleBackColor = false;
            this.btnEncerrar.Click += new System.EventHandler(this.btnEncerrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(833, 415);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SQL Server : Backup / Restore";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_status)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboDataBase;
        private System.Windows.Forms.ComboBox cboServidor;
        private System.Windows.Forms.CheckBox chkIntegratedSecurity;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pb_status;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAlterarDatabase;
        private System.Windows.Forms.Button btnAlterarServidor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Button btnEncerrar;
    }
}

