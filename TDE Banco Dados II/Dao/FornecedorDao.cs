using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TDE_Banco_Dados_II.Conexao;
using TDE_Banco_Dados_II.Model;

namespace TDE_Banco_Dados_II.Dao
{
    public class FornecedorDao
    {
        #region Conexao
        private MySqlConnection conexao;
        public FornecedorDao()
        {
            this.conexao = new ConnectionFactory().GetConnection();
        }
        #endregion

        #region Cadastrar Fornecedor

        public void CadastrarFornecedor(Fornecedores obj)
        {

            try
            {

                string sql = @"INSERT INTO tb_fornecedores(nome,cnpj,email, telefone,celular,cep,endereco,numero,complemento,bairro,cidade,estado)
                                values (@nome,@cnpj,@email,@telefone,@celular,@cep,@endereco,@numero,@complemento,@bairro,@cidade,@estado)";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@cnpj", obj.CNPJ);
                executacmd.Parameters.AddWithValue("@email", obj.email);
                executacmd.Parameters.AddWithValue("@telefone", obj.telefone);
                executacmd.Parameters.AddWithValue("@celular", obj.celular);
                executacmd.Parameters.AddWithValue("@cep", obj.cep);
                executacmd.Parameters.AddWithValue("@endereco", obj.endereco);
                executacmd.Parameters.AddWithValue("@numero", obj.numero);
                executacmd.Parameters.AddWithValue("@complemento", obj.complemento);
                executacmd.Parameters.AddWithValue("@bairro", obj.bairro);
                executacmd.Parameters.AddWithValue("@cidade", obj.cidade);
                executacmd.Parameters.AddWithValue("@estado", obj.estado);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Fornecedor Cadastrado com Sucesso!");

                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show("ERRO!" + erro);
            }

        }

        #endregion

        #region Listar Fornecedor

        public DataTable ListarFornecedor()
        {

            try
            {

                DataTable tabelafornecedores = new DataTable();

                string sql = "SELECT * FROM tb_fornecedores";


                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);

                da.Fill(tabelafornecedores);

                conexao.Close();

                return tabelafornecedores;

            }
            catch (Exception erro)
            {
                MessageBox.Show("ERRO! " + erro);
                return null;
            }

        }

        #endregion

        #region Alterar Fornecedor

        public void AlterarFornecedor(Fornecedores obj)
        {

            try
            {

                string sql = @"UPDATE tb_fornecedores SET nome=@nome, cnpj=@cnpj, email=@email, telefone=@telefone, 
                                celular=@celular, cep=@cep, endereco=@endereco, numero=@numero, complemento=@complemento, bairro=@bairro, cidade=@cidade, estado=@estado
                                 WHERE id = @id";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@id", obj.id);

                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@cnpj", obj.CNPJ);
                executacmd.Parameters.AddWithValue("@email", obj.email);
                executacmd.Parameters.AddWithValue("@telefone", obj.telefone);
                executacmd.Parameters.AddWithValue("@celular", obj.celular);
                executacmd.Parameters.AddWithValue("@cep", obj.cep);
                executacmd.Parameters.AddWithValue("@endereco", obj.endereco);
                executacmd.Parameters.AddWithValue("@numero", obj.numero);
                executacmd.Parameters.AddWithValue("@complemento", obj.complemento);
                executacmd.Parameters.AddWithValue("@bairro", obj.bairro);
                executacmd.Parameters.AddWithValue("@cidade", obj.cidade);
                executacmd.Parameters.AddWithValue("@estado", obj.estado);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Fornecedor Alterado com Sucesso!");

                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show("ERRO!" + erro);
            }

        }


        #endregion

        #region Exlcuir Fornecedor

        public void ExcluirFornecedor(Fornecedores obj)
        {

            try
            {

                string sql = @"DELETE FROM tb_fornecedores WHERE id=@id";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@id", obj.id);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Fornecedor Excluido com Sucesso!");

                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show("ERRO!" + erro);
            }

        }

        #endregion

        #region Listar Fornecedor Por Nome

        public DataTable ListarFornecedorPorNome(string nome)
        {

            try
            {

                DataTable tabelafornecedores = new DataTable();

                string sql = "SELECT * FROM tb_fornecedores WHERE nome LIKE @nome";


                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("nome", nome);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);

                da.Fill(tabelafornecedores);
                conexao.Close();

                return tabelafornecedores;

            }
            catch (Exception erro)
            {
                MessageBox.Show("ERRO! " + erro);
                return null;
            }

        }


        #endregion

        #region Buscar Fornecedor Por Nome

        public DataTable BuscarFornecedorPorNome(string nome)
        {

            try
            {

                DataTable tabefornecedores = new DataTable();

                string sql = "SELECT * FROM tb_fornecedores WHERE nome=@nome";


                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("nome", nome);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);

                da.Fill(tabefornecedores);
                conexao.Close();

                return tabefornecedores;

            }
            catch (Exception erro)
            {
                MessageBox.Show("ERRO! " + erro);
                return null;
            }

        }

        #endregion



    }
}
