using DAL;
using Modelo;
using System;
using System.Collections.Generic;
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
       
        public void incluirProdutoCompra(List<ModeloCompra> listaDeDados)
        {
            try
            {
                if (listaDeDados.Count > 0)
                {
                    DALLCompra DALLCompra = new DALLCompra(conexao);
                    DALLCompra.IncluirProdutoCompra(listaDeDados);
                }
                else
                {
                    throw new Exception("Adicione produtos ao carrinho antes de confirmar a compra.!!!");
                }
            }
            catch (Exception erro)
            {

                throw new Exception("Erro ao incluir os dados:" + erro.Message);
            }
           
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
