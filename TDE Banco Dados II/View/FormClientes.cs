using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
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
    public partial class FormClientes : Form
    {
        public FormClientes()
        {
            InitializeComponent();
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            ClienteDao dao = new ClienteDao();

            GridClientes.DataSource =  dao.ListarClientes();


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txCodigo_Click(object sender, EventArgs e)
        {

        }

        private void TxCidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtBuscar_Click(object sender, EventArgs e)
        {
            ViaCep cep = new ViaCep(TxCEP.Text.Trim());

            TxCidade.Text = cep.cidade;
            TxBairro.Text = cep.bairro;
            TxEndereco.Text = cep.logradouro;
            TxEstado.Text = cep.estado;
        }

        private void BtSalvar_Click(object sender, EventArgs e)
        {
            Cliente obj = new Cliente();

            obj.nome = TxNome.Text;
            obj.datanascimento = Convert.ToDateTime(DtNascimento.Text);
            obj.idade = DateTime.Now.Year - DtNascimento.Value.Year;
            obj.RG = TxRG.Text;
            obj.CPF = TxCPF.Text;
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


            ClienteDao dao = new ClienteDao();
            //obj.idade = dao.CalcularIdade(int.Parse(TxCodigo.Text));
            dao.CadastrarCliente(obj);


            GridClientes.DataSource = dao.ListarClientes();

        }

        private void GridClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtEditar_Click(object sender, EventArgs e)
        {
            Cliente obj = new Cliente();

            obj.id  = int.Parse(TxCodigo.Text);
            obj.nome = TxNome.Text;
            obj.RG = TxRG.Text;
            obj.CPF = TxCPF.Text;
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

            ClienteDao dao = new ClienteDao();
            obj.idade = dao.CalcularIdade(int.Parse(TxCodigo.Text));

            dao.AlterarCliente(obj);
            GridClientes.DataSource = dao.ListarClientes();


        }

        private void GridClientes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TxCodigo.Text = GridClientes.CurrentRow.Cells[0].Value.ToString();
            TxNome.Text = GridClientes.CurrentRow.Cells[1].Value.ToString();
            DtNascimento.Text = GridClientes.CurrentRow.Cells[2].Value.ToString();
            TxIdade.Text = GridClientes.CurrentRow.Cells[3].Value.ToString();
            TxRG.Text = GridClientes.CurrentRow.Cells[4].Value.ToString();
            TxCPF.Text = GridClientes.CurrentRow.Cells[5].Value.ToString();
            TxEmail.Text = GridClientes.CurrentRow.Cells[6].Value.ToString();
            TxTelefone.Text = GridClientes.CurrentRow.Cells[7].Value.ToString();
            TxCelular.Text = GridClientes.CurrentRow.Cells[8].Value.ToString();
            TxCEP .Text = GridClientes.CurrentRow.Cells[9].Value.ToString();
            TxEndereco.Text = GridClientes.CurrentRow.Cells[10].Value.ToString();
            TxNumero.Text = GridClientes.CurrentRow.Cells[11].Value.ToString();
            TxComplemento.Text = GridClientes.CurrentRow.Cells[12].Value.ToString();
            TxBairro.Text = GridClientes.CurrentRow.Cells[13].Value.ToString();
            TxCidade.Text = GridClientes.CurrentRow.Cells[14].Value.ToString();
            TxEstado.Text = GridClientes.CurrentRow.Cells[15].Value.ToString();



            TabCrud.SelectedTab = TabDados;

        }

        private void BtExcluir_Click(object sender, EventArgs e)
        {

            Cliente obj = new Cliente();

            obj.id = int.Parse(TxCodigo.Text);

            ClienteDao dao = new ClienteDao();

            dao.ExcluirCliente(obj);    

            GridClientes.DataSource = dao.ListarClientes();

        }

        private void BtPesquisar_Click(object sender, EventArgs e)
        {
            string nome = TxPequisar.Text;

            ClienteDao dao = new ClienteDao();

            GridClientes.DataSource= dao.BuscarClientesPorNome(nome);

            if (GridClientes.Rows.Count == 0)
            {
                MessageBox.Show("Cliente não encontrado!");
                GridClientes.DataSource = dao.ListarClientes();
            }
        }

        private void TxPequisar_KeyPress(object sender, KeyPressEventArgs e)
        {
         
            string nome = "%" + TxPequisar.Text + "%";
            ClienteDao dao = new ClienteDao();

            GridClientes.DataSource = dao.ListarClientesPorNome(nome);  

        }

        private void BtNovo_Click(object sender, EventArgs e)
        {
            Helpers helper = new Helpers();
            helper.LimparTela(this);
        }
    }
}
