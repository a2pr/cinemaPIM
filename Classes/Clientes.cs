using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaPIM.Classes
{
    class Clientes: Usuarios
    {
        public Clientes(string email, string senha )
        {
            SetEmail(email);
            SetSenha(senha);
        }
    }
}
