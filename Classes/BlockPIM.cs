using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaPIM.Classes
{
   
    class BlockPIM
    {
        private int id;
        private int idCliente;
        private string key;

        public int IdCliente { get => idCliente; set => idCliente = value; }
        public string Key { get => key; set => key = value; }

        public BlockPIM(int id, int idCliente, string key)
        {
            this.id = id;
            this.idCliente = idCliente;
            this.key = key;
        }

        public BlockPIM(int idCliente, string key)
        {
            this.idCliente = idCliente;
            this.key = key;
        }
    }
}
