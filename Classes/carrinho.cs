using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaPIM.Classes
{
    class carrinho
    {
        private int id;
        private int idCliente;
        private Cinemas cinema;
        private Ingressos[] ingresosSelec;
       
        public carrinho(int cliente, Cinemas cinemaSelec, Ingressos[] ingresso)
        {
            Random rnd = new Random();
            id = rnd.Next(1000 - 5000);
            cinema = cinemaSelec;
            ingresosSelec = ingresso;
            idCliente = cliente;
        }
        public int IdCliente { get => idCliente; set => idCliente = value; }
        internal Ingressos[] IngresosSelec { get => ingresosSelec; set => ingresosSelec = value; }
        internal Cinemas Cinema { get => cinema; set => cinema = value; }
    }
}
