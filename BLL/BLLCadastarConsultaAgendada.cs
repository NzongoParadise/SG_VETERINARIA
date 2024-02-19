using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLCadastarConsultaAgendada
    {
        public DALConexao conexao;
        public BLLCadastarConsultaAgendada(DALConexao cx)
        {
            this.conexao = cx;
        }
        public DataTable mostrarConsultasAgendadas()
        {
            DALCadastarConsultaAgendada dall = new DALCadastarConsultaAgendada(conexao);
            return dall.mostrarConsultasAgendadas();

        }
        public DataTable mostrarConsultasAgendadasPorData(DateTime inicial, DateTime final)
        {
            DALCadastarConsultaAgendada dall = new DALCadastarConsultaAgendada(conexao);
            return dall.mostrarConsultasAgendadasPorData(inicial, final);

        }
        public DataTable mostrarConsultasAgendadasPorVeterinario(int codigo)
        {
            DALCadastarConsultaAgendada dall = new DALCadastarConsultaAgendada(conexao);
            return dall.mostrarConsultasAgendadasPorVeterinario(codigo);

        }
        public DataTable mostrarConsultasHoje(DateTime dataHoje)
        {
            DALCadastarConsultaAgendada dall = new DALCadastarConsultaAgendada(conexao);
            return dall.mostrarConsultasHoje(dataHoje);

        }
        public DataTable mostrarConsultasOntem(DateTime dataOntem)
        {
            DALCadastarConsultaAgendada dall = new DALCadastarConsultaAgendada(conexao);
            return dall.mostrarConsultasOntem(dataOntem);

        }
        public DataTable mostrarConsultasAmanha(DateTime dataAmanha)
        {
            DALCadastarConsultaAgendada dall = new DALCadastarConsultaAgendada(conexao);
            return dall.mostrarConsultasAmanha(dataAmanha);

        }
        public DataTable mostrarConsultasSemana(DateTime dataSemana)
        {
            DALCadastarConsultaAgendada dall = new DALCadastarConsultaAgendada(conexao);
            return dall.mostrarConsultasSemana(dataSemana);

        }
        public DataTable mostrarConsultasMes(DateTime dataMes)
        {
            DALCadastarConsultaAgendada dall = new DALCadastarConsultaAgendada(conexao);
            return dall.mostrarConsultasMes(dataMes);

        }
        public DataTable mostrarConsultasEmAndamento()
        {
            DALCadastarConsultaAgendada dall = new DALCadastarConsultaAgendada(conexao);
            return dall.mostrarConsultasEmAndamento();

        }
        public DataTable mostrarConsultasAgendadasSoMarcadas()
        {
            DALCadastarConsultaAgendada dall = new DALCadastarConsultaAgendada(conexao);
            return dall.mostrarConsultasSoMarcadas();

        }
        public DataTable mostrarConsultasCanceladas()
        {
            DALCadastarConsultaAgendada dall = new DALCadastarConsultaAgendada(conexao);
            return dall.mostrarConsultasCanceladas();

        }
        public void CadastarConsultaAgendada(ModeloCadastrarConsultaAgendada modelo)
        {
            if (modelo.funcionarioID <= 0)
            {
                throw new Exception("Por favor selecione o veterinário responsavel pelo serviço.");
            }
            else if(modelo.animalID<=0)
            {
                throw new Exception("Por favor Selecione o Animal para a consulta.");

            }
            else if (modelo.tipoAgendamento.Trim().Length==0)
            {
                throw new Exception("Por favor Selecione o tipo de agendamento.");

            }
            else if (modelo.status.Trim().Length == 0)
            {
                throw new Exception("Por favor Selecione do agendamento.");

            }
            else if (modelo.gravidade.Trim().Length == 0)
            {
                throw new Exception("Por favor Selecione o tipo do Animal.");

            } else if (modelo.tipoAgendamento.Trim().Length==0)
            {
                throw new Exception("Por favor Selecione o tipo de agendamento.");

            }
            DALCadastarConsultaAgendada dall=new DALCadastarConsultaAgendada(conexao);
            dall.CadastarConsultaAgendada(modelo);

        }
        public bool VerificarDisponibilidadeConsulta(ModeloCadastrarConsultaAgendada modelo)
        {
              DALCadastarConsultaAgendada dall = new DALCadastarConsultaAgendada(conexao);
            return dall.VerificarDisponibilidadeConsulta(modelo);

        }

        public void updateConsultaAgendada(ModeloCadastrarConsultaAgendada modelo)
        {
            if (modelo.funcionarioID <= 0)
            {
                throw new Exception("Por favor selecione o veterinário responsavel pelo serviço.");
            }
            else if (modelo.animalID <= 0)
            {
                throw new Exception("Por favor Selecione o Animal para a consulta.");

            }
            else if (modelo.tipoAgendamento.Trim().Length == 0)
            {
                throw new Exception("Por favor Selecione o tipo de agendamento.");

            }
            else if (modelo.status.Trim().Length == 0)
            {
                throw new Exception("Por favor Selecione do agendamento.");

            }
            else if (modelo.gravidade.Trim().Length == 0)
            {
                throw new Exception("Por favor Selecione o tipo do Animal.");

            }
            else if (modelo.tipoAgendamento.Trim().Length == 0)
            {
                throw new Exception("Por favor Selecione o tipo de agendamento.");

            }
            DALCadastarConsultaAgendada dall = new DALCadastarConsultaAgendada(conexao);
            dall.updateConsultaAgendada(modelo);

        }
    }
}
