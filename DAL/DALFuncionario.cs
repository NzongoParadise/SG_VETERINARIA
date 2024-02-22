using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Windows.Forms;

namespace DAL
{
    public class DALFuncionario
    {
        private DALConexao conexao;
        
        public DALFuncionario(DALConexao cx)
        {
            this.conexao = cx;

        }
        public void EliminarFuncionario(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjectoConexao;
            cmd.CommandText = "delete from Funcionario where FuncionarioID=@FuncionarioID";
            cmd.Parameters.AddWithValue("@FuncionarioID", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
        }
        public void IncluirFuncionario(ModeloFuncionario modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjectoConexao;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Insert_procedure_Funcionario";

            cmd.Parameters.AddWithValue("@Nome", modelo.Nome);
            cmd.Parameters.AddWithValue("@Sobrenome", modelo.Sobrenome);
            cmd.Parameters.AddWithValue("@Apelido", modelo.Apelido);
            cmd.Parameters.AddWithValue("@sexo", modelo.Sexo);
            cmd.Parameters.AddWithValue("@NomePai", modelo.NomePai);
            cmd.Parameters.AddWithValue("@NomeMae", modelo.NomeMae);
            cmd.Parameters.AddWithValue("@Cargo", modelo.Cargo);
            cmd.Parameters.AddWithValue("@Salario", modelo.Salario);
            cmd.Parameters.AddWithValue("@DataContratacao", modelo.DataContratacao);
            cmd.Parameters.AddWithValue("@DataNascimento", modelo.DataNascimento);
            cmd.Parameters.AddWithValue("@TipoDocumento", modelo.TipoDocumento1);
            cmd.Parameters.AddWithValue("@NumIdentificacao", modelo.NumIdentificacao);
            cmd.Parameters.AddWithValue("@DataEmissaoBI", modelo.DataEmissaoBI);
            cmd.Parameters.AddWithValue("@DataExpiracaoBI", modelo.DataExpiracaoBI);
            cmd.Parameters.AddWithValue("@Nacionalidade", modelo.Nacionalidade);
            cmd.Parameters.AddWithValue("@GrauAcademico", modelo.GrauAcademico);
            cmd.Parameters.AddWithValue("@EstadoCivil", modelo.EstadoCivil);
            cmd.Parameters.AddWithValue("@Observacao", modelo.Observacao);
            cmd.Parameters.AddWithValue("@EnderecoID", modelo.EnderecoID);
            cmd.Parameters.Add("@Foto", System.Data.SqlDbType.Image);
            if (modelo.Foto == null)
            {
                cmd.Parameters["@Foto"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@Foto"].Value = modelo.Foto;

            }

            try
            {
                conexao.Conectar();
                cmd.ExecuteNonQuery();
                // Se deseja obter o ID do funcionário inserido
                 modelo.FuncionarioID = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                // Trate a exceção aqui
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Desconectar();
            }
        }
        public void ActualizarFuncionario(ModeloFuncionario modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjectoConexao;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "procedure_Atualizar_Funcionario";

            cmd.Parameters.AddWithValue("@FuncionarioID", modelo.FuncionarioID);
            cmd.Parameters.AddWithValue("@Nome", modelo.Nome);
            cmd.Parameters.AddWithValue("@Sobrenome", modelo.Sobrenome);
            cmd.Parameters.AddWithValue("@Apelido", modelo.Apelido);
            cmd.Parameters.AddWithValue("@sexo", modelo.Sexo);
            cmd.Parameters.AddWithValue("@NomePai", modelo.NomePai);
            cmd.Parameters.AddWithValue("@NomeMae", modelo.NomeMae);
            cmd.Parameters.AddWithValue("@Cargo", modelo.Cargo);
            cmd.Parameters.AddWithValue("@Salario", modelo.Salario);
            cmd.Parameters.AddWithValue("@DataContratacao", modelo.DataContratacao);
            cmd.Parameters.AddWithValue("@DataNascimento", modelo.DataNascimento);
            cmd.Parameters.AddWithValue("@TipoDocumento", modelo.TipoDocumento1);
            cmd.Parameters.AddWithValue("@NumIdentificacao", modelo.NumIdentificacao);
            cmd.Parameters.AddWithValue("@DataEmissaoBI", modelo.DataEmissaoBI);
            cmd.Parameters.AddWithValue("@DataExpiracaoBI", modelo.DataExpiracaoBI);
            cmd.Parameters.AddWithValue("@Nacionalidade", modelo.Nacionalidade);
            cmd.Parameters.AddWithValue("@GrauAcademico", modelo.GrauAcademico);
            cmd.Parameters.AddWithValue("@EstadoCivil", modelo.EstadoCivil);
            cmd.Parameters.AddWithValue("@Observacao", modelo.Observacao);
            cmd.Parameters.AddWithValue("@EnderecoID", modelo.EnderecoID);
            cmd.Parameters.Add("@Foto", System.Data.SqlDbType.Image);
            if (modelo.Foto == null)
            {
                cmd.Parameters["@Foto"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@Foto"].Value = modelo.Foto;

            }

            try
            {
                conexao.Conectar();
                cmd.ExecuteNonQuery();
                // Se deseja obter o ID do funcionário inserido
                modelo.FuncionarioID = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                // Trate a exceção aqui
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Desconectar();
            }
        }
        //public DataTable PesquisarFuncionarioComChave01(String keyword)
        //{
        //    DataTable dt = new DataTable();
        //    SqlDataAdapter da = new SqlDataAdapter(" select Nome,Sobrenome,Apelido,sexo,NomePai,NomeMae,Cargo,Salario,DataContratacao,DataNascimento,TipoDocumento,NumIdentificacao,DataEmissaoBI,DataExpiracaoBI,Nacionalidade,foto,GrauAcademico,EstadoCivil,Observacao,EnderecoID, FuncionarioID from Funcionario where Nome like'%" + keyword.ToString() + "%'", conexao.ObjectoConexao);
        //    da.Fill(dt);
        //    da.Dispose();
        //    return dt;
        //}
        public DataTable PesquisarFuncionarioComChave(String keyword)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(" select Nome,FuncionarioID from Funcionario where Nome like'%" + keyword.ToString() + "%'", conexao.ObjectoConexao);
            da.Fill(dt);
            da.Dispose();
            return dt;
        }
        
        public DataTable PesquisarFuncionarioComChaveVacina(String keyword)
        {
            DataTable dt = new DataTable();
            string query = "SELECT FuncionarioID as 'Código Funcionário', CONCAT(Nome, ' ', Sobrenome, ' ', Apelido) AS 'Nome Completo',Especialidade,GrauAcademico as 'Grau Academico' FROM Funcionario WHERE Nome LIKE @keyword ";
            using (SqlConnection con = new SqlConnection(conexao.StringConexao))
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }
        public DataTable PesquisarFuncionarioComChavePesagem(String keyword)
        {
            DataTable dt = new DataTable();
            string query = "SELECT FuncionarioID as 'Código Funcionário', CONCAT(Nome, ' ', Sobrenome, ' ', Apelido) AS 'Nome Completo',Especialidade,GrauAcademico as 'Grau Academico' FROM Funcionario WHERE Nome LIKE @keyword ";
            using (SqlConnection con = new SqlConnection(conexao.StringConexao))
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }



        public ModeloCadastrarConsultaAgendada buscarFuncionarioConsultasAgendadas(int codigo)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(conexao.StringConexao))
            {
                SqlCommand cmd = new SqlCommand("select FuncionarioID, Nome, Sobrenome, Apelido from Funcionario WHERE FuncionarioID=@codigo", con);
                cmd.Parameters.AddWithValue("@codigo", codigo);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            ModeloCadastrarConsultaAgendada modeloFuncionario = new ModeloCadastrarConsultaAgendada();
            if (dt.Rows.Count > 0)
            {
                modeloFuncionario.funcionarioID = Convert.ToInt16(dt.Rows[0]["FuncionarioID"]);
                modeloFuncionario.nomeFuncionario = $"{dt.Rows[0]["Nome"]} {dt.Rows[0]["Sobrenome"]} {dt.Rows[0]["Apelido"]}";
            }
            return modeloFuncionario;
        }

        public DataTable ExibirTodosFuncionarios()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(" select *from  Funcionario", conexao.ObjectoConexao);
            da.Fill(dt);
            da.Dispose();
            return dt;
        }

    }
}
