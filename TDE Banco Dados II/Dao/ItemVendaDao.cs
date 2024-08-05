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
    public class ItemVendaDao
    {

        #region Conexao
        private MySqlConnection conexao;
        public ItemVendaDao()
        {
            this.conexao = new ConnectionFactory().GetConnection();
        }
        #endregion

        #region Cadastra Item de Venda

        public void CadastrarItem(ItemVenda obj) 
        {

            try
            {

                string sql = @"INSERT INTO tb_itensvendas(venda_id, produto_id, qtd, subtotal)
                                VALUES(@venda_id, @produto_id, @qtd, @subtotal)";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@venda_id", obj.vendaId);
                executacmd.Parameters.AddWithValue("@produto_id", obj.produtoid);
                executacmd.Parameters.AddWithValue("@qtd", obj.qtd);
                executacmd.Parameters.AddWithValue("@subtotal", obj.subtotal);

                conexao.Open();

                executacmd.ExecuteNonQuery();


                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show("aconteceu o erro" + erro);
                conexao.Close();
            }
        
        
        }



        #endregion

        #region Listar Itens Por Venda

        public DataTable ListarProdutoPorVenda(int vendaid)
        {

            try
            {
                DataTable tabelaitens = new DataTable();

                string sql = "SELECT * FROM VW_ITENS_VENDAS WHERE ID_Venda = @vendas_id";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@vendas_id", vendaid);
    
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaitens);

                conexao.Close();
                return tabelaitens;
            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro);

                conexao.Close();
                return null;
            }

        }

        #endregion

    }
}
