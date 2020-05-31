using CinemaPIM.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaPIM.Repos
{
    class EnderecoRepo:Database
    {

        public void newEndereco(Enderecos newEndereco)
        {
            string query = "INSERT INTO `endereco`( `rua`, `cidade`, `estado`, `cpe`)" +
                " VALUES ('"+newEndereco.Rua+"','"+ newEndereco.Cidade+"','"+newEndereco.Estado+"','"+newEndereco.CPE1 +"')";

            Insert(query);
        }

        public int getLastId()
        {
            int id;
            string query = "SELECT MAX(id) FROM `endereco`";

            id = Count(query);
            return id;
        }
    }
}
