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
        private static int idCliente;
        private static string username; //will need to refactor to usuario
        private static Cinemas cinema;
        private static Filmes filme;
        private static string horario;
        private static carrinho carrinho;

        public static string Horario { get => horario; set => horario = value; }
        public static int IdCliente { get => idCliente; set => idCliente = value; }

        public static void setUsername(string login)
        {
            username = login.ToString();
        }

        public static string getUsername()
        {
            return username;
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
            carrinho = new carrinho(IdCliente, cinemaSelec);
        }

        public static carrinho getCarrinho()
        {
            return carrinho;
        }
    }
}
