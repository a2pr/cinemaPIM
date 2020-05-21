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
        private int linha;
        private int columna;
        private int sala;
        public cadeira(int l, int c, int s)
        {
            id = l + c + s;
            linha = l;
            columna = c;
            sala = s;
            
        }

        public int Id { get => id; set => id = value; }
        public int Linha { get => linha; set => linha = value; }
        public int Columna { get => columna; set => columna = value; }
        public int Sala { get => sala; set => sala = value; }
    }
}
