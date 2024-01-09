using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLFuncionario
    {
        private DALConexao conexao;
        public BLLFuncionario(DALConexao cx)
        {
            this.conexao = cx;
        }

        public DataTable LocalizarFuncionario(string nome)
        {
            DALFuncionario DALObj = new DALFuncionario(conexao);
            return DALObj.localizarFuncionario(nome);
        }
    }
}
