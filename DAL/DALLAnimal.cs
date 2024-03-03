using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class DALLAnimal
    {
        private DALConexao conexao;
        public DALLAnimal(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void IncluirAnimal(ModeloAnimal modelo)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjectoConexao;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "Insert_procedure_Animal";

                cmd.Parameters.AddWithValue("@nome", modelo.Nome1);
                cmd.Parameters.AddWithValue("@Especie", modelo.Especie1);
                cmd.Parameters.AddWithValue("@Raca", modelo.Raca1);
                cmd.Parameters.AddWithValue("@Cor", modelo.Cor1);
                cmd.Parameters.AddWithValue("@peso", modelo.Peso1);
                cmd.Parameters.AddWithValue("@Estado", modelo.Estado1);
                cmd.Parameters.AddWithValue("@DataNascimento", modelo.DataNascimento1);
                cmd.Parameters.AddWithValue("@Porte", modelo.Porte1);
                cmd.Parameters.AddWithValue("@ProprietarioID", modelo.ProprietarioID1);
                cmd.Parameters.AddWithValue("@observacao", modelo.Observacao);
                cmd.Parameters.AddWithValue("@sexo", modelo.sexo1);
                cmd.Parameters.Add("@Foto", System.Data.SqlDbType.Image);
                if (modelo.Foto == null)
                {
                    cmd.Parameters["@Foto"].Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters["@Foto"].Value = modelo.Foto;

                }

                //cmd.Parameters.AddWithValue("@Foto",modelo.Foto);
                //cmd.Parameters.AddWithValue("@foto", modelo.Foto);

                conexao.Conectar();
                modelo.AnimalID1 = Convert.ToInt16(cmd.ExecuteScalar());
                conexao.Desconectar();

            }
            catch (Exception erro)
            {

                throw new Exception("Falha ao Cadastrar os dados no Banco de Dados:" + erro.Message);
            }
        }

        public void AtualizarAnimal(ModeloAnimal modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjectoConexao;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "procedure_Atualizar_Animal";

            cmd.Parameters.AddWithValue("@AnimalID", modelo.AnimalID1);
            cmd.Parameters.AddWithValue("@nome", modelo.Nome1);
            cmd.Parameters.AddWithValue("@Especie", modelo.Especie1);
            cmd.Parameters.AddWithValue("@Raca", modelo.Raca1);
            cmd.Parameters.AddWithValue("@sexo", modelo.sexo1);
            cmd.Parameters.AddWithValue("@Cor", modelo.Cor1);
            cmd.Parameters.AddWithValue("@peso", modelo.Peso1);
            cmd.Parameters.AddWithValue("@Estado", modelo.Estado1);
            cmd.Parameters.AddWithValue("@DataNascimento", modelo.DataNascimento1);
            cmd.Parameters.AddWithValue("@Porte", modelo.Porte1);
            cmd.Parameters.AddWithValue("@ProprietarioID", modelo.ProprietarioID1);
            cmd.Parameters.AddWithValue("@observacao", modelo.Observacao);
            cmd.Parameters.Add("@Foto", System.Data.SqlDbType.Image);
            if (modelo.Foto == null)
            {
                cmd.Parameters["@Foto"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@Foto"].Value = modelo.Foto;

            }

            //cmd.Parameters.AddWithValue("@Foto",modelo.Foto);
            //cmd.Parameters.AddWithValue("@foto", modelo.Foto);

            conexao.Conectar();
         
            modelo.AnimalID1 = Convert.ToInt16(cmd.ExecuteScalar());
            conexao.Desconectar();

        }



        public void EliminarAnimal(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjectoConexao;
            cmd.CommandText = "delete from Animal where AnimalID=@AnimalID";
            cmd.Parameters.AddWithValue("@AnimalID", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
        }
        public DataTable SelecionarTodosAnimais()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Animal", conexao.ObjectoConexao);
            da.Fill(dt);
            da.Dispose();
            return dt;

        }
        public int ObterTotalAnimaisCadastrados()
        {
            int totalAnimais = 0;

            try
            {
                using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Animal", conexao.ObjectoConexao))
                {
                    conexao.ObjectoConexao.Open();
                    totalAnimais = (int)cmd.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao obter o total de animais cadastrados: " + ex.Message);
            }
            finally
            {
                conexao.ObjectoConexao.Close();
            }

            return totalAnimais;
        }

        public DataTable PesquisarAnimalcomChave(string nome)
        {
            DataTable dt = new DataTable();
            string query = "SELECT  AnimalID as 'Código do Animal', Nome as 'Nome do Animal', Especie as Espécie, Raca as Raça, Estado, DataNascimento as 'Data de Nascimento', Cor, sexo as Sexo, Porte, Peso,observacao as Observação,ProprietarioID AS 'Código do Proprietário' FROM Animal WHERE nome LIKE @Nome OR AnimalID = TRY_CAST(@ID AS INT)";

            using (SqlCommand cmd = new SqlCommand(query, conexao.ObjectoConexao)) 
         
            {
                cmd.Parameters.AddWithValue("@Nome", "%" + nome + "%");
                cmd.Parameters.AddWithValue("@ID", nome);

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }

            return dt;
        }

        public DataTable PesquisarAnimalcomChaveVacina(string nome)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select AnimalID,Nome,Especie,Raca, Cor,Estado, DataNascimento, sexo,Porte,Peso from Animal where nome like '%" + nome.ToString() + "%'", conexao.ObjectoConexao);
            da.Fill(dt);
            da.Dispose();
            return dt;

        }
        public DataTable PesquisarAnimalcomChaveExame(string nome)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select a.AnimalID as 'Código do Animal',a.Nome as 'Nome do Animal',a.Especie as Espécie,a.Raca as Raça, a.Cor,a.Estado, a.DataNascimento as 'Data Nascimento', a.sexo as Sexo,a.Porte,a.Peso ,p.ProprietarioID as 'Código Proprietário',concat(p.nome,' ',p.Sobrenome,' ',p.Apelido) as 'Nome Completo',e.Provincia as Província,e.Municipio as Município,e.Cidade,e.Bairro,e.Rua,e.Email from  proprietario p inner JOIN  Animal a on p.ProprietarioID=a.ProprietarioID INNER JOIN Endereco e on e.EnderecoID=p.EnderecoID where a.nome like '%" + nome.ToString() + "%'", conexao.ObjectoConexao);
            da.Fill(dt);
            da.Dispose();
            return dt;
        }

        public string PesquisarNomeProprietarioVacinaComCodigo(int codigo)
        {
            
                string informacoes = string.Empty;

                using (SqlCommand cmd = new SqlCommand("SELECT p.Nome, p.Sobrenome, p.Apelido FROM Proprietario p, Animal a WHERE p.ProprietarioID = a.ProprietarioID AND a.AnimalID = @Codigo", conexao.ObjectoConexao))
                {
                    cmd.Parameters.AddWithValue("@Codigo", codigo);

                    try
                    {
                        conexao.ObjectoConexao.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            // Recupere os valores das colunas Nome, Sobrenome e Apelido
                            string nome = reader["Nome"].ToString();
                            string sobrenome = reader["Sobrenome"].ToString();
                            string apelido = reader["Apelido"].ToString();

                            // Concatene os valores
                            informacoes = $"{nome} {sobrenome} ({apelido})";
                        }

                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    finally
                    {
                        conexao.ObjectoConexao.Close();
                    }
                }

                return informacoes;
            }


            //string nome = string.Empty;

            //using (SqlCommand cmd = new SqlCommand("SELECT p.Nome FROM Proprietario p, Animal a WHERE p.ProprietarioID = a.ProprietarioID AND a.AnimalID = @Codigo", conexao.ObjectoConexao))
            //{
            //    // Substitua o parâmetro @Codigo pelo valor real que você deseja pesquisar
            //    cmd.Parameters.AddWithValue("@Codigo", codigo);

            //    try
            //    {
            //        conexao.ObjectoConexao.Open();
            //        // Use ExecuteScalar para recuperar um valor único do banco de dados
            //        object resultado = cmd.ExecuteScalar();

            //        // Verifique se o resultado não é nulo antes de atribuir à variável 'nome'
            //        if (resultado != null)
            //        {
            //            nome = resultado.ToString();
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        // Lide com exceções aqui, como registro ou repropagação
            //        // Não se esqueça de fechar a conexão em caso de exceção
            //        Console.WriteLine(ex.Message);
            //    }
            //    finally
            //    {
            //        conexao.ObjectoConexao.Close();
            //    }
            //}

            //return nome;
        }



    
    }

