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
    public class DALVenda
    {
        private DALConexao conexao;

        public DALVenda(DALConexao cx)
        {
            this.conexao = cx;
        }
        public DataTable PesquisarProdutoComChave(string chave)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select IDProduto, NomeProduto,Qtd,ValorVenda,NomeFornecedor,TipoProduto from Produto where NomeProduto like '%" + chave + "%'", conexao.ObjectoConexao);
            da.Fill(dt);
            return dt;
        }


        public void IncluirVendaItem(List<ModeloVenda> listaDeVenda)
        {
            using (SqlConnection conexaoPrincipal = new SqlConnection(conexao.StringConexao))
            {
                conexaoPrincipal.Open();
                SqlTransaction transacaoPrincipal = conexaoPrincipal.BeginTransaction();

                try
                {
                    int vendaID = IncluirVenda(listaDeVenda[0], transacaoPrincipal); // Assume que a lista tem pelo menos um item

                    //Console.WriteLine("ID retornado da venda: " + vendaID);

                    foreach (var modelo in listaDeVenda)
                    {
                        IncluirItemVenda(vendaID, modelo.produtoID, modelo.Qtd, modelo.precoUnitario, modelo.Total, transacaoPrincipal);
                        AtualizarQuantidadeEstoque(modelo.produtoID, modelo.Qtd, transacaoPrincipal);
                    }

                    transacaoPrincipal.Commit();
                }
                catch (Exception erro)
                {
                    transacaoPrincipal.Rollback();
                    throw new Exception("Erro ao incluir Venda e ItemVenda: " + erro.Message);
                }
            }
        }

        private int IncluirVenda(ModeloVenda modelo, SqlTransaction transacao)
        {
            using (SqlCommand cmd = new SqlCommand("Insert_procedure_Venda", transacao.Connection, transacao))
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@DataVenda", modelo.dataVenda);
                    cmd.Parameters.AddWithValue("@TotalVenda", modelo.totalGeral);
                    cmd.Parameters.AddWithValue("@UsuarioID", modelo.UsuarioID);
                    cmd.Parameters.AddWithValue("@NomeCliente", modelo.nomeCliente);
                    // Executa o comando e retorna o ID da venda inserida
                    int vendaID = Convert.ToInt32(cmd.ExecuteScalar());

                    return vendaID;
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao incluir venda: " + ex.Message);
                }
            }
        }

        public void AtualizarQuantidadeEstoque(int produtoID, int quantidade, SqlTransaction transacao)
        {
            using (SqlCommand cmd = new SqlCommand("Update_procedure_AtualizarQuantidadeEstoque", transacao.Connection, transacao))
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@ProdutoID", produtoID);
                    cmd.Parameters.AddWithValue("@Quantidade", quantidade);

                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao atualizar a quantidade do estoque: " + ex.Message);
                }
            }
        }


        private void IncluirItemVenda(int VendaID, int produtoID, int quantidade, decimal precoUnitario, decimal total, SqlTransaction transacao)
        {
            using (SqlCommand cmd = new SqlCommand("Insert_procedure_ItemVendaProduto", transacao.Connection, transacao))
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@VendaID", VendaID);
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