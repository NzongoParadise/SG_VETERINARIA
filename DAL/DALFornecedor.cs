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
        public void DeletarFornecedor(int id)
        {
            SqlCommand cmd=new SqlCommand();
            cmd.Connection = conexao.ObjectoConexao;
            cmd.CommandText= "delete from Fornecedor where FornecedorID=@FornecedorID";
            cmd.Parameters.AddWithValue("@FornecedorID", id);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
            

        }
        public void IncluirFornecedor(ModeloFornecedor modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjectoConexao;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Insert_procedure_Fornecedor";

            
            cmd.Parameters.AddWithValue("@NomeFornecedor", modelo.nomeFornecedor);
            cmd.Parameters.AddWithValue("@TipoServico", modelo.tipoServico);
            cmd.Parameters.AddWithValue("@EnderecoID", modelo.enderecoID);
            cmd.Parameters.AddWithValue("@Observacao", modelo.Observacao);

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            modelo.fornecedorID = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }
        public void AlterarFornecedor(ModeloFornecedor modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjectoConexao;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "procedure_Atualizar_Fornecedor";
            cmd.Parameters.AddWithValue("@FornecedorID", modelo.fornecedorID);
            cmd.Parameters.AddWithValue("@NomeFornecedor", modelo.nomeFornecedor);
            cmd.Parameters.AddWithValue("@TipoServico", modelo.tipoServico);
            cmd.Parameters.AddWithValue("@Observacao", modelo.enderecoID);
            cmd.Parameters.AddWithValue("@EnderecoID", modelo.enderecoID);

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();

        }
        public DataTable PesquisarFornecedorComChave(string nome)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Fornecedor where NomeFornecedor like '%" + nome + "%' or TipoServico like '%"+ nome +"%' or FornecedorID like '%"+nome+"%'" , conexao.ObjectoConexao);
            da.Fill(dt); 
            da.Dispose();
            return dt;
        }
        public DataTable PesquisarEnderecoComChave(string nome)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Endereco where Bairro like '%" + nome + "%'  OR Cidade like '%" + nome + "%' or Provincia like '" + nome +"%'" , conexao.ObjectoConexao);
            da.Fill(dt);
            da.Dispose();
            return dt;
        }
        public DataTable CarregarFornecedores()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Fornecedor", conexao.ObjectoConexao);
            da.Fill(dt);
            da.Dispose();
            return dt;
        }
        public DataTable PesquisarFornecedorComChavenaCompra(string nome)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select FornecedorID,NomeFornecedor from Fornecedor where NomeFornecedor like '%" + nome + "%' or TipoServico like '%" + nome + "%' or FornecedorID like '%" + nome + "%'", conexao.ObjectoConexao);
            da.Fill(dt);
            da.Dispose();
            return dt;
        }

        
    }
}
