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
    public partial class falaconosco : Form
    {
        public falaconosco()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home homeW = new Home();
            this.Hide();
            homeW.Show();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
