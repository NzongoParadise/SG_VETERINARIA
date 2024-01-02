using Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALTipo_Exame
    {
        private DALConexao conexao;
        public DALTipo_Exame(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void IncluirTipo_Exame(ModeloTipo_Exame modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjectoConexao;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "Insert_procedure_Exame";

            cmd.Parameters.AddWithValue("@ID_Exame ", modelo.ID_Tipo_Exame);
            cmd.Parameters.AddWithValue("@ID_Exame", modelo.Descricao);


            conexao.Conectar();
            cmd.ExecuteNonQuery();
            modelo.ID_Tipo_Exame = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }
        public void AlterarTipo_Exame(ModeloTipo_Exame modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjectoConexao;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "Update_procedure_Exame";

            cmd.Parameters.AddWithValue("@ID_Item_Exame", modelo.ID_Tipo_Exame);
            cmd.Parameters.AddWithValue("@ID_Exame", modelo.Descricao);


            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
    }
}
