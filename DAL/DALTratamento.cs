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
    class DALTratamento
    {
        private DALConexao conexao;
        public DALTratamento(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void IncluirTratamento(ModeloTratamento modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjectoConexao;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Insert_procedure_Tratamento";

            cmd.Parameters.AddWithValue("@FuncionarioID", modelo.FuncionarioID);
            cmd.Parameters.AddWithValue("@AnimalID", modelo.AnimalID);
            cmd.Parameters.AddWithValue("@Data_Inicio", modelo.Data_Inicio);
            cmd.Parameters.AddWithValue("@Data_Fim", modelo.Data_Fim);
            cmd.Parameters.AddWithValue("@Descricao", modelo.Escricao);

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            modelo.Id_Tratamento = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }
        public void AlterarTratamento(ModeloTratamento modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjectoConexao;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Insert_procedure_Tratamento";

            cmd.Parameters.AddWithValue("@Id_Tratamento", modelo.Id_Tratamento);
            cmd.Parameters.AddWithValue("@FuncionarioID", modelo.FuncionarioID);
            cmd.Parameters.AddWithValue("@AnimalID", modelo.AnimalID);
            cmd.Parameters.AddWithValue("@Data_Inicio", modelo.Data_Inicio);
            cmd.Parameters.AddWithValue("@Data_Fim", modelo.Data_Fim);
            cmd.Parameters.AddWithValue("@Descricao", modelo.Escricao);

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
    }
}
