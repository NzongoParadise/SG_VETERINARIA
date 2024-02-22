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
    public class DALExame
    {
        private DALConexao conexao;
        public DALExame(DALConexao cx)
        {
            this.conexao = cx;
        //}
        //public void IncluirExame(ModeloExame modelo)
        //{
        //    SqlCommand cmd = new SqlCommand();
        //    cmd.Connection = conexao.ObjectoConexao;
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.CommandText = "Insert_procedure_Exame";

        //    cmd.Parameters.AddWithValue("@AnimalID", modelo.AnimalID);
        //    cmd.Parameters.AddWithValue("@FuncionarioID", modelo.FuncionarioID);
        //    cmd.Parameters.AddWithValue("@ID_Tipo_Exame", modelo.ID_Tipo_Exame);
        //    cmd.Parameters.AddWithValue("@Data_Hora", modelo.Data_Hora);
        //    cmd.Parameters.AddWithValue("@Resultado", modelo.Resultado);


        //    conexao.Conectar();
        //    cmd.ExecuteNonQuery();
        //    modelo.ID_Exame = Convert.ToInt32(cmd.ExecuteScalar());
        //    conexao.Desconectar();
        //}
        //public void AlterarExame(ModeloExame modelo)
        //{
        //    SqlCommand cmd = new SqlCommand();
        //    cmd.Connection = conexao.ObjectoConexao;
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.CommandText = "Update_procedure_Exame";

        //    cmd.Parameters.AddWithValue("@ID_Exame", modelo.ID_Exame);
        //    cmd.Parameters.AddWithValue("@AnimalID", modelo.AnimalID);
        //    cmd.Parameters.AddWithValue("@FuncionarioID", modelo.FuncionarioID);
        //    cmd.Parameters.AddWithValue("@ID_Tipo_Exame", modelo.ID_Tipo_Exame);
        //    cmd.Parameters.AddWithValue("@Data_Hora", modelo.Data_Hora);
        //    cmd.Parameters.AddWithValue("@Resultado", modelo.Resultado);


        //    conexao.Conectar();
        //    cmd.ExecuteNonQuery();
        //    conexao.Desconectar();
        }
    }
}
