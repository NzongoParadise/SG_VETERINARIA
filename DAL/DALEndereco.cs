using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DALEndereco
    {
        private DALConexao conexao;
        public DALEndereco(DALConexao cx)
        {
            this.conexao= cx;
        }

        public void incluirEndereco(ModeloEndereco modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjectoConexao;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Inserir_procedure_Endereco";
            cmd.Parameters.AddWithValue("@Bairro", modelo.Bairro1);
            cmd.Parameters.AddWithValue("@Cidade", modelo.Cidade1);
            cmd.Parameters.AddWithValue("@Rua", modelo.Rua1);
            cmd.Parameters.AddWithValue("@Email", modelo.Email1);
            cmd.Parameters.AddWithValue("@Telefone1", modelo.Telefone11);
            cmd.Parameters.AddWithValue("@Telefone2", modelo.Telefone21);
            cmd.Parameters.AddWithValue("@Municipio", modelo.Municipio1);
            cmd.Parameters.AddWithValue("@Provincia", modelo.Provincia1);
            cmd.Parameters.AddWithValue("@Comuna", modelo.Comuna1);

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            modelo.EndrecoID1 = Convert.ToInt16(cmd.ExecuteScalar());
            conexao.Desconectar();

        }
        public void AlterarEndereco(ModeloEndereco modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjectoConexao;
            cmd.CommandText = "Update _procedure_Endereco";
            cmd.Parameters.AddWithValue("@Bairro", modelo.Bairro1);
            cmd.Parameters.AddWithValue("@Rua", modelo.Rua1);
            cmd.Parameters.AddWithValue("@Cidade", modelo.Cidade1);
            cmd.Parameters.AddWithValue("@Email", modelo.Email1);
            cmd.Parameters.AddWithValue("@Telefone1", modelo.Telefone11);
            cmd.Parameters.AddWithValue("@Telefone2", modelo.Telefone21);
            cmd.Parameters.AddWithValue("@Provincia", modelo.Provincia1);
            cmd.ExecuteNonQuery();
            modelo.EndrecoID1 = Convert.ToInt16(cmd.ExecuteScalar());
            conexao.Desconectar();

        }

        public DataTable Localizar(String nome)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(" select * from Endereco where Bairro like'%" + nome.ToString() + "%'", conexao.ObjectoConexao);
            da.Fill(dt);
            da.Dispose();
            return dt;
        }
    }
}
