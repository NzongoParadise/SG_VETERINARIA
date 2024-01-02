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
    public class DALReceita
    {

        private DALConexao conexao;
        public DALReceita(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void IncluirReceita(ModeloReceita modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjectoConexao;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Insert_procedure_Animal";

            cmd.Parameters.AddWithValue("@num_receita", modelo.Num_receita);
            cmd.Parameters.AddWithValue("@data_receita", modelo.Data_receita);
            cmd.Parameters.AddWithValue("@desc_orientacoes_gerais", modelo.Desc_orientacoes_gerais);
            cmd.Parameters.AddWithValue("@codigo_de_barra", modelo.Codigo_de_barra);
            cmd.Parameters.AddWithValue("@ConsultaID", modelo.ConsultaID);
            cmd.Parameters.AddWithValue("@AnimalID", modelo.AnimalID);
            cmd.Parameters.AddWithValue("@Descricao", modelo.Descricao);

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            modelo.Num_receita = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }
        public void AlterarReceita(ModeloReceita modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjectoConexao;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Update_procedure_Receita";

            cmd.Parameters.AddWithValue("@num_receita", modelo.Num_receita);
            cmd.Parameters.AddWithValue("@data_receita", modelo.Data_receita);
            cmd.Parameters.AddWithValue("@desc_orientacoes_gerais", modelo.Desc_orientacoes_gerais);
            cmd.Parameters.AddWithValue("@codigo_de_barra", modelo.Codigo_de_barra);
            cmd.Parameters.AddWithValue("@ConsultaID", modelo.ConsultaID);
            cmd.Parameters.AddWithValue("@AnimalID", modelo.AnimalID);
            cmd.Parameters.AddWithValue("@Descricao", modelo.Descricao);

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
    }
}
