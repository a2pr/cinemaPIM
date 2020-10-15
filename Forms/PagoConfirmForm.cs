using CinemaPIM.Classes;
using CinemaPIM.Repos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaPIM.Forms
{
    public partial class PagoConfirmForm : Form
    {
        private PagamentoRepo pagamentoDB;
        private CadeirasRepo cadeiraDB;
        private OrderRepo orderDB;
        private IngressosRepo ingressoDB;
        private UsuariosRepo usuariosDB;
        public PagoConfirmForm()
        {
            InitializeComponent();
            usuariosDB = new UsuariosRepo(); 
            textBox1.Text =usuariosDB.getUserName( Session.GetClientes().getUsuarioId());
            textBox2.Text = Session.GetFilme().Titulo;
            textBox3.Text = Session.GetCinema().Nome;
            textBox4.Text = Session.Horario;
            textBox5.Text = Session.getCarrinho().IngresosSelec.Count().ToString() ;
            textBox6.Text = Convert.ToString(Session.getCarrinho().IngresosSelec.Count() * 15); //this should be refactor
            pagamentoDB = new PagamentoRepo();
            cadeiraDB = new CadeirasRepo();
            orderDB = new OrderRepo();
            ingressoDB = new IngressosRepo();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Pago_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pagamentos newPagamento = new Pagamentos(Session.GetClientes(), Session.getCarrinho().IngresosSelec.Count() * 15);
            newPagamento.Id =  pagamentoDB.lastPagamento() + 1;
            newOrderForClient(Session.getCarrinho(), newPagamento);

            paymentConfirmationMessage msg = new paymentConfirmationMessage();
            this.Hide();
            msg.Show();
        }

        private void newOrderForClient(carrinho newCarrinho, Pagamentos newPagamento)
        {
            order newOrder = new order(newPagamento.getId(), newPagamento.getCliente().IdUsuario);
            newOrder.setId( orderDB.lastOrder() + 1);

            if (Session.GetClientes().UseCard)
            {
                newCarrinho.IngresosSelec.ForEach((x) =>
                {
                    cadeiraDB.newCadeira(x.getCadeira());

                });

                pagamentoDB.newPagamentoUseCard(newPagamento);
                orderDB.newOrder(newOrder);
                newCarrinho.IngresosSelec.ForEach((x) => {

                    ingressoDB.newIngresso(x, newOrder, Session.Horario);
                    
                });
                
            }
            else if (Session.GetClientes().UsePIMCoin)
            {
                newCarrinho.IngresosSelec.ForEach((x) =>
                {
                    cadeiraDB.newCadeira(x.getCadeira());

                });

                pagamentoDB.newPagamentoUsePIM(newPagamento);
                orderDB.newOrder(newOrder);
                newCarrinho.IngresosSelec.ForEach((x) => {
                    ingressoDB.newIngresso(x, newOrder, Session.Horario);

                });
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
