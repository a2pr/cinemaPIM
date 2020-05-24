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
    }
}
