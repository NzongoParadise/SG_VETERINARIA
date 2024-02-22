using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    
    public  class BLLPesagem
    {
        private DALConexao conexao;
        public BLLPesagem(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void IncluirPesagem(ModeloPesagem modelo)
        { 
            if (modelo.AnimalID == 0)
            {
                throw new Exception("Informe o Codigo do anaimal.");
            }else if(modelo.FuncionarioID == 0)
            {
                throw new Exception("Informe o Codigo do Funcionário.");
            }
            else if (modelo.peso==0)
            {
                throw new Exception("Informe o peso do Animal.");
            }

            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            DALPesagem dall=new DALPesagem(cx);
           
            dall.incluirPesagem(modelo);
        }

        public DataTable PesquisarPesoComChave(string codigo)
        {
            DALPesagem DALObj = new DALPesagem(conexao);
            return DALObj.PesquisarPesocomChave(codigo);
        }
        public DataTable PesquisarPesoComChaveNomesIdade(string codigo)
        {
            DALPesagem DALObj = new DALPesagem(conexao);
            return DALObj.PesquisarPesocomChaveNomesIdade(codigo);
        }



    }
}
