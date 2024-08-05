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
    public partial class FormHistorico : Form
    {
        public FormHistorico()
        {
            InitializeComponent();
        }

        private void BtConsultar_Click(object sender, EventArgs e)
        {
            DateTime dataincio, datafim;

            dataincio = Convert.ToDateTime(DtInicio.Value.ToString("yyy-MM-dd"));
            datafim = Convert.ToDateTime((DtFim.Value.ToString("yyyy-MM-dd")));

            VendaDao dao = new VendaDao();

            GridHistorico.DataSource = dao.ListarVendasPeriodo(dataincio, datafim);

        }

        private void GridHistorico_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GridHistorico_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idvenda = int.Parse(GridHistorico.CurrentRow.Cells[0].Value.ToString());

            FormDetalhes tela = new FormDetalhes(idvenda);
            DateTime datavenda = Convert.ToDateTime(tela.TxData.Text = GridHistorico.CurrentRow.Cells[1].Value.ToString());

            tela.TxData.Text = datavenda.ToString("dd/MM/yyyy");
            tela.TxCliente.Text = GridHistorico.CurrentRow.Cells[2].Value.ToString();
            tela.TxTotal.Text = GridHistorico.CurrentRow.Cells[3].Value.ToString();
            tela.TxObs.Text = GridHistorico.CurrentRow.Cells[4].Value.ToString();


            tela.ShowDialog();


        }
    } 
}
