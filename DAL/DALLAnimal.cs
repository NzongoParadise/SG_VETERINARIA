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
            cmd.Parameters.AddWithValue("@observacao", modelo.Observacao);
            cmd.Parameters.AddWithValue("@sexo", modelo.sexo1);
            cmd.Parameters.Add("@Foto", System.Data.SqlDbType.Image);
            if (modelo.Foto==null)
            {
                cmd.Parameters["@Foto"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@Foto"].Value = modelo.Foto;

            }

            //cmd.Parameters.AddWithValue("@Foto",modelo.Foto);
            //cmd.Parameters.AddWithValue("@foto", modelo.Foto);

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            modelo.AnimalID1= Convert.ToInt16(cmd.ExecuteScalar());
            conexao.Desconectar();

        }

        public void AtualizarAnimal(ModeloAnimal modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjectoConexao;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "procedure_Atualizar_Animal";

            cmd.Parameters.AddWithValue("@AnimalID", modelo.AnimalID1);
            cmd.Parameters.AddWithValue("@nome", modelo.Nome1);
            cmd.Parameters.AddWithValue("@Especie", modelo.Especie1);
            cmd.Parameters.AddWithValue("@Raca", modelo.Raca1);
            cmd.Parameters.AddWithValue("@sexo", modelo.sexo1);
            cmd.Parameters.AddWithValue("@Cor", modelo.Cor1);
            cmd.Parameters.AddWithValue("@peso", modelo.Peso1);
            cmd.Parameters.AddWithValue("@Estado", modelo.Estado1);
            cmd.Parameters.AddWithValue("@DataNascimento", modelo.DataNascimento1);
            cmd.Parameters.AddWithValue("@Porte", modelo.Porte1);
            cmd.Parameters.AddWithValue("@ProprietarioID", modelo.ProprietarioID1);
            cmd.Parameters.AddWithValue("@observacao", modelo.Observacao);
            cmd.Parameters.Add("@Foto", System.Data.SqlDbType.Image);
            if (modelo.Foto == null)
            {
                cmd.Parameters["@Foto"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@Foto"].Value = modelo.Foto;

            }

            //cmd.Parameters.AddWithValue("@Foto",modelo.Foto);
            //cmd.Parameters.AddWithValue("@foto", modelo.Foto);

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            modelo.AnimalID1 = Convert.ToInt16(cmd.ExecuteScalar());
            conexao.Desconectar();

        }



        public void EliminarAnimal(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjectoConexao;
            cmd.CommandText = "delete from Animal where AnimalID=@AnimalID";
            cmd.Parameters.AddWithValue("@AnimalID", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
        }
        public  DataTable SelecionarTodosAnimais()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Animal", conexao.ObjectoConexao);
            da.Fill(dt);
            da.Dispose();
            return dt; 

        }
        public DataTable PesquisarAnimalcomChave( string nome)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Animal where nome like '%" + nome.ToString() + "%'", conexao.ObjectoConexao);
            da.Fill(dt);
            da.Dispose();
            return dt;

        }
    }
}
