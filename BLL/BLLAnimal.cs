using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            //if (modelo.Foto.Length == null)
            //{
            //    throw new Exception("O a foto do animal tem de ser carregada!!!");
            //}
            if (string.IsNullOrWhiteSpace(modelo.Especie1))
            {
                throw new Exception("O nome da espécie do animal deve ser informado!!!");
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
            if (modelo.sexo1.Trim().Length == 0)
            {
                throw new Exception("O Genero do animal deve ser informado!!!");
            }


            if (modelo.ProprietarioID1 <= 0)
            {
                throw new Exception("O codigo do proprietario deve ser informado!!!");
            }
            if (modelo.Observacao.Trim().Length == 0)
            {
                throw new Exception("a observacao deve  ser informado!!!");
            }
            DALLAnimal DALobj = new DALLAnimal(conexao);
            DALobj.IncluirAnimal(modelo);
        }
        public void AtualizarAnimal(ModeloAnimal modelo)
        {
            if (modelo.Nome1.Trim().Length == 0)
            {
                throw new Exception("O nome do animal deve ser informado!!!");
            }
            if (string.IsNullOrWhiteSpace(modelo.Especie1))
            {
                throw new Exception("O nome da espécie do animal deve ser informado!!!");
            }

            if (modelo.Especie1.Trim().Length == 0)
            {
                throw new Exception("O nome da especie do animal deve ser informado!!!");
            }
            if (modelo.Raca1.Trim().Length == 0)
            {
                throw new Exception("O nome da raça do Animal  deve ser informado!!!");
            }

            if (modelo.sexo1.Trim().Length == 0)
            {
                throw new Exception("O sexo  do Animal deve ser informado!!!");
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
            if (modelo.sexo1.Trim().Length == 0)
            {
                throw new Exception("O Genero do animal deve ser informado!!!");
            }
            if (modelo.AnimalID1 <= 0)
            {
                throw new Exception("O codigo do Animal deve ser informado!!!");
            }
            if (modelo.Observacao.Trim().Length == 0)
            {
                throw new Exception("a observacao deve  ser informado!!!");
            }
            DALLAnimal DALobj = new DALLAnimal(conexao);
            DALobj.AtualizarAnimal(modelo);
        }

        public DataTable PesquisarAnimalcomChave(string Nome)
        {
            DALLAnimal DALObj = new DALLAnimal(conexao);
            return DALObj.PesquisarAnimalcomChave(Nome);
        }
        public DataTable PesquisarAnimalcomChaveVacina(string Nome)
        {
            DALLAnimal DALObj = new DALLAnimal(conexao);
            return DALObj.PesquisarAnimalcomChaveVacina(Nome);
        }
        public DataTable PesquisarAnimalcomChaveExame(string Nome)
        {
            DALLAnimal DALObj = new DALLAnimal(conexao);
            return DALObj.PesquisarAnimalcomChaveExame(Nome);
        }
        public string PesquisarNomeProprietarioVacinaComCodigo(int codigo)
        {
            DALLAnimal DALObj = new DALLAnimal(conexao);
            return DALObj.PesquisarNomeProprietarioVacinaComCodigo(codigo);
        }

        public DataTable SelecionarTodosAnimal()
        {
            DALLAnimal DALObj = new DALLAnimal(conexao);
            return DALObj.SelecionarTodosAnimais();
        }
        public void EliminarAnimal(int codigo)
        {
            DALLAnimal DALObj = new DALLAnimal(conexao);
            DALObj.EliminarAnimal(codigo);

        }
    }
}
