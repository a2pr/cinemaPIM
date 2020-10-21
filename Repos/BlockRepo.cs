using CinemaPIM.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaPIM.Repos
{
    class BlockRepo : Database
    {
        public void newKey(int idCliente, string key)
        {
            string query = "INSERT INTO `pim_coin`(`id_cliente_id`, `private_key_user`) VALUES ("+ idCliente+","+ "'" + key +"'" +")";
            Update(query);
        }

        public int getId(int idCliente)
        {
            string query = "SELECT `id`  FROM `pim_coin` WHERE `id_cliente_id` ="+ "'" + idCliente + "'" + ";";

            List<string> columnas = new List<string>();
            columnas.Add("id");

            List<string>[] data = Select(query, 1, columnas);

            return Convert.ToInt32(data[0][0]);
        }
    }
}
