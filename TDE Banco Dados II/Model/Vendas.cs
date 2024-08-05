using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDE_Banco_Dados_II.Model
{
    public class Vendas
    {
        public int id { get; set; }

        public int clienteid { get; set; }

        public DateTime datavenda { get; set; }

        public decimal totalvenda { get; set; }

        public string obs { get; set; }


    }
}
