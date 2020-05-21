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
        Enderecos endereco = new Enderecos();
        private int telefone;
        private string CPF;


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

        public void SetTelefone(int telefone)
        {
            this.telefone = telefone;

        }


        /*public void SetEndereco(string endereco)
        {
            this.endereco = endereco;

        }*/

        public void SetCPF(string CPF)
        {
            this.CPF = CPF;

        }

        public string GetNome()
        {
            return this.nome;
        }

        public int GetId()
        {
            return this.id;
        }

        public string GetEmail()
        {
            return this.email;
        }

        public int GetTelefone()
        {
            return this.telefone;
        }

        //public string GetEndereco()
        //{
        //    return this.endereco;
        //}

        public string GetCpf()
        {
            return this.CPF;
        }
    }
}
