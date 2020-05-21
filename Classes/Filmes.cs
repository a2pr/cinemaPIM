using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaPIM.Classes
{
    class Filmes
    {
        private int id;
        private string titulo;
        private string categorias;
        private string duracao;
        private string estria;
        private int rating;

        public Filmes(int idSelec, string tituloSelec)
        {
            id = idSelec;
            titulo = tituloSelec;
            categorias = "";
            duracao = "";
            estria = ""; 
        }
        public int Id { get => id; set => id = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Categorias { get => categorias; set => categorias = value; }
        public string Duracao { get => duracao; set => duracao = value; }
        public string Estria { get => estria; set => estria = value; }
        public int Rating { get => rating; set => rating = value; }
    }
}
