using CinemaPIM.Classes;
using CinemaPIM.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Windows.Forms;


namespace CinemaPIM
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
            
        }

        private void nextStep()
        {
            if (Session.getCarrinho() == null)
            {
                Home home = new Home();
                home.Show();
                this.Hide();
            }
            else
            {
                if (Session.GetClientes().UseCard || Session.GetClientes().UsePIMCoin)
                {
                    PagoConfirmForm pagoConfirm = new PagoConfirmForm();
                    this.Hide();
                    pagoConfirm.Show();
                }
                else
                {
                    MessageBox.Show("Cliente nao possui metodo de pagamento. Por favor adicione o tipo de pagamento ");
                    tipodepago tipodePagoForm = new tipodepago();
                    this.Hide();
                    tipodePagoForm.Show();

                }
            }

         

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Database db = new Database();
            db.setDB();
            //MessageBox.Show(amy);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {            
           
            string password =  pass.Text;
            MD5 md5Hash = MD5.Create();
            //MessageBox.Show(MD5Hash.GetMd5Hash(md5Hash, password));

            
            Session.setCliente(username.Text, MD5Hash.GetMd5Hash(md5Hash, password));

            MessageBox.Show(Session.GetClientes().GetEmail() + " with hash " + Session.GetClientes().getSenha());

            nextStep();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
