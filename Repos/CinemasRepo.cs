using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaPIM.Classes;

namespace CinemaPIM.Repos
{
    class CinemasRepo
    {
        public const int COLFILMS = 3;

        private Database db = new Database();

        public void connectDb()
        {

        }

        public List<Cinemas> getCinemas()
        {
            int id;
            string nome;
            string query = "SELECT id,nome from cinemas";

            List<string> columnas = new List<string>();

            columnas.Add("id");
            columnas.Add("nome");

            List<string>[] data = db.Select(query, 2, columnas);

            List<Cinemas> cinemas= new List<Cinemas>();


            for (int i=0; i< data[0].Count(); i++)
            {
                id = Convert.ToInt32(data[0][i]);
                nome = data[1][i];
                Cinemas newCinema = new Cinemas(id, nome);
                cinemas.Add(newCinema);
            }
            return cinemas;
        }
    }
}
