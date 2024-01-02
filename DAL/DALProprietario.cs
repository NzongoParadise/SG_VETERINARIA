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
    public class DALProprietario
    {
        private DALConexao conexao;


        public DALProprietario(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void incluirProprietario(ModeloProprietario modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjectoConexao;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Insert_procedure_Proprietario";

            cmd.Parameters.AddWithValue("@Nome", modelo.Nome);
            cmd.Parameters.AddWithValue("@Sexo", modelo.Sexo);
            cmd.Parameters.AddWithValue("@EnderecoID", modelo.EnderecoID);
            cmd.Parameters.AddWithValue("@Sobrenome", modelo.Sobrenome);
            cmd.Parameters.AddWithValue("@Apelido", modelo.Apelido);
            cmd.Parameters.AddWithValue("@TipoDocumento", modelo.Tipodocumento);
            cmd.Parameters.AddWithValue("@NumIdent", modelo.NumIdnt);
            cmd.Parameters.AddWithValue("@DataEmisao", modelo.DataEmissao);
            cmd.Parameters.AddWithValue("@DataValidade", modelo.DataValidade);
            cmd.Parameters.AddWithValue("@NomePai", modelo.NomePai);
            cmd.Parameters.AddWithValue("@NomeMae", modelo.NomeMae);
            cmd.Parameters.AddWithValue("@Nacionalidade", modelo.Nacionalidade);
            cmd.Parameters.AddWithValue("@descricao", modelo.Descricao);

            conexao.Conectar();

            cmd.ExecuteNonQuery();
            modelo.PropietarioId = Convert.ToInt16(cmd.ExecuteScalar());
            conexao.Desconectar();

        }
        public void AlterarProprietario(ModeloProprietario modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjectoConexao;
            cmd.CommandText = "Update_procedure_Proprietario";

            cmd.Parameters.AddWithValue("@ProprietarioID", modelo.PropietarioId);
            cmd.Parameters.AddWithValue("@Nome", modelo.Nome);
            cmd.Parameters.AddWithValue("@Sexo", modelo.Sexo);
            cmd.Parameters.AddWithValue("@EnderecoID", modelo.EnderecoID);
            cmd.Parameters.AddWithValue("@Sobrenome", modelo.Sobrenome);
            cmd.Parameters.AddWithValue("@Apelido", modelo.Apelido);
            cmd.Parameters.AddWithValue("@TipoDocumento", modelo.Tipodocumento);
            cmd.Parameters.AddWithValue("@NumIdent", modelo.NumIdnt);
            cmd.Parameters.AddWithValue("@DataEmisao", modelo.DataEmissao);
            cmd.Parameters.AddWithValue("@DataValidade", modelo.DataValidade);
            cmd.Parameters.AddWithValue("@NomePai", modelo.NomePai);
            cmd.Parameters.AddWithValue("@NomeMae", modelo.NomeMae);
            cmd.Parameters.AddWithValue("@Nacionalidade", modelo.Nacionalidade);
            cmd.Parameters.AddWithValue("@descricao", modelo.Descricao);
            #region
            //cmd.Parameters.AddWithValue("@foto",System.Data.SqlDbType.Image);
            //if (modelo.Foto==null)
            //{
            //    cmd.Parameters.AddWithValue("@foto", DBNull.Value);
            //}
            //else
            //{
            //    cmd.Parameters.AddWithValue("@foto", modelo.Foto);
            //}
            #endregion
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public void EliminarProprietario(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjectoConexao;
            cmd.CommandText = "delete from proprietario where ProprietarioID=@ProprietarioID";
            cmd.Parameters.AddWithValue("@ProprietarioID", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
        }
  
        public DataTable Localizar(String nome)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(" select * from proprietario where Nome like'%" + nome.ToString() + "%'" , conexao.ObjectoConexao);
            da.Fill(dt);
            da.Dispose();
            return dt;
        }
        public DataTable LocalizarEndereco(String nome)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(" select * from Endereco where Bairro like'%" + nome.ToString() + "%'", conexao.ObjectoConexao);
            da.Fill(dt);
            da.Dispose();
            return dt;
        }
    }
}
