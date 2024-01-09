using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLUsuario
    {
        private DALConexao conexao;
        public BLLUsuario(DALConexao cx)
        {
            this.conexao = cx;
        }
        //public DataTable LocalizarFuncionario(string nome)
        //{
        //    DALFuncionario DALObj = new DALFuncionario(conexao);
        //    return DALObj.localizarFuncionario(nome);
        //}
        public void AlterarUsuario(ModeloUsuario modelo)
        {
            if (modelo.UsuarioID<= 0)
            {
                throw new Exception("O codigo do Usuario deve ser informado!!!");
            }
            if (modelo.NomeFuncionario.Trim().Length == 0)
            {
                throw new Exception("O nome do Funcionario deve ser informado!!!");
            }

            if (modelo.NomeUsuario.Trim().Length == 0)
            {
                throw new Exception("O nome do Usuario deve ser informado!!!");
            }
            if (modelo.Senha.Trim().Length == 0)
            {
                throw new Exception("A senha do Usuario deve ser informado!!!");
            }
            if (modelo.Perfil.Trim().Length == 0)
            {
                throw new Exception("O perfil do Usuario deve ser informado!!!");
            }

            DALUsuario DALObj = new DALUsuario(conexao);
            DALObj.AlterarUsuario(modelo);

        }

        public void Excluir(int codigo)
        {
            DALUsuario DALObj = new DALUsuario(conexao);
            DALObj.EliminarUsuario(codigo);

        }

       



        public void Incluir(ModeloUsuario modelo)
        {
            if (modelo.NomeUsuario.Trim().Length == 0)
            {
                throw new Exception("preencha o campo de usuario");
            }
            if (modelo.Senha.Trim().Length == 0)
            {
                throw new Exception("preencha o campo de senha");
            }
            if (modelo.Perfil.Trim().Length == 0)
            {
                throw new Exception("preencha o campo de perfill");
            }
            if(modelo.NomeFuncionario.Trim().Length == 0)
            {
                throw new Exception("Preencha o campo do Nome do Funcionario");
            }
            DALUsuario DALobj = new DALUsuario(conexao);
            DALobj.incluirUsuario(modelo);
        }
        public DataTable LocalizarUsuarioLogin(string login, String senha)
        {
            DALUsuario DALobj = new DALUsuario(conexao);
            return DALobj.LocalizarUsuarioLogin(login, senha);
        }
        public DataTable Localizar(string nome)
        {
            DALUsuario DALobj = new DALUsuario(conexao);
            return DALobj.Localizar(nome);
        }
        public ModeloUsuario CarregarModelUsuario(int codigo)
        {
            DALUsuario DALobj = new DALUsuario(conexao);
            return DALobj.CarregarModeloUsuario(codigo);
        }
    }
}
