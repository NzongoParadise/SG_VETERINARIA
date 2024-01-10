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
            this.conexao = cx;
        }

        public void incluirEndereco(ModeloEndereco modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjectoConexao;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Insert_procedure_Endereco";
            cmd.Parameters.AddWithValue("@Bairro", modelo.Bairro1);
            cmd.Parameters.AddWithValue("@Comuna", modelo.Comuna1);
            cmd.Parameters.AddWithValue("@Cidade", modelo.Cidade1);
            cmd.Parameters.AddWithValue("@Rua", modelo.Rua1);
            cmd.Parameters.AddWithValue("@Email", modelo.Email1);
            cmd.Parameters.AddWithValue("@Telefone1", modelo.Telefone11);
            cmd.Parameters.AddWithValue("@Telefone2", modelo.Telefone21);
            cmd.Parameters.AddWithValue("@Municipio", modelo.Municipio1);
            cmd.Parameters.AddWithValue("@Provincia", modelo.Provincia1);
   

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            modelo.EndrecoID1 = Convert.ToInt16(cmd.ExecuteScalar());
            conexao.Desconectar();

        }
        public void AlterarEndereco(ModeloEndereco modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjectoConexao;
            cmd.CommandText = "procedure_Atualizar_Endereco";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@EnderecoID", modelo.EndrecoID1);
            cmd.Parameters.AddWithValue("@Bairro", modelo.Bairro1);
            cmd.Parameters.AddWithValue("@Rua", modelo.Rua1);
            cmd.Parameters.AddWithValue("@Cidade", modelo.Cidade1);
            cmd.Parameters.AddWithValue("@Comuna", modelo.Comuna1);
            cmd.Parameters.AddWithValue("@Municipio", modelo.Municipio1);
            cmd.Parameters.AddWithValue("@Email", modelo.Email1);
            cmd.Parameters.AddWithValue("@Telefone1", modelo.Telefone11);
            cmd.Parameters.AddWithValue("@Telefone2", modelo.Telefone21);
            cmd.Parameters.AddWithValue("@Provincia", modelo.Provincia1);

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        //public void AlterarEndereco(ModeloEndereco modelo)
        //{
        //    SqlCommand cmd = new SqlCommand();
        //    cmd.Connection = conexao.ObjectoConexao;
        //    cmd.CommandText = "procedure_Atualizar_Endereco";
        //    cmd.Parameters.AddWithValue("@EnderecoID", modelo.EndrecoID1);
        //    cmd.Parameters.AddWithValue("@Bairro", modelo.Bairro1);
        //    cmd.Parameters.AddWithValue("@Rua", modelo.Rua1);
        //    cmd.Parameters.AddWithValue("@Cidade", modelo.Cidade1);
        //    cmd.Parameters.AddWithValue("@Comuna", modelo.Comuna1);
        //    cmd.Parameters.AddWithValue("@Municipio", modelo.Municipio1);
        //    cmd.Parameters.AddWithValue("@Email", modelo.Email1);
        //    cmd.Parameters.AddWithValue("@Telefone1", modelo.Telefone11);
        //    cmd.Parameters.AddWithValue("@Telefone2", modelo.Telefone21);
        //    cmd.Parameters.AddWithValue("@Provincia", modelo.Provincia1);
        //    conexao.Conectar();
        //    cmd.ExecuteNonQuery();
        //    modelo.EndrecoID1 = Convert.ToInt16(cmd.ExecuteScalar());
        //    conexao.Desconectar();

        //}
        public void EliminarEndereco(int cod)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjectoConexao;
            cmd.CommandText = ("delete from Endereco where EnderecoID=@EnderecoID");
            cmd.Parameters.AddWithValue("@EnderecoID", cod);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
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
