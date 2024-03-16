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
        public int intervaloTempo(int produtoID)
        {
            int intervalo = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(conexao.StringConexao))
                {
                    SqlCommand command = new SqlCommand(@"SELECT IntervaloAplicacao FROM produto WHERE IdProduto = @ProdutoId", connection);
                    command.Parameters.AddWithValue("@ProdutoId", produtoID);

                    connection.Open();
                    intervalo = (int)command.ExecuteScalar();
                }
            }
            catch (Exception erro)
            {
                throw new Exception("Erro ao pesquisar os dados: " + erro.Message);
            }

            return intervalo;
        }


        public bool VerificarVacinaVencida(int animalID, int produtoID)
        {
            bool existeVacinaVencida = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(conexao.StringConexao))
                {
                    SqlCommand command = new SqlCommand(@"SELECT CASE 
    WHEN NOT EXISTS (
        SELECT 1
        FROM RegistroVacinacaobom r
        INNER JOIN ItensRegistroVacinabom i ON r.IDRegistroVacinacao = i.IDRegistroVacinacao
        INNER JOIN Animal a ON r.AnimalID = a.AnimalID
        WHERE a.AnimalID = @AnimalId
        AND i.IdProduto = @ProdutoId
    ) THEN 1 -- Primeira vez que a vacina está sendo administrada ao animal
    WHEN EXISTS (
        SELECT 1
        FROM RegistroVacinacaobom r
        INNER JOIN ItensRegistroVacinabom i ON r.IDRegistroVacinacao = i.IDRegistroVacinacao
        INNER JOIN Animal a ON r.AnimalID = a.AnimalID
        WHERE a.AnimalID = @AnimalId
        AND i.IdProduto = @ProdutoId
        AND i.ProximaDataVacinacao < GETDATE()
    ) AND NOT EXISTS (
        SELECT 1
        FROM RegistroVacinacaobom r
        INNER JOIN ItensRegistroVacinabom i ON r.IDRegistroVacinacao = i.IDRegistroVacinacao
        INNER JOIN Animal a ON r.AnimalID = a.AnimalID
        WHERE a.AnimalID = @AnimalId
        AND i.IdProduto = @ProdutoId
        AND i.ProximaDataVacinacao >= GETDATE()
    ) THEN 1 -- Vacina precedente vencida
    ELSE 0 -- Vacina precedente não vencida ou já administrada anteriormente e não vencida
END AS ExisteVacinaVencida", connection);

                    command.Parameters.AddWithValue("@AnimalId", animalID);
                    command.Parameters.AddWithValue("@ProdutoId", produtoID);

                    connection.Open(); // O bloco using já cuidará do Open e Close, não é necessário abrir manualmente aqui
                    existeVacinaVencida = (int)command.ExecuteScalar() == 1;
                    return existeVacinaVencida;
                }
            }
            catch (Exception erro)
            {
                throw new Exception("Erro ao pesquisar os dados: " + erro.Message);
            }
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
               

                    foreach (var modelo in listaDeVacina)
                    {
                        IncluirItemVacina(IDRegistroVacinacao, modelo.IdVacina, modelo.qtdAdministrada,modelo.LoteVacina,modelo.ViaAdministracao,modelo.LocalAdministracao,
                            
                          modelo.ReacoesAdversas,modelo.dataProximaDataVacinacao,transacaoPrincipal);

                        AtualizarQuantidadeEstoque(modelo.IdVacina, modelo.qtdAdministrada, transacaoPrincipal);
                    }
                    transacaoPrincipal.Commit();
                }
                catch (Exception erro)
                {
                    transacaoPrincipal.Rollback();
                    throw new Exception("Erro ao incluir a vacina: " + erro.Message);
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


        private void IncluirItemVacina(int IDRegistroVacinacao, int IdProduto, decimal qtdAdministrada , string LoteVacina, string ViaAdministracao, string LocalAdministracao,
            string ReacoesAdversas, DateTime ProximaDataVacinacao,SqlTransaction transacao)
        {
            using (SqlCommand cmd = new SqlCommand("Insert_procedure_ItensRegistroVacinabom", transacao.Connection, transacao))
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IDRegistroVacinacao", IDRegistroVacinacao);
                    cmd.Parameters.AddWithValue("@IdProduto ", IdProduto);
                    cmd.Parameters.AddWithValue("@DoseVacina", qtdAdministrada);
                    cmd.Parameters.AddWithValue("@LoteVacina", LoteVacina);
                    cmd.Parameters.AddWithValue("@ViaAdministracao ", ViaAdministracao);
                    cmd.Parameters.AddWithValue("@LocalAdministracao", LocalAdministracao);
                    //cmd.Parameters.AddWithValue("@ValidadeVacina", ValidadeVacina);
                    cmd.Parameters.AddWithValue("@ReacoesAdversas", ReacoesAdversas);
                    cmd.Parameters.AddWithValue("@ProximaDataVacinacao ", ProximaDataVacinacao);
                    //cmd.Parameters.AddWithValue("@VacinacaoCompleta", vacinacaoCompleta);
                    //cmd.Parameters.AddWithValue("@DataValidade",DataValidade);
                    //cmd.Parameters.AddWithValue("@NotasObservacoes", NotasObservacoes);
                    //cmd.Parameters.AddWithValue("@CustodeCompra", CustodeCompra);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao incluir a Vacina: " + ex.Message);
                }
            }
        }


        //private int IncluirRegistroVacinacao(ModeloVacina modelo, SqlTransaction transacao)
        //{
        //    using (SqlCommand cmd = new SqlCommand("Insert_procedure_RegistroVacinacao", transacao.Connection, transacao))
        //    {
        //        try
        //        {
        //            cmd.CommandType = CommandType.StoredProcedure;
        //            cmd.Parameters.AddWithValue("@AnimalID", modelo.AnimalID);
        //            cmd.Parameters.AddWithValue("@FuncionarioID ", modelo.FuncionarioID);
        //            cmd.Parameters.AddWithValue("@UsuarioID", modelo.UsuarioID);
        //            cmd.Parameters.AddWithValue("@DataVacinacao", modelo.dataVacinacao);
        //            // Executa o comando e retorna o IDRegistroVacinacao inserida
        //            int IDRegistroVacinacao = Convert.ToInt32(cmd.ExecuteScalar());

        //            return IDRegistroVacinacao;
        //        }
        //        catch (Exception ex)
        //        {
        //            throw new Exception("Erro ao incluir Registro de vacinação: " + ex.Message);
        //        }
        //    }
        //}

        private int IncluirRegistroVacinacao(ModeloVacina modelo, SqlTransaction transacao)
        {
            using (SqlCommand cmd = new SqlCommand("Insert_procedure_RegistroVacinacaobom", transacao.Connection, transacao))
            {
                try
                    {
                       
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@AnimalID", modelo.AnimalID);
                        cmd.Parameters.AddWithValue("@UsuarioID", modelo.UsuarioID);
                        cmd.Parameters.AddWithValue("@Desconto", modelo.desconto);
                        cmd.Parameters.AddWithValue("@Imposto", modelo.imposto);
                        cmd.Parameters.AddWithValue("@Troco", modelo.troco);
                        cmd.Parameters.AddWithValue("@FormaPagamento", modelo.formaPagamento);
                        cmd.Parameters.AddWithValue("@CustoTotal", modelo.custoTotalCompra);
                        cmd.Parameters.AddWithValue("@ValorEntregue", modelo.valorEntregue);
                        cmd.Parameters.AddWithValue("@NotasObservacoes", modelo.NotasObservacoes);

                        // Executa o comando e retorna o IDRegistroVacinacao inserido
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
