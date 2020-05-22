using CinemaPIM.Classes;
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
        public PagoConfirmForm()
        {
            InitializeComponent();
            textBox1.Text = Session.GetClientes().GetNome();
            textBox2.Text = Session.GetFilme().Titulo;
            textBox3.Text = Session.GetCinema().Nome;
            textBox4.Text = Session.Horario;
            textBox5.Text = Session.getCarrinho().IngresosSelec.Count().ToString() ;
            textBox6.Text = Convert.ToString(Session.getCarrinho().IngresosSelec.Count() * 15); //


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
            /**
             * Save order into db
             */
            paymentConfirmationMessage msg = new paymentConfirmationMessage();
            this.Hide();
            msg.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
