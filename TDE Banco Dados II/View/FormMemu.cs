using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TDE_Banco_Dados_II.View
{
    public partial class FormMemu : Form
    {
        public FormMemu()
        {
            InitializeComponent();
        }

        private void FormMemu_Load(object sender, EventArgs e)
        {
            Data.Text = DateTime.Now.ToShortDateString();
        }

        private void cadastrarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {

        }

        private void cadastrarClienteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormClientes tela = new FormClientes();
            tela.ShowDialog();

        }

        private void consultarClienteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormClientes tela = new FormClientes();
            tela.TabCrud.SelectedTab = tela.tabPage4;
            tela.ShowDialog();
        }

        private void cadastrarFuncionarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormFuncionarios tela = new FormFuncionarios();
            tela.ShowDialog();
        }

        private void consultarFuncionarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormFuncionarios tela = new FormFuncionarios();
            tela.TabCrudFuncionarios.SelectedTab = tela.tabConsulta;
            tela.ShowDialog();
        }

        private void cadastrarFornecedorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormFornecedores tela = new FormFornecedores();
            tela.ShowDialog();
        }

        private void consultarFornecedorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormFornecedores tela = new FormFornecedores();
            tela.TabCrudFornecedores.SelectedTab = tela.tabConsulta;
            tela.ShowDialog();
        }

        private void cadastrarProdutoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormProdutos tela = new FormProdutos();
            tela.ShowDialog();
        }

        private void consultarProdutoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormProdutos tela = new FormProdutos();
            tela.TabCrudProdutos.SelectedTab = tela.tabPage4;
            tela.ShowDialog();
        }

        private void realizarVendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVendas tela = new FormVendas();
            tela.ShowDialog();
        }

        private void historicoDeVendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHistorico formHistorico = new FormHistorico();
            formHistorico.ShowDialog();
        }

        private void vendasToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Hora.Text = DateTime.Now.ToShortTimeString();
        }

        private void sairDoSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Você deseja sair?", "ATENÇÃO!", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Application.Exit();

            }

        }

        private void trocarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {

            

        }
    }
}
