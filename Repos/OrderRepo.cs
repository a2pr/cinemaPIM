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
    }
}
