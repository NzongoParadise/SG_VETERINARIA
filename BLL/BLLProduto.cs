using DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public  class BLLProduto
    {
        private DALConexao conexao;
        public BLLProduto(DALConexao cx)
        {
            this.conexao = cx;
        }

        public DataTable PesquisarProdutoVacinaComChave(string chave)
        {
            DALProduto dall = new DALProduto(conexao);

            return dall.PesquisarProdutoVacinaComChave(chave);
        }
    }
}
