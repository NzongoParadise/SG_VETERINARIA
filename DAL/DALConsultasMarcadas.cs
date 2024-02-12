using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALConsultasMarcadas
    {
        private DALConexao conexao;
        public DALConsultasMarcadas(DALConexao cx)
        {
            this.conexao = cx;
        }
    
        public DataTable mostrarConsultasAgendadas()
        {
            DataTable dt = new DataTable();
            //SqlDataAdapter da = new SqlDataAdapter("SELECT a.AgendamentoID, an.AnimalID, a.DataAgendamento,f.Nome, a.TipoAgendamento, a.StatusAgendamento, a.Gravidade, a.HoraInicial, a.HoraFinal, e.Telefone1from agendamento a INNER join Animal an on a.AnimalID = an.AnimalID inner JOINFuncionario f on a.FuncionarioID = f.FuncionarioID INNER join Usuario u on a.UsuarioID = u.UsuarioID inner JOIN proprietario p on an.ProprietarioID = p.ProprietarioID inner join Endereco e on p.EnderecoID = e.EnderecoID", conexao.ObjectoConexao);
            SqlDataAdapter da = new SqlDataAdapter("SELECT a.AgendamentoID,an.AnimalID,a.DataAgendamento, CONCAT(f.Nome,' ',f.Sobrenome,' ',f.Apelido ) as 'Nome Funcionario', a.TipoAgendamento,\r\na.StatusAgendamento,a.Gravidade, a.HoraInicial, a.HoraFinal, e.Telefone1,\r\n-- Cálculo da diferença em minutos\r\n  DATEDIFF(MINUTE, a.horaInicial, a.horaFinal) AS 'Duração(minutos)',\r\n  -- Determinação do período\r\n  CASE\r\n    WHEN a.horaInicial < '12:00:00' THEN 'Manhã'\r\n    WHEN a.horaInicial < '18:00:00' THEN 'Tarde'\r\n    ELSE 'Noite'\r\n  END AS periodo,\r\n  -- Cálculo da diferença em dias\r\n  DATEDIFF(DAY, a.DataCadastro, a.dataAgendamento) AS diasDiferenca\r\nfrom agendamento a INNER join Animal an on a.AnimalID= an.AnimalID inner JOIN \r\nFuncionario f on a.FuncionarioID=f.FuncionarioID INNER join Usuario u on a.UsuarioID=u.UsuarioID\r\ninner JOIN proprietario p on an.ProprietarioID=p.ProprietarioID inner join Endereco e on p.EnderecoID=e.EnderecoID\r\n", conexao.ObjectoConexao);
            da.Fill(dt);
            da.Dispose();
            return dt;
        }
        public DataTable CarregarFornecedores()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Fornecedor", conexao.ObjectoConexao);
            da.Fill(dt);
            da.Dispose();
            return dt;
        }

    }
}
