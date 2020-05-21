using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaPIM.Classes
{
    class cadeira
    {
        private int id;
        private string linha;
        private int columna;
        private int sala;
        public cadeira(string l, int c, int s)
        {
            Random rnd = new Random();
            id = rnd.Next(5000,7000 );
            linha = l;
            columna = c;
            sala = s;
            
        }

        public int Id { get => id; set => id = value; }
        public string Linha { get => linha; set => linha = value; }
        public int Columna { get => columna; set => columna = value; }
        public int Sala { get => sala; set => sala = value; }
    }
}
