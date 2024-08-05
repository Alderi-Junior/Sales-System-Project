namespace TDE_Banco_Dados_II.View
{
    partial class FormFornecedores
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
            this.TabCrudFornecedores = new System.Windows.Forms.TabControl();
            this.TabDados = new System.Windows.Forms.TabPage();
            this.TxNome = new System.Windows.Forms.TextBox();
            this.BtBuscar = new System.Windows.Forms.Button();
            this.BtSalvar = new System.Windows.Forms.Button();
            this.TxEmail = new System.Windows.Forms.TextBox();
            this.BtEditar = new System.Windows.Forms.Button();
            this.TxEndereco = new System.Windows.Forms.TextBox();
            this.TxCodigo = new System.Windows.Forms.TextBox();
            this.BtExcluir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TxCelular = new System.Windows.Forms.MaskedTextBox();
            this.BtNovo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.TxCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.TxCidade = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxComplemento = new System.Windows.Forms.TextBox();
            this.TxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.TxNumero = new System.Windows.Forms.TextBox();
            this.TxEstado = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TxCEP = new System.Windows.Forms.MaskedTextBox();
            this.TxBairro = new System.Windows.Forms.TextBox();
            this.tabConsulta = new System.Windows.Forms.TabPage();
            this.GridFornecedores = new System.Windows.Forms.DataGridView();
            this.BtPesquisar = new System.Windows.Forms.Button();
            this.TxPesquisar = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.TabCrudFornecedores.SuspendLayout();
            this.TabDados.SuspendLayout();
            this.tabConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridFornecedores)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(728, 82);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Fornecedores";
            // 
            // TabCrudFornecedores
            // 
            this.TabCrudFornecedores.Controls.Add(this.TabDados);
            this.TabCrudFornecedores.Controls.Add(this.tabConsulta);
            this.TabCrudFornecedores.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabCrudFornecedores.Location = new System.Drawing.Point(12, 89);
            this.TabCrudFornecedores.Name = "TabCrudFornecedores";
            this.TabCrudFornecedores.SelectedIndex = 0;
            this.TabCrudFornecedores.Size = new System.Drawing.Size(696, 432);
            this.TabCrudFornecedores.TabIndex = 3;
            // 
            // TabDados
            // 
            this.TabDados.Controls.Add(this.TxNome);
            this.TabDados.Controls.Add(this.BtBuscar);
            this.TabDados.Controls.Add(this.BtSalvar);
            this.TabDados.Controls.Add(this.TxEmail);
            this.TabDados.Controls.Add(this.BtEditar);
            this.TabDados.Controls.Add(this.TxEndereco);
            this.TabDados.Controls.Add(this.TxCodigo);
            this.TabDados.Controls.Add(this.BtExcluir);
            this.TabDados.Controls.Add(this.label2);
            this.TabDados.Controls.Add(this.TxCelular);
            this.TabDados.Controls.Add(this.BtNovo);
            this.TabDados.Controls.Add(this.label3);
            this.TabDados.Controls.Add(this.label15);
            this.TabDados.Controls.Add(this.label6);
            this.TabDados.Controls.Add(this.label10);
            this.TabDados.Controls.Add(this.label4);
            this.TabDados.Controls.Add(this.label13);
            this.TabDados.Controls.Add(this.label7);
            this.TabDados.Controls.Add(this.label14);
            this.TabDados.Controls.Add(this.label12);
            this.TabDados.Controls.Add(this.TxCNPJ);
            this.TabDados.Controls.Add(this.TxCidade);
            this.TabDados.Controls.Add(this.label8);
            this.TabDados.Controls.Add(this.TxComplemento);
            this.TabDados.Controls.Add(this.TxTelefone);
            this.TabDados.Controls.Add(this.TxNumero);
            this.TabDados.Controls.Add(this.TxEstado);
            this.TabDados.Controls.Add(this.label9);
            this.TabDados.Controls.Add(this.label11);
            this.TabDados.Controls.Add(this.TxCEP);
            this.TabDados.Controls.Add(this.TxBairro);
            this.TabDados.Location = new System.Drawing.Point(4, 27);
            this.TabDados.Name = "TabDados";
            this.TabDados.Padding = new System.Windows.Forms.Padding(3);
            this.TabDados.Size = new System.Drawing.Size(688, 401);
            this.TabDados.TabIndex = 0;
            this.TabDados.Text = "Dados Pessoais";
            this.TabDados.UseVisualStyleBackColor = true;
            // 
            // TxNome
            // 
            this.TxNome.Location = new System.Drawing.Point(89, 73);
            this.TxNome.Name = "TxNome";
            this.TxNome.Size = new System.Drawing.Size(262, 26);
            this.TxNome.TabIndex = 3;
            // 
            // BtBuscar
            // 
            this.BtBuscar.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtBuscar.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtBuscar.Location = new System.Drawing.Point(232, 216);
            this.BtBuscar.Name = "BtBuscar";
            this.BtBuscar.Size = new System.Drawing.Size(119, 28);
            this.BtBuscar.TabIndex = 6;
            this.BtBuscar.Text = "Buscar";
            this.BtBuscar.UseVisualStyleBackColor = false;
            this.BtBuscar.Click += new System.EventHandler(this.BtBuscar_Click);
            // 
            // BtSalvar
            // 
            this.BtSalvar.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtSalvar.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtSalvar.Location = new System.Drawing.Point(177, 330);
            this.BtSalvar.Name = "BtSalvar";
            this.BtSalvar.Size = new System.Drawing.Size(157, 62);
            this.BtSalvar.TabIndex = 3;
            this.BtSalvar.Text = "Salvar";
            this.BtSalvar.UseVisualStyleBackColor = false;
            this.BtSalvar.Click += new System.EventHandler(this.BtSalvar_Click);
            // 
            // TxEmail
            // 
            this.TxEmail.Location = new System.Drawing.Point(89, 117);
            this.TxEmail.Name = "TxEmail";
            this.TxEmail.Size = new System.Drawing.Size(262, 26);
            this.TxEmail.TabIndex = 5;
            // 
            // BtEditar
            // 
            this.BtEditar.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtEditar.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtEditar.Location = new System.Drawing.Point(340, 330);
            this.BtEditar.Name = "BtEditar";
            this.BtEditar.Size = new System.Drawing.Size(157, 62);
            this.BtEditar.TabIndex = 4;
            this.BtEditar.Text = "Editar";
            this.BtEditar.UseVisualStyleBackColor = false;
            this.BtEditar.Click += new System.EventHandler(this.BtEditar_Click);
            // 
            // TxEndereco
            // 
            this.TxEndereco.Location = new System.Drawing.Point(89, 287);
            this.TxEndereco.Name = "TxEndereco";
            this.TxEndereco.Size = new System.Drawing.Size(262, 26);
            this.TxEndereco.TabIndex = 15;
            // 
            // TxCodigo
            // 
            this.TxCodigo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TxCodigo.Enabled = false;
            this.TxCodigo.Location = new System.Drawing.Point(89, 41);
            this.TxCodigo.Name = "TxCodigo";
            this.TxCodigo.Size = new System.Drawing.Size(137, 26);
            this.TxCodigo.TabIndex = 1;
            // 
            // BtExcluir
            // 
            this.BtExcluir.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtExcluir.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtExcluir.Location = new System.Drawing.Point(519, 330);
            this.BtExcluir.Name = "BtExcluir";
            this.BtExcluir.Size = new System.Drawing.Size(157, 62);
            this.BtExcluir.TabIndex = 5;
            this.BtExcluir.Text = "Excluír";
            this.BtExcluir.UseVisualStyleBackColor = false;
            this.BtExcluir.Click += new System.EventHandler(this.BtExcluir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Código:";
            // 
            // TxCelular
            // 
            this.TxCelular.Location = new System.Drawing.Point(89, 160);
            this.TxCelular.Mask = "(99) 00000-0000";
            this.TxCelular.Name = "TxCelular";
            this.TxCelular.Size = new System.Drawing.Size(137, 26);
            this.TxCelular.TabIndex = 10;
            // 
            // BtNovo
            // 
            this.BtNovo.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtNovo.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtNovo.Location = new System.Drawing.Point(14, 330);
            this.BtNovo.Name = "BtNovo";
            this.BtNovo.Size = new System.Drawing.Size(157, 62);
            this.BtNovo.TabIndex = 2;
            this.BtNovo.Text = "Novo";
            this.BtNovo.UseVisualStyleBackColor = false;
            this.BtNovo.Click += new System.EventHandler(this.BtNovo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(395, 290);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 18);
            this.label15.TabIndex = 26;
            this.label15.Text = "Comp:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(395, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "CNPJ:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 219);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 18);
            this.label10.TabIndex = 17;
            this.label10.Text = "CEP:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "E-mail:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(395, 245);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 18);
            this.label13.TabIndex = 22;
            this.label13.Text = "Estado:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 18);
            this.label7.TabIndex = 11;
            this.label7.Text = "Celular:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(546, 240);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 18);
            this.label14.TabIndex = 24;
            this.label14.Text = "Número:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 251);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 18);
            this.label12.TabIndex = 20;
            this.label12.Text = "Bairro:";
            // 
            // TxCNPJ
            // 
            this.TxCNPJ.Location = new System.Drawing.Point(471, 100);
            this.TxCNPJ.Mask = "##,###,###/####-##";
            this.TxCNPJ.Name = "TxCNPJ";
            this.TxCNPJ.Size = new System.Drawing.Size(173, 26);
            this.TxCNPJ.TabIndex = 8;
            // 
            // TxCidade
            // 
            this.TxCidade.Location = new System.Drawing.Point(471, 196);
            this.TxCidade.Name = "TxCidade";
            this.TxCidade.Size = new System.Drawing.Size(204, 26);
            this.TxCidade.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(395, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 18);
            this.label8.TabIndex = 13;
            this.label8.Text = "Telefone:";
            // 
            // TxComplemento
            // 
            this.TxComplemento.Location = new System.Drawing.Point(471, 280);
            this.TxComplemento.Name = "TxComplemento";
            this.TxComplemento.Size = new System.Drawing.Size(204, 26);
            this.TxComplemento.TabIndex = 27;
            // 
            // TxTelefone
            // 
            this.TxTelefone.Location = new System.Drawing.Point(471, 148);
            this.TxTelefone.Mask = "(99) 000-0000";
            this.TxTelefone.Name = "TxTelefone";
            this.TxTelefone.Size = new System.Drawing.Size(137, 26);
            this.TxTelefone.TabIndex = 12;
            // 
            // TxNumero
            // 
            this.TxNumero.Location = new System.Drawing.Point(623, 232);
            this.TxNumero.Name = "TxNumero";
            this.TxNumero.Size = new System.Drawing.Size(52, 26);
            this.TxNumero.TabIndex = 25;
            // 
            // TxEstado
            // 
            this.TxEstado.Location = new System.Drawing.Point(471, 237);
            this.TxEstado.Name = "TxEstado";
            this.TxEstado.Size = new System.Drawing.Size(52, 26);
            this.TxEstado.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 290);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 18);
            this.label9.TabIndex = 14;
            this.label9.Text = "Endereço:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(395, 204);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 18);
            this.label11.TabIndex = 18;
            this.label11.Text = "Cidade:";
            // 
            // TxCEP
            // 
            this.TxCEP.Location = new System.Drawing.Point(89, 216);
            this.TxCEP.Mask = "00000-999";
            this.TxCEP.Name = "TxCEP";
            this.TxCEP.Size = new System.Drawing.Size(137, 26);
            this.TxCEP.TabIndex = 16;
            // 
            // TxBairro
            // 
            this.TxBairro.Location = new System.Drawing.Point(89, 248);
            this.TxBairro.Name = "TxBairro";
            this.TxBairro.Size = new System.Drawing.Size(262, 26);
            this.TxBairro.TabIndex = 21;
            // 
            // tabConsulta
            // 
            this.tabConsulta.Controls.Add(this.GridFornecedores);
            this.tabConsulta.Controls.Add(this.BtPesquisar);
            this.tabConsulta.Controls.Add(this.TxPesquisar);
            this.tabConsulta.Controls.Add(this.label16);
            this.tabConsulta.Location = new System.Drawing.Point(4, 27);
            this.tabConsulta.Name = "tabConsulta";
            this.tabConsulta.Padding = new System.Windows.Forms.Padding(3);
            this.tabConsulta.Size = new System.Drawing.Size(688, 401);
            this.tabConsulta.TabIndex = 1;
            this.tabConsulta.Text = "Consulta";
            this.tabConsulta.UseVisualStyleBackColor = true;
            // 
            // GridFornecedores
            // 
            this.GridFornecedores.AllowUserToAddRows = false;
            this.GridFornecedores.AllowUserToDeleteRows = false;
            this.GridFornecedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridFornecedores.Location = new System.Drawing.Point(6, 47);
            this.GridFornecedores.Name = "GridFornecedores";
            this.GridFornecedores.ReadOnly = true;
            this.GridFornecedores.Size = new System.Drawing.Size(695, 297);
            this.GridFornecedores.TabIndex = 7;
            this.GridFornecedores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridFornecedores_CellContentClick);
            // 
            // BtPesquisar
            // 
            this.BtPesquisar.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtPesquisar.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtPesquisar.Location = new System.Drawing.Point(371, 15);
            this.BtPesquisar.Name = "BtPesquisar";
            this.BtPesquisar.Size = new System.Drawing.Size(129, 26);
            this.BtPesquisar.TabIndex = 6;
            this.BtPesquisar.Text = "Pesquisar";
            this.BtPesquisar.UseVisualStyleBackColor = false;
            this.BtPesquisar.Click += new System.EventHandler(this.BtPesquisar_Click);
            // 
            // TxPesquisar
            // 
            this.TxPesquisar.Location = new System.Drawing.Point(94, 15);
            this.TxPesquisar.Name = "TxPesquisar";
            this.TxPesquisar.Size = new System.Drawing.Size(262, 26);
            this.TxPesquisar.TabIndex = 5;
            this.TxPesquisar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxPesquisar_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(11, 18);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 18);
            this.label16.TabIndex = 4;
            this.label16.Text = "Nome:";
            // 
            // FormFornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TDE_Banco_Dados_II.Properties.Resources.Flag_of_the_new_;
            this.ClientSize = new System.Drawing.Size(728, 519);
            this.Controls.Add(this.TabCrudFornecedores);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormFornecedores";
            this.Text = "Cadastro de Fornecedores";
            this.Load += new System.EventHandler(this.FormFornecedores_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.TabCrudFornecedores.ResumeLayout(false);
            this.TabDados.ResumeLayout(false);
            this.TabDados.PerformLayout();
            this.tabConsulta.ResumeLayout(false);
            this.tabConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridFornecedores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxNome;
        private System.Windows.Forms.Button BtBuscar;
        private System.Windows.Forms.Button BtSalvar;
        private System.Windows.Forms.TextBox TxEmail;
        private System.Windows.Forms.Button BtEditar;
        private System.Windows.Forms.TextBox TxEndereco;
        private System.Windows.Forms.TextBox TxCodigo;
        private System.Windows.Forms.Button BtExcluir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox TxCelular;
        private System.Windows.Forms.Button BtNovo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox TxCNPJ;
        private System.Windows.Forms.TextBox TxCidade;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxComplemento;
        private System.Windows.Forms.MaskedTextBox TxTelefone;
        private System.Windows.Forms.TextBox TxNumero;
        private System.Windows.Forms.TextBox TxEstado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox TxCEP;
        private System.Windows.Forms.TextBox TxBairro;
        private System.Windows.Forms.DataGridView GridFornecedores;
        private System.Windows.Forms.Button BtPesquisar;
        private System.Windows.Forms.TextBox TxPesquisar;
        private System.Windows.Forms.Label label16;
        public System.Windows.Forms.TabControl TabCrudFornecedores;
        public System.Windows.Forms.TabPage TabDados;
        public System.Windows.Forms.TabPage tabConsulta;
    }
}