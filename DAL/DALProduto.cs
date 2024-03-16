using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace DAL
{
    public class DALProduto
    {
        private DALConexao conexao;
        public DALProduto(DALConexao cx)
        {
            this.conexao = cx;
        }
        public DataTable PesquisarProdutoVacinaComChave(string chave)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select IDProduto, NomeProduto,Qtd,ValorVenda,TipoProduto,FinalidadeProduto,IsentoCusto from Produto where NomeProduto like '%" + chave + "%'"+"and TipoProduto = 'Vacina' and EstadoProduto='1' ", conexao.ObjectoConexao);
            da.Fill(dt);
            return dt;

        }

        public int CadastrarProduto(ModeloProduto modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjectoConexao;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "Insert_procedure_Produto";

                // Adiciona os parâmetros com base nas propriedades do modelo
                cmd.Parameters.AddWithValue("@NomeProduto", modelo.NomeProduto);
                cmd.Parameters.AddWithValue("@FornecedorID", modelo.CodFornecedor);
                cmd.Parameters.AddWithValue("@Qtd", 0);
                cmd.Parameters.AddWithValue("@ValorCompra", 0);
                cmd.Parameters.AddWithValue("@ValorVenda", 0);
                cmd.Parameters.AddWithValue("@Concentracao", modelo.Concentracao);
                cmd.Parameters.AddWithValue("@Dosagem", modelo.Dosagem);
                cmd.Parameters.AddWithValue("@TipoProduto", modelo.TipoProduto);
                cmd.Parameters.AddWithValue("@CategoriaProduto", modelo.CategoriaProduto);
                cmd.Parameters.AddWithValue("@FormaFarmaceutica", modelo.FormaFarmaceutica);
                cmd.Parameters.AddWithValue("@Obs", modelo.Obs);
                cmd.Parameters.AddWithValue("@NomeFornecedor", modelo.NomeFornecedor);
                cmd.Parameters.AddWithValue("@Fabricante", modelo.Fabricante);
                cmd.Parameters.AddWithValue("@DataProducao", DateTime.Now);
                cmd.Parameters.AddWithValue("@DataExpiracao", modelo.dataExpiracao);
                cmd.Parameters.AddWithValue("@FinalidadeProduto", modelo.finalidadeProduto);
                cmd.Parameters.AddWithValue("UsuarioID", modelo.UsuarioID);
                cmd.Parameters.AddWithValue("CodigodeBarra", modelo.CodigodeBara);
                cmd.Parameters.AddWithValue("estadoProduto", modelo.eestadoProduto);
                cmd.Parameters.AddWithValue("IsentoCusto", modelo.situacaCusto);
                cmd.Parameters.AddWithValue("IntervaloAplicacao", modelo.intervaloAplicacao);
                // Adiciona o parâmetro de saída para capturar o novo ID
                SqlParameter paramNovoProdutoID = new SqlParameter("@NovoProdutoID", SqlDbType.Int);
                paramNovoProdutoID.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(paramNovoProdutoID);

                conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();

                // Retorna o valor do parâmetro de saída
                return modelo.produtoID = Convert.ToInt32(cmd.Parameters["@NovoProdutoID"].Value);

            }
            catch (Exception erro)
            {
                throw new Exception("Erro ao incluir o produto:" + erro.Message);

            }


        }



    }
}
