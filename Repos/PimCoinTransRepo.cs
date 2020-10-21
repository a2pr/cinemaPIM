using CinemaPIM.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaPIM.Repos
{
    class PimCoinTransRepo :Database
    {
        public PimCoinTransRepo()
        {

        }

        public void newTrans(PimCoinTrans newTrans)
        {
            int id = newTrans.Id;
            string previous = newTrans.KeyPrevious;
            string current = newTrans.KeyCurrent;
            string dtc = newTrans.DTC.ToString("yyyy-MM-dd HH:mm:ss"); ;
            int blockPim = newTrans.IdBlock;

            string query = "INSERT INTO `pim_coin_trans` (`id`, `hash_key_current`, `hash_key_previous`, `dtc`, `pim_coin_id`) VALUES (" + id + ",'" + current + "','" + previous + "','" + dtc + "'," + blockPim + ")";
            Insert(query);
        }

        public int lastTransId()
        {
            int id;
            string query = "SELECT CASE WHEN id IS NULL THEN 0 ELSE MAX(id) END AS id FROM `pim_coin_trans`;";

            id = Count(query);

            if (id == 0)
            {
                return 1;
            }

            return id;
        }

        public string lastHashByUser(int blockPimId)
        {
            string query = "SELECT CASE WHEN COUNT(`hash_key_current`) <1 THEN 'empty' ELSE  MAX(`hash_key_current`) END AS `hash_key_current`  FROM `pim_coin_trans` WHERE `pim_coin_id` =" + "'" + blockPimId + "'" + ";";
            List<string> columnas = new List<string>();
            columnas.Add("hash_key_current");

            List<string>[] data = Select(query, 1, columnas);

            return data[0][0];
        }
    }
}
