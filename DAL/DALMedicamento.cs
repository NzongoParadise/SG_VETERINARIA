using Modelo;
using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
    public class DALMedicamento
    {
        private DALConexao conexao;
        public DALMedicamento(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void IncluirirMedicamento( ModeloMedicamento modelo) {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjectoConexao;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Inserir_procedure_Medicamento";
            cmd.Parameters.AddWithValue("@nomeMedicamento", modelo.NomeMedicamento);
            cmd.Parameters.AddWithValue("@TipoProduto", modelo.TipoProduto);
            cmd.Parameters.AddWithValue("@formaFarmaceutica", modelo.FormaFarmaceutica);
            cmd.Parameters.AddWithValue("@dosagemMedicamento", modelo.DosagemMedicamento);
            cmd.Parameters.AddWithValue("@instrucoes", modelo.Instrucoes);
            cmd.Parameters.AddWithValue("@fabricante", modelo.Fabricante);
            cmd.Parameters.AddWithValue("@concentracao", modelo.Concentracao);
            cmd.Parameters.AddWithValue("@descricao", modelo.Descricao);

            conexao.Conectar();
            cmd.ExecuteNonQuery();

            modelo.CodeMedicamento = Convert.ToInt16(cmd.ExecuteScalar());

            conexao.Desconectar();
        }
        public void AlterarMedicamento(ModeloMedicamento modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjectoConexao;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Update_procedure_Medicamento";
            cmd.Parameters.AddWithValue("@codeMedicamento", modelo.CodeMedicamento);
            cmd.Parameters.AddWithValue("@nomeMedicamento", modelo.NomeMedicamento);
            cmd.Parameters.AddWithValue("@TipoProduto", modelo.TipoProduto);
            cmd.Parameters.AddWithValue("@formaFarmaceutica", modelo.FormaFarmaceutica);
            cmd.Parameters.AddWithValue("@dosagemMedicamento", modelo.DosagemMedicamento);
            cmd.Parameters.AddWithValue("@instrucoes", modelo.Instrucoes);
            cmd.Parameters.AddWithValue("@fabricante", modelo.Fabricante);
            cmd.Parameters.AddWithValue("@concentracao", modelo.Concentracao);
            cmd.Parameters.AddWithValue("@descricao", modelo.Descricao);

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();

        }
        public void EliminarMedicamento(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjectoConexao;
            cmd.CommandText = "delete from Medicamentos where codeMedicamento = @codeMedicamento";
            cmd.Parameters.AddWithValue("@codeMedicamento", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();

        }
        public DataTable Localizar(String nome)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(" select * from medicamento where nomeMedicamento like'%" + nome.ToString() + "%'", conexao.ObjectoConexao);
            da.Fill(dt);
            da.Dispose();
            return dt;
        }
    }
}
