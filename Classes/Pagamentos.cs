using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaPIM.Classes
{
    class Pagamentos
    {
        private int id;
        private Clientes cliente;
        private float valor;


        public Pagamentos( Clientes cliente, float valor)
        {
            this.cliente = cliente;
            this.valor = valor;
        }


        public int Id { get => id; set => id = value; }
        public float Valor { get => valor; set => valor = value; }

        public Clientes getCliente()
        {
            return cliente;
        }

        public int getId()
        {
            return id;
        }
    }
}
