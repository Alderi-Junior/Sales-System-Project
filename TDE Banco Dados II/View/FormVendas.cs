using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TDE_Banco_Dados_II.Dao;
using TDE_Banco_Dados_II.Model;

namespace TDE_Banco_Dados_II.View
{
    public partial class FormVendas : Form
    {
        Cliente Cliente = new Cliente();
        ClienteDao ClienteDao = new ClienteDao();


        Produto Produto = new Produto();
        ProdutoDao ProdutoDao = new ProdutoDao();

        int qtd;
        decimal preco;
        decimal subtotal, total;

        DataTable carrinho = new DataTable();


        public FormVendas()
        {
            InitializeComponent();

            carrinho.Columns.Add("Código", typeof(int));
            carrinho.Columns.Add("Produto", typeof(string));
            carrinho.Columns.Add("Quantidade", typeof(int));
            carrinho.Columns.Add("Preço", typeof(decimal));
            carrinho.Columns.Add("SubTotal", typeof(decimal));

            GridVendas.DataSource = carrinho;
        }

        private void TxEstoque_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) 
            {
                Cliente = ClienteDao.RetorenaClienteCPF(TxCPF.Text);
                if(Cliente != null)
                {
                    TxNome.Text = Cliente.nome;
                }
                else
                {
                
                    TxCPF.Clear();
                    TxCPF.Focus();

                }
            }
        }

        private void TxCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Produto = ProdutoDao.RetornaPorCodigo(int.Parse(TxCodigo.Text));
                if (Produto != null)
                {
                    TxDesc.Text = Produto.descricao;
                    TxPreco.Text = Produto.preco.ToString();
                    TxEmEstoque.Text = Produto.qtdestoque.ToString();
                }
                else
                { 
                    TxCodigo.Clear();
                    TxCodigo.Focus();
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void BtAdicionar_Click(object sender, EventArgs e)
        {
            try
            {

                qtd = int.Parse(TxEstoque.Text);
                preco = decimal.Parse(TxPreco.Text);
                subtotal = qtd * preco;

                total += subtotal;

                carrinho.Rows.Add(int.Parse(TxCodigo.Text), TxDesc.Text, qtd, preco, subtotal);

                Txtotal.Text = total.ToString();

                TxCodigo.Clear();
                TxDesc.Clear();
                TxPreco.Clear();
                TxEmEstoque.Clear();
                TxEstoque.Clear();

            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro);
            }
        }

        private void BtRemover_Click(object sender, EventArgs e)
        {
            try
            {
                decimal subproduto = decimal.Parse(GridVendas.CurrentRow.Cells[4].Value.ToString());
                int indice = GridVendas.CurrentRow.Index;
                DataRow linha = carrinho.Rows[indice];

                carrinho.Rows.Remove(linha);
                carrinho.AcceptChanges();

                total -= subproduto;

                Txtotal.Text = total.ToString();

                MessageBox.Show("Item Removido!");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro:" + erro);
            }

        }

        private void BtPagamento_Click(object sender, EventArgs e)
        {
            DateTime dataatual = DateTime.Parse(TxDataVenda.Text)   ;
            FormPagamento tela = new FormPagamento(Cliente, carrinho, dataatual);
            tela.TxTotal.Text = total.ToString();

            tela.ShowDialog();

        }

        private void FormVendas_Load(object sender, EventArgs e)
        {
            TxDataVenda.Text = DateTime.Now.ToShortDateString();
        }

        public void FechaFormVendas() { 
            this.Close();
        }
    }
}
