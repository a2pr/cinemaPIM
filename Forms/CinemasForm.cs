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
    public partial class CinemasForm : Form
    {
        Cinemas cinema;
        Filmes filme;
        public CinemasForm()
        {
            InitializeComponent();
            cinema = Session.GetCinema();
            filme = Session.GetFilme();
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
                Session.setCinema(1, "cinema 1");
                MessageBox.Show(Session.GetCinema().Nome);

            }
            nextStep();

        }

        private void cinema2Btn_Click(object sender, EventArgs e)
        {
            if (cinema == null)
            {
                Session.setCinema(2, "cinema 2");
                MessageBox.Show(Session.GetCinema().Nome);
            }
            nextStep();
        }

        private void cinema3Btn_Click(object sender, EventArgs e)
        {
            if (cinema == null)
            {
                Session.setCinema(3, "cinema 3");
                MessageBox.Show(Session.GetCinema().Nome);
            }
            nextStep();
        }

        private void cinema4Btn_Click(object sender, EventArgs e)
        {;
            if (cinema == null)
            {
                Session.setCinema(4, "cinema 4");
                MessageBox.Show(Session.GetCinema().Nome);
            }
            nextStep();
        }
    }
}
