using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DALLCompra
    {
        private DALConexao conexao;

        public DALLCompra(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void IncluirProdutoCompra(List<ModeloCompra> listaDeCompra)
        {
            using (SqlConnection conexaoPrincipal = new SqlConnection(conexao.StringConexao))
            {
                conexaoPrincipal.Open();
                SqlTransaction transacaoPrincipal = conexaoPrincipal.BeginTransaction();

                try
                {
                    foreach (var modelo in listaDeCompra)
                    {
                        //int compraID = IncluirCompra(modelo, transacaoPrincipal);
                        int compraID = IncluirCompra(modelo, transacaoPrincipal);
                        compraID = ObterIDInserido(transacaoPrincipal); // Modifique esta linha

                        Console.WriteLine("id retornado da compra" + compraID);
                        int produtoID = IncluirProduto(modelo, transacaoPrincipal);
                        Console.WriteLine("id retornado da do produto" + compraID);
                        IncluirItemCompraProduto(compraID, produtoID, modelo.Qtd, modelo.precoCompraUnitario, modelo.Total, transacaoPrincipal);
                    }

                    transacaoPrincipal.Commit();
                }
                catch (Exception erro)
                {
                    transacaoPrincipal.Rollback();
                    throw new Exception("Erro ao incluir Compra e produto: " + erro.Message);
                }
            }
        }
        private int ObterIDInserido(SqlTransaction transacao)
        {
            using (SqlCommand cmd = new SqlCommand("SELECT SCOPE_IDENTITY()", transacao.Connection, transacao))
            {
                object result = cmd.ExecuteScalar();
                return (result != DBNull.Value) ? Convert.ToInt32(result) : 0;
            }
        }


        private int IncluirProduto(ModeloCompra modelo, SqlTransaction transacao)
        {
            using (SqlCommand cmd = new SqlCommand("Insert_procedure_Produto", transacao.Connection, transacao))
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Adiciona os parâmetros com base nas propriedades do modelo
                    cmd.Parameters.AddWithValue("@NomeProduto", modelo.NomeProduto);
                    cmd.Parameters.AddWithValue("@CodFornecedor", modelo.CodFornecedor);
                    cmd.Parameters.AddWithValue("@Qtd", modelo.Qtd);
                    cmd.Parameters.AddWithValue("@ValorCompra", modelo.precoCompraUnitario);
                    cmd.Parameters.AddWithValue("@ValorVenda", modelo.precoUnitarioVenda);
                    cmd.Parameters.AddWithValue("@Concentracao", modelo.Concentracao);
                    cmd.Parameters.AddWithValue("@Dosagem", modelo.Dosagem);
                    cmd.Parameters.AddWithValue("@TipoProduto", modelo.TipoProduto);
                    cmd.Parameters.AddWithValue("@CategoriaProduto", modelo.CategoriaProduto);
                    cmd.Parameters.AddWithValue("@FormaFarmaceutica", modelo.FormaFarmaceutica);
                    cmd.Parameters.AddWithValue("@Obs", modelo.Obs);
                    cmd.Parameters.AddWithValue("@NomeFornecedor", modelo.NomeFornecedor);
                    cmd.Parameters.AddWithValue("@Total", modelo.Total);
                    cmd.Parameters.AddWithValue("@Fabricante", modelo.Fabricante);
                    cmd.Parameters.AddWithValue("@DataProducao", modelo.dataProducao);
                    cmd.Parameters.AddWithValue("@DataExpiracao", modelo.dataExpiracao);
                    cmd.Parameters.AddWithValue("@FinalidadeProduto", modelo.finalidadeProduto);

                    // Executa o comando e retorna o ID do produto inserido
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao incluir Produto: " + ex.Message);
                }
            }
        }

        private int IncluirCompra(ModeloCompra modelo, SqlTransaction transacao)
        {
            using (SqlCommand cmd = new SqlCommand("Insert_procedure_Compra", transacao.Connection, transacao))
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@FornecedorID", modelo.CodFornecedor);
                    cmd.Parameters.AddWithValue("@DataCompra", modelo.DataCompra);
                    cmd.Parameters.AddWithValue("@TotalCompra", modelo.Total);

                    // Executa o comando e retorna o ID da compra inserida
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao incluir Compra: " + ex.Message);
                }
            }
        }

        private void IncluirItemCompraProduto(int compraID, int produtoID, int quantidade, decimal precoUnitario, decimal total, SqlTransaction transacao)
        {
            using (SqlCommand cmd = new SqlCommand("Insert_procedure_ItemCompraProduto", transacao.Connection, transacao))
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@CompraID", compraID);
                    cmd.Parameters.AddWithValue("@ProdutoID", produtoID);
                    cmd.Parameters.AddWithValue("@Quantidade", quantidade);
                    cmd.Parameters.AddWithValue("@PrecoUnitario", precoUnitario);
                    cmd.Parameters.AddWithValue("@Total", total);

                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao incluir ItemCompraProduto: " + ex.Message);
                }
            }
        }
    }
}
