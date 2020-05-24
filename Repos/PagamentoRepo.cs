﻿using CinemaPIM.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaPIM.Repos
{
    class PagamentoRepo :Database
    {
        public PagamentoRepo()
        {

        }

        public void newPagamentoUsePIM(Pagamentos newPagamento)
        {
            int idCliente = newPagamento.getCliente().IdUsuario;
            float valor = newPagamento.Valor;
            Random rnd = new Random();
            int id = rnd.Next(8000, 9000);
            string query = "INSERT INTO `pagamento`(`id`, `id_cliente_id`, `use_pimcoin`, `valor`) VALUES ("+ id + "," + idCliente + ", 1 ," + valor + ")";
            Insert(query);
        } 
        public void newPagamentoUseCard(Pagamentos newPagamento)
        {
            int idCliente = newPagamento.getCliente().IdUsuario;
            float valor = newPagamento.Valor;
            int id = newPagamento.getId();
            string query = "INSERT INTO `pagamento`(`id`,`id_cliente_id`, `use_card`, `valor`) VALUES (" + id + "," + idCliente + ", 1 ,"+ valor + ");";
            Insert(query);
        }
    }
}