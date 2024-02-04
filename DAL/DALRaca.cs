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
    public class DALRaca
    {
        //public class BLLRacaAnimal
        //{
        //    private DALConexao conexao;
        //    public BLLRacaAnimal(DALConexao cx)
        //    {
        //        this.conexao = cx;
        //    }
        private DALConexao conexao;


        public DALRaca(DALConexao cx)
        {
            this.conexao = cx;
        }



        public void atualizarRaca(ModeloRacaAnimal modelo)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjectoConexao;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "Update_procedure_Raca";

                cmd.Parameters.AddWithValue("@IDRaca", modelo.IDRaca);
                cmd.Parameters.AddWithValue("@NomeRaca", modelo.nomeRaca);
                cmd.Parameters.AddWithValue("@Descricao", modelo.Descricao);

                conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();

            }
            catch (Exception erro)
            {

                throw new Exception("Erro ao atualizar os dados:"+erro.Message);
            }

        }

        public void EliminarRaca(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjectoConexao;
            cmd.CommandText = "delete from Racas where IDRaca=@IDRaca";
            cmd.Parameters.AddWithValue("@IDRaca", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
        }

        public void cadastrarRaca(ModeloRacaAnimal modelo)
        {

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjectoConexao;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "Insert_procedure_Raca";

                cmd.Parameters.AddWithValue("@NomeRaca", modelo.nomeRaca);
                cmd.Parameters.AddWithValue("@Descricao", modelo.Descricao);

                conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();
            }
            catch (Exception erro)
            {

                throw new Exception("Falha ao tentar cadastrar os dados:" + erro.Message);
            }
        }
        public DataTable PesquisarRacacomChave(string nome)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Racas where NomeRaca like '%" + nome.ToString() + "%'", conexao.ObjectoConexao);
            da.Fill(dt);
            da.Dispose();
            return dt;

        }
        public DataTable selecionanarTodasRacas()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Racas ", conexao.ObjectoConexao);
            da.Fill(dt);
            da.Dispose();
            return dt;

        }

        public DataTable encherComboboxRaca()
        {
            DataTable dt = new DataTable();
            using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Racas", conexao.ObjectoConexao))
            {
                da.Fill(dt);
            }
            return dt;
        }
        public void obterRaca()
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
        }

    }



}
