using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TDE_Banco_Dados_II.Conexao
{
    public class ViaCep
    {

        public ViaCep(string cep) {

            BuscaCep(cep);


    }
        public string logradouro { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public string complemento { get; set; }


        private void BuscaCep(string cep) {

            using (HttpClient http = new HttpClient()) 
            {
                using (HttpResponseMessage resposta = http.GetAsync($"https://viacep.com.br/ws/{cep}/json/").Result) {

                    //MessageBox.Show(resposta.Content.ReadAsStringAsync().Result);
                    dynamic json = JsonConvert.DeserializeObject(resposta.Content.ReadAsStringAsync().Result);

                    logradouro = json.logradouro.ToString();
                    bairro = json.bairro.ToString();
                    cidade = json.localidade.ToString();
                    estado = json.uf.ToString();
                    complemento = json.complemento.ToString();
                }
            }

        }
    }
}
