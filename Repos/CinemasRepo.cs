using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaPIM.Classes;

namespace CinemaPIM.Repos
{
    class CinemasRepo :Database
    {
        public const int COLFILMS = 3;


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

            List<string>[] data = Select(query, 2, columnas);

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

        public int getCinemaIdByName(string cinema)
        {
            string query = "SELECT id FROM `cinemas` WHERE `nome` =" + "'" + cinema + "'" + ";";
            
            List<string> columnas = new List<string>();
            columnas.Add("id");

            List<string>[] data = Select(query, 1, columnas);

            return Convert.ToInt32( data[0][0]);
        }
    }
}
