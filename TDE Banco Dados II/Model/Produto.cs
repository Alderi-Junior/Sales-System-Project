using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDE_Banco_Dados_II.Model
{
    public class Produto
    {


        public int id { get; set; }
        public string descricao { get; set; }
        public decimal preco { get; set; }
        public int qtdestoque { get; set; }
        public int forid { get; set; }
    }
}
