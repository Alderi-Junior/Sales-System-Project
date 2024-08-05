using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDE_Banco_Dados_II.Model
{
    public class Funcionario : Cliente
    {

        public string senha { get; set; }
        public string nivelacesso { get; set; }
        public string cargo { get; set; }


    }
}
