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
    public class BLLEndereco
    {
        private DALConexao conexao;
        public BLLEndereco(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloEndereco modelo)
        {
            if (modelo.Bairro1.Trim().Length == 0)
            {
                throw new Exception("O nome do Bairro deve ser incluido");
            }
            if (modelo.Bairro1.Trim().Length == 0)
            {
                throw new Exception("O nome da cidade deve ser incluido");
            }
            if (modelo.Provincia1.Trim().Length == 0)
            {
                throw new Exception("O nome da provincia deve ser incluido");
            }
            if (modelo.Municipio1.Trim().Length == 0)
            {
                throw new Exception("O nome do Municipio deve ser incluido");
            }
            if (modelo.Rua1.Trim().Length == 0)
            {
                throw new Exception("O nome da rua ser incluido");
            }
            if (modelo.Telefone11.Trim().Length == 0)
            {
                throw new Exception("O nuemero de telefone 1 deve ser incluido");
            }
            if (modelo.Comuna1.Trim().Length == 0)
            {
                throw new Exception("O nome da comuna deve ser incluido");
            }

            //Passa os dados para fazer a inclusao dos dados no BD
            DALEndereco DALobj = new DALEndereco(conexao);
            DALobj.incluirEndereco(modelo);
        }
        public void Alterar(ModeloEndereco modelo)
        {
            if (modelo.EndrecoID1<= 0)
            {
                throw new Exception("o codigo do endereco deve ser incluido");
            }
            if (modelo.Bairro1.Trim().Length == 0)
            {
                throw new Exception("O nome do Bairro deve ser incluido");
            }
            if (modelo.Bairro1.Trim().Length == 0)
            {
                throw new Exception("O nome da cidade deve ser incluido");
            }
            if (modelo.Provincia1.Trim().Length == 0)
            {
                throw new Exception("O nome da provincia deve ser incluido");
            }
            if (modelo.Municipio1.Trim().Length == 0)
            {
                throw new Exception("O nome do Municipio deve ser incluido");
            }
            if (modelo.Rua1.Trim().Length == 0)
            {
                throw new Exception("O nome da rua ser incluido");
            }
            if (modelo.Telefone11.Trim().Length == 0)
            {
                throw new Exception("O nuemero de telefone 1 deve ser incluido");
            }
            if (modelo.Comuna1.Trim().Length == 0)
            {
                throw new Exception("O nome da comuna deve ser incluido");
            }
            //Passa os dados para fazer a inclusao dos dados no BD
            DALEndereco DALobj = new DALEndereco(conexao);
            DALobj.AlterarEndereco(modelo);
        }
        public void EliminarEndereco(int cod)
        {
            DALEndereco DALobj = new DALEndereco(conexao);
            DALobj.EliminarEndereco(cod);
        }
        public DataTable Localizar(string nome)
        {
            DALEndereco DALObj = new DALEndereco(conexao);
            return DALObj.Localizar(nome);
        }
    }
}
