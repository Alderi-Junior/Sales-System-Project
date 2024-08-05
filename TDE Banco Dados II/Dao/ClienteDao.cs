using MySql.Data.MySqlClient;
using Mysqlx;
using Mysqlx.Prepare;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Bcpg.OpenPgp;
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
    public class ClienteDao
    {
        #region Conexao
        private MySqlConnection conexao;
        public ClienteDao(){ 
            this.conexao= new ConnectionFactory().GetConnection();
             

        }
        #endregion

        #region CadastrarCliente
        // Cadastrar
        public void CadastrarCliente(Cliente obj) {

            try
            {

                string sql = @"INSERT INTO tb_clientes(data_nascimento,idade, nome,rg,cpf,email,telefone,celular,cep,endereco,numero,complemento,bairro,cidade,estado)
                                VALUES (@data_nascimento,@idade, @nome,@rg,@cpf,@email,@telefone,@celular,@cep,@endereco,@numero,@complemento,@bairro,@cidade,@estado)";

                MySqlCommand executacmd = new MySqlCommand(sql,conexao);

                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@data_nascimento", obj.datanascimento);
                executacmd.Parameters.AddWithValue("@idade", obj.idade);
                executacmd.Parameters.AddWithValue("@rg", obj.RG);
                executacmd.Parameters.AddWithValue("@cpf", obj.CPF);
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

                MessageBox.Show("Cliente Cadastrado com Sucesso!");

                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show("ERRO!" + erro);
            }

        }
        #endregion

        #region AlterarCliente

        public void AlterarCliente(Cliente obj)
        {

            try
            {

                string sql = @"UPDATE tb_clientes SET nome=@nome, rg=@rg , cpf=@cpf, email=@email, telefone=@telefone, 
                                celular=@celular, cep=@cep, endereco=@endereco, numero=@numero, complemento=@complemento, bairro=@bairro, cidade=@cidade, estado=@estado, idade=@idade
                                 WHERE id = @id";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@id", obj.id);

                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@rg", obj.RG);
                executacmd.Parameters.AddWithValue("@cpf", obj.CPF);
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
                executacmd.Parameters.AddWithValue("@idade", obj.idade);


                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Cliente Alterado com Sucesso!");

                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show("ERRO!" + erro);
            }

        }

        #endregion

        #region ListarCliente

        public DataTable ListarClientes() {

            try
            {

                DataTable tabelaclientes = new DataTable();

                string sql = "SELECT * FROM VW_CLIENTES";


                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                conexao.Open() ;
                executacmd.ExecuteNonQuery() ;

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);

                da.Fill(tabelaclientes);

                conexao.Close() ;

                return tabelaclientes;

            }
            catch (Exception erro)
            {
                MessageBox.Show("ERRO! " + erro);
                return null;
            }

        }

        #endregion

        #region ExcluirCliente

        public void ExcluirCliente(Cliente obj)
        {

            try
            {

                string sql = @"DELETE FROM tb_clientes WHERE id=@id";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@id", obj.id);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Cliente Excluido com Sucesso!");

                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show("ERRO!" + erro);
            }

        }

        #endregion

        #region Buscar Cliente Por Nome

        public DataTable BuscarClientesPorNome(string nome)
        {

            try
            {

                DataTable tabelaclientes = new DataTable();

                string sql = "SELECT * FROM tb_clientes WHERE nome=@nome";


                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("nome", nome);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);

                da.Fill(tabelaclientes);
                conexao.Close();

                return tabelaclientes;

            }
            catch (Exception erro)
            {
                MessageBox.Show("ERRO! " + erro);
                return null;
            }

        }

        #endregion

        #region Listar Cliente Por Nome

        public DataTable ListarClientesPorNome(string nome)
        {

            try
            {

                DataTable tabelaclientes = new DataTable();

                string sql = "SELECT * FROM tb_clientes WHERE nome LIKE @nome";


                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("nome", nome);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);

                da.Fill(tabelaclientes);
                conexao.Close();

                return tabelaclientes;

            }
            catch (Exception erro)
            {
                MessageBox.Show("ERRO! " + erro);
                return null;
            }

        }


        #endregion

        #region Calcular Idade

        public int CalcularIdade(int idCliente)
        {
            int idade = 0;

            try
            {
                string sql = "SELECT calcular_idade(@id)";

                using (MySqlCommand cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@id", idCliente);

                    conexao.Open();
                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        idade = Convert.ToInt32(result);
                    }
                    else
                    {
                        MessageBox.Show($"Não foi possível determinar a idade do cliente {idCliente}.");
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("ERRO! " + erro.Message);
            }
            finally
            {
                if (conexao.State == System.Data.ConnectionState.Open)
                    conexao.Close();
            }

            return idade;
        }

        #endregion

        #region Retorna Cliente Por CPF

        public Cliente RetorenaClienteCPF(string CPF) {

            try
            {
                Cliente obj = new Cliente();

                string sql = "SELECT * FROM tb_clientes WHERE cpf = @cpf";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@cpf", CPF);

                conexao.Open();

                MySqlDataReader rs = executacmd.ExecuteReader();

                if (rs.Read())
                {

                    obj.id = rs.GetInt32("id");
                    obj.nome = rs.GetString("nome");
                    conexao.Close();

                    return obj;

                }
                else {
                    MessageBox.Show("Cliente não encontrado!");
                    conexao.Close();

                    return null;
                }


            }
            catch (Exception erro)
            {
                conexao.Close();

                MessageBox.Show("Aconteceu o Erro:" + erro);
                return null;
            }
        }

        #endregion

    }
}
