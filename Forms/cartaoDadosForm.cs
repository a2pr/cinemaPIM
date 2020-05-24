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
using System.Security.Cryptography;
using System.Windows.Forms;

namespace CinemaPIM.Forms
{
    public partial class cartaoDadosForm : Form
    {
        private carrinho currentCarrinho;
        private CardRepo cardDB;

        public cartaoDadosForm()
        {
            InitializeComponent();
            currentCarrinho = Session.getCarrinho();
            cardDB = new CardRepo();
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

                addingToDB();

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

        private void addingToDB()
        {
            MD5 md5Hash = MD5.Create();
            MD5Hash.GetMd5Hash(md5Hash, textBox4.Text);
            Card newCard = new Card(
                Session.GetClientes().IdUsuario,
                textBox1.Text, 
                textBox2.Text,
                MD5Hash.GetMd5Hash(md5Hash, textBox4.Text)
                );
            cardDB.newCard(newCard);
            ClienteRepo clientDB = new ClienteRepo();
            clientDB.updateUseCard(Session.GetClientes().IdUsuario);
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
