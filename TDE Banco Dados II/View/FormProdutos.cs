using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TDE_Banco_Dados_II.Dao;
using TDE_Banco_Dados_II.Model;

namespace TDE_Banco_Dados_II.View
{
    public partial class FormProdutos : Form
    {
        public FormProdutos()
        {
            InitializeComponent();
        }

        private void FormProdutos_Load(object sender, EventArgs e)
        {
            FornecedorDao f_dao =  new FornecedorDao();

            CbFornecedor.DataSource = f_dao.ListarFornecedor();
            CbFornecedor.DisplayMember = "nome";
            CbFornecedor.ValueMember = "id";

            ProdutoDao dao = new ProdutoDao();

            GridProdutos.DataSource = dao.ListarProdutos();

        }

        private void BtSalvar_Click(object sender, EventArgs e)
        {
            Produto obj = new Produto();

            obj.descricao = TxDesc.Text;
            obj.preco = decimal.Parse(TxPreco.Text);
            obj.qtdestoque = int.Parse(TxEstoque.Text);
            obj.forid = int.Parse(CbFornecedor.SelectedValue.ToString());
            

            ProdutoDao dao = new ProdutoDao();
            dao.CadastrarProduto(obj);
            GridProdutos.DataSource = dao.ListarProdutos();


        }

        private void BtNovo_Click(object sender, EventArgs e)
        {
            Helpers helper = new Helpers();
            helper.LimparTela(this);
        }

        private void GridProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TxCodigo.Text = GridProdutos.CurrentRow.Cells[0].Value.ToString();
            TxDesc.Text = GridProdutos.CurrentRow.Cells[1].Value.ToString();
            TxPreco.Text = GridProdutos.CurrentRow.Cells[2].Value.ToString();
            TxEstoque.Text = GridProdutos.CurrentRow.Cells[3].Value.ToString();
            CbFornecedor.Text = GridProdutos.CurrentRow.Cells[4].Value.ToString();


            TabCrudProdutos.SelectedTab = TabDados;
        }

        private void BtEditar_Click(object sender, EventArgs e)
        {
            Produto obj = new Produto();

            obj.id = int.Parse(TxCodigo.Text);
            obj.descricao = TxDesc.Text;
            obj.preco = decimal.Parse(TxPreco.Text);
            obj.qtdestoque = int.Parse(TxEstoque.Text);
            obj.forid = int.Parse(CbFornecedor.SelectedValue.ToString());


            ProdutoDao dao = new ProdutoDao();
            dao.AlterarProduto(obj);
            GridProdutos.DataSource = dao.ListarProdutos();
        }

        private void BtExcluir_Click(object sender, EventArgs e)
        {

            Produto obj = new Produto();

            obj.id = int.Parse(TxCodigo.Text);

            ProdutoDao dao = new ProdutoDao();

            dao.ExcluirProduto(obj);

            GridProdutos.DataSource = dao.ListarProdutos();
        }

        private void BtPesquisar_Click(object sender, EventArgs e)
        {
            string nome = TxPequisar.Text;

            ProdutoDao dao = new ProdutoDao();

            GridProdutos.DataSource = dao.BuscarProdutosPorNome(nome);

            if (GridProdutos.Rows.Count == 0)
            {
                MessageBox.Show("Produto não encontrado!");
                GridProdutos.DataSource = dao.ListarProdutos();
            }
        }

        private void TxPequisar_KeyPress(object sender, KeyPressEventArgs e)
        {

            string nome = "%" + TxPequisar.Text + "%";
            ProdutoDao dao = new ProdutoDao();

            GridProdutos.DataSource = dao.ListarProdutosPorNome(nome);
        }
    }
}
