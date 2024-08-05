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
    public partial class FormFuncionarios : Form
    {
        public FormFuncionarios()
        {
            InitializeComponent();
        }

        private void TxAcesso_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtSalvar_Click(object sender, EventArgs e)
        {
            Funcionario obj = new Funcionario();

            obj.nome = TxNome.Text;
            obj.RG = TxRG.Text;
            obj.CPF = TxCPF.Text;
            obj.email = TxEmail.Text;
            obj.senha = TxSenha.Text;
            obj.cargo = CbCargo.SelectedItem.ToString();
            obj.nivelacesso = CbNivelAcesso.SelectedItem.ToString();
            obj.celular = TxCelular.Text;
            obj.telefone = TxTelefone.Text;
            obj.cep = TxCEP.Text;
            obj.endereco = TxEndereco.Text;
            obj.numero = int.Parse(TxNumero.Text);
            obj.complemento = TxComplemento.Text;
            obj.bairro = TxBairro.Text;
            obj.cidade = TxCidade.Text;
            obj.estado = TxEstado.Text;

            FuncionarioDao dao = new FuncionarioDao();
            dao.CadastrarFuncionario(obj);
            GridFuncionarios.DataSource = dao.ListarFuncionario();
        }

        private void BtBuscar_Click(object sender, EventArgs e)
        {
            ViaCep cep = new ViaCep(TxCEP.Text.Trim());

            TxCidade.Text = cep.cidade;
            TxBairro.Text = cep.bairro;
            TxEndereco.Text = cep.logradouro;
            TxEstado.Text = cep.estado;
        
        }

        private void GridFuncionarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormFuncionarios_Load(object sender, EventArgs e)
        {
            FuncionarioDao dao = new FuncionarioDao();
            GridFuncionarios.DataSource = dao.ListarFuncionario();
        }

        private void BtEditar_Click(object sender, EventArgs e)
        {

            Funcionario obj = new Funcionario();

            obj.id = int.Parse(TxCodigo.Text);
            obj.nome = TxNome.Text;
            obj.RG = TxRG.Text;
            obj.CPF = TxCPF.Text;
            obj.email = TxEmail.Text;
            obj.senha = TxSenha.Text;
            obj.cargo = CbCargo.SelectedItem.ToString();
            obj.nivelacesso = CbNivelAcesso.SelectedItem.ToString();
            obj.celular = TxCelular.Text;
            obj.telefone = TxTelefone.Text;
            obj.cep = TxCEP.Text;
            obj.endereco = TxEndereco.Text;
            obj.numero = int.Parse(TxNumero.Text);
            obj.complemento = TxComplemento.Text;
            obj.bairro = TxBairro.Text;
            obj.cidade = TxCidade.Text;
            obj.estado = TxEstado.Text;

            FuncionarioDao dao = new FuncionarioDao();
            dao.AlterarFuncionario(obj);
            GridFuncionarios.DataSource = dao.ListarFuncionario();


        }

        private void GridFuncionarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxCodigo.Text = GridFuncionarios.CurrentRow.Cells[0].Value.ToString();
            TxNome.Text = GridFuncionarios.CurrentRow.Cells[1].Value.ToString();
            TxRG.Text = GridFuncionarios.CurrentRow.Cells[2].Value.ToString();
            TxCPF.Text = GridFuncionarios.CurrentRow.Cells[3].Value.ToString();
            TxEmail.Text = GridFuncionarios.CurrentRow.Cells[4].Value.ToString();
            TxSenha.Text = GridFuncionarios.CurrentRow.Cells[5].Value.ToString();
            CbCargo.Text = GridFuncionarios.CurrentRow.Cells[6].Value.ToString();
            CbNivelAcesso.Text = GridFuncionarios.CurrentRow.Cells[7].Value.ToString();
            TxTelefone.Text = GridFuncionarios.CurrentRow.Cells[8].Value.ToString();
            TxCelular.Text = GridFuncionarios.CurrentRow.Cells[9].Value.ToString();
            TxCEP.Text = GridFuncionarios.CurrentRow.Cells[10].Value.ToString();
            TxEndereco.Text = GridFuncionarios.CurrentRow.Cells[11].Value.ToString();
            TxNumero.Text = GridFuncionarios.CurrentRow.Cells[12].Value.ToString();
            TxComplemento.Text = GridFuncionarios.CurrentRow.Cells[13].Value.ToString();
            TxBairro.Text = GridFuncionarios.CurrentRow.Cells[14].Value.ToString();
            TxCidade.Text = GridFuncionarios.CurrentRow.Cells[15].Value.ToString();
            TxEstado.Text = GridFuncionarios.CurrentRow.Cells[16].Value.ToString();

            TabCrudFuncionarios.SelectedTab = TabDados;
        }

        private void BtExcluir_Click(object sender, EventArgs e)
        {
            Funcionario obj = new Funcionario();

            obj.id = int.Parse(TxCodigo.Text);

            FuncionarioDao dao = new FuncionarioDao();

            dao.ExcluirFuncionario(obj);

            GridFuncionarios.DataSource = dao.ListarFuncionario();
        }

        private void BtPesquisar_Click(object sender, EventArgs e)
        {
            string nome = TxPesquisar.Text;

            FuncionarioDao dao = new FuncionarioDao();

            GridFuncionarios.DataSource = dao.BuscarFuncionarioPorNome(nome);

            if (GridFuncionarios.Rows.Count == 0)
            {
                MessageBox.Show("Funcionário não encontrado!");
                GridFuncionarios.DataSource = dao.ListarFuncionario();
            }
        }

        private void TxPesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            string nome = "%" + TxPesquisar.Text + "%";
            FuncionarioDao dao = new FuncionarioDao();
            GridFuncionarios.DataSource = dao.ListarFuncionarioPorNome(nome);
        }

        private void BtNovo_Click(object sender, EventArgs e)
        {
            Helpers helper = new Helpers();
            helper.LimparTela(this);
        }
    }
}
