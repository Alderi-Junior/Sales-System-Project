namespace TDE_Banco_Dados_II.View
{
    partial class FormDetalhes
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
            this.GpConsulta = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxCliente = new System.Windows.Forms.TextBox();
            this.TxData = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxObs = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.GridDetalhes = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.GpConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridDetalhes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(572, 59);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(37, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(484, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Detalhes da Venda";
            // 
            // GpConsulta
            // 
            this.GpConsulta.Controls.Add(this.TxObs);
            this.GpConsulta.Controls.Add(this.label5);
            this.GpConsulta.Controls.Add(this.TxTotal);
            this.GpConsulta.Controls.Add(this.label4);
            this.GpConsulta.Controls.Add(this.TxData);
            this.GpConsulta.Controls.Add(this.label3);
            this.GpConsulta.Controls.Add(this.TxCliente);
            this.GpConsulta.Controls.Add(this.label2);
            this.GpConsulta.Location = new System.Drawing.Point(12, 65);
            this.GpConsulta.Name = "GpConsulta";
            this.GpConsulta.Size = new System.Drawing.Size(547, 174);
            this.GpConsulta.TabIndex = 5;
            this.GpConsulta.TabStop = false;
            this.GpConsulta.Text = "Dados da Venda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cliente:";
            // 
            // TxCliente
            // 
            this.TxCliente.Location = new System.Drawing.Point(79, 21);
            this.TxCliente.Name = "TxCliente";
            this.TxCliente.Size = new System.Drawing.Size(182, 26);
            this.TxCliente.TabIndex = 3;
            // 
            // TxData
            // 
            this.TxData.Location = new System.Drawing.Point(111, 53);
            this.TxData.Name = "TxData";
            this.TxData.Size = new System.Drawing.Size(150, 26);
            this.TxData.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data  Venda:";
            // 
            // TxTotal
            // 
            this.TxTotal.Location = new System.Drawing.Point(402, 21);
            this.TxTotal.Name = "TxTotal";
            this.TxTotal.Size = new System.Drawing.Size(129, 26);
            this.TxTotal.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(281, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Total da Venda:";
            // 
            // TxObs
            // 
            this.TxObs.Location = new System.Drawing.Point(111, 91);
            this.TxObs.Multiline = true;
            this.TxObs.Name = "TxObs";
            this.TxObs.ReadOnly = true;
            this.TxObs.Size = new System.Drawing.Size(420, 75);
            this.TxObs.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Observações:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // GridDetalhes
            // 
            this.GridDetalhes.AllowUserToAddRows = false;
            this.GridDetalhes.AllowUserToDeleteRows = false;
            this.GridDetalhes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridDetalhes.Location = new System.Drawing.Point(12, 263);
            this.GridDetalhes.Name = "GridDetalhes";
            this.GridDetalhes.ReadOnly = true;
            this.GridDetalhes.Size = new System.Drawing.Size(547, 302);
            this.GridDetalhes.TabIndex = 6;
            this.GridDetalhes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridDetalhes_CellClick);
            // 
            // FormDetalhes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 577);
            this.Controls.Add(this.GridDetalhes);
            this.Controls.Add(this.GpConsulta);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormDetalhes";
            this.Text = "Detalhes de Venda";
            this.Load += new System.EventHandler(this.FormDetalhes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.GpConsulta.ResumeLayout(false);
            this.GpConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridDetalhes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GpConsulta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView GridDetalhes;
        public System.Windows.Forms.TextBox TxObs;
        public System.Windows.Forms.TextBox TxTotal;
        public System.Windows.Forms.TextBox TxData;
        public System.Windows.Forms.TextBox TxCliente;
    }
}