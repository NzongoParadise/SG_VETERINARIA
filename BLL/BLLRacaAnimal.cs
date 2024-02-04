using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{

    public class BLLRacaAnimal
    {
        private DALConexao conexao;
        public BLLRacaAnimal(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void EliminarRaca(int codigo)
        {
            DALRaca DALObj = new DALRaca(conexao);
            DALObj.EliminarRaca(codigo);

        }
        public DataTable selecionanarTodasRacas()
        {
            DALRaca DALObj = new DALRaca(conexao);
            return DALObj.selecionanarTodasRacas();

        }

        public void atualizarrRaca(ModeloRacaAnimal modelo)
        {
            if (modelo.nomeRaca.Trim().Length == 0)
            {
                throw new Exception("informa o nome da Raça do animal antes de cadastrar");
            }
            DALRaca dal = new DALRaca(conexao);
            dal.atualizarRaca(modelo);
        }

        public void incluirRaca(ModeloRacaAnimal modelo)
        {
            if (modelo.nomeRaca.Trim().Length== 0)
            {
                throw new Exception("informa o nome da Raça do animal antes de cadastrar");
            } 
            DALRaca dal = new DALRaca(conexao);
            dal.cadastrarRaca(modelo);
        }
        public DataTable PesquisarRacacomChave(string Nome)
        {
            DALRaca DALObj = new DALRaca(conexao);
            return DALObj.PesquisarRacacomChave(Nome);
        }
   
    }
}
