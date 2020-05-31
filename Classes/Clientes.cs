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
        private string telefone;

        public Clientes(int id, int endereco_id, bool useCard, bool usePIMCoin, string CPF, int idUsuario)
        {
            this.endereco_id = endereco_id;
            this.id = id;
            this.useCard = useCard;
            this.usePIMCoin = usePIMCoin;
            this.CPF1 = CPF;
            this.idUsuario = idUsuario;
        }

        public Clientes(int endereco_id, bool useCard, bool usePIMCoin, string CPF, int idUsuario)
        {
            this.endereco_id = endereco_id;
            this.useCard = useCard;
            this.usePIMCoin = usePIMCoin;
            this.CPF1 = CPF;
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
        public int Endereco_id { get => endereco_id; set => endereco_id = value; }
        public string CPF1 { get => CPF; set => CPF = value; }
        public string Telefone { get => telefone; set => telefone = value; }

        public int getUsuarioId()
        {
            return idUsuario;
        }
        public string getNome()
        {
            return base.GetNome();
        }
    }
}
