using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TDE_Banco_Dados_II.Conexao;
using TDE_Banco_Dados_II.Dao;
using TDE_Banco_Dados_II.Model;

namespace TDE_Banco_Dados_II.View
{
    public partial class FormFornecedores : Form
    {
        public FormFornecedores()
        {
            InitializeComponent();
        }

        private void BtBuscar_Click(object sender, EventArgs e)
        {
            ViaCep cep = new ViaCep(TxCEP.Text.Trim());

            TxCidade.Text = cep.cidade;
            TxBairro.Text = cep.bairro;
            TxEndereco.Text = cep.logradouro;
            TxEstado.Text = cep.estado;
        }

        private void BtNovo_Click(object sender, EventArgs e)
        {
            Helpers helper = new Helpers();
            helper.LimparTela(this);
        }

        private void BtSalvar_Click(object sender, EventArgs e)
        {
            Fornecedores obj = new Fornecedores();

            obj.nome = TxNome.Text;
            obj.CNPJ = TxCNPJ.Text;
            obj.email = TxEmail.Text;
            obj.celular = TxCelular.Text;
            obj.telefone = TxTelefone.Text;
            obj.cep = TxCEP.Text;
            obj.endereco = TxEndereco.Text;
            obj.numero = int.Parse(TxNumero.Text);
            obj.complemento = TxComplemento.Text;
            obj.bairro = TxBairro.Text;
            obj.cidade = TxCidade.Text;
            obj.estado = TxEstado.Text;

            FornecedorDao dao = new FornecedorDao();
            dao.CadastrarFornecedor(obj);
            GridFornecedores.DataSource = dao.ListarFornecedor();
        }

        private void BtEditar_Click(object sender, EventArgs e)
        {
            Fornecedores obj = new Fornecedores();

            obj.id = int.Parse(TxCodigo.Text);
            obj.nome = TxNome.Text;
            obj.CNPJ = TxCNPJ.Text;
            obj.email = TxEmail.Text;
            obj.celular = TxCelular.Text;
            obj.telefone = TxTelefone.Text;
            obj.cep = TxCEP.Text;
            obj.endereco = TxEndereco.Text;
            obj.numero = int.Parse(TxNumero.Text);
            obj.complemento = TxComplemento.Text;
            obj.bairro = TxBairro.Text;
            obj.cidade = TxCidade.Text;
            obj.estado = TxEstado.Text;

            FornecedorDao dao = new FornecedorDao();
            dao.AlterarFornecedor(obj);
            GridFornecedores.DataSource = dao.ListarFornecedor();

        }

        private void FormFornecedores_Load(object sender, EventArgs e)
        {
            FornecedorDao dao = new FornecedorDao();

            GridFornecedores.DataSource = dao.ListarFornecedor();
        }

        private void GridFornecedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TxCodigo.Text = GridFornecedores.CurrentRow.Cells[0].Value.ToString();
            TxNome.Text = GridFornecedores.CurrentRow.Cells[1].Value.ToString();
            TxCNPJ.Text = GridFornecedores.CurrentRow.Cells[2].Value.ToString();
            TxEmail.Text = GridFornecedores.CurrentRow.Cells[3].Value.ToString();
            TxTelefone.Text = GridFornecedores.CurrentRow.Cells[4].Value.ToString();
            TxCelular.Text = GridFornecedores.CurrentRow.Cells[5].Value.ToString();
            TxCEP.Text = GridFornecedores.CurrentRow.Cells[6].Value.ToString();
            TxEndereco.Text = GridFornecedores.CurrentRow.Cells[7].Value.ToString();
            TxNumero.Text = GridFornecedores.CurrentRow.Cells[8].Value.ToString();
            TxComplemento.Text = GridFornecedores.CurrentRow.Cells[9].Value.ToString();
            TxBairro.Text = GridFornecedores.CurrentRow.Cells[10].Value.ToString();
            TxCidade.Text = GridFornecedores.CurrentRow.Cells[11].Value.ToString();
            TxEstado.Text = GridFornecedores.CurrentRow.Cells[12].Value.ToString();

            TabCrudFornecedores.SelectedTab = TabDados;
        }

        private void BtExcluir_Click(object sender, EventArgs e)
        {

            Fornecedores obj = new Fornecedores();

            obj.id = int.Parse(TxCodigo.Text);

            FornecedorDao dao = new FornecedorDao();

            dao.ExcluirFornecedor(obj);

            GridFornecedores.DataSource = dao.ListarFornecedor();
        }

        private void BtPesquisar_Click(object sender, EventArgs e)
        {
            string nome = TxPesquisar.Text;

            FornecedorDao dao = new FornecedorDao();

            GridFornecedores.DataSource = dao.BuscarFornecedorPorNome(nome);

            if (GridFornecedores.Rows.Count == 0)
            {
                MessageBox.Show("Cliente não encontrado!");
                GridFornecedores.DataSource = dao.ListarFornecedor();
            }
        }

        private void TxPesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            string nome = "%" + TxPesquisar.Text + "%";
            FornecedorDao dao = new FornecedorDao();

            GridFornecedores.DataSource = dao.ListarFornecedorPorNome(nome);
        }
    }
}
