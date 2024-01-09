using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class BLLFuncionario
    {
        private DALConexao conexao;
        public BLLFuncionario(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloFuncionario modelo)
        {
            if (modelo.Nome.Trim().Length == 0)
            {
               throw new Exception ("Preencha o Capmo Nome do Funcionário!");
            }
            if (modelo.Sobrenome.Trim().Length == 0)
            {
                throw new Exception("Preencha o Capmo Sobrenome do Funcionário!");
            }
            if (modelo.Apelido.Trim().Length == 0)
            {
                throw new Exception("Preencha o Capmo Apelido do Funcionário!");
            }
            if (modelo.NomePai.Trim().Length == 0)
            {
                throw new Exception("Preencha o Capmo Nome do Pai do Funcionário!");
            }
            if (modelo.NomeMae.Trim().Length == 0)
            {
                throw new Exception("Preencha o Capmo Nome da Mãe do Funcionário!");
            }
            if (modelo.Cargo.Trim().Length == 0)
            {
                throw new Exception("Preencha o Capmo Cargo do Funcionário!");
            }
            if (modelo.Salario <= 0)
            {
                throw new Exception("Preencha o campo Salário do Funcionário!");
            }
            if (modelo.DataContratacao == DateTime.MinValue)
            {
                throw new Exception("Preencha o  Capmo Data de Contratação  do Funcionário!");
            }
            if (modelo.DataNascimento == DateTime.MinValue)
            {
                throw new Exception("Preencha o Capmo Data de Nascimento do Funcionário!");
            }
            if (modelo.TipoDocumento1.Trim().Length == 0)
            {
                throw new Exception("Preencha o Capmo Tipo de documento do Funcionário!");
            }
            if (modelo.NumIdentificacao.Trim().Length <= 0)
            {
                throw new Exception("Preencha o Capmo Numero de Identificação do Funcionário!");
            }
            if (modelo.DataEmissaoBI == DateTime.MinValue)
            {
                throw new Exception("Preencha o Capmo Data de emissão do Documento  do Funcionário!");
            }

            if (modelo.DataExpiracaoBI == DateTime.MinValue)
            {
                throw new Exception("Preencha o Capmo Data de Expiração do Funcionário!");
            }
            if (modelo.Nacionalidade.Trim().Length == 0)
            {
                throw new Exception("Preencha o Capmo Nacionalidade do Funcionário!");
            }
            if (modelo.GrauAcademico.Trim().Length == 0)
            {
                throw new Exception("Preencha o Capmo Grau académico do Funcionário!");
            }
            if (modelo.Nome.Trim().Length == 0)
            {
                throw new Exception("Preencha o Capmo Nome do Funcionário!");
            }
            if (modelo.EstadoCivil.Trim().Length == 0)
            {
                throw new Exception("Preencha o Capmo Estado Civil do Funcionário!");

            }
            if (modelo.EnderecoID <= 0)
            {
                throw new Exception("Preencha o Capmo Endereço do Funcionário!");
            }
            DALFuncionario Dallobj = new DALFuncionario(conexao);
            Dallobj.IncluirFuncionario(modelo);
       }

        public DataTable ExibirFuncionario(string nome)
        {
            DALFuncionario DALObj = new DALFuncionario(conexao);
            return DALObj.ExibirFuncionario(nome);
        }
    }
}
