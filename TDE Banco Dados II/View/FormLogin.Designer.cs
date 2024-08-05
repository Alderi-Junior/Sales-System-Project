namespace TDE_Banco_Dados_II.Resources
{
    partial class FormLogin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.TxSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxUsuario = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BtLogin = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(518, 82);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(74, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Realizar Login";
            // 
            // TxSenha
            // 
            this.TxSenha.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxSenha.Location = new System.Drawing.Point(168, 156);
            this.TxSenha.Margin = new System.Windows.Forms.Padding(4);
            this.TxSenha.Name = "TxSenha";
            this.TxSenha.PasswordChar = '*';
            this.TxSenha.Size = new System.Drawing.Size(194, 26);
            this.TxSenha.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(104, 164);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 18);
            this.label2.TabIndex = 20;
            this.label2.Text = "Senha:";
            // 
            // TxUsuario
            // 
            this.TxUsuario.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxUsuario.Location = new System.Drawing.Point(168, 104);
            this.TxUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.TxUsuario.Name = "TxUsuario";
            this.TxUsuario.Size = new System.Drawing.Size(194, 26);
            this.TxUsuario.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(92, 107);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 18);
            this.label8.TabIndex = 18;
            this.label8.Text = "Usuário:";
            // 
            // BtLogin
            // 
            this.BtLogin.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtLogin.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtLogin.ForeColor = System.Drawing.Color.Transparent;
            this.BtLogin.Location = new System.Drawing.Point(168, 203);
            this.BtLogin.Name = "BtLogin";
            this.BtLogin.Size = new System.Drawing.Size(194, 47);
            this.BtLogin.TabIndex = 24;
            this.BtLogin.Text = " Login";
            this.BtLogin.UseVisualStyleBackColor = false;
            this.BtLogin.Click += new System.EventHandler(this.BtLogin_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 262);
            this.Controls.Add(this.BtLogin);
            this.Controls.Add(this.TxSenha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxUsuario);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox TxSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxUsuario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtLogin;
    }
}