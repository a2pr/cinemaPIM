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
    public partial class paymentConfirmationMessage : Form
    {

        public paymentConfirmationMessage()
        {
            InitializeComponent();
        }

        private void mensagem_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Session.reset();
            Home home = new Home();
            this.Hide();
            home.Show();
        }
    }
}
