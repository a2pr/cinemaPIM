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
using System.Windows.Forms;

namespace CinemaPIM.Forms
{
    public partial class FilmesForm : Form
    {
        Cinemas cinema;
        Filmes filme;
        private FilmesRepo filmesDB;
        private List<Filmes> FilmesByCinema;
        public FilmesForm()
        {
            InitializeComponent();
            cinema = Session.GetCinema();
            filme=  Session.GetFilme();
            filmesDB = new FilmesRepo();
            if (cinema !=null)
            {
                FilmesByCinema = filmesDB.getFilmesByIdCinema(cinema.Id);
            }
            else
            {
                FilmesByCinema = filmesDB.getFilmes();

            }
        }

        private void nextStep()
        {
            if (cinema == null)
            {
                CinemasForm cinemaForm = new CinemasForm();
                cinemaForm.Show();
                this.Hide();
            }
            else
            {
                SalaForm sala = new SalaForm();
                sala.Show();
                this.Hide();
            }
        }
        private void filme1_MouseClick(object sender, MouseEventArgs e)
        {
            if (filme == null)
            {
                Session.setFilme(FilmesByCinema[0].Id, FilmesByCinema[0].Titulo) ;
                MessageBox.Show(Session.GetFilme().Titulo);
                Session.Horario = comboBox1.Text;
                MessageBox.Show(Session.GetFilme().Titulo + " no horario " + Session.Horario);
            }

            nextStep();
        }

        private void filme2_MouseClick(object sender, MouseEventArgs e)
        {
            if (filme == null)
            {
                Session.setFilme(FilmesByCinema[1].Id, FilmesByCinema[1].Titulo);
                MessageBox.Show(Session.GetFilme().Titulo);
                Session.Horario = comboBox1.Text;
                MessageBox.Show(Session.GetFilme().Titulo + " no horario " + Session.Horario);
            }

            nextStep();
        }

        private void filme2_Click(object sender, EventArgs e)
        {

          
        }

        private void filme3_MouseClick(object sender, MouseEventArgs e)
        {
            if (filme == null)
            {
                Session.setFilme(FilmesByCinema[2].Id, FilmesByCinema[2].Titulo);
                MessageBox.Show(Session.GetFilme().Titulo);
                Session.Horario = comboBox1.Text;
                MessageBox.Show(Session.GetFilme().Titulo + " no horario " + Session.Horario);
            }

            nextStep();
        }

        private void filme4_MouseClick(object sender, MouseEventArgs e)
        {
            if (filme == null)
            {
                Session.setFilme(FilmesByCinema[3].Id, FilmesByCinema[3].Titulo);
                MessageBox.Show(Session.GetFilme().Titulo);
                Session.Horario = comboBox1.Text;
                MessageBox.Show(Session.GetFilme().Titulo + " no horario " + Session.Horario);
            }
            nextStep();
        }

        private void filme5_MouseClick(object sender, MouseEventArgs e)
        {
            if (filme == null)
            {
                Session.setFilme(FilmesByCinema[4].Id, FilmesByCinema[4].Titulo);
                MessageBox.Show(Session.GetFilme().Titulo);
                Session.Horario = comboBox1.Text;
                MessageBox.Show(Session.GetFilme().Titulo + " no horario " + Session.Horario);
            }

            nextStep();
        }

        private void filme6_MouseClick(object sender, MouseEventArgs e)
        {
           
            if (filme == null)
            {

                Session.setFilme(FilmesByCinema[5].Id, FilmesByCinema[5].Titulo);
                Session.Horario = comboBox1.Text;
                MessageBox.Show(Session.GetFilme().Titulo + " no horario " + Session.Horario);
            }
            nextStep();
        }

        private void FilmesForm_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            filme1.Enabled = true;
            filme2.Enabled = true;
            filme3.Enabled = true;
            filme4.Enabled = true;
            filme5.Enabled = true;
            filme6.Enabled = true;

        }

        private void filme1_Click(object sender, EventArgs e)
        {

        }

        private void filme3_Click(object sender, EventArgs e)
        {

        }
    }
}
