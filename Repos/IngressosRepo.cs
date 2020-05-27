using CinemaPIM.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaPIM.Repos
{
    class IngressosRepo: Database
    {
        public IngressosRepo()
        {

        }


        public void newIngresso(Ingressos ingresso, order newOrder, string horario )
        {
            FilmesRepo filmesDb = new FilmesRepo();
            CinemasRepo cinemaDb = new CinemasRepo();
            int id = ingresso.Id;
            int filmeId = filmesDb.getFilmeIdByTituloAndCinema(ingresso.Filme, ingresso.Cinema );
            int cinemaId = cinemaDb.getCinemaIdByName(ingresso.Cinema);
            int cadeiraId = ingresso.getCadeira().Id;
            int orderId = newOrder.getId();



            string query = "INSERT INTO `ingressos`(`id`, `cinema_id`, `id_cadeira_id`, `id_order_id`, `horario`, `valor`) " +
                "VALUES ("+id+","+cinemaId+","+ cadeiraId + ","+ orderId + ",'"+ horario + "',"+ingresso.Valor+")";
            string query2 = "INSERT INTO `ingressos_filme`(`ingressos_id`, `filme_id`) VALUES (" + id + ","+filmeId+")";
            Insert(query);
            Insert(query2);
        }
    }
}
