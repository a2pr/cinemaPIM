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
    public partial class cartaoDadosForm : Form
    {
        public cartaoDadosForm()
        {
            InitializeComponent();
        }

        private void dadosdopagamento_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkInputs())
            {
                PagoConfirmForm confirm = new PagoConfirmForm();

                Session.GetClientes().UseCard = true;
                /**
                 * Save Pagamento in DB
                 */

                this.Hide();
                confirm.Show();

            }
            else
            {
                MessageBox.Show("Fill all your inputs.");
            }
        }

        private bool checkInputs()
        {
            if (
                !string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text)
                && !string.IsNullOrEmpty(textBox3.Text) && !string.IsNullOrEmpty(textBox4.Text)
                )
            {
                return true;
            }
            return false;
        }
    }
}
