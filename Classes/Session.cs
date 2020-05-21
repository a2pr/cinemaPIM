using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaPIM.Classes
{
     static class Session
    {
        private static string username;
        private static Cinemas cinema;
        private static Filmes filme;
        private static carrinho carrinho;
        
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

        public static void SetCarrinho(int cliente, string cinema, string horarios, int cadeiras)
        {
            Cinemas cinemaSelec = GetCinema();
            Filmes filmesSelec = GetFilme();
            Ingressos ingressos = new Ingressos(horarios, filmesSelec.Titulo, cinemaSelec.Nome, cadeiras);
            Ingressos[] collecIngressos = { ingressos };
            carrinho = new carrinho(cliente, cinemaSelec, collecIngressos);
        }
    }
}
