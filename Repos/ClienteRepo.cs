using CinemaPIM.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaPIM.Repos
{
    class ClienteRepo:Database
    {

        public void updateUseCard(int id)
        {
            string query = "UPDATE `clientes` SET `use_card`= 1 WHERE `id`="+id;
            Update(query);
        }
        public void updateUsePIMCoin(int id)
        {
            string query = "UPDATE `clientes` SET `use_pimcoin`= 1 WHERE id=" + id;
            Update(query);
        }

        public void newCliente(Clientes newCliente)
        {
            string query = "INSERT INTO `clientes`( `endereco_id`, `cpf`, `telefone`, `id_usuario_id`) " +
                "VALUES ("+newCliente.Endereco_id+",'"+newCliente.CPF1+"','"+newCliente.Telefone+"',"+newCliente.getUsuarioId() + ")";

            Insert(query);
        }

        public int lastCliente()
        {
            int id;
            string query = "SELECT MAX(id) FROM `clientes`";

            id = Count(query);
            return id;
        }

    }
}
