using CinemaPIM.Classes;
using CinemaPIM.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaPIM
{
    public partial class blockDados : Form
    {
        public blockDados()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox2.Text))
            {
                Session.GetClientes().UsePIMCoin = true;
                /*
                 * Here should be set the key into db
                 */

                PagoConfirmForm payment = new PagoConfirmForm();
                this.Hide();
                payment.Show();
            }
            else
            {
                MessageBox.Show("Adicione sua chave PIMcoin publica");
            }
           
        }
    }
}
