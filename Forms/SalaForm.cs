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
    public partial class SalaForm : Form
    {
        private List<cadeira> cadeiras = new List<cadeira>();

        private IngressosRepo ingressoDB;
        private CadeirasRepo cadeirasDB;
        private int idSala;
        private string cinemaNome;
        private string horarioSelec;
        private string filmeTitulo;
        private int numberOfCadeira= 1;
        public SalaForm()
        {
            InitializeComponent();
            Random rnd = new Random();
            idSala =rnd.Next(1,3);
            Cinemas Cinema = Session.GetCinema();
            cinemaNome = Cinema.Nome;
            Salas currentSala = new Salas(idSala, Cinema.Id);
            filmeTitulo = Session.GetFilme().Titulo;
            horarioSelec = Session.Horario;
            ingressoDB = new IngressosRepo();
            cadeirasDB = new CadeirasRepo();
        }

        private void setCadeira(string linha, int columna)
        {
            cadeira newCadeira = new cadeira(linha,columna, idSala);
            newCadeira.Id = cadeirasDB.lastCadeira() + this.numberOfCadeira;
            cadeiras.Add(newCadeira);
            this.numberOfCadeira++;
            MessageBox.Show("escolhida cadeira " + linha+ Convert.ToString(columna));
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxLinha_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Sala_Load(object sender, EventArgs e)
        {

        }


        #region
        private void btnA1_Click(object sender, EventArgs e)
        {
            string linha = "A";
            int columna = 1;

            setCadeira(linha, columna);
            btnA1.BackColor = Color.DarkGray;
        }

        private void btnA2_Click(object sender, EventArgs e)
        {
            string linha = "A";
            int columna = 2;

            setCadeira(linha, columna);
            btnA2.BackColor = Color.DarkGray;
        }

        private void btnA3_Click(object sender, EventArgs e)
        {
            string linha = "A";
            int columna = 3;

            setCadeira(linha, columna);
            btnA3.BackColor = Color.DarkGray;
        }

        private void btnA4_Click(object sender, EventArgs e)
        {
            string linha = "A";
            int columna = 4;

            setCadeira(linha, columna);
            btnA4.BackColor = Color.DarkGray;
        }

        private void btnA5_Click(object sender, EventArgs e)
        {
            string linha = "A";
            int columna = 5;

            setCadeira(linha, columna);
            btnA5.BackColor = Color.DarkGray;
        }

        private void btnA8_Click(object sender, EventArgs e)
        {
            string linha = "A";
            int columna = 8;

            setCadeira(linha, columna);
            btnA8.BackColor = Color.DarkGray;
        }

        private void btnA9_Click(object sender, EventArgs e)
        {
            string linha = "A";
            int columna = 9;

            setCadeira(linha, columna);
            btnA9.BackColor = Color.DarkGray;
        }

        private void btnA10_Click(object sender, EventArgs e)
        {
            string linha = "A";
            int columna = 10;

            setCadeira(linha, columna);
            btnA10.BackColor = Color.DarkGray;
        }

        private void btnA11_Click(object sender, EventArgs e)
        {
            string linha = "A";
            int columna = 11;

            setCadeira(linha, columna);
            btnA11.BackColor = Color.DarkGray;
        }

        private void btnA12_Click(object sender, EventArgs e)
        {
            string linha = "A";
            int columna = 12;

            setCadeira(linha, columna);
            btnA12.BackColor = Color.DarkGray;
        }

        #endregion AA linha A


        #region
        private void btnB1_Click(object sender, EventArgs e)
        {
            string linha = "B";
            int columna = 1;

            setCadeira(linha, columna);
            btnB1.BackColor = Color.DarkGray;
        }

        private void btnB2_Click(object sender, EventArgs e)
        {
            string linha = "B";
            int columna = 2;

            setCadeira(linha, columna);
            btnB2.BackColor = Color.DarkGray;
        }

        private void btnB3_Click(object sender, EventArgs e)
        {
            string linha = "B";
            int columna = 3;

            setCadeira(linha, columna);
            btnB3.BackColor = Color.DarkGray;
        }

        private void btnB4_Click(object sender, EventArgs e)
        {
            string linha = "B";
            int columna = 4;

            setCadeira(linha, columna);
            btnB4.BackColor = Color.DarkGray;
        }

        private void btnB5_Click(object sender, EventArgs e)
        {
            string linha = "B";
            int columna = 5;

            setCadeira(linha, columna);
            btnB5.BackColor = Color.DarkGray;
        }

        private void btnB8_Click(object sender, EventArgs e)
        {
            string linha = "B";
            int columna = 8;

            setCadeira(linha, columna);
            btnB8.BackColor = Color.DarkGray;
        }

        private void btnB9_Click(object sender, EventArgs e)
        {
            string linha = "B";
            int columna = 9;

            setCadeira(linha, columna);
            btnB9.BackColor = Color.DarkGray;
        }

        private void btnB10_Click(object sender, EventArgs e)
        {
            string linha = "B";
            int columna = 10;

            setCadeira(linha, columna);
            btnB10.BackColor = Color.DarkGray;
        }

        private void btnB11_Click(object sender, EventArgs e)
        {
            string linha = "B";
            int columna = 11;

            setCadeira(linha, columna);
            btnB11.BackColor = Color.DarkGray;
        }

        private void btnB12_Click(object sender, EventArgs e)
        {
            string linha = "B";
            int columna = 12;

            setCadeira(linha, columna);
            btnB12.BackColor = Color.DarkGray;
        }
        #endregion

        #region
        private void btnC1_Click(object sender, EventArgs e)
        {
            string linha = "C";
            int columna = 1;

            setCadeira(linha, columna);
            btnC1.BackColor = Color.DarkGray;
        }

        private void btnC2_Click(object sender, EventArgs e)
        {
            string linha = "C";
            int columna = 2;

            setCadeira(linha, columna);
            btnC2.BackColor = Color.DarkGray;
        }

        private void btnC3_Click(object sender, EventArgs e)
        {
            string linha = "C";
            int columna = 3;

            setCadeira(linha, columna);
            btnC3.BackColor = Color.DarkGray;
        }

        private void btnC4_Click(object sender, EventArgs e)
        {
            string linha = "C";
            int columna = 4;

            setCadeira(linha, columna);
            btnC4.BackColor = Color.DarkGray;
        }

        private void btnC5_Click(object sender, EventArgs e)
        {
            string linha = "C";
            int columna = 5;

            setCadeira(linha, columna);
            btnC5.BackColor = Color.DarkGray;
        }

        private void btnC8_Click(object sender, EventArgs e)
        {
            string linha = "C";
            int columna = 8;

            setCadeira(linha, columna);
            btnC8.BackColor = Color.DarkGray;
        }

        private void btnC9_Click(object sender, EventArgs e)
        {
            string linha = "C";
            int columna = 9;

            setCadeira(linha, columna);
            btnC9.BackColor = Color.DarkGray;
        }

        private void btnC10_Click(object sender, EventArgs e)
        {
            string linha = "C";
            int columna = 10;

            setCadeira(linha, columna);
            btnC10.BackColor = Color.DarkGray;
        }

        private void btnC11_Click(object sender, EventArgs e)
        {
            string linha = "C";
            int columna = 11;

            setCadeira(linha, columna);
            btnC11.BackColor = Color.DarkGray;
        }

        private void btnC12_Click(object sender, EventArgs e)
        {
            string linha = "C";
            int columna = 12;

            setCadeira(linha, columna);
            btnC12.BackColor = Color.DarkGray;
        }


        #endregion

        #region
        private void btnD1_Click(object sender, EventArgs e)
        {
            string linha = "D";
            int columna = 1;

            setCadeira(linha, columna);
            btnD1.BackColor = Color.DarkGray;
        }

        private void btnD2_Click(object sender, EventArgs e)
        {
            string linha = "D";
            int columna = 2;

            setCadeira(linha, columna);
            btnD2.BackColor = Color.DarkGray;
        }

        private void btnD3_Click(object sender, EventArgs e)
        {
            string linha = "D";
            int columna = 3;

            setCadeira(linha, columna);
            btnD3.BackColor = Color.DarkGray;
        }

        private void btnD4_Click(object sender, EventArgs e)
        {
            string linha = "D";
            int columna = 4;

            setCadeira(linha, columna);
            btnD4.BackColor = Color.DarkGray;
        }

        private void btnD5_Click(object sender, EventArgs e)
        {
            string linha = "D";
            int columna = 5;

            setCadeira(linha, columna);
            btnD5.BackColor = Color.DarkGray;
        }

        private void btnD8_Click(object sender, EventArgs e)
        {
            string linha = "D";
            int columna = 8;

            setCadeira(linha, columna);
            btnD8.BackColor = Color.DarkGray;
        }

        private void btnD9_Click(object sender, EventArgs e)
        {
            string linha = "D";
            int columna = 9;

            setCadeira(linha, columna);
            btnD9.BackColor = Color.DarkGray;
        }

        private void btnD10_Click(object sender, EventArgs e)
        {
            string linha = "D";
            int columna = 10;

            setCadeira(linha, columna);
            btnD10.BackColor = Color.DarkGray;
        }

        private void btnD11_Click(object sender, EventArgs e)
        {
            string linha = "D";
            int columna = 11;

            setCadeira(linha, columna);
            btnD11.BackColor = Color.DarkGray;
        }

        private void btnD12_Click(object sender, EventArgs e)
        {
            string linha = "D";
            int columna = 12;

            setCadeira(linha, columna);
            btnD12.BackColor = Color.DarkGray;
        }


        #endregion

        #region
        private void btnE1_Click(object sender, EventArgs e)
        {
            string linha = "E";
            int columna = 1;

            setCadeira(linha, columna);
            btnE1.BackColor = Color.DarkGray;
        }

        private void btnE2_Click(object sender, EventArgs e)
        {
            string linha = "E";
            int columna = 2;

            setCadeira(linha, columna);
            btnE2.BackColor = Color.DarkGray;
        }

        private void btnE3_Click(object sender, EventArgs e)
        {
            string linha = "E";
            int columna = 3;

            setCadeira(linha, columna);
            btnE3.BackColor = Color.DarkGray;
        }

        private void btnE4_Click(object sender, EventArgs e)
        {
            string linha = "E";
            int columna = 4;

            setCadeira(linha, columna);
            btnE4.BackColor = Color.DarkGray;
        }

        private void btnE5_Click(object sender, EventArgs e)
        {
            string linha = "E";
            int columna = 5;

            setCadeira(linha, columna);
            btnE5.BackColor = Color.DarkGray;
        }

        private void btnE8_Click(object sender, EventArgs e)
        {
            string linha = "E";
            int columna = 8;

            setCadeira(linha, columna);
            btnE8.BackColor = Color.DarkGray;
        }

        private void btnE9_Click(object sender, EventArgs e)
        {
            string linha = "E";
            int columna = 9;

            setCadeira(linha, columna);
            btnE9.BackColor = Color.DarkGray;
        }

        private void btnE10_Click(object sender, EventArgs e)
        {
            string linha = "E";
            int columna = 10;

            setCadeira(linha, columna);
            btnE10.BackColor = Color.DarkGray;
        }

        private void btnE11_Click(object sender, EventArgs e)
        {
            string linha = "E";
            int columna = 11;

            setCadeira(linha, columna);
            btnE11.BackColor = Color.DarkGray;
        }

        private void btnE12_Click(object sender, EventArgs e)
        {
            string linha = "E";
            int columna = 12;

            setCadeira(linha, columna);
            btnE12.BackColor = Color.DarkGray;
        }


        #endregion

        #region
        private void btnF1_Click(object sender, EventArgs e)
        {
            string linha = "F";
            int columna = 1;

            setCadeira(linha, columna);
            btnF1.BackColor = Color.DarkGray;
        }

        private void btnF2_Click(object sender, EventArgs e)
        {
            string linha = "F";
            int columna = 2;

            setCadeira(linha, columna);
            btnF2.BackColor = Color.DarkGray;
        }

        private void btnF3_Click(object sender, EventArgs e)
        {
            string linha = "F";
            int columna = 3;

            setCadeira(linha, columna);
            btnF3.BackColor = Color.DarkGray;
        }

        private void btnF4_Click(object sender, EventArgs e)
        {
            string linha = "F";
            int columna = 4;

            setCadeira(linha, columna);
            btnF4.BackColor = Color.DarkGray;
        }

        private void btnF5_Click(object sender, EventArgs e)
        {
            string linha = "F";
            int columna = 5;

            setCadeira(linha, columna);
            btnF5.BackColor = Color.DarkGray;
        }

        private void btnF8_Click(object sender, EventArgs e)
        {
            string linha = "F";
            int columna = 8;

            setCadeira(linha, columna);
            btnF8.BackColor = Color.DarkGray;
        }

        private void btnF9_Click(object sender, EventArgs e)
        {
            string linha = "F";
            int columna = 9;

            setCadeira(linha, columna);
            btnF9.BackColor = Color.DarkGray;
        }

        private void btnF10_Click(object sender, EventArgs e)
        {
            string linha = "F";
            int columna = 10;

            setCadeira(linha, columna);
            btnF10.BackColor = Color.DarkGray;
        }

        private void btnF11_Click(object sender, EventArgs e)
        {
            string linha = "F";
            int columna = 11;

            setCadeira(linha, columna);
            btnF11.BackColor = Color.DarkGray;
        }

        private void btnF12_Click(object sender, EventArgs e)
        {
            string linha = "F";
            int columna = 12;

            setCadeira(linha, columna);
            btnF12.BackColor = Color.DarkGray;
        }

        #endregion

        #region
        private void btnG1_Click(object sender, EventArgs e)
        {
            string linha = "G";
            int columna = 1;

            setCadeira(linha, columna);
            btnG1.BackColor = Color.DarkGray;
        }

        private void btnG2_Click(object sender, EventArgs e)
        {
            string linha = "G";
            int columna = 2;

            setCadeira(linha, columna);
            btnG2.BackColor = Color.DarkGray;
        }

        private void btnG3_Click(object sender, EventArgs e)
        {
            string linha = "G";
            int columna = 3;

            setCadeira(linha, columna);
            btnG3.BackColor = Color.DarkGray;
        }

        private void btnG4_Click(object sender, EventArgs e)
        {
            string linha = "G";
            int columna = 4;

            setCadeira(linha, columna);
            btnG4.BackColor = Color.DarkGray;
        }

        private void btnG5_Click(object sender, EventArgs e)
        {
            string linha = "G";
            int columna = 5;

            setCadeira(linha, columna);
            btnG5.BackColor = Color.DarkGray;
        }

        private void btnG8_Click(object sender, EventArgs e)
        {
            string linha = "G";
            int columna = 8;

            setCadeira(linha, columna);
            btnG8.BackColor = Color.DarkGray;
        }

        private void btnG9_Click(object sender, EventArgs e)
        {
            string linha = "G";
            int columna = 9;

            setCadeira(linha, columna);
            btnG9.BackColor = Color.DarkGray;
        }

        private void btnG10_Click(object sender, EventArgs e)
        {
            string linha = "G";
            int columna = 10;

            setCadeira(linha, columna);
            btnG10.BackColor = Color.DarkGray;
        }

        private void btnG11_Click(object sender, EventArgs e)
        {
            string linha = "G";
            int columna = 11;

            setCadeira(linha, columna);
            btnG11.BackColor = Color.DarkGray;
        }

        private void btnG12_Click(object sender, EventArgs e)
        {
            string linha = "G";
            int columna = 12;

            setCadeira(linha, columna);
            btnG12.BackColor = Color.DarkGray;
        }


        #endregion

        #region

        private void btnH1_Click(object sender, EventArgs e)
        {
            string linha = "H";
            int columna = 1;

            setCadeira(linha, columna);
            btnH1.BackColor = Color.DarkGray;
        }

        private void btnH2_Click(object sender, EventArgs e)
        {
            string linha = "H";
            int columna = 2;

            setCadeira(linha, columna);
            btnH2.BackColor = Color.DarkGray;
        }

        private void btnH3_Click(object sender, EventArgs e)
        {
            string linha = "H";
            int columna = 3;

            setCadeira(linha, columna);
            btnH3.BackColor = Color.DarkGray;
        }

        private void btnH4_Click(object sender, EventArgs e)
        {
            string linha = "H";
            int columna =4;

            setCadeira(linha, columna);
            btnH4.BackColor = Color.DarkGray;
        }

        private void btnH5_Click(object sender, EventArgs e)
        {
            string linha = "H";
            int columna = 5;

            setCadeira(linha, columna);
            btnH5.BackColor = Color.DarkGray;
        }

        private void btnH8_Click(object sender, EventArgs e)
        {
            string linha = "H";
            int columna = 8;

            setCadeira(linha, columna);
            btnH8.BackColor = Color.DarkGray;
        }

        private void btnH9_Click(object sender, EventArgs e)
        {
            string linha = "H";
            int columna = 9;

            setCadeira(linha, columna);
            btnH9.BackColor = Color.DarkGray;
        }

        private void btnH10_Click(object sender, EventArgs e)
        {
            string linha = "H";
            int columna = 10;

            setCadeira(linha, columna);
            btnH10.BackColor = Color.DarkGray;
        }

        private void btnH11_Click(object sender, EventArgs e)
        {
            string linha = "H";
            int columna = 11;

            setCadeira(linha, columna);
            btnH11.BackColor = Color.DarkGray;
        }

        private void btnH12_Click(object sender, EventArgs e)
        {
            string linha = "H";
            int columna = 12;

            setCadeira(linha, columna);
            btnH12.BackColor = Color.DarkGray;
        }


        #endregion

        #region

        private void btnI1_Click(object sender, EventArgs e)
        {
            string linha = "I";
            int columna = 1;

            setCadeira(linha, columna);
            btnI1.BackColor = Color.DarkGray;
        }

        private void btnI2_Click(object sender, EventArgs e)
        {
            string linha = "I";
            int columna = 2;

            setCadeira(linha, columna);
            btnI2.BackColor = Color.DarkGray;
        }

        private void btnI3_Click(object sender, EventArgs e)
        {
            string linha = "I";
            int columna = 3;

            setCadeira(linha, columna);
            btnI3.BackColor = Color.DarkGray;
        }

        private void btnI4_Click(object sender, EventArgs e)
        {
            string linha = "I";
            int columna = 4;

            setCadeira(linha, columna);
            btnI4.BackColor = Color.DarkGray;
        }

        private void btnI5_Click(object sender, EventArgs e)
        {
            string linha = "I";
            int columna = 5;

            setCadeira(linha, columna);
            btnI5.BackColor = Color.DarkGray;
        }

        private void btnI6_Click(object sender, EventArgs e)
        {
            string linha = "I";
            int columna = 6;

            setCadeira(linha, columna);
            btnI6.BackColor = Color.DarkGray;
        }

        private void btnI7_Click(object sender, EventArgs e)
        {
            string linha = "I";
            int columna = 7;

            setCadeira(linha, columna);
            btnI7.BackColor = Color.DarkGray;
        }

        private void btnI8_Click(object sender, EventArgs e)
        {
            string linha = "I";
            int columna = 8;

            setCadeira(linha, columna);
            btnI8.BackColor = Color.DarkGray;
        }

        private void btnI9_Click(object sender, EventArgs e)
        {
            string linha = "I";
            int columna = 9;

            setCadeira(linha, columna);
            btnI9.BackColor = Color.DarkGray;
        }

        private void btnI10_Click(object sender, EventArgs e)
        {
            string linha = "I";
            int columna = 10;

            setCadeira(linha, columna);
            btnI10.BackColor = Color.DarkGray;
        }

        private void btnI11_Click(object sender, EventArgs e)
        {
            string linha = "I";
            int columna = 11;

            setCadeira(linha, columna);
            btnI11.BackColor = Color.DarkGray;
        }

        private void btnI12_Click(object sender, EventArgs e)
        {
            string linha = "I";
            int columna = 12;

            setCadeira(linha, columna);
            btnI12.BackColor = Color.DarkGray;
        }
        #endregion
        private void button1_Click(object sender, EventArgs e)
        {
            List<Ingressos> ing = new List<Ingressos>();
            int i = 1;
            cadeiras.ForEach(x =>
            {
                if (x != null)
                {
                    Ingressos newIngressos = new Ingressos(horarioSelec, filmeTitulo, cinemaNome, x);
                    newIngressos.Id = ingressoDB.lastIngreso() + i;
                    ing.Add(newIngressos);
                }
                i ++;
            });

            Session.SetCarrinho();

            ing.ForEach(x =>
            {
                Session.getCarrinho().addIngressos(x);
            });

            if (Session.GetClientes() == null)
            {
                Login loginForm = new Login();
                this.Hide();
                loginForm.Show();

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

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
