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

namespace TDE_Banco_Dados_II.View
{
    public partial class FormDetalhes : Form
    {
        int vendaid;
        public FormDetalhes(int idvenda)

        {
            vendaid = idvenda;
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void GridDetalhes_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormDetalhes_Load(object sender, EventArgs e)
        {
            ItemVendaDao dao = new ItemVendaDao();
            GridDetalhes.DataSource = dao.ListarProdutoPorVenda(vendaid);
        }
    }
}
