﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using enfunip.modelo.validacoes;
using enfunip.dao;
using System.Data;


namespace enfunip.modelo.controle
{
    public class controleEstoque
    {
        public String mensagem;
        public void CadastrarItem(List<String> dadosItem)
        {
            this.mensagem = "";
            validarEstoque validarestoque = new validarEstoque();
            validarestoque.ValidarDados(dadosItem);
            if (validarestoque.mensagem.Equals(""))
            {
                Estoque estoque = new Estoque();

                estoque.produto = dadosItem[2];
                estoque.dataentrada = Convert.ToDateTime(dadosItem[1]);
                estoque.quantidade = (Convert.ToInt32(dadosItem[3]));
                estoque.descricao = dadosItem[4];

                Estoquedao estoqueDAO = new Estoquedao();
                estoqueDAO.CadastrarItem(estoque);
                this.mensagem = estoqueDAO.mensagem;
            }
            else
            {
                this.mensagem = validarestoque.mensagem;
            }
        }

        public Estoque PesquisarItemPorID(List<String> dadosEstoque)
        {
            this.mensagem = "";
            Estoque estoque = new Estoque();
            validarEstoque validarestoque = new validarEstoque();
            validarestoque.ValidarDados(dadosEstoque);
            if (validarestoque.mensagem.Equals(""))
            {
                estoque.id = validarestoque.id;
                Estoquedao estoqueDAO = new Estoquedao();
                estoque = estoqueDAO.PesquisarItemPorID(estoque);
                this.mensagem = estoqueDAO.mensagem;
            }
            else
            {
                this.mensagem = validarestoque.mensagem;
            }
            return estoque;
        }

        public void EditarItem(List<String> dadosEstoque)
        {
            this.mensagem = "";
            Estoque estoque = new Estoque();
            validarEstoque validarestoque = new validarEstoque();
            if (validarestoque.mensagem.Equals(""))
            {
                Estoque estoque1 = new Estoque();
                estoque1.produto = dadosEstoque[1];
                estoque1.dataentrada = Convert.ToDateTime(dadosEstoque[2]);
                estoque1.quantidade = Convert.ToInt32(dadosEstoque[3]);
                estoque1.descricao = dadosEstoque[4];
                Estoquedao estoqueDAO = new Estoquedao();
                estoqueDAO.EditarItem(estoque1);
                this.mensagem = estoqueDAO.mensagem;
            }
            else
            {
                this.mensagem = validarestoque.mensagem;
            }
        }


        public void ExcluirItem(String Id_Excluir)
        {
            this.mensagem = "";
            validarEstoque validarEstoque = new validarEstoque();

            validarEstoque.ValidarId(Id_Excluir);
            if (validarEstoque.mensagem.Equals(""))
            {
                Estoque estoque = new Estoque();
                estoque.id = validarEstoque.id;
                Estoquedao estoqueDAO = new Estoquedao();
                if (estoqueDAO.ListarItemPorNome() != null)
                {
                    estoqueDAO.ExcluirItem(estoque);
                    this.mensagem = estoqueDAO.mensagem;
                }
                else
                {
                    this.mensagem = "Não existe este ID";
                }
            }
        }

        public DataTable ListarPorNome()
        {
            try
         {
                Estoquedao estoquedao = new Estoquedao();
                DataTable dt = new DataTable();

                dt = estoquedao.ListarItemPorNome();

                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public DataTable PesquisarPorNome(Estoque estoque)
        {
            try
            {
                Estoquedao estoquedao = new Estoquedao();
                DataTable dt = new DataTable();

                dt = estoquedao.PesquisarProduto(estoque);

                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
