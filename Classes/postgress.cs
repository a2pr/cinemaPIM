
using System.Windows.Forms;
using Npgsql;

namespace CinemaPIM.Classes
{
    class postgress
    {

        private string conConfig = "Host=127.0.0.1;Port=50237;Database=test-PIM;Username=postgres;Password=123456";
        private NpgsqlConnection conection = new NpgsqlConnection();
        public postgress()
        {

        }

        public void connectToDB()
        {

            this.conection.ConnectionString = this.conConfig;
            conection.Open();

            if (conection.State == System.Data.ConnectionState.Open)
            {
                MessageBox.Show("Connected");
            }
            conection.Close();
        }
        public NpgsqlDataReader querystm(string query)
        {
            try
            {
                this.conection.ConnectionString = this.conConfig;
                conection.Open();
            }
            catch
            {
                conection.Close();
            }
            NpgsqlCommand command = new NpgsqlCommand(query, this.conection);
            NpgsqlDataReader reader = command.ExecuteReader();
            conection.Close();
            return reader;
        }
    }
}
