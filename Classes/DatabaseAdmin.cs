using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace CinemaPIM.Classes
{
    class DatabaseAdmin : Database
    {

        public DatabaseAdmin()
        {
            base.Initialize();
        }
        //Backup


        public DataTable table()
        {
            base.OpenConnection();
            string query = "SELECT o.id, o.id_cliente_id as idCliente,  c.nome as Cinema, f.titulo as Filme, p.valor, " +
               "p.use_card as useCard, p.use_pimcoin as usePIMCoin  FROM `order` o inner Join  pagamento p on o.id_pagamento_id = p.id " +
               "inner join ingressos i ON i.id_order_id = o.id inner join cinemas c ON i.cinema_id = c.id inner join ingressos_filme ingf ON " +
               "ingf.ingressos_id - i.id INNER join filme f ON f.id = ingf.filme_id";

            MySqlDataAdapter sql = new MySqlDataAdapter(query, base.connection);

            DataTable dtbl = new DataTable();
            sql.Fill(dtbl);
            base.CloseConnection();
            return dtbl;

        }

        public List<string>[] getAllPDf()
        {
            string query = "SELECT o.id, o.id_cliente_id as idCliente,  c.nome as Cinema, f.titulo as Filme, p.valor, " +
               "p.use_card as useCard, p.use_pimcoin as usePIMCoin  FROM `order` o inner Join  pagamento p on o.id_pagamento_id = p.id " +
               "inner join ingressos i ON i.id_order_id = o.id inner join cinemas c ON i.cinema_id = c.id inner join ingressos_filme ingf ON " +
               "ingf.ingressos_id - i.id INNER join filme f ON f.id = ingf.filme_id";


            List<string> columnas = new List<string>();

            columnas.Add("id");
            columnas.Add("idCLiente");
            columnas.Add("Cinema");
            columnas.Add("Filme");
            columnas.Add("valor");
            columnas.Add("useCard");
            columnas.Add("usePIMCoin");
            List<string>[] data = Select(query, 7, columnas);

            return data;
        }

        public DataTable getCinemas()
        {
            base.OpenConnection();
            string query = "SELECT  c.nome as Cinemas, sum(i.valor) as totalVendas  FROM `order` o inner join pagamento p " +
                "ON o.id_pagamento_id = p.id inner join ingressos i ON i.id_order_id = o.id inner join cinemas c " +
                "ON i.cinema_id = c.id group by c.nome";


            MySqlDataAdapter sql = new MySqlDataAdapter(query, base.connection);

            DataTable dtbl = new DataTable();
            sql.Fill(dtbl);
            base.CloseConnection();
            return dtbl;
        }

        public DataTable getFilmes()
        {
            base.OpenConnection();
            string query = "SELECT  f.titulo as Filme, sum(i.valor) as total  FROM `order` o " +
                "inner join pagamento p ON o.id_pagamento_id = p.id inner join ingressos i ON" +
                " i.id_order_id = o.id inner join ingressos_filme inf on i.id = inf.ingressos_id " +
                "inner join filme f ON inf.filme_id = f.id group by f.titulo";


            MySqlDataAdapter sql = new MySqlDataAdapter(query, base.connection);

            DataTable dtbl = new DataTable();
            sql.Fill(dtbl);
            base.CloseConnection();
            return dtbl;

        }

        public List<string>[] getFilmesPDf()
        {
            string query = "SELECT  f.titulo as Filme, sum(i.valor) as total  FROM `order` o " +
                "inner join pagamento p ON o.id_pagamento_id = p.id inner join ingressos i ON" +
                " i.id_order_id = o.id inner join ingressos_filme inf on i.id = inf.ingressos_id " +
                "inner join filme f ON inf.filme_id = f.id group by f.titulo";

            List<string> columnas = new List<string>();

            columnas.Add("Filme");
            columnas.Add("total");
            List<string>[] data =Select(query, 2, columnas);

            return data;
        }
        public List<string>[] getCinemasPDf()
        {
            string query = "SELECT  c.nome as Cinemas, sum(i.valor) as totalVendas  FROM `order` o inner join pagamento p " +
                 "ON o.id_pagamento_id = p.id inner join ingressos i ON i.id_order_id = o.id inner join cinemas c " +
                 "ON i.cinema_id = c.id group by c.nome";

            List<string> columnas = new List<string>();

            columnas.Add("Cinemas");
            columnas.Add("totalVendas");
            List<string>[] data =Select(query, 2, columnas);

            return data;
        }

        public DataTable getCard()
        {
            base.OpenConnection();
            string query = "SELECT  sum(i.valor) as total  FROM `order` o " +
                " inner join pagamento p ON o.id_pagamento_id = p.id inner join ingressos i" +
                " ON i.id_order_id = o.id where p.use_card = 1";


            MySqlDataAdapter sql = new MySqlDataAdapter(query, base.connection);

            DataTable dtbl = new DataTable();
            sql.Fill(dtbl);
            base.CloseConnection();
            return dtbl;

        }

        public List<string>[] getCardsPDf()
        {
            string query = "SELECT  sum(i.valor) as total  FROM `order` o " +
                " inner join pagamento p ON o.id_pagamento_id = p.id inner join ingressos i" +
                " ON i.id_order_id = o.id where p.use_card = 1";

            List<string> columnas = new List<string>();

            columnas.Add("total");
            List<string>[] data = Select(query, 1, columnas);

            return data;
        }
        public DataTable getPIMCoin()
        {
            base.OpenConnection();
            string query = "SELECT  sum(i.valor) as total  FROM `order` o " +
                " inner join pagamento p ON o.id_pagamento_id = p.id inner join ingressos i" +
                " ON i.id_order_id = o.id where p.use_pimcoin =1";


            MySqlDataAdapter sql = new MySqlDataAdapter(query, base.connection);

            DataTable dtbl = new DataTable();
            sql.Fill(dtbl);
            base.CloseConnection();
            return dtbl;

        }

        public List<string>[] getPIMCoinPDf()
        {
            string query = "SELECT  sum(i.valor) as total  FROM `order` o " +
               " inner join pagamento p ON o.id_pagamento_id = p.id inner join ingressos i" +
               " ON i.id_order_id = o.id where p.use_pimcoin =1";

            List<string> columnas = new List<string>();

            columnas.Add("total");
            List<string>[] data = Select(query, 1, columnas);

            return data;
        }


        public void Backup()
        {
            string file = "D:\\Documents\\Projects\\CinemaPIM\\backup.sql";
            using (MySqlConnection conn = base.connection)
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlBackup mb = new MySqlBackup(cmd))
                    {
                        cmd.Connection = conn;
                        mb.ExportToFile(file);
                        conn.Close();
                    }
                }
            }
        }

        //Restore
        public void Restore()
        {
            /*will be use in testing*/
            string file = "D:\\Documents\\Projects\\CinemaPIM\\backup.sql";
            using (MySqlConnection conn = base.connection)
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlBackup mb = new MySqlBackup(cmd))
                    {
                        cmd.Connection = conn;
                        conn.Open();
                        mb.ImportFromFile(file);
                        conn.Close();
                    }
                }
            }
        }

    }
}
