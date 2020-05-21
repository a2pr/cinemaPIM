using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaPIM.Classes
{
    class Salas
    {
        public const string HORARIO_FIRST = "1:00-3:00";
        public const string HORARIO_SECOND = "3:30-5:30";
        public const string HORARIO_THIRD = "7:00-9:00";
        public const string HORARIO_FOURTH = "9:30-11:30";
        private int id;
        private string[] horarios = {HORARIO_FIRST, HORARIO_SECOND, HORARIO_THIRD, HORARIO_FOURTH};
        private int idCinema;

        public Salas(int value, int cinemaValue)
        {
            id = value;
            idCinema = cinemaValue;
        }

        public string[] getHorarios()
        {
            return horarios;
        }
    }
}
