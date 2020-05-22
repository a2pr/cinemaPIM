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
        private List<Ingressos> ingresosSelec = new List<Ingressos>();
       
        public carrinho(int cliente, Cinemas cinemaSelec)
        {
            Random rnd = new Random();
            id = rnd.Next(1000,5000);
            cinema = cinemaSelec;
            idCliente = cliente;
        }
        public carrinho(Cinemas cinemaSelec)
        {
            Random rnd = new Random();
            id = rnd.Next(1000, 5000);
            cinema = cinemaSelec;
        }
        public int IdCliente { get => idCliente; set => idCliente = value; }
        internal Cinemas Cinema { get => cinema; set => cinema = value; }
        public List<Ingressos> IngresosSelec { get => ingresosSelec; set => ingresosSelec = value; }

        public void addIngressos(Ingressos selecIngressos)
        {
            ingresosSelec.Add(selecIngressos);
        }


    }
}
