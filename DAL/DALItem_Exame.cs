using Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALItem_Exame
    {

        private DALConexao conexao;
        public DALItem_Exame(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void IncluirExame(ModeloItem_Exame modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjectoConexao;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "Insert_procedure_Exame";

            cmd.Parameters.AddWithValue("@ID_Exame ", modelo.ID_Exame);
            cmd.Parameters.AddWithValue("@Descricao_Exame", modelo.Descricao_Exame);
            cmd.Parameters.AddWithValue("@Resultado_Exame", modelo.Resultado_Exame);


            conexao.Conectar();
            cmd.ExecuteNonQuery();
            modelo.ID_Item_Exame = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }
        public void AlterarExame(ModeloItem_Exame modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjectoConexao;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "Update_procedure_Exame";

            cmd.Parameters.AddWithValue("@ID_Item_Exame", modelo.ID_Exame);
            cmd.Parameters.AddWithValue("@ID_Exame", modelo.ID_Exame);
            cmd.Parameters.AddWithValue("@Descricao_Exame", modelo.Descricao_Exame);
            cmd.Parameters.AddWithValue("@Resultado_Exame", modelo.Resultado_Exame);


            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
    }
}