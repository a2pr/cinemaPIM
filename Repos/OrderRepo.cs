using CinemaPIM.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaPIM.Repos
{
    class OrderRepo: Database
    {
        public OrderRepo()
        {

        }

        public void newOrder(order newOrder)
        {

            int id = newOrder.getId();
            int idPagamento = newOrder.IdPagamento ;
            int idCliente = newOrder.IdCliente ;

            string query = "INSERT INTO `order`(`id`, `id_pagamento_id`, `id_cliente_id`)"+
                "VALUES (" + id +","+ idPagamento + "," + idCliente + ")";
            Insert(query);
        }

        public List<string>[] getOrders()
        {
            string query = "SELECT o.id, o.id_cliente_id as idCliente,  c.nome as Cinema, f.titulo as Filme, p.valor, " +
                "p.use_card as useCard, p.use_pimcoin as usePIMCoin  FROM `order` o inner Join  pagamento p on " +
                "o.id_pagamento_id = p.id inner join ingressos i ON i.id_order_id = o.id inner join cinemas c ON " +
                "i.cinema_id = c.id INNER join filme f ON f.id = i.filme_id";

            List<string> columnas = new List<string>();

            columnas.Add("id");
            columnas.Add("idCliente");
            columnas.Add("Cinema");
            columnas.Add("Filme");
            columnas.Add("valor");
            columnas.Add("useCard");
            columnas.Add("usePIMCoin");
            List<string>[] data = Select(query, 7, columnas);

            return data;
        }

        public int lastOrder()
        {
            int id;
            string query = "SELECT CASE WHEN COUNT(`id`) <  1 THEN 0 ELSE  MAX(`id`) END AS `id`  FROM `order`";

            id = Count(query);

            if (id == 0)
            {
                return 1;
            }

            return id;
        }
    }
}
