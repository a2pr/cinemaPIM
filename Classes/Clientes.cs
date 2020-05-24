using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaPIM.Classes
{
    class Clientes: Usuarios
    {
        private int id;
        private int endereco_id;
        private bool useCard;
        private bool usePIMCoin;
        private string CPF;
        private int idUsuario;
        public Clientes(int id, int endereco_id, bool useCard, bool usePIMCoin, string CPF, int idUsuario)
        {
            this.endereco_id = endereco_id;
            this.id = id;
            this.useCard = useCard;
            this.usePIMCoin = usePIMCoin;
            this.CPF = CPF;
            this.idUsuario = idUsuario;
        }
        public Clientes(string email, string senha )
        {
            SetEmail(email);
            SetSenha(senha);

        }

        public bool UseCard { get => useCard; set => useCard = value; }
        public bool UsePIMCoin { get => usePIMCoin; set => usePIMCoin = value; }
        public int IdUsuario { get => id; set => id = value; }
    }
}
