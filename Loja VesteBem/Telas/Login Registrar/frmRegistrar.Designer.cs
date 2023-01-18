namespace Loja_VesteBem
{
    partial class frmRegistrar
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblLoginSenha = new System.Windows.Forms.Label();
            this.lblLoginNome = new System.Windows.Forms.Label();
            this.btnRegistrarDfn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSenhaReg = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.Label();
            this.btnVoltarMenuADMFornecedores = new System.Windows.Forms.Button();
            this.txtCelularReg = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.DimGray;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtNome.Location = new System.Drawing.Point(122, 164);
            this.txtNome.MaxLength = 45;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(167, 29);
            this.txtNome.TabIndex = 12;
            // 
            // lblLoginSenha
            // 
            this.lblLoginSenha.AutoSize = true;
            this.lblLoginSenha.BackColor = System.Drawing.Color.Transparent;
            this.lblLoginSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginSenha.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLoginSenha.Location = new System.Drawing.Point(32, 224);
            this.lblLoginSenha.Name = "lblLoginSenha";
            this.lblLoginSenha.Size = new System.Drawing.Size(52, 24);
            this.lblLoginSenha.TabIndex = 10;
            this.lblLoginSenha.Text = "CPF:";
            // 
            // lblLoginNome
            // 
            this.lblLoginNome.AutoSize = true;
            this.lblLoginNome.BackColor = System.Drawing.Color.Transparent;
            this.lblLoginNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginNome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLoginNome.Location = new System.Drawing.Point(22, 167);
            this.lblLoginNome.Name = "lblLoginNome";
            this.lblLoginNome.Size = new System.Drawing.Size(67, 24);
            this.lblLoginNome.TabIndex = 9;
            this.lblLoginNome.Text = "Nome:";
            // 
            // btnRegistrarDfn
            // 
            this.btnRegistrarDfn.BackColor = System.Drawing.Color.Black;
            this.btnRegistrarDfn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnRegistrarDfn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarDfn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegistrarDfn.Location = new System.Drawing.Point(239, 342);
            this.btnRegistrarDfn.Name = "btnRegistrarDfn";
            this.btnRegistrarDfn.Size = new System.Drawing.Size(142, 34);
            this.btnRegistrarDfn.TabIndex = 8;
            this.btnRegistrarDfn.Text = "Registrar";
            this.btnRegistrarDfn.UseVisualStyleBackColor = false;
            this.btnRegistrarDfn.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::Loja_VesteBem.Properties.Resources.logo2;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(239, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(142, 90);
            this.panel2.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(239, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "REGISTRAR";
            // 
            // txtCelular
            // 
            this.txtCelular.AutoSize = true;
            this.txtCelular.BackColor = System.Drawing.Color.Transparent;
            this.txtCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelular.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtCelular.Location = new System.Drawing.Point(332, 224);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(74, 24);
            this.txtCelular.TabIndex = 17;
            this.txtCelular.Text = "Celular:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(320, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 24);
            this.label3.TabIndex = 16;
            this.label3.Text = "Telefone:";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.DimGray;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtEmail.Location = new System.Drawing.Point(122, 278);
            this.txtEmail.MaxLength = 45;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(167, 29);
            this.txtEmail.TabIndex = 21;
            this.txtEmail.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(21, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 24);
            this.label4.TabIndex = 20;
            this.label4.Text = "E-mail:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtSenhaReg
            // 
            this.txtSenhaReg.BackColor = System.Drawing.Color.DimGray;
            this.txtSenhaReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaReg.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtSenhaReg.Location = new System.Drawing.Point(420, 278);
            this.txtSenhaReg.MaxLength = 15;
            this.txtSenhaReg.Name = "txtSenhaReg";
            this.txtSenhaReg.Size = new System.Drawing.Size(167, 29);
            this.txtSenhaReg.TabIndex = 23;
            this.txtSenhaReg.UseSystemPasswordChar = true;
            // 
            // txtSenha
            // 
            this.txtSenha.AutoSize = true;
            this.txtSenha.BackColor = System.Drawing.Color.Transparent;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtSenha.Location = new System.Drawing.Point(332, 281);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(70, 24);
            this.txtSenha.TabIndex = 22;
            this.txtSenha.Text = "Senha:";
            // 
            // btnVoltarMenuADMFornecedores
            // 
            this.btnVoltarMenuADMFornecedores.BackColor = System.Drawing.Color.Transparent;
            this.btnVoltarMenuADMFornecedores.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnVoltarMenuADMFornecedores.FlatAppearance.BorderSize = 0;
            this.btnVoltarMenuADMFornecedores.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVoltarMenuADMFornecedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltarMenuADMFornecedores.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVoltarMenuADMFornecedores.Location = new System.Drawing.Point(12, 12);
            this.btnVoltarMenuADMFornecedores.Name = "btnVoltarMenuADMFornecedores";
            this.btnVoltarMenuADMFornecedores.Size = new System.Drawing.Size(113, 34);
            this.btnVoltarMenuADMFornecedores.TabIndex = 60;
            this.btnVoltarMenuADMFornecedores.Text = "Voltar";
            this.btnVoltarMenuADMFornecedores.UseVisualStyleBackColor = false;
            this.btnVoltarMenuADMFornecedores.Click += new System.EventHandler(this.btnVoltarMenuADMFornecedores_Click);
            // 
            // txtCelularReg
            // 
            this.txtCelularReg.BackColor = System.Drawing.Color.DimGray;
            this.txtCelularReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelularReg.Location = new System.Drawing.Point(420, 221);
            this.txtCelularReg.Mask = "(99) 00000-0000";
            this.txtCelularReg.Name = "txtCelularReg";
            this.txtCelularReg.PromptChar = ' ';
            this.txtCelularReg.Size = new System.Drawing.Size(167, 29);
            this.txtCelularReg.TabIndex = 67;
            // 
            // txtTelefone
            // 
            this.txtTelefone.BackColor = System.Drawing.Color.DimGray;
            this.txtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.Location = new System.Drawing.Point(420, 162);
            this.txtTelefone.Mask = "(99) 0000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.PromptChar = ' ';
            this.txtTelefone.Size = new System.Drawing.Size(167, 29);
            this.txtTelefone.TabIndex = 66;
            // 
            // txtCPF
            // 
            this.txtCPF.BackColor = System.Drawing.Color.DimGray;
            this.txtCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPF.Location = new System.Drawing.Point(122, 221);
            this.txtCPF.Mask = "000,000,000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.PromptChar = ' ';
            this.txtCPF.Size = new System.Drawing.Size(167, 29);
            this.txtCPF.TabIndex = 65;
            // 
            // frmRegistrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Loja_VesteBem.Properties.Resources.fundo1_logo1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(614, 419);
            this.Controls.Add(this.txtCelularReg);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.btnVoltarMenuADMFornecedores);
            this.Controls.Add(this.txtSenhaReg);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblLoginSenha);
            this.Controls.Add(this.lblLoginNome);
            this.Controls.Add(this.btnRegistrarDfn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmRegistrar";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.frmRegistrar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblLoginSenha;
        private System.Windows.Forms.Label lblLoginNome;
        private System.Windows.Forms.Button btnRegistrarDfn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtCelular;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSenhaReg;
        private System.Windows.Forms.Label txtSenha;
        private System.Windows.Forms.Button btnVoltarMenuADMFornecedores;
        private System.Windows.Forms.MaskedTextBox txtCelularReg;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.MaskedTextBox txtCPF;
    }
}