using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLConsulta
    {
        private DALConexao conexao;
        public BLLConsulta(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void incluir(ModeloConsulta modelo)
        {

            if (modelo.Tratamento.Trim().Length == 0)
            {
                throw new Exception("o Nome do Medicamento deve ser Informado!!!");
            }
            if (modelo.Observacao.Trim().Length == 0)
            {
                throw new Exception("o Nome do Medicamento deve ser Informado!!!");
            }
            if (modelo.Diagnostico.Trim().Length == 0)
            {
                throw new Exception("o Nome do Medicamento deve ser Informado!!!");
            }
            if (modelo.DataConsulta == null)
            {
                throw new Exception("A Data da Consulta deve ser Informada!!!");
                // Or handle this situation according to your application's requirements
            }
            if (modelo.AnimalID >= 0)
            {
                throw new Exception("o Nome do Medicamento deve ser Informado!!!");
            }

            DALConsulta DALobj = new DALConsulta(conexao);
            DALobj.IncluirConsulta(modelo);
        }
        public void alterar(ModeloConsulta modelo)
        {
            if (modelo.ConsultaID >= 0)
            {
                throw new Exception("o Nome do Medicamento deve ser Informado!!!");
            }
            if (modelo.Tratamento.Trim().Length == 0)
            {
                throw new Exception("o Nome do Medicamento deve ser Informado!!!");
            }
            if (modelo.Observacao.Trim().Length == 0)
            {
                throw new Exception("o Nome do Medicamento deve ser Informado!!!");
            }
            if (modelo.Diagnostico.Trim().Length == 0)
            {
                throw new Exception("o Nome do Medicamento deve ser Informado!!!");
            }
            if (modelo.DataConsulta == null)
            {
                throw new Exception("A Data da Consulta deve ser Informada!!!");
                // Or handle this situation according to your application's requirements
            }
            if (modelo.AnimalID >= 0)
            {
                throw new Exception("o Nome do Medicamento deve ser Informado!!!");
            }

            DALConsulta DALobj = new DALConsulta(conexao);
            DALobj.AlterarConsulta(modelo);
        }
        public void Excluir(int codigo)
        {
            DALConsulta DALobj = new DALConsulta(conexao);
            DALobj.EliminarConsulta(codigo);

        }
        public DataTable Localizar(string nome)
        {
            DALConsulta DALobj = new DALConsulta(conexao);
            return DALobj.Localizar(nome);
        }
    }
}

