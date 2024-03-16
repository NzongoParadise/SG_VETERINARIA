using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class DALCadastarConsultaAgendada
    {
        public DALConexao conexao;
        public DALCadastarConsultaAgendada(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void CadastarConsultaAgendada(ModeloCadastrarConsultaAgendada modelo)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjectoConexao;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "Insert_procedure_CadastrarCosultaAgendada";


                cmd.Parameters.AddWithValue("@DataAgendamento", modelo.dataMarcada);
                cmd.Parameters.AddWithValue("@FuncionarioID", modelo.funcionarioID);
                cmd.Parameters.AddWithValue("@UsuarioID", modelo.UsuarioID);
                cmd.Parameters.AddWithValue("@AnimalID", modelo.animalID);
                cmd.Parameters.AddWithValue("@TipoAgendamento", modelo.tipoAgendamento);
                cmd.Parameters.AddWithValue("@Observacoes", modelo.Obs);
                cmd.Parameters.AddWithValue("@StatusAgendamento", modelo.status);
                cmd.Parameters.AddWithValue("@Gravidade", modelo.gravidade);
                cmd.Parameters.AddWithValue("@HoraInicial", modelo.horaInicial);
                cmd.Parameters.AddWithValue("@HoraFinal", modelo.horaFinal);
                conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();

            }
            catch (Exception erro)
            {

                throw new Exception("Falha ao Cadastrar os dados no Banco de Dados:" + erro.Message);
            }
        }
        public void updateConsultaAgendada(ModeloCadastrarConsultaAgendada modelo)
        {
            try
            {


                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjectoConexao;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "procedure_Atualizar_ConsultaAgendada";

                cmd.Parameters.AddWithValue("@DataAgendamento", modelo.dataMarcada);
                cmd.Parameters.AddWithValue("@FuncionarioID", modelo.funcionarioID);
                cmd.Parameters.AddWithValue("@UsuarioID", modelo.UsuarioID);
                cmd.Parameters.AddWithValue("@AnimalID", modelo.animalID);
                cmd.Parameters.AddWithValue("@TipoAgendamento", modelo.tipoAgendamento);
                cmd.Parameters.AddWithValue("@Observacoes", modelo.Obs);
                cmd.Parameters.AddWithValue("@StatusAgendamento", modelo.status);
                cmd.Parameters.AddWithValue("@Gravidade", modelo.gravidade);
                cmd.Parameters.AddWithValue("@HoraInicial", modelo.horaInicial);
                cmd.Parameters.AddWithValue("@HoraFinal", modelo.horaFinal);
                cmd.Parameters.AddWithValue("@AgendamentoID", modelo.agendamentoID);

                conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();

            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao actualizar os dados na base dedados: " + ex.Message);
            }
        }

        public DataTable mostrarConsultasAgendadas()
        {
            DataTable dt = new DataTable();
            //SqlDataAdapter da = new SqlDataAdapter("SELECT a.AgendamentoID, an.AnimalID, a.DataAgendamento,f.Nome, a.TipoAgendamento, a.StatusAgendamento, a.Gravidade, a.HoraInicial, a.HoraFinal, e.Telefone1from agendamento a INNER join Animal an on a.AnimalID = an.AnimalID inner JOINFuncionario f on a.FuncionarioID = f.FuncionarioID INNER join Usuario u on a.UsuarioID = u.UsuarioID inner JOIN proprietario p on an.ProprietarioID = p.ProprietarioID inner join Endereco e on p.EnderecoID = e.EnderecoID", conexao.ObjectoConexao);
            SqlDataAdapter da = new SqlDataAdapter("SELECT a.AgendamentoID as Código,an.AnimalID as 'Código Animal',an.Nome as 'Nome do Animal', f.FuncionarioID as 'Código Veterinário', CONCAT(f.Nome,' ',f.Sobrenome,' ',f.Apelido ) as 'Veterinário', a.DataAgendamento as 'Data Marcada', a.TipoAgendamento as Tipo,\r\na.StatusAgendamento as Situação,a.Gravidade, a.HoraInicial as Início, a.HoraFinal as Fim, e.Telefone1 as Contacto,\r\n-- Cálculo da diferença em minutos\r\n  DATEDIFF(MINUTE, a.horaInicial, a.horaFinal) AS 'Duração(minutos)',\r\n  -- Determinação do período\r\n  CASE\r\n    WHEN a.horaInicial < '12:00:00' THEN 'Manhã'\r\n    WHEN a.horaInicial < '18:00:00' THEN 'Tarde'\r\n    ELSE 'Noite'\r\n  END AS Período,\r\n  -- Cálculo da diferença em dias\r\n  DATEDIFF(DAY, a.DataCadastro, a.dataAgendamento) AS 'Dias Restante' \r\nfrom agendamento a INNER join Animal an on a.AnimalID= an.AnimalID inner JOIN \r\nFuncionario f on a.FuncionarioID=f.FuncionarioID INNER join Usuario u on a.UsuarioID=u.UsuarioID\r\ninner JOIN proprietario p on an.ProprietarioID=p.ProprietarioID inner join Endereco e on p.EnderecoID=e.EnderecoID\r\n", conexao.ObjectoConexao);
            da.Fill(dt);
            da.Dispose();
            return dt;
        }
        public DataTable mostrarConsultasAgendadasPorData(DateTime inicial, DateTime final)
        {
            DataTable dt = new DataTable();
            string query = @"
        SELECT 
            a.AgendamentoID as Código,
            an.AnimalID as 'Código Animal',
            an.Nome as 'Nome do Animal',
            f.FuncionarioID as 'Código Veterinário',
            CONCAT(f.Nome, ' ', f.Sobrenome, ' ', f.Apelido) as 'Veterinário',
            a.DataAgendamento as 'Data Marcada',
            a.TipoAgendamento as Tipo,
            a.StatusAgendamento as Situação,
            a.Gravidade, 
            a.HoraInicial as Início, 
            a.HoraFinal as Fim, 
            e.Telefone1 as Contacto,
            -- Cálculo da diferença em minutos
            DATEDIFF(MINUTE, a.horaInicial, a.horaFinal) AS 'Duração(minutos)',
            -- Determinação do período
            CASE
                WHEN a.horaInicial < '12:00:00' THEN 'Manhã'
                WHEN a.horaInicial < '18:00:00' THEN 'Tarde'
                ELSE 'Noite'
            END AS Período,
            -- Cálculo da diferença em dias
            DATEDIFF(DAY, a.DataCadastro, a.dataAgendamento) AS 'Dias Restante' 
        FROM 
            agendamento a 
            INNER JOIN Animal an ON a.AnimalID= an.AnimalID 
            INNER JOIN Funcionario f ON a.FuncionarioID=f.FuncionarioID 
            INNER JOIN Usuario u ON a.UsuarioID=u.UsuarioID
            INNER JOIN proprietario p ON an.ProprietarioID=p.ProprietarioID 
            INNER JOIN Endereco e ON p.EnderecoID=e.EnderecoID 
        WHERE 
            a.DataAgendamento >=@Inicial AND a.DataAgendamento <=@Final";
            using (SqlConnection connection = new SqlConnection(conexao.StringConexao))
               {
                using (SqlDataAdapter da = new SqlDataAdapter(query, connection))
                {
                    da.SelectCommand.Parameters.AddWithValue("@Inicial", inicial);
                    da.SelectCommand.Parameters.AddWithValue("@Final", final);

                    da.Fill(dt);
                }
            }

            return dt;
        }

        public DataTable mostrarConsultasCanceladas()
        {
            DataTable dt = new DataTable();
            string query = @"
        SELECT 
            a.AgendamentoID as Código,
            an.AnimalID as 'Código Animal',
            an.Nome as 'Nome do Animal',
            f.FuncionarioID as 'Código Veterinário',
            CONCAT(f.Nome, ' ', f.Sobrenome, ' ', f.Apelido) as 'Veterinário',
            a.DataAgendamento as 'Data Marcada',
            a.TipoAgendamento as Tipo,
            a.StatusAgendamento as Situação,
            a.Gravidade, 
            a.HoraInicial as Início, 
            a.HoraFinal as Fim, 
            e.Telefone1 as Contacto,
            -- Cálculo da diferença em minutos
            DATEDIFF(MINUTE, a.horaInicial, a.horaFinal) AS 'Duração(minutos)',
            -- Determinação do período
            CASE
                WHEN a.horaInicial < '12:00:00' THEN 'Manhã'
                WHEN a.horaInicial < '18:00:00' THEN 'Tarde'
                ELSE 'Noite'
            END AS Período,
            -- Cálculo da diferença em dias
            DATEDIFF(DAY, a.DataCadastro, a.dataAgendamento) AS 'Dias Restante' 
        FROM 
            agendamento a 
            INNER JOIN Animal an ON a.AnimalID= an.AnimalID 
            INNER JOIN Funcionario f ON a.FuncionarioID=f.FuncionarioID 
            INNER JOIN Usuario u ON a.UsuarioID=u.UsuarioID
            INNER JOIN proprietario p ON an.ProprietarioID=p.ProprietarioID 
            INNER JOIN Endereco e ON p.EnderecoID=e.EnderecoID 
        WHERE 
            StatusAgendamento='Cancelada'";
            using (SqlConnection connection = new SqlConnection(conexao.StringConexao))
            {
                using (SqlDataAdapter da = new SqlDataAdapter(query, connection))
                {
                
                    da.Fill(dt);
                }
            }

            return dt;
        }
        public DataTable mostrarConsultasAgendadasPorVeterinario(int codigo)
        {
            DataTable dt = new DataTable();
            string query = @"
        SELECT 
            a.AgendamentoID as Código,
            an.AnimalID as 'Código Animal',
            an.Nome as 'Nome do Animal',
            f.FuncionarioID as 'Código Veterinário',
            CONCAT(f.Nome, ' ', f.Sobrenome, ' ', f.Apelido) as 'Veterinário',
            a.DataAgendamento as 'Data Marcada',
            a.TipoAgendamento as Tipo,
            a.StatusAgendamento as Situação,
            a.Gravidade, 
            a.HoraInicial as Início, 
            a.HoraFinal as Fim, 
            e.Telefone1 as Contacto,
            -- Cálculo da diferença em minutos
            DATEDIFF(MINUTE, a.horaInicial, a.horaFinal) AS 'Duração(minutos)',
            -- Determinação do período
            CASE
                WHEN a.horaInicial < '12:00:00' THEN 'Manhã'
                WHEN a.horaInicial < '18:00:00' THEN 'Tarde'
                ELSE 'Noite'
            END AS Período,
            -- Cálculo da diferença em dias
            DATEDIFF(DAY, a.DataCadastro, a.dataAgendamento) AS 'Dias Restante' 
        FROM 
            agendamento a 
            INNER JOIN Animal an ON a.AnimalID= an.AnimalID 
            INNER JOIN Funcionario f ON a.FuncionarioID=f.FuncionarioID 
            INNER JOIN Usuario u ON a.UsuarioID=u.UsuarioID
            INNER JOIN proprietario p ON an.ProprietarioID=p.ProprietarioID 
            INNER JOIN Endereco e ON p.EnderecoID=e.EnderecoID 
        WHERE    

            ((StatusAgendamento='Marcada') or (StatusAgendamento='Em andamento') or (StatusAgendamento='Em espera')) and f.FuncionarioID=@FuncionarioID";
            using (SqlConnection connection = new SqlConnection(conexao.StringConexao))
            {
                using (SqlDataAdapter da = new SqlDataAdapter(query, connection))
                {
                    da.SelectCommand.Parameters.AddWithValue("@FuncionarioID",codigo);
                    da.Fill(dt);
                }
            }

            return dt;
        }
        public DataTable mostrarConsultasAgendadasExame(int keyword)
        {
            
            DataTable dt = new DataTable();
            string query = @"
        SELECT 
            a.AgendamentoID as Código,
            an.AnimalID as 'Código Animal',
            an.Nome as 'Nome do Animal',
            f.FuncionarioID as 'Código Veterinário',
            CONCAT(f.Nome, ' ', f.Sobrenome, ' ', f.Apelido) as 'Veterinário',
            a.DataAgendamento as 'Data Marcada',
            a.TipoAgendamento as Tipo,
            a.StatusAgendamento as Situação,
            a.Gravidade, 
            a.HoraInicial as Início, 
            a.HoraFinal as Fim, 
            e.Telefone1 as Contacto,
            -- Cálculo da diferença em minutos
            DATEDIFF(MINUTE, a.horaInicial, a.horaFinal) AS 'Duração(minutos)',
            -- Determinação do período
            CASE
                WHEN a.horaInicial < '12:00:00' THEN 'Manhã'
                WHEN a.horaInicial < '18:00:00' THEN 'Tarde'
                ELSE 'Noite'
            END AS Período,
            -- Cálculo da diferença em dias
            DATEDIFF(DAY, a.DataCadastro, a.dataAgendamento) AS 'Dias Restante' 
        FROM 
            agendamento a 
            INNER JOIN Animal an ON a.AnimalID= an.AnimalID 
            INNER JOIN Funcionario f ON a.FuncionarioID=f.FuncionarioID 
            INNER JOIN Usuario u ON a.UsuarioID=u.UsuarioID
            INNER JOIN proprietario p ON an.ProprietarioID=p.ProprietarioID 
            INNER JOIN Endereco e ON p.EnderecoID=e.EnderecoID 
        WHERE    

            ((StatusAgendamento='Marcada') or (StatusAgendamento='Em andamento') or (StatusAgendamento='Em espera')) and AgendamentoID=@keyword";
            using (SqlConnection connection = new SqlConnection(conexao.StringConexao))
            {
                using (SqlDataAdapter da = new SqlDataAdapter(query, connection))
                {
                    
                    da.SelectCommand.Parameters.AddWithValue("@keyword", keyword);
                      da.Fill(dt);
                    
                }
            }

            return dt;
        }

        public DataTable mostrarConsultasHoje(DateTime dataHoje)
        {
            DataTable dt = new DataTable();
            string query = @"
    SELECT 
        a.AgendamentoID as Código,
        an.AnimalID as 'Código Animal',
        an.Nome as 'Nome do Animal',
        f.FuncionarioID as 'Código Veterinário',
        CONCAT(f.Nome, ' ', f.Sobrenome, ' ', f.Apelido) as 'Veterinário',
        a.DataAgendamento as 'Data Marcada',
        a.TipoAgendamento as Tipo,
        a.StatusAgendamento as Situação,
        a.Gravidade, 
        a.HoraInicial as Início, 
        a.HoraFinal as Fim, 
        e.Telefone1 as Contacto,
        -- Cálculo da diferença em minutos
        DATEDIFF(MINUTE, a.horaInicial, a.horaFinal) AS 'Duração(minutos)',
        -- Determinação do período
        CASE
            WHEN a.horaInicial < '12:00:00' THEN 'Manhã'
            WHEN a.horaInicial < '18:00:00' THEN 'Tarde'
            ELSE 'Noite'
        END AS Período,
        -- Cálculo da diferença em dias
        DATEDIFF(DAY, a.DataCadastro, a.dataAgendamento) AS 'Dias Restante' 
    FROM 
        agendamento a 
        INNER JOIN Animal an ON a.AnimalID= an.AnimalID 
        INNER JOIN Funcionario f ON a.FuncionarioID=f.FuncionarioID 
        INNER JOIN Usuario u ON a.UsuarioID=u.UsuarioID
        INNER JOIN proprietario p ON an.ProprietarioID=p.ProprietarioID 
        INNER JOIN Endereco e ON p.EnderecoID=e.EnderecoID 
    WHERE    
         a.DataAgendamento = @dataHoje";

            using (SqlConnection connection = new SqlConnection(conexao.StringConexao))
            {
                using (SqlDataAdapter da = new SqlDataAdapter(query, connection))
                {
                    da.SelectCommand.Parameters.AddWithValue("@dataHoje", dataHoje);
                    da.Fill(dt);
                }
            }

            return dt;
        }

        public DataTable mostrarConsultasOntem(DateTime dataOntem)
        {
            DataTable dt = new DataTable();
            string query = @"
    SELECT 
        a.AgendamentoID as Código,
        an.AnimalID as 'Código Animal',
        an.Nome as 'Nome do Animal',
        f.FuncionarioID as 'Código Veterinário',
        CONCAT(f.Nome, ' ', f.Sobrenome, ' ', f.Apelido) as 'Veterinário',
        a.DataAgendamento as 'Data Marcada',
        a.TipoAgendamento as Tipo,
        a.StatusAgendamento as Situação,
        a.Gravidade, 
        a.HoraInicial as Início, 
        a.HoraFinal as Fim, 
        e.Telefone1 as Contacto,
        -- Cálculo da diferença em minutos
        DATEDIFF(MINUTE, a.horaInicial, a.horaFinal) AS 'Duração(minutos)',
        -- Determinação do período
        CASE
            WHEN a.horaInicial < '12:00:00' THEN 'Manhã'
            WHEN a.horaInicial < '18:00:00' THEN 'Tarde'
            ELSE 'Noite'
        END AS Período,
        -- Cálculo da diferença em dias
        DATEDIFF(DAY, a.DataCadastro, a.dataAgendamento) AS 'Dias Restante' 
    FROM 
        agendamento a 
        INNER JOIN Animal an ON a.AnimalID= an.AnimalID 
        INNER JOIN Funcionario f ON a.FuncionarioID=f.FuncionarioID 
        INNER JOIN Usuario u ON a.UsuarioID=u.UsuarioID
        INNER JOIN proprietario p ON an.ProprietarioID=p.ProprietarioID 
        INNER JOIN Endereco e ON p.EnderecoID=e.EnderecoID 
    WHERE    
        CONVERT(date, a.DataAgendamento) = @dataOntem";

            using (SqlConnection connection = new SqlConnection(conexao.StringConexao))
            {
                using (SqlDataAdapter da = new SqlDataAdapter(query, connection))
                {
                    da.SelectCommand.Parameters.AddWithValue("@dataOntem", dataOntem.Date);
                    da.Fill(dt);
                }
            }

            return dt;
        }

        public DataTable mostrarConsultasAmanha(DateTime dataAmanha)
        {
            DataTable dt = new DataTable();
            string query = @"
    SELECT 
        a.AgendamentoID as Código,
        an.AnimalID as 'Código Animal',
        an.Nome as 'Nome do Animal',
        f.FuncionarioID as 'Código Veterinário',
        CONCAT(f.Nome, ' ', f.Sobrenome, ' ', f.Apelido) as 'Veterinário',
        a.DataAgendamento as 'Data Marcada',
        a.TipoAgendamento as Tipo,
        a.StatusAgendamento as Situação,
        a.Gravidade, 
        a.HoraInicial as Início, 
        a.HoraFinal as Fim, 
        e.Telefone1 as Contacto,
        -- Cálculo da diferença em minutos
        DATEDIFF(MINUTE, a.horaInicial, a.horaFinal) AS 'Duração(minutos)',
        -- Determinação do período
        CASE
            WHEN a.horaInicial < '12:00:00' THEN 'Manhã'
            WHEN a.horaInicial < '18:00:00' THEN 'Tarde'
            ELSE 'Noite'
        END AS Período,
        -- Cálculo da diferença em dias
        DATEDIFF(DAY, a.DataCadastro, a.dataAgendamento) AS 'Dias Restante' 
    FROM 
        agendamento a 
        INNER JOIN Animal an ON a.AnimalID= an.AnimalID 
        INNER JOIN Funcionario f ON a.FuncionarioID=f.FuncionarioID 
        INNER JOIN Usuario u ON a.UsuarioID=u.UsuarioID
        INNER JOIN proprietario p ON an.ProprietarioID=p.ProprietarioID 
        INNER JOIN Endereco e ON p.EnderecoID=e.EnderecoID 
    WHERE    
        CONVERT(date, a.DataAgendamento) = @dataAmanha";

            using (SqlConnection connection = new SqlConnection(conexao.StringConexao))
            {
                using (SqlDataAdapter da = new SqlDataAdapter(query, connection))
                {
                    da.SelectCommand.Parameters.AddWithValue("@dataAmanha", dataAmanha.Date);
                    da.Fill(dt);
                }
            }

            return dt;
        }

        public DataTable mostrarConsultasSemana(DateTime dataSemana)
        {
            DataTable dt = new DataTable();
            string query = @"
    SELECT 
        a.AgendamentoID as Código,
        an.AnimalID as 'Código Animal',
        an.Nome as 'Nome do Animal',
        f.FuncionarioID as 'Código Veterinário',
        CONCAT(f.Nome, ' ', f.Sobrenome, ' ', f.Apelido) as 'Veterinário',
        a.DataAgendamento as 'Data Marcada',
        a.TipoAgendamento as Tipo,
        a.StatusAgendamento as Situação,
        a.Gravidade, 
        a.HoraInicial as Início, 
        a.HoraFinal as Fim, 
        e.Telefone1 as Contacto,
        -- Cálculo da diferença em minutos
        DATEDIFF(MINUTE, a.HoraInicial, a.HoraFinal) AS 'Duração(minutos)',
        -- Determinação do período
        CASE
            WHEN a.HoraInicial < '12:00:00' THEN 'Manhã'
            WHEN a.HoraInicial < '18:00:00' THEN 'Tarde'
            ELSE 'Noite'
        END AS Período,
        -- Cálculo da diferença em dias
        DATEDIFF(DAY, a.DataCadastro, a.DataAgendamento) AS 'Dias Restante' 
    FROM 
        agendamento a 
        INNER JOIN Animal an ON a.AnimalID= an.AnimalID 
        INNER JOIN Funcionario f ON a.FuncionarioID=f.FuncionarioID 
        INNER JOIN Usuario u ON a.UsuarioID=u.UsuarioID
        INNER JOIN proprietario p ON an.ProprietarioID=p.ProprietarioID 
        INNER JOIN Endereco e ON p.EnderecoID=e.EnderecoID 
    WHERE    
        a.DataAgendamento >= @inicioSemana
        AND a.DataAgendamento < DATEADD(DAY, 7, @inicioSemana)";

            using (SqlConnection connection = new SqlConnection(conexao.StringConexao))
            {
                using (SqlDataAdapter da = new SqlDataAdapter(query, connection))
                {
                    da.SelectCommand.Parameters.AddWithValue("@inicioSemana", dataSemana.Date);
                    da.Fill(dt);
                }
            }

            return dt;
        }

        public DataTable mostrarConsultasMes(DateTime dataMes)
        {
            DataTable dt = new DataTable();
            string query = @"
    SELECT 
        a.AgendamentoID as Código,
        an.AnimalID as 'Código Animal',
        an.Nome as 'Nome do Animal',
        f.FuncionarioID as 'Código Veterinário',
        CONCAT(f.Nome, ' ', f.Sobrenome, ' ', f.Apelido) as 'Veterinário',
        a.DataAgendamento as 'Data Marcada',
        a.TipoAgendamento as Tipo,
        a.StatusAgendamento as Situação,
        a.Gravidade, 
        a.HoraInicial as Início, 
        a.HoraFinal as Fim, 
        e.Telefone1 as Contacto,
        -- Cálculo da diferença em minutos
        DATEDIFF(MINUTE, a.horaInicial, a.horaFinal) AS 'Duração(minutos)',
        -- Determinação do período
        CASE
            WHEN a.horaInicial < '12:00:00' THEN 'Manhã'
            WHEN a.horaInicial < '18:00:00' THEN 'Tarde'
            ELSE 'Noite'
        END AS Período,
        -- Cálculo da diferença em dias
        DATEDIFF(DAY, a.DataCadastro, a.dataAgendamento) AS 'Dias Restante' 
    FROM 
        agendamento a 
        INNER JOIN Animal an ON a.AnimalID= an.AnimalID 
        INNER JOIN Funcionario f ON a.FuncionarioID=f.FuncionarioID 
        INNER JOIN Usuario u ON a.UsuarioID=u.UsuarioID
        INNER JOIN proprietario p ON an.ProprietarioID=p.ProprietarioID 
        INNER JOIN Endereco e ON p.EnderecoID=e.EnderecoID 
    WHERE    
        MONTH(a.DataAgendamento) = MONTH(@dataMes) 
        AND YEAR(a.DataAgendamento) = YEAR(@dataMes)";

            using (SqlConnection connection = new SqlConnection(conexao.StringConexao))
            {
                using (SqlDataAdapter da = new SqlDataAdapter(query, connection))
                {
                    da.SelectCommand.Parameters.AddWithValue("@dataMes", dataMes);
                    da.Fill(dt);
                }
            }

            return dt;
        }
        public DataTable mostrarConsultasEmAndamento()
        {
            DataTable dt = new DataTable();
            string query = @"
        SELECT 
            a.AgendamentoID as Código,
            an.AnimalID as 'Código Animal',
            an.Nome as 'Nome do Animal',
            f.FuncionarioID as 'Código Veterinário',
            CONCAT(f.Nome, ' ', f.Sobrenome, ' ', f.Apelido) as 'Veterinário',
            a.DataAgendamento as 'Data Marcada',
            a.TipoAgendamento as Tipo,
            a.StatusAgendamento as Situação,
            a.Gravidade, 
            a.HoraInicial as Início, 
            a.HoraFinal as Fim, 
            e.Telefone1 as Contacto,
            -- Cálculo da diferença em minutos
            DATEDIFF(MINUTE, a.horaInicial, a.horaFinal) AS 'Duração(minutos)',
            -- Determinação do período
            CASE
                WHEN a.horaInicial < '12:00:00' THEN 'Manhã'
                WHEN a.horaInicial < '18:00:00' THEN 'Tarde'
                ELSE 'Noite'
            END AS Período,
            -- Cálculo da diferença em dias
            DATEDIFF(DAY, a.DataCadastro, a.dataAgendamento) AS 'Dias Restante' 
        FROM 
            agendamento a 
            INNER JOIN Animal an ON a.AnimalID= an.AnimalID 
            INNER JOIN Funcionario f ON a.FuncionarioID=f.FuncionarioID 
            INNER JOIN Usuario u ON a.UsuarioID=u.UsuarioID
            INNER JOIN proprietario p ON an.ProprietarioID=p.ProprietarioID 
            INNER JOIN Endereco e ON p.EnderecoID=e.EnderecoID 
        WHERE    

           StatusAgendamento='Em andamento'";
            using (SqlConnection connection = new SqlConnection(conexao.StringConexao))
            {
                using (SqlDataAdapter da = new SqlDataAdapter(query, connection))
                {
                       da.Fill(dt);
                }
            }

            return dt;
        }

        public bool VerificarDisponibilidadeConsulta(ModeloCadastrarConsultaAgendada modelo)
        {
            try
            {

           
            // Verifica se já existe uma consulta agendada para o veterinário no mesmo horário
            bool horarioDisponivel = !ConsultaJaAgendadaNoHorario(modelo.funcionarioID,modelo.dataMarcada,modelo.horaInicial.TimeOfDay,modelo.horaFinal.TimeOfDay);
            return horarioDisponivel;
            }
            catch (Exception ex)
            {

                throw new Exception("erro ao tentar enviar os dados para o metodo:"+ex.Message);
            }
        }

        public DataTable mostrarConsultasSoMarcadas()
        {
            DataTable dt = new DataTable();
            string query = @"
        SELECT 
            a.AgendamentoID as Código,
            an.AnimalID as 'Código Animal',
            f.FuncionarioID as 'Código Veterinário',
            CONCAT(f.Nome, ' ', f.Sobrenome, ' ', f.Apelido) as 'Veterinário',
            a.DataAgendamento as 'Data Marcada',
            a.TipoAgendamento as Tipo,
            a.StatusAgendamento as Situação,
            a.Gravidade, 
            a.HoraInicial as Início, 
            a.HoraFinal as Fim, 
            e.Telefone1 as Contacto,
            -- Cálculo da diferença em minutos
            DATEDIFF(MINUTE, a.horaInicial, a.horaFinal) AS 'Duração(minutos)',
            -- Determinação do período
            CASE
                WHEN a.horaInicial < '12:00:00' THEN 'Manhã'
                WHEN a.horaInicial < '18:00:00' THEN 'Tarde'
                ELSE 'Noite'
            END AS Período,
            -- Cálculo da diferença em dias
            DATEDIFF(DAY, a.DataCadastro, a.dataAgendamento) AS 'Dias Restante' 
        FROM 
            agendamento a 
            INNER JOIN Animal an ON a.AnimalID= an.AnimalID 
            INNER JOIN Funcionario f ON a.FuncionarioID=f.FuncionarioID 
            INNER JOIN Usuario u ON a.UsuarioID=u.UsuarioID
            INNER JOIN proprietario p ON an.ProprietarioID=p.ProprietarioID 
            INNER JOIN Endereco e ON p.EnderecoID=e.EnderecoID 
        WHERE    

            StatusAgendamento='Marcada'";
            using (SqlConnection connection = new SqlConnection(conexao.StringConexao))
            {
                using (SqlDataAdapter da = new SqlDataAdapter(query, connection))
                {
                    da.Fill(dt);
                }
            }

            return dt;
        }

        // Consulta o banco de dados para verificar se já existe uma consulta agendada
        // para o veterinário no mesmo horário

        // Exemplo de conexão com o banco de dados (substitua por sua lógica real de acesso ao banco de dados)
        private bool ConsultaJaAgendadaNoHorario(int funcionarioID, DateTime dataMarcada, TimeSpan horaInicial, TimeSpan horaFinal)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(conexao.StringConexao))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Agendamento WHERE FuncionarioID = @FuncionarioID AND DataAgendamento = @DataAgendamento AND ((HoraInicial <= @HoraInicial AND HoraFinal >= @HoraInicial) OR (HoraInicial <= @HoraFinal AND HoraFinal >= @HoraFinal))", connection);
                  
                    command.Parameters.AddWithValue("@FuncionarioID", funcionarioID);
                    command.Parameters.AddWithValue("@DataAgendamento", dataMarcada);
                    command.Parameters.AddWithValue("@HoraInicial", horaInicial);
                    command.Parameters.AddWithValue("@HoraFinal", horaFinal);

                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
            catch (Exception erro)
            {
                throw new Exception("Erro ao pesquisar os dados: " + erro.Message);
            }
        }










    }

}


