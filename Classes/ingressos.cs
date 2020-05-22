using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace CinemaPIM.Classes
{
    class Ingressos
    {
        private int id;
        private string horario;
        private string filme;
        private string cinema;
        private int cadeiraSelec;
        private float valor;

        public Ingressos( string selectHorario, string selecFilme, string selecCinema, int idCadeira)
        {
            Random rnd = new Random();
            id = rnd.Next(1,1000);
            horario = selectHorario;
            filme = selecFilme;
            cinema = selecCinema;
            cadeiraSelec = idCadeira;
        }

        public int Id { get => id; set => id = value; }
        public string Horario { get => horario; set => horario = value; }
        public string Filme { get => filme; set => filme = value; }
        public string Cinema { get => cinema; set => cinema = value; }
        public float Valor { get => valor; set => valor = value; }
    }
}
