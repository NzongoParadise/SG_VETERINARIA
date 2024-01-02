using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLAnimal
    {
        private DALConexao conexao;
        public BLLAnimal(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void incluir(ModeloAnimal modelo)
        {
            if (modelo.Nome1.Trim().Length == 0)
            {
                throw new Exception("O nome do animal deve ser informado!!!");
            }
            if (modelo.Especie1.Trim().Length == 0)
            {
                throw new Exception("O nome da especie do animal deve ser informado!!!");
            }
            if (modelo.Raca1.Trim().Length == 0)
            {
                throw new Exception("O nome da raca deve ser informado!!!");
            }
            if (modelo.Cor1.Trim().Length == 0)
            {
                throw new Exception("O a cor do animal deve ser informado!!!");
            }
            if (modelo.Peso1 <= 0)
            {
                throw new Exception("O peso do animal deve ser informado!!!");
            }
            if (modelo.Estado1.Trim().Length == 0)
            {
                throw new Exception("O estado do animal deve ser informado!!!");
            }
            if (modelo.Porte1.Trim().Length == 0)
            {
                throw new Exception("O porte do animal deve ser informado!!!");
            }
            if (modelo.ProprietarioID1<= 0)
            {
                throw new Exception("O o codigo do proprietario deve ser informado!!!");
            }
            if (modelo.Observacao.Trim().Length == 0)
            {
                throw new Exception("a observacao deve  ser informado!!!");
            }
            DALLAnimal DALobj = new DALLAnimal(conexao);
            DALobj.IncluirAnimal(modelo);


        }
    }
}
