using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaPIM.Classes
{
    class order
    {
        private int id;
        private int idPagamento;
        private int idCliente;
        
        public order( int id, int idPagamento, int idCliente)
        {
            this.id = id;
            this.idPagamento = idPagamento;
            this.idCliente = idCliente;
        }
        public order( int idPagamento, int idCliente)
        {
            Random rnd = new Random();
            this.id = rnd.Next(11000, 12000);
            this.idPagamento = idPagamento;
            this.idCliente = idCliente;
        }

        public int getId()
        {
            return id;
        }
        public int IdPagamento { get => idPagamento; set => idPagamento = value; }
        public int IdCliente { get => idCliente; set => idCliente = value; }
    }
}
