using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALFornecedor
    {
        private DALConexao conexao;
        public DALFornecedor(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void IncluirFornecedor(ModeloFornecedor modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjectoConexao;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Insert_procedure_Fornecedor";

            cmd.Parameters.AddWithValue("@NomeFornecedor", modelo.NomeFornecedor);
            cmd.Parameters.AddWithValue("@TipoServico", modelo.TipoServico);
            cmd.Parameters.AddWithValue("@EnderecoID", modelo.EnderecoID);


            conexao.Conectar();
            cmd.ExecuteNonQuery();
            modelo.FornecedorID = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }
        public void AlterarFornecedor(ModeloFornecedor modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjectoConexao;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Update_procedure_Fornecedor";
            cmd.Parameters.AddWithValue("@FornecedorID", modelo.FornecedorID);
            cmd.Parameters.AddWithValue("@NomeFornecedor", modelo.NomeFornecedor);
            cmd.Parameters.AddWithValue("@TipoServico", modelo.TipoServico);
            cmd.Parameters.AddWithValue("@EnderecoID", modelo.EnderecoID);

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();

        }
    }
}
