﻿using System;
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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Properties.Resources.mulan;
        }

        private void cinemaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            CinemasForm cinemaForm = new CinemasForm();
            cinemaForm.Show();
            this.Hide();
        }

        private void filmesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FilmesForm filmesForm = new FilmesForm();
            filmesForm.Show();
            this.Hide();
        }
    }
}
