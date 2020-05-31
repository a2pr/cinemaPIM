using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaPIM.Classes
{
    class Usuarios
    {
        private int id;
        private string nome;
        private string senha;
        private string email;
        
        public void SetId(int id)
        {
            this.id = id;

        }

        public void SetNome(string nome)
        {
            this.nome = nome;

        }

        public void SetSenha(string senha)
        {
            this.senha = senha;

        }
        public void SetEmail(string email)
        {
            this.email = email;

        }

        public string getSenha()
        {
            return senha;
        }
        public string getEmail()
        {
            return email;
        }

        public string GetNome()
        {
            return this.nome;
        }

        public int GetId()
        {
            return this.id;
        }


    }
}
