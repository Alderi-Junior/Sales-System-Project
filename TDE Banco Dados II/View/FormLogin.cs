using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TDE_Banco_Dados_II.Dao;
using TDE_Banco_Dados_II.Model;
using TDE_Banco_Dados_II.View;

namespace TDE_Banco_Dados_II.Resources
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void BtLogin_Click(object sender, EventArgs e)
        {
            string email = TxUsuario.Text;
            string senha = TxSenha.Text;

            FuncionarioDao dao = new FuncionarioDao();

            if (dao.Login(email, senha))
            {

                  

                this.Hide();

            }
            else
            {
                    
                TxSenha.Clear();
                TxUsuario.Clear();

            }
        }
    }
}
