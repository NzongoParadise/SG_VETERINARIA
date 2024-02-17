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
    public  class BLLConsultasMarcadas
    {
        public DALConexao conexao;
        public BLLConsultasMarcadas(DALConexao cx)
        {
            this.conexao = cx;
        }
        public ModeloCadastrarConsultaAgendada BusacarConsultaComChave(int codigo)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            DALConsultasMarcadas dall=new DALConsultasMarcadas(cx);
            return dall.BusacarConsultaComChave(codigo);
        }


    }
}
