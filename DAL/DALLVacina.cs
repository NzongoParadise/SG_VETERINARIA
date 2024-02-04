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
    public class DALLVacina
    {
        private DALConexao conexao;

        public DALLVacina(DALConexao cx)
        {

            this.conexao = cx;
        }

        public void IncluirRegistrodeVacinao(List<ModeloVacina> listaDeVacina)
        {
            using (SqlConnection conexaoPrincipal = new SqlConnection(conexao.StringConexao))
            {
                conexaoPrincipal.Open();
                SqlTransaction transacaoPrincipal = conexaoPrincipal.BeginTransaction();

                try
                {
                    int IDRegistroVacinacao = IncluirRegistroVacinacao(listaDeVacina[0], transacaoPrincipal); // Assume que a lista tem pelo menos um item
                    Console.WriteLine("id registro:" + IDRegistroVacinacao);
                    Console.WriteLine("ID retornado da venda: " + IDRegistroVacinacao);

                    foreach (var modelo in listaDeVacina)
                    {
                        IncluirItemVacina(IDRegistroVacinacao, modelo.IdVacina, modelo.DoseVacina, modelo.NomeVacina, modelo.LoteVacina,modelo.ViaAdministracao,modelo.LocalAdministracao,
                            
                           modelo.dataValidadeVacina,modelo.ReacoesAdversas,modelo.dataProximaDataVacinacao, modelo.dataValidadeVacina,
                           modelo.NotasObservacoes,modelo.IsentoCusto,modelo.LoteVacina,modelo.VacinacaoCompleta, transacaoPrincipal);

                        AtualizarQuantidadeEstoque(modelo.IdVacina, modelo.qtdAdministrada, transacaoPrincipal);
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



        public void AtualizarQuantidadeEstoque(int produtoID, decimal quantidade, SqlTransaction transacao)
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


        private void IncluirItemVacina(int IDRegistroVacinacao, int IdProduto, decimal DoseVacina , string NomeVacina, string LoteVacina, string ViaAdministracao, string LocalAdministracao,
            DateTime ValidadeVacina,string ReacoesAdversas, DateTime ProximaDataVacinacao,DateTime DataValidade, 
            string NotasObservacoes, string CustodeCompra,string loteVacina,bool vacinacaoCompleta, SqlTransaction transacao)
        {
            using (SqlCommand cmd = new SqlCommand("Insert_procedure_ItensRegistroVacina", transacao.Connection, transacao))
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IDRegistroVacinacao", IDRegistroVacinacao);
                    cmd.Parameters.AddWithValue("@IdProduto ", IdProduto);
                    cmd.Parameters.AddWithValue("@DoseVacina", DoseVacina);
                    cmd.Parameters.AddWithValue("@NomeVacina", NomeVacina);
                    cmd.Parameters.AddWithValue("@LoteVacina", LoteVacina);
                    cmd.Parameters.AddWithValue("@ViaAdministracao ", ViaAdministracao);
                    cmd.Parameters.AddWithValue("@LocalAdministracao", LocalAdministracao);
                    cmd.Parameters.AddWithValue("@ValidadeVacina", ValidadeVacina);
                    cmd.Parameters.AddWithValue("@ReacoesAdversas", ReacoesAdversas);
                    cmd.Parameters.AddWithValue("@ProximaDataVacinacao ", ProximaDataVacinacao);
                    cmd.Parameters.AddWithValue("@VacinacaoCompleta", vacinacaoCompleta);
                    cmd.Parameters.AddWithValue("@DataValidade",DataValidade);
                    cmd.Parameters.AddWithValue("@NotasObservacoes", NotasObservacoes);
                    cmd.Parameters.AddWithValue("@CustodeCompra", CustodeCompra);
                  
                   

                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao incluir Item Vacina: " + ex.Message);
                }
            }
        }


        private int IncluirRegistroVacinacao(ModeloVacina modelo, SqlTransaction transacao)
        {
            using (SqlCommand cmd = new SqlCommand("Insert_procedure_RegistroVacinacao", transacao.Connection, transacao))
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@AnimalID", modelo.AnimalID);
                    cmd.Parameters.AddWithValue("@FuncionarioID ", modelo.FuncionarioID);
                    cmd.Parameters.AddWithValue("@UsuarioID", modelo.UsuarioID);
                    cmd.Parameters.AddWithValue("@DataVacinacao", modelo.dataVacinacao);
                    // Executa o comando e retorna o IDRegistroVacinacao inserida
                    int IDRegistroVacinacao = Convert.ToInt32(cmd.ExecuteScalar());

                    return IDRegistroVacinacao;
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao incluir Registro de vacinação: " + ex.Message);
                }
            }
        }







    }
}
