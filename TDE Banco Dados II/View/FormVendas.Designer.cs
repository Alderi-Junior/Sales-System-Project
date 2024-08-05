namespace TDE_Banco_Dados_II.View
{
    partial class FormVendas
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxDataVenda = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxCPF = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtRemover = new System.Windows.Forms.Button();
            this.BtAdicionar = new System.Windows.Forms.Button();
            this.TxPreco = new System.Windows.Forms.TextBox();
            this.TxDesc = new System.Windows.Forms.TextBox();
            this.TxEmEstoque = new System.Windows.Forms.TextBox();
            this.TxEstoque = new System.Windows.Forms.TextBox();
            this.TxCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.GridVendas = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtCancelar = new System.Windows.Forms.Button();
            this.BtPagamento = new System.Windows.Forms.Button();
            this.Txtotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridVendas)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1011, 59);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(224, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tela de Vendas";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxDataVenda);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.TxNome);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TxCPF);
            this.groupBox1.Location = new System.Drawing.Point(12, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 170);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            // 
            // TxDataVenda
            // 
            this.TxDataVenda.Enabled = false;
            this.TxDataVenda.Location = new System.Drawing.Point(93, 36);
            this.TxDataVenda.Name = "TxDataVenda";
            this.TxDataVenda.ReadOnly = true;
            this.TxDataVenda.Size = new System.Drawing.Size(131, 26);
            this.TxDataVenda.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 18);
            this.label9.TabIndex = 14;
            this.label9.Text = "Data:";
            // 
            // TxNome
            // 
            this.TxNome.Enabled = false;
            this.TxNome.Location = new System.Drawing.Point(93, 124);
            this.TxNome.Name = "TxNome";
            this.TxNome.ReadOnly = true;
            this.TxNome.Size = new System.Drawing.Size(262, 26);
            this.TxNome.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nome:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "CPF:";
            // 
            // TxCPF
            // 
            this.TxCPF.Location = new System.Drawing.Point(93, 92);
            this.TxCPF.Mask = "###,###,###-##";
            this.TxCPF.Name = "TxCPF";
            this.TxCPF.Size = new System.Drawing.Size(131, 26);
            this.TxCPF.TabIndex = 10;
            this.TxCPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxCPF_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtRemover);
            this.groupBox2.Controls.Add(this.BtAdicionar);
            this.groupBox2.Controls.Add(this.TxPreco);
            this.groupBox2.Controls.Add(this.TxDesc);
            this.groupBox2.Controls.Add(this.TxEmEstoque);
            this.groupBox2.Controls.Add(this.TxEstoque);
            this.groupBox2.Controls.Add(this.TxCodigo);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(12, 256);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(378, 253);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Produto";
            // 
            // BtRemover
            // 
            this.BtRemover.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtRemover.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtRemover.ForeColor = System.Drawing.Color.Transparent;
            this.BtRemover.Location = new System.Drawing.Point(198, 171);
            this.BtRemover.Name = "BtRemover";
            this.BtRemover.Size = new System.Drawing.Size(157, 62);
            this.BtRemover.TabIndex = 21;
            this.BtRemover.Text = "Remover Item";
            this.BtRemover.UseVisualStyleBackColor = false;
            this.BtRemover.Click += new System.EventHandler(this.BtRemover_Click);
            // 
            // BtAdicionar
            // 
            this.BtAdicionar.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtAdicionar.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtAdicionar.ForeColor = System.Drawing.Color.Transparent;
            this.BtAdicionar.Location = new System.Drawing.Point(13, 171);
            this.BtAdicionar.Name = "BtAdicionar";
            this.BtAdicionar.Size = new System.Drawing.Size(157, 62);
            this.BtAdicionar.TabIndex = 20;
            this.BtAdicionar.Text = "Adicionar Item";
            this.BtAdicionar.UseVisualStyleBackColor = false;
            this.BtAdicionar.Click += new System.EventHandler(this.BtAdicionar_Click);
            // 
            // TxPreco
            // 
            this.TxPreco.Enabled = false;
            this.TxPreco.Location = new System.Drawing.Point(285, 101);
            this.TxPreco.Name = "TxPreco";
            this.TxPreco.ReadOnly = true;
            this.TxPreco.Size = new System.Drawing.Size(70, 26);
            this.TxPreco.TabIndex = 19;
            // 
            // TxDesc
            // 
            this.TxDesc.Enabled = false;
            this.TxDesc.Location = new System.Drawing.Point(114, 69);
            this.TxDesc.Name = "TxDesc";
            this.TxDesc.ReadOnly = true;
            this.TxDesc.Size = new System.Drawing.Size(241, 26);
            this.TxDesc.TabIndex = 15;
            // 
            // TxEmEstoque
            // 
            this.TxEmEstoque.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TxEmEstoque.Enabled = false;
            this.TxEmEstoque.Location = new System.Drawing.Point(114, 133);
            this.TxEmEstoque.Name = "TxEmEstoque";
            this.TxEmEstoque.Size = new System.Drawing.Size(70, 26);
            this.TxEmEstoque.TabIndex = 17;
            this.TxEmEstoque.TextChanged += new System.EventHandler(this.TxEstoque_TextChanged);
            // 
            // TxEstoque
            // 
            this.TxEstoque.Location = new System.Drawing.Point(114, 101);
            this.TxEstoque.Name = "TxEstoque";
            this.TxEstoque.Size = new System.Drawing.Size(70, 26);
            this.TxEstoque.TabIndex = 17;
            this.TxEstoque.TextChanged += new System.EventHandler(this.TxEstoque_TextChanged);
            // 
            // TxCodigo
            // 
            this.TxCodigo.BackColor = System.Drawing.SystemColors.HighlightText;
            this.TxCodigo.Location = new System.Drawing.Point(114, 34);
            this.TxCodigo.Name = "TxCodigo";
            this.TxCodigo.Size = new System.Drawing.Size(137, 26);
            this.TxCodigo.TabIndex = 13;
            this.TxCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxCodigo_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Código:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "Descrição:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 136);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 18);
            this.label10.TabIndex = 16;
            this.label10.Text = "Em Estoque:";
            this.label10.Click += new System.EventHandler(this.label5_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "Quantidade:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(190, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 18);
            this.label7.TabIndex = 18;
            this.label7.Text = "Preço (R$):";
            // 
            // GridVendas
            // 
            this.GridVendas.AllowUserToAddRows = false;
            this.GridVendas.AllowUserToDeleteRows = false;
            this.GridVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridVendas.Location = new System.Drawing.Point(396, 80);
            this.GridVendas.Name = "GridVendas";
            this.GridVendas.ReadOnly = true;
            this.GridVendas.Size = new System.Drawing.Size(603, 365);
            this.GridVendas.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtCancelar);
            this.groupBox3.Controls.Add(this.BtPagamento);
            this.groupBox3.Controls.Add(this.Txtotal);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(396, 459);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(603, 126);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Total";
            // 
            // BtCancelar
            // 
            this.BtCancelar.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtCancelar.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtCancelar.ForeColor = System.Drawing.Color.Transparent;
            this.BtCancelar.Location = new System.Drawing.Point(438, 25);
            this.BtCancelar.Name = "BtCancelar";
            this.BtCancelar.Size = new System.Drawing.Size(157, 62);
            this.BtCancelar.TabIndex = 23;
            this.BtCancelar.Text = "Cancelar Venda";
            this.BtCancelar.UseVisualStyleBackColor = false;
            // 
            // BtPagamento
            // 
            this.BtPagamento.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtPagamento.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtPagamento.ForeColor = System.Drawing.Color.Transparent;
            this.BtPagamento.Location = new System.Drawing.Point(253, 25);
            this.BtPagamento.Name = "BtPagamento";
            this.BtPagamento.Size = new System.Drawing.Size(157, 62);
            this.BtPagamento.TabIndex = 22;
            this.BtPagamento.Text = "Pagamento";
            this.BtPagamento.UseVisualStyleBackColor = false;
            this.BtPagamento.Click += new System.EventHandler(this.BtPagamento_Click);
            // 
            // Txtotal
            // 
            this.Txtotal.Enabled = false;
            this.Txtotal.Location = new System.Drawing.Point(102, 29);
            this.Txtotal.Name = "Txtotal";
            this.Txtotal.ReadOnly = true;
            this.Txtotal.Size = new System.Drawing.Size(131, 26);
            this.Txtotal.TabIndex = 13;
            this.Txtotal.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 18);
            this.label8.TabIndex = 12;
            this.label8.Text = " Total (R$):";
            // 
            // FormVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 597);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.GridVendas);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormVendas";
            this.Text = "Vendas";
            this.Load += new System.EventHandler(this.FormVendas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridVendas)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox TxCPF;
        private System.Windows.Forms.TextBox TxNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxPreco;
        private System.Windows.Forms.TextBox TxDesc;
        private System.Windows.Forms.TextBox TxEstoque;
        private System.Windows.Forms.TextBox TxCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtRemover;
        private System.Windows.Forms.Button BtAdicionar;
        private System.Windows.Forms.DataGridView GridVendas;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox Txtotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtCancelar;
        private System.Windows.Forms.Button BtPagamento;
        private System.Windows.Forms.TextBox TxDataVenda;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxEmEstoque;
        private System.Windows.Forms.Label label10;
    }
}