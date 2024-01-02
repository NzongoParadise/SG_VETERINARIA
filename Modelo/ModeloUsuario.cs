using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloUsuario
    {
        private int id;
        private string usuario;
        private string senha;
        private string perfil;

        public ModeloUsuario()
        {
            this.id = 0;
            this.usuario = "";
            this.senha = "";
            this.perfil = "";
        }
        public ModeloUsuario(int id, string usuario, string senha, string perfil)
        {
            this.id = id;
            this.usuario = usuario;
            this.senha = senha;
            this.perfil = perfil;
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Usuario
        {
            get
            {
                return usuario;
            }

            set
            {
                usuario = value;
            }
        }

        public string Senha
        {
            get
            {
                return senha;
            }

            set
            {
                senha = value;
            }
        }

        public string Perfil
        {
            get
            {
                return perfil;
            }

            set
            {
                perfil = value;
            }
        }
    }
}
