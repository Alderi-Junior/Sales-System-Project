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
using TDE_Banco_Dados_II.View;

namespace TDE_Banco_Dados_II.Dao
{
    public class FuncionarioDao
    {
        #region Conexao
        private MySqlConnection conexao;
        public FuncionarioDao()
        {
            this.conexao = new ConnectionFactory().GetConnection();
        }
        #endregion

        #region Cadastrar Funcionario

        public void CadastrarFuncionario(Funcionario obj)
        {

            try
            {

                string sql = @"INSERT INTO tb_funcionarios(nome,rg,cpf,email, senha, cargo, nivel_acesso,telefone,celular,cep,endereco,numero,complemento,bairro,cidade,estado)
                                values (@nome,@rg,@cpf,@email, @senha, @cargo, @nivel_acesso,@telefone,@celular,@cep,@endereco,@numero,@complemento,@bairro,@cidade,@estado)";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@rg", obj.RG);
                executacmd.Parameters.AddWithValue("@cpf", obj.CPF);
                executacmd.Parameters.AddWithValue("@email", obj.email);
                executacmd.Parameters.AddWithValue("@senha", obj.senha);
                executacmd.Parameters.AddWithValue("@cargo", obj.cargo);
                executacmd.Parameters.AddWithValue("@nivel_acesso", obj.nivelacesso);
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

                MessageBox.Show("Funcionario Cadastrado com Sucesso!");

                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show("ERRO!" + erro);
            }

        }

        #endregion

        #region Listar Funcionario

        public DataTable ListarFuncionario()
        {

            try
            {

                DataTable tabelafuncionario = new DataTable();

                string sql = "SELECT * FROM VW_FUNCIONARIOS";


                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);

                da.Fill(tabelafuncionario);

                conexao.Close();

                return tabelafuncionario;

            }
            catch (Exception erro)
            {
                MessageBox.Show("ERRO! " + erro);
                return null;
            }

        }

        #endregion

        #region Alterar Funcionario

        public void AlterarFuncionario(Funcionario obj)
        {

            try
            {

                string sql = @"UPDATE tb_funcionarios SET nome=@nome, rg=@rg , cpf=@cpf, email=@email, senha=@senha, cargo=@cargo, nivel_acesso=@nivel_acesso, telefone=@telefone, 
                                celular=@celular, cep=@cep, endereco=@endereco, numero=@numero, complemento=@complemento, bairro=@bairro, cidade=@cidade, estado=@estado
                                 WHERE id = @id";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@id", obj.id);

                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@rg", obj.RG);
                executacmd.Parameters.AddWithValue("@cpf", obj.CPF);
                executacmd.Parameters.AddWithValue("@email", obj.email);
                executacmd.Parameters.AddWithValue("@senha", obj.senha);
                executacmd.Parameters.AddWithValue("@cargo", obj.cargo);
                executacmd.Parameters.AddWithValue("@nivel_acesso", obj.nivelacesso);
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

                MessageBox.Show("Funcionario Alterado com Sucesso!");

                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show("ERRO!" + erro);
            }

        }


        #endregion

        #region Exlcuir Funcionario

        public void ExcluirFuncionario(Funcionario obj)
        {

            try
            {

                string sql = @"DELETE FROM tb_funcionarios WHERE id=@id";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@id", obj.id);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Funcionário Excluido com Sucesso!");

                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show("ERRO!" + erro);
            }

        }

        #endregion

        #region Listar Funcionario Por Nome

        public DataTable ListarFuncionarioPorNome(string nome)
        {

            try
            {

                DataTable tabelafuncionarios = new DataTable();

                string sql = "SELECT * FROM tb_funcionarios WHERE nome LIKE @nome";


                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("nome", nome);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);

                da.Fill(tabelafuncionarios);
                conexao.Close();

                return tabelafuncionarios;

            }
            catch (Exception erro)
            {
                MessageBox.Show("ERRO! " + erro);
                return null;
            }

        }


        #endregion

        #region Buscar Funcionario Por Nome

        public DataTable BuscarFuncionarioPorNome(string nome)
        {

            try
            {

                DataTable tabelafuncionario = new DataTable();

                string sql = "SELECT * FROM tb_funcionarios WHERE nome=@nome";


                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("nome", nome);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);

                da.Fill(tabelafuncionario);
                conexao.Close();

                return tabelafuncionario;

            }
            catch (Exception erro)
            {
                MessageBox.Show("ERRO! " + erro);
                return null;
            }

        }

        #endregion

        #region Login Method

        public bool Login(string email, string senha)
        {

            try
            {

                //Create Sql Command

                string sql = @"SELECT * FROM tb_funcionarios
                                WHERE email = @email and senha=@senha";

                // Execute Sql Command

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@email", email);
                executacmd.Parameters.AddWithValue("@senha", senha);

                conexao.Open();
                MySqlDataReader reader = executacmd.ExecuteReader();

                if (reader.Read())
                {
                    string nivel = reader.GetString("nivel_acesso");
                    string nome = reader.GetString("nome");

                    //Login sussefull.
                    FormMemu telamenu = new FormMemu();
                    telamenu.User.Text = nome;

                    if (nivel.Equals("Administrador"))
                    {

                        telamenu.Show();
                    }
                    else if (nivel.Equals("Vendedor"))
                    {
                        telamenu.fornecedorToolStripMenuItem.Visible = false;
                        telamenu.funcionarioToolStripMenuItem.Visible = false;
                        telamenu.cadastrarProdutoToolStripMenuItem1.Enabled = false;
                        telamenu.Show();

                    }

                    return true;

                }
                else
                {
                    MessageBox.Show("Email ou Senha Incorretos!");
                    return false;
                }
            }
            catch (Exception error)
            {

                MessageBox.Show("Error: " + error);
                return false;
            }
        
        }

        #endregion

    }
}
