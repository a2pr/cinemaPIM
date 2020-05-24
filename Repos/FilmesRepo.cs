using CinemaPIM.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaPIM.Repos
{
    
    class FilmesRepo :Database
    {
        public const int COLFILMS = 3;

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

            List<string>[] data = Select(query, 3, columnas);

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

            List<string>[] data = Select(query, 3, columnas);

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


        public int getFilmeIdByTituloAndCinema(string titulo, string cinema)
        {
            string query = "SELECT f.id FROM `filme`f Inner join `cinemas` c ON f.cinemas_id = c.id WHERE f.titulo=" + 
                "'" + titulo + "'" + " and c.nome=" + "'"+ cinema + "'"+";";

            List<string> columnas = new List<string>();
            columnas.Add("id");

            List<string>[] data = Select(query,1,columnas);

            return Convert.ToInt32( data[0][0]);
        }
    }
}
