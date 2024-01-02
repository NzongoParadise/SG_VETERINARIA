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
    public class BLLProprietario
    {
        private DALConexao conexao;
        public BLLProprietario(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloProprietario modelo)
        {
            if (modelo.Nome.Trim().Length == 0)
            {
                throw new Exception("O nome do proprietario deve ser informado!!!");
            }
            if (modelo.Sobrenome.Trim().Length == 0)
            {
                throw new Exception("o sobrenome do proprietario deve ser informado!!!");
            }
            if (modelo.Apelido.Trim().Length == 0)
            {
                throw new Exception("o apelido do proprietario deve ser informado!!!");
            }
            if (modelo.NomeMae.Trim().Length == 0)
            {
                throw new Exception("o nome da mae  deve ser informado!!!");
            }
            if (modelo.NomePai.Trim().Length== 0)
            {
                throw new Exception("o nome do pai  deve ser informado!!!");
            }
            if (modelo.NumIdnt.Trim().Length==0)
            {
                throw new Exception("o numero de identificacao deve ser Informado!!!");
            }
            if (modelo.Nacionalidade.Trim().Length == 0)
            {
                throw new Exception("a nacionalidade deve ser Informado!!!");
            }
            //if (modelo.Municipio.Trim().Length == 0)
            //{
            //    throw new Exception("o municipio deve ser Informado!!!");
            //}
            if (modelo.EnderecoID <= 0)
            {
                throw new Exception("O endereço do proprietario deve ser informado!!!");
            }
            //Passa os dados para o DALMedicament para fazer a inclusao dos dados no BD
            DALProprietario DALobj = new DALProprietario(conexao);
            DALobj.incluirProprietario(modelo);
        }
        public void Alterar(ModeloProprietario modelo)
        {
            if (modelo.PropietarioId <= 0)
            {
                throw new Exception("O ID do proprietario deve ser informado!!!");
            }

            if (modelo.Nome.Trim().Length == 0)
            {
                throw new Exception("O nome do proprietario deve ser informado!!!");
            }
            if (modelo.Sobrenome.Trim().Length == 0)
            {
                throw new Exception("o sobrenome do proprietario deve ser informado!!!");
            }
            if (modelo.Apelido.Trim().Length == 0)
            {
                throw new Exception("o apelido do proprietario deve ser informado!!!");
            }
            if (modelo.NomeMae.Trim().Length == 0)
            {
                throw new Exception("o nome da mae  deve ser informado!!!");
            }
            if (modelo.NomePai.Trim().Length == 0)
            {
                throw new Exception("o nome do pai  deve ser informado!!!");
            }
            if (modelo.NumIdnt.Trim().Length == 0)
            {
                throw new Exception("o numero de identificacao deve ser Informado!!!");
            }
            if (modelo.Nacionalidade.Trim().Length == 0)
            {
                throw new Exception("a nacionalidade deve ser Informado!!!");
            }
            if (modelo.EnderecoID <= 0)
            {
                throw new Exception("O endereço do proprietario deve ser informado!!!");
            }
            //Passa os dados para fazer a inclusao dos dados no BD
            DALProprietario DALobj = new    DALProprietario(conexao);
            DALobj.AlterarProprietario(modelo);
        }
        public void Excluir(int codigo)
        {
            DALProprietario DALObj = new DALProprietario(conexao);
            DALObj.EliminarProprietario(codigo);

        }
        public DataTable Localizar(string nome)
        {
            DALProprietario DALObj = new DALProprietario(conexao);
            return DALObj.Localizar(nome);
        }

        public DataTable LocalizarEndereco(string nome)
        {
            DALProprietario DALObj = new DALProprietario(conexao);
            return DALObj.LocalizarEndereco(nome);
        }

    }
}
