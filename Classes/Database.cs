using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaPIM.Classes
{
    class Database
    {
        private string connectionString = "Host= localhost;Database=aulBaseDeDados;username=a2pr;password=123456 ";

        public Database()
        {

        }

        public void setDB()
        {
            try {
                string mysql = "SELECT * from Departamento";
                MySqlConnection conn = new MySqlConnection(this.connectionString);
                MySqlCommand command = new MySqlCommand(mysql, conn);
                conn.Open();

                MySqlDataReader reader = command.ExecuteReader();
                //MessageBox.Show(conn.State.ToString());
                if (reader.HasRows)
                {
                    //MessageBox.Show("has rows");
                }

                

            } catch(Exception e){ }

        }

        public void getUsuarioTable()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(this.connectionString);
                conn.Open();
            }
            catch (Exception e)
            {

            }
            
        }
    }
}
    
