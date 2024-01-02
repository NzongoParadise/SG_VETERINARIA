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
    public class DALAgendamento
    {
        private DALConexao conexao;
        public DALAgendamento(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void IncluirAgendamento(ModeloAgendamento modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjectoConexao;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Insert_procedure_Animal";

            cmd.Parameters.AddWithValue("@DataAgendamento", modelo.DataAgendamento);
            cmd.Parameters.AddWithValue("@ConsultaID", modelo.ConsultaID);
            cmd.Parameters.AddWithValue("@Observacoes", modelo.Observacoes);

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            modelo.AgendamentoID = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }
        public void AlterarAgendamento(ModeloAgendamento modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjectoConexao;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Update_procedure_Animal";

            cmd.Parameters.AddWithValue("@AgendamentoID", modelo.DataAgendamento);
            cmd.Parameters.AddWithValue("@DataAgendamento", modelo.DataAgendamento);
            cmd.Parameters.AddWithValue("@ConsultaID", modelo.ConsultaID);
            cmd.Parameters.AddWithValue("@Observacoes", modelo.Observacoes);

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
    }
}
