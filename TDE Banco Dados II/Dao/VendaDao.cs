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
    public class VendaDao
    {
        #region Conexao
        private MySqlConnection conexao;
        public VendaDao()
        {
            this.conexao = new ConnectionFactory().GetConnection();
        }
        #endregion

        #region Cadastrar Venda

        public void CadastrarVenda(Vendas obj) 
        {

            try
            {
                string sql = @"INSERT INTO tb_vendas( cliente_id, data_venda, total_venda, observacoes)
                                VALUES ( @cliente_id, @data_venda, @total_venda, @obs)";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@cliente_id", obj.clienteid);
                executacmd.Parameters.AddWithValue("@data_venda", obj.datavenda);
                executacmd.Parameters.AddWithValue("@total_venda", obj.totalvenda);
                executacmd.Parameters.AddWithValue("@obs", obj.obs);

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

        #region Retornar ID da Ultima Venda

        public int RetorndaIDVendas()
        {
            try
            {

                int idvenda = 0;

                string sql = "SELECT MAX(id) id FROM tb_vendas";
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                conexao.Open();

                MySqlDataReader rs = executacmd.ExecuteReader();

                if (rs.Read())
                {
                    idvenda = rs.GetInt32("id");

                }
                conexao.Close();
                return idvenda;


            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro);
                conexao.Close();
                return 0;
            }
        
        }

        #endregion

        #region  Historico Venda

        public DataTable ListarVendasPeriodo(DateTime datainicio, DateTime datafim)
        {

            try
            {
                DataTable tabelahistorico = new DataTable();

                string sql = @"SELECT * FROM VW_VENDAS_PERIODO
                                WHERE data_venda BETWEEN @datainicio AND @datafim ";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@datainicio", datainicio);
                executacmd.Parameters.AddWithValue("@datafim",datafim);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelahistorico);

                conexao.Close();
                return tabelahistorico;
            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: "+ erro);

                conexao.Close( );
                return null;
            }

        }

        #endregion

        #region Comissao

        public void RetornaComisssao(decimal valorvenda)
        {


            string sql = "SELECT RETORNA_COMISSAO(@valorvenda);";
            MySqlCommand executacmd = new MySqlCommand(sql, conexao);

            executacmd.Parameters.AddWithValue("@cliente_id", valorvenda);


            conexao.Open();

            MySqlDataReader rs = executacmd.ExecuteReader();

            MessageBox.Show("Comissão recebida" + valorvenda);
            conexao.Close();

        }

        #endregion
    }
}
