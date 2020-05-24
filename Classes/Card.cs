using CinemaPIM.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaPIM.Classes
{

    class Card
    {
        private int id;
        private int cliente;
        private string nomeCliente;
        private string card_number;
        private string token;

        public Card(
            int id, 
            int cliente, 
            string nomeCliente,
            string card_number,
            string token)
        {
            this.id = id;
            this.cliente = cliente;
            this.nomeCliente = nomeCliente;
            this.card_number = card_number;
            this.token = token;
        }
        
        public Card(
            int cliente, 
            string nomeCliente,
            string card_number,
            string token)
        {
            this.id = id;
            this.cliente = cliente;
            this.nomeCliente = nomeCliente;
            this.card_number = card_number;
            this.token = token;
        }

        public int Id { get => id; set => id = value; }
        public int Cliente { get => cliente; set => cliente = value; }
        public string NomeCliente { get => nomeCliente; set => nomeCliente = value; }
        public string Card_number { get => card_number; set => card_number = value; }
        public string Token { get => token; set => token = value; }
    }
}
