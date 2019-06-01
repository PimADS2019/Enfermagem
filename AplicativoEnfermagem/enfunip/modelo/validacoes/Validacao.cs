using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using enfunip.modelo;

namespace enfunip.modelo
{
    public class Validacao
    {
        private String usuario;
        private String senha;
        private String mensagem;
        private int id;

        public string Mensagem { get => mensagem; }
        public int Id { get => id; set => id = value; }

        public Validacao(string usuario, string senha)
        {
            this.usuario = usuario;
            this.senha = senha;
            Validar();
        }

        public Validacao()
        {
        }

        private void Validar()
        {
            this.mensagem = "Usuário e/ou senha inválidos";
            Estaticos.logado = false;
            try
            {
                if (this.usuario == "admin" && this.senha == "admin" )
                {
                    this.mensagem = "";
                    Estaticos.logado = true;
                }
            }
            catch (Exception)
            {
                this.mensagem = "Usuário e/ou senha inválidos";

            }
        }
    }
}