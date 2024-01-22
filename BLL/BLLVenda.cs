using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public  class BLLVenda
    {
        private DALConexao conexao;

        public BLLVenda(DALConexao cx)
        {
            this.conexao = cx;
        }
        public DataTable PesquisarProduto(string chave)
        {
            DALVenda dall = new DALVenda(conexao);
            
            return dall.PesquisarProdutoComChave(chave);
        }
        public void incluirVendaItem(List <ModeloVenda> listaDeDados)
        {
            try
            {
                if (listaDeDados.Count>0)
                {
                    DALVenda dall = new DALVenda(conexao);
                    dall.IncluirVendaItem(listaDeDados);

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
        }
    }

