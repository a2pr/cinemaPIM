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
            Random rnd = new Random();
            this.id = rnd.Next(10000, 11000);
            this.cliente = cliente;
            this.valor = valor;
        }



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
