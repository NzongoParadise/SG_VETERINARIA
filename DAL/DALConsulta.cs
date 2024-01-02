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
    public class DALConsulta
    {
        private DALConexao conexao;
        public DALConsulta(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void IncluirConsulta(ModeloConsulta modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjectoConexao;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Insert_procedure_Animal";

            cmd.Parameters.AddWithValue("@DataConsulta", modelo.DataConsulta);
            cmd.Parameters.AddWithValue("@AnimalID", modelo.AnimalID);
            cmd.Parameters.AddWithValue("@Diagnostico", modelo.Diagnostico);
            cmd.Parameters.AddWithValue("@Tratamento", modelo.Tratamento);
            cmd.Parameters.AddWithValue("@Observacao", modelo.Observacao);

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            modelo.ConsultaID = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();

        }
        public void AlterarConsulta(ModeloConsulta modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjectoConexao;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Update_procedure_Animal";

            cmd.Parameters.AddWithValue("@ConsultaID", modelo.ConsultaID);
            cmd.Parameters.AddWithValue("@DataConsulta", modelo.DataConsulta);
            cmd.Parameters.AddWithValue("@AnimalID", modelo.AnimalID);
            cmd.Parameters.AddWithValue("@Diagnostico", modelo.Diagnostico);
            cmd.Parameters.AddWithValue("@Tratamento", modelo.Tratamento);
            cmd.Parameters.AddWithValue("@Observacao", modelo.Observacao);

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();

        }
        public void EliminarConsulta(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjectoConexao;
            cmd.CommandText = "delete from Consulta where codeMedicamento = @ConsultaID";
            cmd.Parameters.AddWithValue("@codeMedicamento", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();

        }
        public DataTable Localizar(String nome)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(" select * from Consulta where nomeMedicamento like'%" + nome.ToString() + "%'", conexao.ObjectoConexao);
            da.Fill(dt);
            da.Dispose();
            return dt;
        }
    }
}
