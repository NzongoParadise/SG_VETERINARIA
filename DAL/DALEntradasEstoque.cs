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
    public class DALEntradasEstoque
    {
        private DALConexao conexao;
        public DALEntradasEstoque(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void IncluirEntradasEstoque(ModeloEntradasEstoque modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjectoConexao;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Insert_procedure_EntradasEstoque";

            cmd.Parameters.AddWithValue("@codeMedicamento", modelo.CodeMedicamento);
            cmd.Parameters.AddWithValue("@FornecedorID", modelo.FornecedorID);
            cmd.Parameters.AddWithValue("@DataEntrada", modelo.DataEntrada);
            cmd.Parameters.AddWithValue("@Quantidade", modelo.Quantidade);
            cmd.Parameters.AddWithValue("@quantidade_minima", modelo.Quantidade_minima);
            cmd.Parameters.AddWithValue("@lote", modelo.Lote);
            cmd.Parameters.AddWithValue("@tipoEstoque", modelo.TipoEstoque);
            cmd.Parameters.AddWithValue("@qtdTipoEstoque ", modelo.QtdTipoEstoque);
            cmd.Parameters.AddWithValue("@dataFabricado", modelo.DataFabricado);
            cmd.Parameters.AddWithValue("@dataValidade", modelo.DataValidade);

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            modelo.EntradaID = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }
        public void AlterarEntradasEstoque(ModeloEntradasEstoque modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjectoConexao;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Update_procedure_EntradasEstoque";

            cmd.Parameters.AddWithValue("@EntradaID", modelo.EntradaID);
            cmd.Parameters.AddWithValue("@codeMedicamento", modelo.CodeMedicamento);
            cmd.Parameters.AddWithValue("@FornecedorID", modelo.FornecedorID);
            cmd.Parameters.AddWithValue("@DataEntrada", modelo.DataEntrada);
            cmd.Parameters.AddWithValue("@Quantidade", modelo.Quantidade);
            cmd.Parameters.AddWithValue("@quantidade_minima", modelo.Quantidade_minima);
            cmd.Parameters.AddWithValue("@lote", modelo.Lote);
            cmd.Parameters.AddWithValue("@tipoEstoque", modelo.TipoEstoque);
            cmd.Parameters.AddWithValue("@qtdTipoEstoque ", modelo.QtdTipoEstoque);
            cmd.Parameters.AddWithValue("@dataFabricado", modelo.DataFabricado);
            cmd.Parameters.AddWithValue("@dataValidade", modelo.DataValidade);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
    }
}
