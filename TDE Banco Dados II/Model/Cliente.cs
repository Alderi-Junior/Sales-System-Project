using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDE_Banco_Dados_II.Model
{
    public class Cliente
    {
        public int id { get; set; }

        public DateTime datanascimento { get; set; }
        public string nome { get; set; }
        public string RG { get; set; }
        public string CPF   { get; set; }
        public string email { get; set; }
        public string telefone { get; set; }
        public string celular { get; set; }
        public string cep { get; set; }
        public string endereco { get; set; }
        public int numero { get; set; }
        public string complemento { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public int idade { get; set; }



    }
}
