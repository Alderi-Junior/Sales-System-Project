namespace TDE_Banco_Dados_II.View
{
    partial class FormHistorico
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
            this.BtConsultar = new System.Windows.Forms.Button();
            this.DtFim = new System.Windows.Forms.DateTimePicker();
            this.DtInicio = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GridHistorico = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.GpConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridHistorico)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(563, 82);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(34, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(525, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Historico de Vendas";
            // 
            // GpConsulta
            // 
            this.GpConsulta.Controls.Add(this.BtConsultar);
            this.GpConsulta.Controls.Add(this.DtFim);
            this.GpConsulta.Controls.Add(this.DtInicio);
            this.GpConsulta.Controls.Add(this.label3);
            this.GpConsulta.Controls.Add(this.label2);
            this.GpConsulta.Location = new System.Drawing.Point(12, 89);
            this.GpConsulta.Name = "GpConsulta";
            this.GpConsulta.Size = new System.Drawing.Size(547, 87);
            this.GpConsulta.TabIndex = 4;
            this.GpConsulta.TabStop = false;
            this.GpConsulta.Text = "Consulta";
            // 
            // BtConsultar
            // 
            this.BtConsultar.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtConsultar.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtConsultar.Location = new System.Drawing.Point(370, 16);
            this.BtConsultar.Name = "BtConsultar";
            this.BtConsultar.Size = new System.Drawing.Size(153, 59);
            this.BtConsultar.TabIndex = 5;
            this.BtConsultar.Text = "Consultar";
            this.BtConsultar.UseVisualStyleBackColor = false;
            this.BtConsultar.Click += new System.EventHandler(this.BtConsultar_Click);
            // 
            // DtFim
            // 
            this.DtFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtFim.Location = new System.Drawing.Point(110, 52);
            this.DtFim.Name = "DtFim";
            this.DtFim.Size = new System.Drawing.Size(121, 25);
            this.DtFim.TabIndex = 4;
            // 
            // DtInicio
            // 
            this.DtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtInicio.Location = new System.Drawing.Point(110, 16);
            this.DtInicio.Name = "DtInicio";
            this.DtInicio.Size = new System.Drawing.Size(123, 25);
            this.DtInicio.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data Fim:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data Inicio:";
            // 
            // GridHistorico
            // 
            this.GridHistorico.AllowUserToAddRows = false;
            this.GridHistorico.AllowUserToDeleteRows = false;
            this.GridHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridHistorico.Location = new System.Drawing.Point(12, 182);
            this.GridHistorico.Name = "GridHistorico";
            this.GridHistorico.ReadOnly = true;
            this.GridHistorico.Size = new System.Drawing.Size(547, 425);
            this.GridHistorico.TabIndex = 5;
            this.GridHistorico.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridHistorico_CellClick);
            this.GridHistorico.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridHistorico_CellContentClick);
            // 
            // FormHistorico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 619);
            this.Controls.Add(this.GridHistorico);
            this.Controls.Add(this.GpConsulta);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormHistorico";
            this.Text = "Historico de Vendas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.GpConsulta.ResumeLayout(false);
            this.GpConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridHistorico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GpConsulta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DtFim;
        private System.Windows.Forms.DateTimePicker DtInicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView GridHistorico;
        private System.Windows.Forms.Button BtConsultar;
    }
}