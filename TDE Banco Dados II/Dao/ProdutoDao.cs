using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TDE_Banco_Dados_II.Conexao;
using TDE_Banco_Dados_II.Model;

namespace TDE_Banco_Dados_II.Dao
{
    public class ProdutoDao
    {
        #region Conexao
        private MySqlConnection conexao;
        public ProdutoDao()
        {
            this.conexao = new ConnectionFactory().GetConnection();
        }
        #endregion

        #region Cadastrar Porduto
        public void CadastrarProduto(Produto obj)
        {

            try
            {

                string sql = @"INSERT INTO tb_produtos(descricao, preco, qtd_estoque, for_id)
                                VALUES (@descricao, @preco, @qtd_estoque, @for_id)";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@descricao", obj.descricao);
                executacmd.Parameters.AddWithValue("@preco", obj.preco);
                executacmd.Parameters.AddWithValue("@qtd_estoque", obj.qtdestoque);
                executacmd.Parameters.AddWithValue("@for_id", obj.forid);
               

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Produto Cadastrado com Sucesso!");

                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show("ERRO!" + erro);
            }

        }
        #endregion

        #region Listar Produtos

        public DataTable ListarProdutos()
        {

            try
            {

                DataTable tabelaprodutos = new DataTable();

                string sql = @"SELECT   p.id AS 'Código',
                                        p.descricao AS 'Descrição',
                                        p.preco AS 'Preço',
                                        p.qtd_estoque AS 'Qtd.Estoque',
                                        p.for_id AS 'Fornecedor'
                                        FROM tb_produtos AS p
                              JOIN tb_fornecedores ON (p.for_id = tb_fornecedores.id)";


                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);

                da.Fill(tabelaprodutos);

                conexao.Close();

                return tabelaprodutos;

            }
            catch (Exception erro)
            {
                MessageBox.Show("ERRO! " + erro);
                return null;
            }

        }

        #endregion

        #region Alterar Produto

        public void AlterarProduto(Produto obj)
        {

            try
            {

                string sql = @"UPDATE tb_produtos SET descricao=@descricao, preco=@preco , qtd_estoque=@qtd_estoque, for_id=@for_id
                                WHERE id = @id";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@id", obj.id);

                executacmd.Parameters.AddWithValue("@descricao", obj.descricao);
                executacmd.Parameters.AddWithValue("@preco", obj.preco);
                executacmd.Parameters.AddWithValue("@qtd_estoque", obj.qtdestoque);
                executacmd.Parameters.AddWithValue("@for_id", obj.forid);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show(" Produto Alterado com Sucesso!");

                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show("ERRO!" + erro);
                conexao.Close();

            }

        }

        #endregion

        #region ExcluirProduto

        public void ExcluirProduto(Produto obj)
        {

            try
            {

                string sql = @"DELETE FROM tb_produtos WHERE id=@id";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@id", obj.id);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Produto Excluido com Sucesso!");

                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show("ERRO!" + erro);
            }

        }

        #endregion

        #region Buscar Produto Por Nome

        public DataTable BuscarProdutosPorNome(string nome)
        {

            try
            {

                DataTable tabelaprodutos = new DataTable();

                string sql = "SELECT * FROM tb_produtos WHERE descricao=@descricao";


                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("descricao", nome);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);

                da.Fill(tabelaprodutos);
                conexao.Close();

                return tabelaprodutos;

            }
            catch (Exception erro)
            {
                MessageBox.Show("ERRO! " + erro);
                return null;
            }

        }

        #endregion

        #region Listar Produtos Por Nome

        public DataTable ListarProdutosPorNome(string nome)
        {

            try
            {

                DataTable tabelaprodutos = new DataTable();

                string sql = "SELECT * FROM tb_produtos WHERE descricao LIKE @descricao";


                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("descricao", nome);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);

                da.Fill(tabelaprodutos);
                conexao.Close();

                return tabelaprodutos;

            }
            catch (Exception erro)
            {
                MessageBox.Show("ERRO! " + erro);
                return null;
            }

        }


        #endregion

        #region Retorna Produto Por Codigo

        public Produto RetornaPorCodigo(int id) 
        {

            try
            {

                string sql = "SELECT * FROM tb_produtos WHERE id=@id";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", id);

                conexao.Open();

                MySqlDataReader rs = executacmd.ExecuteReader();

                if (rs.Read()) { 
                    Produto p = new Produto();

                    p.id = rs.GetInt32("id");
                    p.descricao = rs.GetString("descricao");
                    p.preco = rs.GetDecimal("preco");
                    p.qtdestoque = rs.GetInt32("qtd_estoque");
                    conexao.Close();
                    return p;
                
                }else
                {
                    MessageBox.Show("Nunhum Produto encontado!");
                    conexao.Close();

                    return null;
                
                }

            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o ERRO: " + erro);
                conexao.Close();

                return null;
            }
        
        }


        #endregion

        #region Baixar Estoque

        public void BaixaEstoque(int idproduto, int qtde_stoque)
        {

            try
            {

                string sql = @"UPDATE tb_produtos SET  qtd_estoque=@qtd_estoque WHERE id=@id";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@id", idproduto);
                executacmd.Parameters.AddWithValue("@qtd_estoque", qtde_stoque);


                conexao.Open();
                executacmd.ExecuteNonQuery();

                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro);
                conexao.Close();
            }

        }

        #endregion

        #region Estoque Atual

            public int RetornaEstoqueAtual(int idproduto) 
            {
            try
            {

                string sql = @"SELECT qtd_estoque FROM tb_produtos WHERE id =@id";
                int qtd_estoque = 0;

                MySqlCommand executacmd = new MySqlCommand(sql,conexao);
                executacmd.Parameters.AddWithValue("@id", idproduto);


                conexao.Open();
                MySqlDataReader rs = executacmd.ExecuteReader();

                if (rs.Read())
                {
                    qtd_estoque = rs.GetInt32("qtd_estoque");
                    conexao.Close();


                }
                conexao.Close();

                return qtd_estoque;
            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro);
                conexao.Close();

                return 0;
            }
            }

        #endregion

    }
}
