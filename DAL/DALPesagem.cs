using Modelo;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DALPesagem
    {
        private DALConexao conexao;

        public DALPesagem(DALConexao cx)
        {
            this.conexao = cx;
        }
        public DataTable PesquisarPesocomChave(string nome)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DISTINCT a.AnimalID as 'Código do Animal', a.Cor, a.DataNascimento as 'Data Nascimento', a.Especie as 'Espécie', a.Raca as 'Raça', p.DataPesagem as 'Data Pesagem', p.peso as 'Peso Obtido' " +
                                        "FROM proprietario pp, pesagem p, Animal a " +
                                        "WHERE p.animalID = a.AnimalID " +
                                        "AND pp.ProprietarioID = a.ProprietarioID " +
                                        "AND (a.Nome LIKE '%" + nome.ToString() + "%' OR p.AnimalID LIKE '%" + nome + "%')",
                                        conexao.ObjectoConexao);
            da.Fill(dt);
            da.Dispose();
            return dt;

        }
        public DataTable PesquisarPesocomChaveNomesIdade(string nome)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DISTINCT a.Nome as 'Nome do Animal', pp.Nome as 'Proprietário do Animal',a.DataNascimento as 'Data Nascimento'" +
                                        "FROM proprietario pp, pesagem p, Animal a " +
                                        "WHERE p.animalID = a.AnimalID " +
                                        "AND pp.ProprietarioID = a.ProprietarioID " +
                                        "AND (a.Nome LIKE '%" + nome.ToString() + "%' OR p.AnimalID LIKE '%" + nome + "%')",
                                        conexao.ObjectoConexao);
            da.Fill(dt);
            da.Dispose();
            return dt;

        }
        public void incluirRegistroPesagem(ModeloPesagem modelo, SqlTransaction transacao)
        {
            using (SqlCommand cmd = new SqlCommand("insert_procedure_Pesagem", transacao.Connection, transacao))
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@AnimalID", modelo.AnimalID);
                    cmd.Parameters.AddWithValue("@FuncionarioID", modelo.FuncionarioID);
                    cmd.Parameters.AddWithValue("@Peso", modelo.peso);
                    cmd.Parameters.AddWithValue("@Obs", modelo.obs);
                    cmd.Parameters.AddWithValue("@UsuarioID", modelo.usuarioID);

                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao incluir os dados: " + ex.Message);
                }
            }
        }

        public void UpdatePeso(int animalID, decimal novoPeso, SqlTransaction transacao)
        {
            using (SqlCommand cmd = new SqlCommand("Update_procedure_Peso", transacao.Connection, transacao))
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@AnimalID", animalID);
                    cmd.Parameters.AddWithValue("@NovoPeso", novoPeso);

                    cmd.ExecuteNonQuery();
                }
                catch (Exception erro)
                {
                    throw new Exception("Erro ao atualizar o peso: " + erro.Message);
                }
            }
        }

        public void incluirPesagem(ModeloPesagem modelo)
        {
            using (SqlConnection conexaoPrincipal = new SqlConnection(conexao.StringConexao))
            {
                conexaoPrincipal.Open();

                SqlTransaction transacaoPrincipal = conexaoPrincipal.BeginTransaction();
                try
                {
                    incluirRegistroPesagem(modelo, transacaoPrincipal);

                    // Atualizar o peso do animal
                    UpdatePeso(modelo.AnimalID, modelo.peso, transacaoPrincipal);

                    transacaoPrincipal.Commit();
                }
                catch (Exception erro)
                {
                    transacaoPrincipal.Rollback();
                    throw new Exception("Erro ao incluir e atualizar o peso: " + erro.Message);
                }
            }
        }
    }
}
