using CinemaPIM.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaPIM.Repos
{
    
    class FilmesRepo
    {
        public const int COLFILMS = 3;

        private Database db = new Database();

        public void connectDb()
        {

        }

        public List<Filmes> getFilmesByIdCinema(int idCinema)
        {
            int id;
            string titulo;
            int rating;
            string query = "SELECT id,titulo,rating FROM filme WHERE cinemas_id="+ idCinema.ToString();

            List<string> columnas = new List<string>();

            columnas.Add("id");
            columnas.Add("titulo");
            columnas.Add("rating");

            List<string>[] data = db.Select(query, 3, columnas);

            List<Filmes> filmes = new List<Filmes>();

            for (int i = 0; i < data[0].Count(); i++)
            {
                id = Convert.ToInt32(data[0][i]);
                titulo = data[1][i];
                rating = Convert.ToInt32(data[2][i]);
                Filmes newFilmes = new Filmes(id, titulo);
                newFilmes.Rating = rating;
                filmes.Add(newFilmes);
            }

            return filmes;
        }

        public List<Filmes> getFilmes()
        {
            int id;
            string titulo;
            int rating;
            string query = "SELECT id, titulo, rating FROM filme GROUP BY " +
                "titulo HAVING COUNT(*) > 1 ORDER by  id ASC";

            List<string> columnas = new List<string>();

            columnas.Add("id");
            columnas.Add("titulo");
            columnas.Add("rating");

            List<string>[] data = db.Select(query, 3, columnas);

            List<Filmes> filmes = new List<Filmes>();

            for (int i = 0; i < data[0].Count(); i++)
            {
                id = Convert.ToInt32(data[0][i]);
                titulo = data[1][i];
                rating = Convert.ToInt32(data[2][i]);
                Filmes newFilmes = new Filmes(id, titulo);
                newFilmes.Rating = rating;
                filmes.Add(newFilmes);
            }

            return filmes;
        }
    }
}
