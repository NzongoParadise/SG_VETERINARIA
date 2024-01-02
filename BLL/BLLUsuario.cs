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
    public class BLLUsuario
    {
        private DALConexao conexao;
        public BLLUsuario(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloUsuario modelo)
        {
            if (modelo.Usuario.Trim().Length == 0)
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
