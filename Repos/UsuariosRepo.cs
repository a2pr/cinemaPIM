using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaPIM.Classes;

namespace CinemaPIM.Repos
{
    class UsuariosRepo: Database
    {
        public string getUserName(int idUsuario)
        {
            string query = "SELECT nome FROM `usuarios` where id =" + idUsuario;
            List<string> columnas = new List<string>();

            columnas.Add("nome");
            List<string>[] cliente = Select(query, 1, columnas);
            return cliente[0][0];
        }

        public void newUsuario(Usuarios newUser)
        {
            string query = "INSERT INTO `usuarios`(`nome`, `email`, `password`, `admin`) " +
                "VALUES ('"+newUser.GetNome()+"','"+newUser.getEmail()+"','"+newUser.getSenha()+"',0)";
            Insert(query);
        }

        public int lastUsuario()
        {
            int id;
            string query = "SELECT MAX(id) FROM `usuarios`";

            id = Count(query);
            return id;
        }
    }
}
