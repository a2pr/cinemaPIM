using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaPIM.Classes
{
    class Clientes: Usuarios
    {
        private bool useCard;
        private bool usePIMCoin;
        public Clientes(string email, string senha )
        {
            SetEmail(email);
            SetSenha(senha);
        }

        public bool UseCard { get => useCard; set => useCard = value; }
        public bool UsePIMCoin { get => usePIMCoin; set => usePIMCoin = value; }
    }
}
