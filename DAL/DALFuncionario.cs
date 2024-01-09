using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALFuncionario
    {
        private DALConexao conexao;
        
        public DALFuncionario(DALConexao cx)
        {
            this.conexao = cx;

        }
        public DataTable localizarFuncionario(String keyword)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(" select Nome, FuncionarioID from Funcionario where Nome like'%" + keyword.ToString() + "%'", conexao.ObjectoConexao);
            da.Fill(dt);
            da.Dispose();
            return dt;
        }

    }
}
