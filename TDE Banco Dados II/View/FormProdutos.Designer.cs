namespace TDE_Banco_Dados_II.View
{
    partial class FormProdutos
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TabCrudProdutos = new System.Windows.Forms.TabControl();
            this.TabDados = new System.Windows.Forms.TabPage();
            this.TxPreco = new System.Windows.Forms.TextBox();
            this.CbFornecedor = new System.Windows.Forms.ComboBox();
            this.TxDesc = new System.Windows.Forms.TextBox();
            this.BtSalvar = new System.Windows.Forms.Button();
            this.TxEstoque = new System.Windows.Forms.TextBox();
            this.BtEditar = new System.Windows.Forms.Button();
            this.TxCodigo = new System.Windows.Forms.TextBox();
            this.BtExcluir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BtNovo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.GridProdutos = new System.Windows.Forms.DataGridView();
            this.BtPesquisar = new System.Windows.Forms.Button();
            this.TxPequisar = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.TabCrudProdutos.SuspendLayout();
            this.TabDados.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Produtos";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(710, 82);
            this.panel1.TabIndex = 1;
            // 
            // TabCrudProdutos
            // 
            this.TabCrudProdutos.Controls.Add(this.TabDados);
            this.TabCrudProdutos.Controls.Add(this.tabPage4);
            this.TabCrudProdutos.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabCrudProdutos.Location = new System.Drawing.Point(12, 89);
            this.TabCrudProdutos.Name = "TabCrudProdutos";
            this.TabCrudProdutos.SelectedIndex = 0;
            this.TabCrudProdutos.Size = new System.Drawing.Size(684, 375);
            this.TabCrudProdutos.TabIndex = 2;
            // 
            // TabDados
            // 
            this.TabDados.Controls.Add(this.TxPreco);
            this.TabDados.Controls.Add(this.CbFornecedor);
            this.TabDados.Controls.Add(this.TxDesc);
            this.TabDados.Controls.Add(this.BtSalvar);
            this.TabDados.Controls.Add(this.TxEstoque);
            this.TabDados.Controls.Add(this.BtEditar);
            this.TabDados.Controls.Add(this.TxCodigo);
            this.TabDados.Controls.Add(this.BtExcluir);
            this.TabDados.Controls.Add(this.label2);
            this.TabDados.Controls.Add(this.BtNovo);
            this.TabDados.Controls.Add(this.label3);
            this.TabDados.Controls.Add(this.label6);
            this.TabDados.Controls.Add(this.label4);
            this.TabDados.Controls.Add(this.label5);
            this.TabDados.Location = new System.Drawing.Point(4, 27);
            this.TabDados.Name = "TabDados";
            this.TabDados.Padding = new System.Windows.Forms.Padding(3);
            this.TabDados.Size = new System.Drawing.Size(676, 344);
            this.TabDados.TabIndex = 0;
            this.TabDados.Text = "Dados do Produto";
            this.TabDados.UseVisualStyleBackColor = true;
            // 
            // TxPreco
            // 
            this.TxPreco.Location = new System.Drawing.Point(471, 70);
            this.TxPreco.Name = "TxPreco";
            this.TxPreco.Size = new System.Drawing.Size(137, 26);
            this.TxPreco.TabIndex = 11;
            // 
            // CbFornecedor
            // 
            this.CbFornecedor.FormattingEnabled = true;
            this.CbFornecedor.Location = new System.Drawing.Point(110, 114);
            this.CbFornecedor.Name = "CbFornecedor";
            this.CbFornecedor.Size = new System.Drawing.Size(241, 26);
            this.CbFornecedor.TabIndex = 10;
            // 
            // TxDesc
            // 
            this.TxDesc.Location = new System.Drawing.Point(110, 73);
            this.TxDesc.Name = "TxDesc";
            this.TxDesc.Size = new System.Drawing.Size(241, 26);
            this.TxDesc.TabIndex = 3;
            // 
            // BtSalvar
            // 
            this.BtSalvar.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtSalvar.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtSalvar.Location = new System.Drawing.Point(171, 276);
            this.BtSalvar.Name = "BtSalvar";
            this.BtSalvar.Size = new System.Drawing.Size(157, 62);
            this.BtSalvar.TabIndex = 3;
            this.BtSalvar.Text = "Salvar";
            this.BtSalvar.UseVisualStyleBackColor = false;
            this.BtSalvar.Click += new System.EventHandler(this.BtSalvar_Click);
            // 
            // TxEstoque
            // 
            this.TxEstoque.Location = new System.Drawing.Point(471, 117);
            this.TxEstoque.Name = "TxEstoque";
            this.TxEstoque.Size = new System.Drawing.Size(137, 26);
            this.TxEstoque.TabIndex = 5;
            // 
            // BtEditar
            // 
            this.BtEditar.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtEditar.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtEditar.Location = new System.Drawing.Point(334, 276);
            this.BtEditar.Name = "BtEditar";
            this.BtEditar.Size = new System.Drawing.Size(157, 62);
            this.BtEditar.TabIndex = 4;
            this.BtEditar.Text = "Editar";
            this.BtEditar.UseVisualStyleBackColor = false;
            this.BtEditar.Click += new System.EventHandler(this.BtEditar_Click);
            // 
            // TxCodigo
            // 
            this.TxCodigo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TxCodigo.Enabled = false;
            this.TxCodigo.Location = new System.Drawing.Point(110, 41);
            this.TxCodigo.Name = "TxCodigo";
            this.TxCodigo.Size = new System.Drawing.Size(137, 26);
            this.TxCodigo.TabIndex = 1;
            // 
            // BtExcluir
            // 
            this.BtExcluir.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtExcluir.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtExcluir.Location = new System.Drawing.Point(513, 276);
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
            // BtNovo
            // 
            this.BtNovo.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtNovo.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtNovo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtNovo.Location = new System.Drawing.Point(8, 276);
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
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descrição:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Fornecedor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(371, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Em Estoque:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(371, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Preço (R$):";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.GridProdutos);
            this.tabPage4.Controls.Add(this.BtPesquisar);
            this.tabPage4.Controls.Add(this.TxPequisar);
            this.tabPage4.Controls.Add(this.label16);
            this.tabPage4.Location = new System.Drawing.Point(4, 27);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(676, 344);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Consulta";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // GridProdutos
            // 
            this.GridProdutos.AllowUserToAddRows = false;
            this.GridProdutos.AllowUserToDeleteRows = false;
            this.GridProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridProdutos.Location = new System.Drawing.Point(6, 47);
            this.GridProdutos.Name = "GridProdutos";
            this.GridProdutos.ReadOnly = true;
            this.GridProdutos.Size = new System.Drawing.Size(695, 297);
            this.GridProdutos.TabIndex = 7;
            this.GridProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridProdutos_CellContentClick);
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
            // TxPequisar
            // 
            this.TxPequisar.Location = new System.Drawing.Point(94, 15);
            this.TxPequisar.Name = "TxPequisar";
            this.TxPequisar.Size = new System.Drawing.Size(262, 26);
            this.TxPequisar.TabIndex = 5;
            this.TxPequisar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxPequisar_KeyPress);
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
            // FormProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TDE_Banco_Dados_II.Properties.Resources.Flag_of_the_new_;
            this.ClientSize = new System.Drawing.Size(710, 467);
            this.Controls.Add(this.TabCrudProdutos);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormProdutos";
            this.Text = "Cadastro de Produtos";
            this.Load += new System.EventHandler(this.FormProdutos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.TabCrudProdutos.ResumeLayout(false);
            this.TabDados.ResumeLayout(false);
            this.TabDados.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxDesc;
        private System.Windows.Forms.Button BtSalvar;
        private System.Windows.Forms.TextBox TxEstoque;
        private System.Windows.Forms.Button BtEditar;
        private System.Windows.Forms.TextBox TxCodigo;
        private System.Windows.Forms.Button BtExcluir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtNovo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView GridProdutos;
        private System.Windows.Forms.Button BtPesquisar;
        private System.Windows.Forms.TextBox TxPequisar;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox CbFornecedor;
        private System.Windows.Forms.TextBox TxPreco;
        public System.Windows.Forms.TabControl TabCrudProdutos;
        public System.Windows.Forms.TabPage TabDados;
        public System.Windows.Forms.TabPage tabPage4;
    }
}