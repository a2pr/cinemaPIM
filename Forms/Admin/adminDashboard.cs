using CinemaPIM.Classes;
using CinemaPIM.Forms.Admin;
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
    public partial class adminDashboard : Form
    {
        private OrderRepo orderDB;
        private DatabaseAdmin adminDB;
        public adminDashboard()
        {
            InitializeComponent();
            orderDB = new OrderRepo();
            adminDB = new DatabaseAdmin();
            dataGridView1.DataSource = adminDB.table();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void adminDashboard_Load(object sender, EventArgs e)
        {
           // dataGridView1.Columns[6].Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            adminDB.Backup();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            adminDB.Restore();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = adminDB.getCinemas();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = adminDB.getFilmes();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = adminDB.getCard();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = adminDB.getPIMCoin();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            gerarRelatorios Rela = new gerarRelatorios();
            this.Hide();
            Rela.Show();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
