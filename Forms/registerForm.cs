using CinemaPIM.Classes;
using CinemaPIM.Repos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace CinemaPIM.Forms
{
    public partial class registerForm : Form
    {
        private EnderecoRepo enderecoDB;
        private UsuariosRepo usuarioDB;
        private ClienteRepo clientesDB;
        public registerForm()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void registerForm_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string msg = "Segundo a Lei geral Proteção de Dados nosso applicativo faz tratamento de seus dados inseridos a continuacao," +
                       " por sua seguranca mas se voce desejase retirar pode contatar conosco. Clickando aceito, voce aceita o uso de dados" +
                       " pessoais em nosso aplicativo.";

            
            if (checkInputs())
            {
                DialogResult dialogResult = MessageBox.Show(msg, "message", MessageBoxButtons.OKCancel);
                if (dialogResult == DialogResult.Cancel)
                {
                    this.Hide();
                    Home home = new Home();
                    home.Show();

                }
                Enderecos newEndereco = new Enderecos(
                        textBox2.Text,
                        textBox3.Text,
                        textBox4.Text,
                        textBox5.Text
                    );
                enderecoDB = new EnderecoRepo();
                enderecoDB.newEndereco(newEndereco);
                newEndereco.Id = enderecoDB.getLastId();


                Usuarios newUser= new Usuarios();
                newUser.SetEmail(email.Text) ;
                newUser.SetNome(textBox1.Text);
                MD5 md5Hash = MD5.Create();
                newUser.SetSenha(MD5Hash.GetMd5Hash(md5Hash, pass.Text));

                usuarioDB = new UsuariosRepo();
                usuarioDB.newUsuario(newUser);
                newUser.SetId(usuarioDB.lastUsuario());

                clientesDB = new ClienteRepo();
                Clientes newCliente = new Clientes(
                    newEndereco.Id,
                    false,
                    false,
                    textBox6.Text,
                    newUser.GetId()
                    );
                newCliente.Telefone = textBox7.Text;
                clientesDB.newCliente(newCliente);
                newCliente.IdUsuario= clientesDB.lastCliente();

                Session.setCliente(newCliente);
                this.Hide();
                Home homeW = new Home();
                homeW.Show();
            }
            else
            {
                MessageBox.Show("Campos faltantes");
            }
            

        }

        private bool checkInputs()
        {
            if (
                !string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text)
                && !string.IsNullOrEmpty(textBox3.Text) && !string.IsNullOrEmpty(textBox4.Text)
                && !string.IsNullOrEmpty(textBox5.Text) && !string.IsNullOrEmpty(textBox6.Text)
                && !string.IsNullOrEmpty(textBox5.Text) && !string.IsNullOrEmpty(textBox6.Text)
                && !string.IsNullOrEmpty(textBox7.Text) && !string.IsNullOrEmpty(email.Text)
                && !string.IsNullOrEmpty(pass.Text) 
                )
            {
                return true;
            }
            return false;
        }

        
    }
}
