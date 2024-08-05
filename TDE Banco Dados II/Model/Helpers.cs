using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TDE_Banco_Dados_II.Model
{
   public class Helpers
    {

        public void LimparTela(Form tela)
        {

            foreach (Control ctrPai in tela.Controls) 
            {

                foreach (Control ctr1 in ctrPai.Controls) 
                {

                    if (ctr1 is TabPage)
                    {

                        foreach (Control ctr2 in ctr1.Controls)
                        {

                            if (ctr2 is TextBox)
                            {

                                (ctr2 as TextBox).Text = string.Empty;
                            }
                            if (ctr2 is MaskedTextBox )
                            {

                                (ctr2 as MaskedTextBox).Text = string.Empty;
                            }
                            if (ctr2 is ComboBox)
                            {

                                (ctr2 as ComboBox).Text = string.Empty;
                            }
                        }
                    }
                }
            }       
        }
    }
}
