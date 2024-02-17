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
    public class DALConsultasMarcadas
    {
        private DALConexao conexao;
        public DALConsultasMarcadas(DALConexao cx)
        {
            this.conexao = cx;
        }

        public ModeloCadastrarConsultaAgendada BusacarConsultaComChave(int codigo)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(conexao.StringConexao))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Agendamento WHERE AgendamentoID=@codigo", con);
                cmd.Parameters.AddWithValue("@codigo", codigo);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            ModeloCadastrarConsultaAgendada modelo = new ModeloCadastrarConsultaAgendada();
            if (dt.Rows.Count > 0)
            {

                modelo.agendamentoID = Convert.ToInt32(dt.Rows[0]["AgendamentoID"]);
                modelo.dataMarcada = Convert.ToDateTime(dt.Rows[0]["DataAgendamento"]);
                modelo.funcionarioID = Convert.ToInt16(dt.Rows[0]["FuncionarioID"]);
                modelo.UsuarioID = Convert.ToInt16(dt.Rows[0]["UsuarioID"]);
                modelo.animalID = Convert.ToUInt16(dt.Rows[0]["AnimalID"]);
                modelo.tipoAgendamento = dt.Rows[0]["TipoAgendamento"].ToString();
                modelo.Obs = dt.Rows[0]["Observacoes"].ToString();
                modelo.status = dt.Rows[0]["StatusAgendamento"].ToString();
                modelo.gravidade = dt.Rows[0]["Gravidade"].ToString();

                TimeSpan horainicial = (TimeSpan)dt.Rows[0]["HoraInicial"];
                modelo.horaInicial=new DateTime().Add(horainicial);
                TimeSpan horaFinal = (TimeSpan)dt.Rows[0]["HoraFinal"];
                modelo.horaFinal = new DateTime().Add(horaFinal);
                
                   }
            return modelo;
            
        }



    }
}
