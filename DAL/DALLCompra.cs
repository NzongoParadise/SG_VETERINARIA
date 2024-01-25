using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DAL
{
    public class DALLCompra
    {
        private DALConexao conexao;

        public DALLCompra(DALConexao cx)
        {
            this.conexao = cx;
        }


        // esta mbora a funcionar este se dar mal ai volta aqui
        //public void UpdateProdutoCompra(List<ModeloCompra> listaDeCompra)
        //{
        //    try
        //    {
        //        using (SqlCommand cmd = new SqlCommand())
        //        {
        //            cmd.Connection = conexao.ObjectoConexao;
        //            cmd.CommandType = System.Data.CommandType.StoredProcedure;
        //            cmd.CommandText = "Update_procedure_Produtocompra";

        //            foreach (ModeloCompra produto in listaDeCompra)
        //            {
        //                cmd.Parameters.Clear(); // Limpa os parâmetros 
        //                // Adiciona os parâmetros com base nas propriedades do modelo
        //                cmd.Parameters.AddWithValue("@IdProduto", produto.produtoID);
        //                cmd.Parameters.AddWithValue("@NovaQuantidade", produto.Qtd);
        //                cmd.Parameters.AddWithValue("@NovaDataProducao", produto.dataProducao);
        //                cmd.Parameters.AddWithValue("@NovaDataExpiracao", produto.dataExpiracao);
        //                cmd.Parameters.AddWithValue("@NovoValorCompra", produto.precoCompraUnitario);
        //                cmd.Parameters.AddWithValue("@NovoValorVenda", produto.precoUnitarioVenda);
        //                conexao.Conectar();
        //                cmd.ExecuteNonQuery();
        //                conexao.Desconectar();

        //            }

        //            // Após atualizar os produtos, chama o método CadastrarCompra
        //            // Aqui você precisaria fornecer os parâmetros necessários para CadastrarCompra
        //            ModeloCompra modeloCompra = new ModeloCompra(); // Substitua isso pelos dados corretos
        //            List<ModeloCompra> listaDeItensCompra = new List<ModeloCompra>(); // Substitua isso pelos dados corretos
        //            CadastrarItensCompra(modeloCompra, listaDeItensCompra);
        //        }
        //    }
        //    catch (Exception erro)
        //    {
        //        throw new Exception("Erro ao atualizar os produtos: " + erro.Message);
        //    }
        //}
        // Método na classe BLLCompra

        // Método na classe DALLCompra

        public void IncluirCompraItem(List<ModeloCompra> listaDeCompra)
        {
            using (SqlConnection conexaoPrincipal = new SqlConnection(conexao.StringConexao))
            {
                conexaoPrincipal.Open();
                
                
                    SqlTransaction transacaoPrincipal = conexaoPrincipal.BeginTransaction();
                try
                {

                    int CompraID = IncluirCompra(listaDeCompra[0], transacaoPrincipal); // Assume que a lista tem pelo menos um item

                    //Console.WriteLine("ID retornado da venda: " + vendaID);

                    foreach (var modelo in listaDeCompra)
                    {
                        IncluirItemCompra(CompraID, modelo.produtoID, modelo.Qtd, modelo.precoCompraUnitario, modelo.Total, transacaoPrincipal);
                        UpdateProdutoCompra(listaDeCompra, transacaoPrincipal);
                    }

                    transacaoPrincipal.Commit();
                }
                catch (Exception erro)
                {
                    transacaoPrincipal.Rollback();
                    throw new Exception("Erro ao incluir a Compra e ItemVenda: " + erro.Message);
                }
            }

        }


        public void UpdateProdutoCompra(List<ModeloCompra> listaDeCompra, SqlTransaction transacao)
        {
            using (SqlCommand cmd = new SqlCommand("Update_procedure_Produtocompra", transacao.Connection, transacao))
            {

                try
                {

                    cmd.CommandType = CommandType.StoredProcedure;
                    foreach (ModeloCompra produto in listaDeCompra)
                    {
                        cmd.Parameters.Clear(); // Limpa os parâmetros 
                                                // Adiciona os parâmetros com base nas propriedades do modelo
                        cmd.Parameters.AddWithValue("@IdProduto", produto.produtoID);
                        cmd.Parameters.AddWithValue("@NovaQuantidade", produto.Qtd);
                        cmd.Parameters.AddWithValue("@NovaDataProducao", produto.dataProducao);
                        cmd.Parameters.AddWithValue("@NovaDataExpiracao", produto.dataExpiracao);
                        cmd.Parameters.AddWithValue("@NovoValorCompra", produto.precoCompraUnitario);
                        cmd.Parameters.AddWithValue("@NovoValorVenda", produto.precoUnitarioVenda);
                        //conexao.Conectar();
                        cmd.ExecuteNonQuery();
                        //conexao.Desconectar();
                    }


                }

                catch (Exception erro)
                {
                    throw new Exception("Erro ao atualizar os produtos: " + erro.Message);
                }

            }
        }

        //metodo para cadastrar os itens da compra
        public void IncluirItemCompra(int CompraID, int produtoID, int quantidade, decimal precoUnitario, decimal total, SqlTransaction transacao)
        {
            using (SqlCommand cmd = new SqlCommand("Insert_procedure_ItemCompra", transacao.Connection, transacao))
            {

                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    // Adiciona os parâmetros com base nas propriedades do modelo
                    cmd.Parameters.AddWithValue("@CompraID", CompraID);
                    cmd.Parameters.AddWithValue("@ProdutoID", produtoID);
                    cmd.Parameters.AddWithValue("@Quantidade", quantidade);
                    cmd.Parameters.AddWithValue("@PrecoUnitario", precoUnitario);
                    cmd.Parameters.AddWithValue("Total", total);
                    conexao.Conectar();
                    cmd.ExecuteNonQuery();
                    conexao.Desconectar();
                }
                catch (Exception erro)
                {
                    throw new Exception("Erro ao incluir os dados:" + erro.Message);

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

                   
                    cmd.Parameters.AddWithValue("@UsuarioID", modelo.UsuarioID);
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








































































        public void CadastrarItensECompra(ModeloCompra modelo, List<ModeloCompra> listaDeItens)
        {
            try
            {
                conexao.Conectar();
                // Iniciar uma transação para garantir consistência nos dados
                SqlTransaction transaction = conexao.ObjectoConexao.BeginTransaction();

                try
                {
                    SqlCommand cmdCompra = new SqlCommand();
                    cmdCompra.Connection = conexao.ObjectoConexao;
                    cmdCompra.Transaction = transaction;
                    cmdCompra.CommandType = System.Data.CommandType.StoredProcedure;
                    cmdCompra.CommandText = "Insert_procedure_Compra";

                    // Adiciona os parâmetros com base nas propriedades do modelo
                    cmdCompra.Parameters.AddWithValue("@UsuarioID", 2);
                    Console.WriteLine("id=="+modelo.UsuarioID);
                    cmdCompra.Parameters.AddWithValue("@DataCompra", DateTime.Now);
                    cmdCompra.Parameters.AddWithValue("@TotalCompra", modelo.Total); // Certifique-se de ajustar conforme sua lógica

                    // Executa o comando da compra
                    cmdCompra.ExecuteNonQuery();

                    // Obtém o ID da compra recém-inserida
                    int compraID = ObterUltimoIDInserido(); // Implemente conforme necessário

                    // Agora, insere os itens da compra
                    foreach (ModeloCompra itemCompra in listaDeItens)
                    {
                        SqlCommand cmdItemCompra = new SqlCommand();
                        cmdItemCompra.Connection = conexao.ObjectoConexao;
                        cmdItemCompra.Transaction = transaction;
                        cmdItemCompra.CommandType = System.Data.CommandType.StoredProcedure;
                        cmdItemCompra.CommandText = "Insert_procedure_ItemCompra";

                        // Adiciona os parâmetros com base nas propriedades do modelo e no CompraID
                        cmdItemCompra.Parameters.AddWithValue("@CompraID", compraID);
                        cmdItemCompra.Parameters.AddWithValue("@ProdutoID", itemCompra.produtoID);
                        cmdItemCompra.Parameters.AddWithValue("@PrecoUnitario", itemCompra.precoCompraUnitario);
                        cmdItemCompra.Parameters.AddWithValue("@Total", itemCompra.Total);

                        // Executa o comando do item da compra
                        cmdItemCompra.ExecuteNonQuery();
                    }

                    // Commit da transação apenas se tudo ocorreu sem erros
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    // Em caso de erro, faz o rollback da transação
                    transaction.Rollback();
                    throw new Exception("Erro ao incluir os dados:" + ex.Message);
                }
                finally
                {
                    // Fecha a conexão, pois já foi utilizado o método Conectar()
                    conexao.Desconectar();
                }
            }
            catch (Exception erro)
            {
                throw new Exception("Erro ao incluir os dados:" + erro.Message);
            }
        }


        private int ObterUltimoIDInserido()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT SCOPE_IDENTITY()", conexao.ObjectoConexao);
                conexao.Conectar();

                // ExecuteScalar é usado para obter o valor resultante da consulta
                object result = cmd.ExecuteScalar();

                // Verifica se o resultado não é nulo e é um número inteiro
                if (result != null && result != DBNull.Value)
                {
                    return Convert.ToInt32(result);
                }

                // Se não houver ID inserido, você pode tratar de acordo (lançar exceção, retornar um valor padrão, etc.)
                throw new Exception("Não foi possível obter o último ID inserido.");
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao obter o último ID inserido: " + ex.Message);
            }
            finally
            {
                // Certifique-se de desconectar, pois a conexão foi utilizada
                conexao.Desconectar();
            }
        }
        //metodo para cadastrar a compra
        public void CadastrarCompra(ModeloCompra modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjectoConexao;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "Insert_procedure_Compra";
                // Adiciona os parâmetros com base nas propriedades do modelo
                cmd.Parameters.AddWithValue("@UsuarioID", modelo.UsuarioID);
                cmd.Parameters.AddWithValue("@DataCompra", DateTime.Now);
                cmd.Parameters.AddWithValue("TotalCompra", modelo.UsuarioID);
                conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();
            }
            catch (Exception erro)
            {
                throw new Exception("Erro ao incluir os dados:" + erro.Message);

            }

        }
        //metodo para cadastrar os itens da compra
        public void CadastrarItemCompra(List<ModeloCompra> listaDeCompra)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjectoConexao;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "Insert_procedure_ItemCompra";

                // Adiciona os parâmetros com base nas propriedades do modelo
                cmd.Parameters.AddWithValue("@CompraID", listaDeCompra);
                cmd.Parameters.AddWithValue("@ProdutoID", DateTime.Now);
                cmd.Parameters.AddWithValue(" PrecoUnitario", listaDeCompra);
                cmd.Parameters.AddWithValue("Total", listaDeCompra);
                conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();


            }
            catch (Exception erro)
            {
                throw new Exception("Erro ao incluir os dados:" + erro.Message);

            }


        }



        public DataTable PesquisarFornecedorComChavenaCompra(string nome)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select FornecedorID,NomeFornecedor from Fornecedor where NomeFornecedor like '%" + nome + "%' or TipoServico like '%" + nome + "%' or FornecedorID like '%" + nome + "%'", conexao.ObjectoConexao);
            da.Fill(dt);
            da.Dispose();
            return dt;

        }
        public DataTable PesquisarProdutoComChave(string chave)
        {
            //SqlConnection con=new SqlConnection(conexao.StringConexao);
            DataTable dt = new DataTable();
            //con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select IdProduto,NomeProduto, TipoProduto, CategoriaProduto,FinalidadeProduto from produto where NomeProduto like '%" + chave + "%' OR IdProduto like '%" + chave + "%' OR CodigodeBarra like '%" + chave + "%'", conexao.ObjectoConexao);
            da.Fill(dt);
            return dt;
        }

        private int ObterIDInserido(SqlTransaction transacao)
        {
            using (SqlCommand cmd = new SqlCommand("SELECT SCOPE_IDENTITY()", transacao.Connection, transacao))
            {
                object result = cmd.ExecuteScalar();
                return (result != DBNull.Value) ? Convert.ToInt32(result) : 0;
            }
        }



        public int CadastrarProduto(ModeloCompra modelo)
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
                throw new Exception("Erro ao incluir os dados:" + erro.Message);

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
