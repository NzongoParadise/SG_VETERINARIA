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
   public  class BLLMedicamento
    {
        private DALConexao conexao;
      public  BLLMedicamento(DALConexao cx) {
            this.conexao = cx;
        }
        public void incluir(ModeloMedicamento modelo)
        {
                      
            if (modelo.NomeMedicamento.Trim().Length == 0)
            {
                throw new Exception("o Nome do Medicamento deve ser Informado!!!");
            }
            if (modelo.TipoProduto.Trim().Length == 0)
            {
                throw new Exception("o Nome do Medicamento deve ser Informado!!!");
            }
            if (modelo.FormaFarmaceutica.Trim().Length == 0)
            {
                throw new Exception("o Nome do Medicamento deve ser Informado!!!");
            }
            if (modelo.DosagemMedicamento.Trim().Length == 0)
            {
                throw new Exception("o Nome do Medicamento deve ser Informado!!!");
            }
            if (modelo.Instrucoes.Trim().Length == 0)
            {
                throw new Exception("o Nome do Medicamento deve ser Informado!!!");
            }
            if (modelo.Fabricante.Trim().Length == 0)
            {
                throw new Exception("o Nome do Medicamento deve ser Informado!!!");
            }
            if (modelo.Concentracao.Trim().Length == 0)
            {
                throw new Exception("o Nome do Medicamento deve ser Informado!!!");
            }
            if (modelo.Descricao.Trim().Length == 0)
            {
                throw new Exception("o Nome do Medicamento deve ser Informado!!!");
            }

            DALMedicamento DALobj = new DALMedicamento(conexao);
            DALobj.IncluirirMedicamento(modelo);
        }
        public void alterar(ModeloMedicamento modelo)
        {
            if (modelo.CodeMedicamento >= 0)
            {
                throw new Exception("o Nome do Medicamento deve ser Informado!!!");
            }
            if (modelo.NomeMedicamento.Trim().Length == 0)
            {
                throw new Exception("o Nome do Medicamento deve ser Informado!!!");
            }
            if (modelo.TipoProduto.Trim().Length == 0)
            {
                throw new Exception("o Nome do Medicamento deve ser Informado!!!");
            }
            if (modelo.FormaFarmaceutica.Trim().Length == 0)
            {
                throw new Exception("o Nome do Medicamento deve ser Informado!!!");
            }
            if (modelo.DosagemMedicamento.Trim().Length == 0)
            {
                throw new Exception("o Nome do Medicamento deve ser Informado!!!");
            }
            if (modelo.Instrucoes.Trim().Length == 0)
            {
                throw new Exception("o Nome do Medicamento deve ser Informado!!!");
            }
            if (modelo.Fabricante.Trim().Length == 0)
            {
                throw new Exception("o Nome do Medicamento deve ser Informado!!!");
            }
            if (modelo.Concentracao.Trim().Length == 0)
            {
                throw new Exception("o Nome do Medicamento deve ser Informado!!!");
            }
            if (modelo.Descricao.Trim().Length == 0)
            {
                throw new Exception("o Nome do Medicamento deve ser Informado!!!");
            }

            DALMedicamento DALobj = new DALMedicamento(conexao);
            DALobj.AlterarMedicamento(modelo);
        }
        public void Excluir(int codigo)
        {
            DALMedicamento DALobj = new DALMedicamento(conexao);
            DALobj.EliminarMedicamento(codigo);

        }
        public DataTable Localizar(string nome)
        {
            DALMedicamento DALobj = new DALMedicamento(conexao);
            return DALobj.Localizar(nome);
        }
    }
}
