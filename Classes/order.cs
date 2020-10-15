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
        

        public order( int idPagamento, int idCliente)
        {
            this.idPagamento = idPagamento;
            this.idCliente = idCliente;
        }

        public int getId()
        {
            return id;
        }
        
        public void setId(int id)
        {
            this.id = id;
        }
        public int IdPagamento { get => idPagamento; set => idPagamento = value; }
        public int IdCliente { get => idCliente; set => idCliente = value; }
    }
}
