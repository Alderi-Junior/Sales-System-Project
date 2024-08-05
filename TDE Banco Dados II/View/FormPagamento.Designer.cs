namespace TDE_Banco_Dados_II.View
{
    partial class FormPagamento
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
            this.TxPagamento = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxTotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxTroco = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtFinalizar = new System.Windows.Forms.Button();
            this.TxObs = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(714, 82);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(235, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pagamento";
            // 
            // TxPagamento
            // 
            this.TxPagamento.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxPagamento.Location = new System.Drawing.Point(161, 106);
            this.TxPagamento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxPagamento.Name = "TxPagamento";
            this.TxPagamento.Size = new System.Drawing.Size(194, 26);
            this.TxPagamento.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 109);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "Pagamento (R$):";
            // 
            // TxTotal
            // 
            this.TxTotal.Enabled = false;
            this.TxTotal.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxTotal.Location = new System.Drawing.Point(161, 135);
            this.TxTotal.Margin = new System.Windows.Forms.Padding(4);
            this.TxTotal.Name = "TxTotal";
            this.TxTotal.ReadOnly = true;
            this.TxTotal.Size = new System.Drawing.Size(194, 26);
            this.TxTotal.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 143);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = " Total (R$):";
            // 
            // TxTroco
            // 
            this.TxTroco.Enabled = false;
            this.TxTroco.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxTroco.Location = new System.Drawing.Point(161, 169);
            this.TxTroco.Margin = new System.Windows.Forms.Padding(4);
            this.TxTroco.Name = "TxTroco";
            this.TxTroco.ReadOnly = true;
            this.TxTroco.Size = new System.Drawing.Size(194, 26);
            this.TxTroco.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 177);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 18);
            this.label3.TabIndex = 18;
            this.label3.Text = " Troco (R$):";
            // 
            // BtFinalizar
            // 
            this.BtFinalizar.BackColor = System.Drawing.Color.Chartreuse;
            this.BtFinalizar.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtFinalizar.ForeColor = System.Drawing.Color.Transparent;
            this.BtFinalizar.Location = new System.Drawing.Point(28, 211);
            this.BtFinalizar.Name = "BtFinalizar";
            this.BtFinalizar.Size = new System.Drawing.Size(327, 62);
            this.BtFinalizar.TabIndex = 23;
            this.BtFinalizar.Text = "Finalizar Venda";
            this.BtFinalizar.UseVisualStyleBackColor = false;
            this.BtFinalizar.Click += new System.EventHandler(this.BtFinalizar_Click);
            // 
            // TxObs
            // 
            this.TxObs.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxObs.Location = new System.Drawing.Point(467, 109);
            this.TxObs.Margin = new System.Windows.Forms.Padding(4);
            this.TxObs.Multiline = true;
            this.TxObs.Name = "TxObs";
            this.TxObs.Size = new System.Drawing.Size(234, 164);
            this.TxObs.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(363, 109);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 18);
            this.label4.TabIndex = 24;
            this.label4.Text = "Observação:";
            // 
            // FormPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 285);
            this.Controls.Add(this.TxObs);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtFinalizar);
            this.Controls.Add(this.TxTroco);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxPagamento);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormPagamento";
            this.Text = "Pagamento";
            this.Load += new System.EventHandler(this.FormPagamento_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxPagamento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtFinalizar;
        public System.Windows.Forms.TextBox TxTotal;
        private System.Windows.Forms.TextBox TxTroco;
        public System.Windows.Forms.TextBox TxObs;
        private System.Windows.Forms.Label label4;
    }
}