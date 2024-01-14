using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
        #region metodo atualizar proprietario
        public void AlterarProprietario(ModeloProprietario modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjectoConexao;
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.CommandText = "procedure_Atualizar_Proprietario";

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
            
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        #endregion
        public void EliminarProprietario(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjectoConexao;
            cmd.CommandText = "delete from proprietario where ProprietarioID=@ProprietarioID";
            cmd.Parameters.AddWithValue("@ProprietarioID", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
        }
        public DataTable PesquisarProprietarioComChave( string nome)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select Nome,sobrenome, ProprietarioID from Proprietario where Nome like '%" + nome.ToString() + "%'", conexao.ObjectoConexao);
            da.Fill(dt);
            da.Dispose();
           return dt;
        }
    public DataTable Localizar(String nome)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(" select * from proprietario where Nome like'%" + nome.ToString() + "%'" , conexao.ObjectoConexao);
            da.Fill(dt);
            da.Dispose();
            return dt;
        }
        public int ObterTotalProprietariosCadastrados()
        {
            int totalProprietarios = 0;

            try
            {
                using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Proprietario", conexao.ObjectoConexao))
                {
                    conexao.ObjectoConexao.Open();
                    totalProprietarios = (int)cmd.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
              
                Console.WriteLine("Erro ao obter o total de proprietários cadastrados: " + ex.Message);
            }
            finally
            {
                conexao.ObjectoConexao.Close();
            }

            return totalProprietarios;
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
