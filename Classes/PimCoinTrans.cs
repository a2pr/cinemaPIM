using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CinemaPIM.Classes
{
    class PimCoinTrans
    {
        private int id;
        private string hashKeyCurrent;
        private string hashKeyPrevious;
        private DateTime dtc;
        private int idBlockPIM;

        public PimCoinTrans( string KeyPrevious, int BlockPIM)
        {
            hashKeyPrevious = KeyPrevious;
            dtc = DateTime.Now;
            idBlockPIM = BlockPIM;

        }

        public int Id { get => id; set => id = value; }
        public int IdBlock { get => idBlockPIM; set => idBlockPIM = value; }

        public void setNewkeyCurrent( int idClient)
        {
            string i = KeyPrevious + idClient + DTC.ToString();
            MD5 md5Hash = MD5.Create();
            KeyCurrent = MD5Hash.GetMd5Hash(md5Hash, i);
        }
        public string KeyCurrent { get => hashKeyCurrent; set => hashKeyCurrent = value; }
        public string KeyPrevious { get => hashKeyPrevious; set => hashKeyPrevious = value; }
        public DateTime DTC { get => dtc; set => dtc = value; }

    }
}
