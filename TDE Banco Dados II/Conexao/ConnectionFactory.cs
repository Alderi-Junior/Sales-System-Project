using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TDE_Banco_Dados_II.Conexao
{
    public class ConnectionFactory
    {
        // conexao com o db
        public MySqlConnection GetConnection() {

            string conexao = ConfigurationManager.ConnectionStrings["bdvendas"].ConnectionString;
            return new MySqlConnection(conexao);



        }

    }
}
