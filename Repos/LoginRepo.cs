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
    }
}
