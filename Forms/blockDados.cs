using CinemaPIM.Classes;
using CinemaPIM.Forms;
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

namespace CinemaPIM
{
    public partial class blockDados : Form
    {
        private BlockRepo blockDB;
        private ClienteRepo clienteDB;
        public blockDados()
        {
            InitializeComponent();
            blockDB = new BlockRepo();
            clienteDB = new ClienteRepo();
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

                BlockPIM block = new BlockPIM(Session.GetClientes().IdUsuario, textBox2.Text);
                blockDB.newKey(block.IdCliente, block.Key);
                clienteDB.updateUsePIMCoin(block.IdCliente);

                PagoConfirmForm payment = new PagoConfirmForm();
                this.Hide();
                payment.Show();
            }
            else
            {
                MessageBox.Show("Adicione sua chave PIMcoin publica");
            }
           
        }

        private void blockDados_Load(object sender, EventArgs e)
        {

        }
    }
}
