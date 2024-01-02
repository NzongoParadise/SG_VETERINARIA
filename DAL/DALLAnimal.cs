using Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class DALLAnimal
    {
        private DALConexao conexao;
        public DALLAnimal(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void IncluirAnimal(ModeloAnimal  modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjectoConexao;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "Insert_procedure_Animal";

            cmd.Parameters.AddWithValue("@nome", modelo.Nome1);
            cmd.Parameters.AddWithValue("@Especie", modelo.Especie1);
            cmd.Parameters.AddWithValue("@Raca", modelo.Raca1);
            cmd.Parameters.AddWithValue("@Cor", modelo.Cor1);
            cmd.Parameters.AddWithValue("@peso", modelo.Peso1);
            cmd.Parameters.AddWithValue("@Estado", modelo.Estado1);
            cmd.Parameters.AddWithValue("@DataNascimento", modelo.DataNascimento1);
            cmd.Parameters.AddWithValue("@Porte", modelo.Porte1);
            cmd.Parameters.AddWithValue("@ProprietarioID", modelo.ProprietarioID1);
            cmd.Parameters.AddWithValue("@bservacao", modelo.Observacao);
            cmd.Parameters.AddWithValue("@foto", modelo.Foto);

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            modelo.AnimalID1= Convert.ToInt16(cmd.ExecuteScalar());
            conexao.Desconectar();

        }
    }
}
