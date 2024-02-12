using DAL;
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
        public DataTable mostrarConsultasAgendadas()
        {
            DALConsultasMarcadas dall = new DALConsultasMarcadas(conexao);
            return dall.mostrarConsultasAgendadas();

        }
    }
}
