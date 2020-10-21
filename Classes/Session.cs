using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CinemaPIM.Classes
{
     static class Session
    {
        private static Clientes cliente;
        private static Cinemas cinema;
        private static Filmes filme;
        private static string horario;
        private static carrinho carrinho;
        private static order order;
        public static string Horario { get => horario; set => horario = value; }

        public static bool signIn()
        {
            if (cliente !=null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void setOrder(order value) {
            order = value;
        }
        public static void setCliente(Clientes newCLiente)
        {
            cliente = newCLiente;
        }

        public static order getOrder()
        {
            return order;
        }
        public static void setClienteByDB(Clientes dbCLient)
        {
            cliente = dbCLient;
        }

        public static Clientes GetClientes()
        {
            return cliente;
        }

        public static void setCinema(int id, string nome)
        {
            cinema = new Cinemas(id, nome);
        }

        public static Cinemas GetCinema()
        {
            return cinema;
        }

        public static void setFilme(int id, string nome)
        {
            filme = new Filmes(id, nome);
        }

        internal static Filmes GetFilme()
        {
            return filme;
        }

        public static void SetCarrinho()
        {
            Cinemas cinemaSelec = GetCinema();
            Filmes filmesSelec = GetFilme();
            if (cliente != null)
            {
                carrinho = new carrinho(cliente.GetId(), cinemaSelec);
            }
            else
            {
                carrinho = new carrinho(cinemaSelec);
            }
            
        }

        public static carrinho getCarrinho()
        {
            return carrinho;
        }

        public static void reset()
        {
            cliente = null;
            cinema = null;
            filme = null;
            horario = null;
            carrinho = null;
            order = null;
        }
    }
}
