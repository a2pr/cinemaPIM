using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaPIM.Classes
{
    class Cinemas
    {

        private int id;
        private string nome;
        private string[] filmes;
        private string endereco;

        public Cinemas(int idSelect, string nomeSelect)
        {
            Id = idSelect;
            Nome = nomeSelect;
            Filmes = new string[] { };
            Endereco = "";
        }

        public string Nome { get => nome; set => nome = value; }
        public string[] Filmes { get => filmes; set => filmes = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public int Id { get => id; set => id = value; }
    }
}
