using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BLL
{
    public class BLLCompra
    {
        private DALConexao conexao;

        public BLLCompra(DALConexao cx)
        {
            this.conexao = cx;
        }

       
        public DataTable PesquisarFornecedorComChavenaCompra( string chave)
        {
            DALLCompra dall = new DALLCompra(conexao);
            return  dall.PesquisarFornecedorComChavenaCompra(chave);
        }

        public void updateProdutoCompra(List<ModeloCompra> listaDeDados)
        {
            try
            {
                if (listaDeDados.Count > 0)
                {
                    DALLCompra DALLCompra = new DALLCompra(conexao);
                    ModeloCompra modeloCompra = new ModeloCompra();
                    DALLCompra.IncluirCompraItem(listaDeDados);
                }
                else
                {
                    throw new Exception("Adicione produtos ao carrinho antes de confirmar a compra.!!!");
                }
            }
            catch (Exception erro)
            {

                throw new Exception("Erro ao atualizar os produtos no banco de dados. Detalhes: " + erro.Message);
            }

        }
        public void CadastrarProduto(ModeloCompra listaDeDados)
        {
            try
            {
                
                    DALLCompra DALLCompra = new DALLCompra(conexao);
                    DALLCompra.CadastrarProduto (listaDeDados);                
            }
            catch (Exception erro)
            {

                throw new Exception("Erro ao incluir os dados:" + erro.Message);
            }

        }
        public DataTable PesquisarProdutoComChave( string chave)
        {
            DALLCompra dall = new DALLCompra(conexao);
            return dall.PesquisarProdutoComChave(chave);

        }
        //public void incluirCompra(List<ModeloCompra> listaDeDados)
        //{
        //    try
        //    {
        //        if (listaDeDados.Count > 0)
        //        {
        //            DALLCompra DALLCompra = new DALLCompra(conexao);
        //            DALLCompra.IncluirCompra(listaDeDados);
        //        }
        //        else
        //        {
        //            throw new Exception("Adicione produtos ao carrinho antes de confirmar a compra.!!!");
        //        }

        //    }
        //    catch (Exception erro)
        //    {

        //        throw new Exception("Erro ao incluir:" + erro.Message);
        //    }

        //}
    }
}
