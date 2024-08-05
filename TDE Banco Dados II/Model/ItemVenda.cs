using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDE_Banco_Dados_II.Model
{
    public class ItemVenda
    {
        public int id { get; set; }

        public int vendaId { get; set; }

        public int produtoid { get; set; }

        public int qtd { get; set; }

        public decimal subtotal { get; set; }
    }
}
