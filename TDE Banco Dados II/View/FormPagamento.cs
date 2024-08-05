using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TDE_Banco_Dados_II.Dao;
using TDE_Banco_Dados_II.Model;

namespace TDE_Banco_Dados_II.View
{
    public partial class FormPagamento : Form
    {
        Cliente cliente = new Cliente();
        DataTable carrinho = new DataTable();
        DateTime dataatual;

        public FormPagamento(Cliente cliente, DataTable carrinho, DateTime dataatual)
        {

            this.cliente = cliente;
            this.carrinho = carrinho;
            this.dataatual = dataatual;
            InitializeComponent();
        }

        private void FormPagamento_Load(object sender, EventArgs e)
        {

            TxPagamento.Text = "0,0";
            TxTroco.Text = "0,0";

        }

        private void BtFinalizar_Click(object sender, EventArgs e)
        {

            decimal v_pagamento, v_total, troco;

            int qtd_estoque, qtd_comprada, qtd_atualizada;

            try
            {

                ProdutoDao produtoDao = new ProdutoDao();

                v_pagamento = decimal.Parse(TxPagamento.Text);
                v_total = decimal.Parse(TxTotal.Text);

                if (v_pagamento < v_total) 
                {
                    MessageBox.Show("Valor de pagamento insuficiente");
                }
                else
                {
                    troco = v_pagamento - v_total;
                    Vendas venda = new Vendas();

                    venda.clienteid =  cliente.id;
                    venda.datavenda = dataatual;
                    venda.totalvenda = v_total;
                    venda.obs = TxObs.Text;

                    VendaDao vendaDao = new VendaDao();
                    TxTroco.Text = troco.ToString();

                    vendaDao.CadastrarVenda(venda);

                    foreach (DataRow linha in carrinho.Rows) 
                    {


                        ItemVenda item = new ItemVenda();

                        item.vendaId = vendaDao.RetorndaIDVendas();
                        item.produtoid =int.Parse( linha["Código"].ToString());
                        item.qtd = int.Parse(linha["Quantidade"].ToString());
                        item.subtotal = decimal.Parse(linha["SubTotal"].ToString());

                        // Baixa do estoque

                        qtd_estoque = produtoDao.RetornaEstoqueAtual(item.produtoid);
                        qtd_comprada = item.qtd;
                        qtd_atualizada = qtd_estoque - qtd_comprada;

                        produtoDao.BaixaEstoque(item.produtoid, qtd_atualizada);

                        ItemVendaDao itemdao = new ItemVendaDao();
                        itemdao.CadastrarItem(item);


                    }

                    MessageBox.Show("Venda Finalizada Com sucesso!");
                    
                    this.Dispose();
                    
                    new FormVendas().ShowDialog();
                }
            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: "+ erro);
            }

        }
    }
}
