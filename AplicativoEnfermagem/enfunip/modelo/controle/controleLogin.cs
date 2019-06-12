
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using enfunip.modelo;

namespace enfunip.modelo
{
    public class ControleLogin
    {
        private String usuario;
        private String senha;
        private String mensagem;
        

        public ControleLogin(string usuario, string senha)
        {
            
            this.usuario = usuario;
            this.senha = senha;
            Executar();
        }

        public string Mensagem { get => mensagem; }

        private void Executar()
        {
            this.mensagem = "Usuário e/ou senha inválidos";

            Login login = new Login();

            login.usuario = this.usuario;
            login.senha = this.senha;

            dao.Logindao logindao = new dao.Logindao();

            logindao.ValidarLogin(login);

            if (logindao.mensagem .Equals(""))
            {
                this.mensagem = "";
            }
            else
            {
                this.mensagem = logindao.mensagem;
            }
        }
    }
}