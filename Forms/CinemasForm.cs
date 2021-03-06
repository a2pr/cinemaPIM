﻿using CinemaPIM.Classes;
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
    public partial class CinemasForm : Form
    {
        Cinemas cinema;
        Filmes filme;
        private CinemasRepo cinemaDB;
        private List<Cinemas> cinemasDisp; 
        public CinemasForm()
        {
            InitializeComponent();
            cinemaDB = new CinemasRepo();
            cinemasDisp = cinemaDB.getCinemas();
            cinema = Session.GetCinema();
            filme = Session.GetFilme();
            setCinema();
        }

        private void setCinema()
        {
            cinema1Btn.Text = cinemasDisp[0].Nome;
            cinema2Btn.Text = cinemasDisp[1].Nome;
            cinema3Btn.Text = cinemasDisp[2].Nome;
            cinema4Btn.Text = cinemasDisp[3].Nome;
            setImages();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cinema1_Click(object sender, EventArgs e)
        {

        }

        private void Cinemas_Load(object sender, EventArgs e)
        {
            Database db = new Database();
        }

        private void setImages()
        {
            cinema1.BackgroundImage = Properties.Resources.descarga;
            cinema2.BackgroundImage = Properties.Resources.pontaNegra;
            cinema3.BackgroundImage = Properties.Resources.milleniumShopping;
            cinema4.BackgroundImage = Properties.Resources.sumaUma;
        }
        private void nextStep()
        {
            if (filme == null)
            {
                FilmesForm filmeForm = new FilmesForm();
                filmeForm.Show();
                this.Hide();
            }
            else
            {
                SalaForm sala = new SalaForm();
                sala.Show();
                this.Hide();
            }
        }
        private void cinema1Btn_Click(object sender, EventArgs e)
        {
            
            if (cinema == null)
            {
                Session.setCinema(cinemasDisp[0].Id, cinema1Btn.Text);
                MessageBox.Show(Session.GetCinema().Nome);

            }
            nextStep();

        }

        private void cinema2Btn_Click(object sender, EventArgs e)
        {
            if (cinema == null)
            {
                Session.setCinema(cinemasDisp[1].Id, cinema2Btn.Text);
                MessageBox.Show(Session.GetCinema().Nome);
            }
            nextStep();
        }

        private void cinema3Btn_Click(object sender, EventArgs e)
        {
            if (cinema == null)
            {
                Session.setCinema(cinemasDisp[2].Id, cinema3Btn.Text);
                MessageBox.Show(Session.GetCinema().Nome);
            }
            nextStep();
        }

        private void cinema4Btn_Click(object sender, EventArgs e)
        {;
            if (cinema == null)
            {
                Session.setCinema(cinemasDisp[3].Id, cinema4Btn.Text);
                MessageBox.Show(Session.GetCinema().Nome);
            }
            nextStep();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string targetURL = @"https://www.google.com/maps/search/" + cinemasDisp[0].Nome;
            System.Diagnostics.Process.Start(targetURL);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string targetURL = @"https://www.google.com/maps/search/" + cinemasDisp[1].Nome;
            System.Diagnostics.Process.Start(targetURL);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string targetURL = @"https://www.google.com/maps/search/" + cinemasDisp[2].Nome;
            System.Diagnostics.Process.Start(targetURL);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string targetURL = @"https://www.google.com/maps/search/" + cinemasDisp[3].Nome;
            System.Diagnostics.Process.Start(targetURL);
        }
    }
}
