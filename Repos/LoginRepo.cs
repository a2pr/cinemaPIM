using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaPIM.Classes;

namespace CinemaPIM.Repos
{
    class LoginRepo 
    {
        private Database db = new Database();
        public void connectDb()
        {
        }

        public bool checkUser(string email, string pass)
        {
            string query = "SELECT email, password  FROM usuarios WHERE email="+ 
                "'"+ email+ "'"+ "and password="+ "'" + pass + "'";
            List<string> columnas= new List<string>();

            columnas.Add("email");
            columnas.Add("password");
            List<string>[] cliente= db.Select(query,2,columnas);

            if (cliente[0].Contains(email))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public Clientes getCliente(string email)
        {
            string query = "SELECT c.id, c.endereco_id, c.cpf,c.use_card, c.use_pimcoin, c.id_usuario_id FROM clientes c " +
                "INNER JOIN usuarios u ON c.id_usuario_id = u.id WHERE u.email=" +"'"+ email+"';";

            List<string> columnas= new List<string>();

            columnas.Add("id");
            columnas.Add("endereco_id");
            columnas.Add("cpf");
            columnas.Add("use_card");
            columnas.Add("use_pimcoin");
            columnas.Add("id_usuario_id");
            List<string>[] cliente= db.Select(query,6,columnas);


            bool usePIM = String.IsNullOrEmpty(cliente[5].ToString());
            bool useCard = String.IsNullOrEmpty(cliente[4].ToString());
            string cpf = cliente[2][0];

            Clientes newCliente = new Clientes(
                Convert.ToInt32(cliente[0][0]), 
                Convert.ToInt32(cliente[1][0]),
                useCard,
                usePIM,
                cpf, 
                Convert.ToInt32(cliente[5][0])
                );
            
            return newCliente;

        }

    }
}
