using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALProduto
    {
        private DALConexao conexao;
        public DALProduto(DALConexao cx)
        {
            this.conexao = cx;
        }
        public DataTable PesquisarProdutoVacinaComChave(string chave)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select IDProduto, NomeProduto,Qtd,ValorVenda,TipoProduto,FinalidadeProduto,IsentoCusto from Produto where NomeProduto like '%" + chave + "%'"+"and TipoProduto = 'Vacina' and EstadoProduto='1' ", conexao.ObjectoConexao);
            da.Fill(dt);
            return dt;

        }
       
    }
}
