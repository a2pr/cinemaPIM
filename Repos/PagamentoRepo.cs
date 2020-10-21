using CinemaPIM.Classes;
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
            int id = newPagamento.getId();
            int pimCoinTransId = (int)newPagamento.PimCoinTrans;

            string query = "INSERT INTO `pagamento`(`id`, `id_cliente_id`, `use_pimcoin`, `valor`, `id_pim_coin_trans_id`) VALUES (" + id + "," + idCliente + ", 1 ," + valor +","+ pimCoinTransId+ ")";
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

        public int lastPagamento()
        {
            int id;
            string query = "SELECT MAX(id) FROM `pagamento`";

            id = Count(query);

            if (id == 0)
            {
                return 1;
            }

            return id;
        }
    }
}
