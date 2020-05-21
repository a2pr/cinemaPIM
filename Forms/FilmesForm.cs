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
    public partial class FilmesForm : Form
    {
        Cinemas cinema;
        Filmes filme;
        public FilmesForm()
        {
            InitializeComponent();
            cinema = Session.GetCinema();
            filme=  Session.GetFilme();
        }

        private void filme1_MouseClick(object sender, MouseEventArgs e)
        {
            if (filme == null)
            {
                Session.setFilme(1,"filme 1" );
                MessageBox.Show(Session.GetFilme().Titulo);
            }

            if (cinema == null)
            {
                CinemasForm cinemaForm = new CinemasForm();
                cinemaForm.Show();
                this.Hide();
            }
            else
            {
                //aqui iremos a pagamentos
            }
        }

        private void filme2_MouseClick(object sender, MouseEventArgs e)
        {
            if (filme == null)
            {
                Session.setFilme(2, "filme 2");
                MessageBox.Show(Session.GetFilme().Titulo);
            }

            if (cinema == null)
            {
                CinemasForm cinemaForm = new CinemasForm();
                cinemaForm.Show();
                this.Hide();
            }
            else
            {
                //aqui iremos a pagamentos
            }
        }

        private void filme2_Click(object sender, EventArgs e)
        {

          
        }

        private void filme3_MouseClick(object sender, MouseEventArgs e)
        {
            if (filme == null)
            {
                Session.setFilme(3, "filme 3");
                MessageBox.Show(Session.GetFilme().Titulo);
            }

            if (cinema == null)
            {
                CinemasForm cinemaForm = new CinemasForm();
                cinemaForm.Show();
                this.Hide();
            }
            else
            {
                //aqui iremos a pagamentos
            }
        }

        private void filme4_MouseClick(object sender, MouseEventArgs e)
        {
            if (filme == null)
            {
                Session.setFilme(4, "filme 4");
                MessageBox.Show(Session.GetFilme().Titulo);
            }

            if (cinema == null)
            {
                CinemasForm cinemaForm = new CinemasForm();
                cinemaForm.Show();
                this.Hide();
            }
            else
            {
                //aqui iremos a pagamentos
            }
        }

        private void filme5_MouseClick(object sender, MouseEventArgs e)
        {
            if (filme == null)
            {
                Session.setFilme(5, "filme 5");
                MessageBox.Show(Session.GetFilme().Titulo);
            }

            if (cinema == null)
            {
                CinemasForm cinemaForm = new CinemasForm();
                cinemaForm.Show();
                this.Hide();
            }
            else
            {
                //aqui iremos a pagamentos
            }
        }

        private void filme6_MouseClick(object sender, MouseEventArgs e)
        {
            if (filme == null)
            {
                Session.setFilme(6, "filme 6");
                MessageBox.Show(Session.GetFilme().Titulo);
            }

            if (cinema == null)
            {
                CinemasForm cinemaForm = new CinemasForm();
                cinemaForm.Show();
                this.Hide();
            }
            else
            {
                //aqui iremos a pagamentos
            }
        }
    }
}
