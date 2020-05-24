using CinemaPIM.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaPIM.Repos
{
    class CardRepo:Database
    {
        public CardRepo()
        {

        }

        public Card getCardByClienteId(int id)
        {
            string query = "SELECT * FROM Cards WHERE id_cliente_id=" + id;

            List<string> columns = new List<string>();
            columns.Add("id");
            columns.Add("id_cliente_id");
            columns.Add("nome");
            columns.Add("card_number");
            columns.Add("secure_number");

            List<string>[] data = Select(query, 5, columns);

            Card cardSelec = new Card(Convert.ToInt32(data[0][0]), Convert.ToInt32(data[1][0]), data[2][0], data[3][0], data[4][0]);

            return cardSelec;
        }

        public bool ClientHasCard(int id)
        {
            string query= "SELECT Count(*) FROM Cards WHERE id_cliente_id=" + id;

            if (Count(query) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void newCard( Card newCard)
        {
            string query = "INSERT INTO `cards`( `id_cliente_id`, `nome`, `card_number`, `secure_number`) VALUES ("+
                + newCard.Cliente+"," +"'"+ newCard.NomeCliente+ "'" +  ","+ "'"  +newCard.Card_number+ "'"+ ","+ "'" + newCard.Token+ "'" + ");";

            Update(query);
        }
    }
}
