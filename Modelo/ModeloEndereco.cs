using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloEndereco
    {
        private int EndrecoID;
        private string Bairro;
        private string Cidade;
        private String Rua;
        private string Email;
        private string Telefone1;
        private string Telefone2;
        private string Municipio;
        private String Provincia;
        private String Comuna;

        public ModeloEndereco(int endrecoID, string bairro, string cidade, string rua, string email, string telefone1, string telefone2, string municipio, string provincia, string comuna)
        {
            EndrecoID = endrecoID;
            Bairro = bairro;
            Cidade = cidade;
            Rua = rua;
            Email = email;
            Telefone1 = telefone1;
            Telefone2 = telefone2;
            Municipio = municipio;
            Provincia = provincia;
            Comuna = comuna;
        }
        public ModeloEndereco()
        {
            EndrecoID = 0;
            Bairro = "";
            Cidade = "";
            Rua = "";
            Email = "";
            Telefone1 = "";
            Telefone2 = "";
            Municipio = "";
            Provincia = "";
            Comuna = "";
        }


        public int EndrecoID1
        {
            get
            {
                return EndrecoID;
            }

            set
            {
                EndrecoID = value;
            }
        }

        public string Bairro1
        {
            get
            {
                return Bairro;
            }

            set
            {
                Bairro = value;
            }
        }

        public string Cidade1
        {
            get
            {
                return Cidade;
            }

            set
            {
                Cidade = value;
            }
        }

        public string Rua1
        {
            get
            {
                return Rua;
            }

            set
            {
                Rua = value;
            }
        }

        public string Email1
        {
            get
            {
                return Email;
            }

            set
            {
                Email = value;
            }
        }

        public string Telefone11
        {
            get
            {
                return Telefone1;
            }

            set
            {
                Telefone1 = value;
            }
        }

        public string Telefone21
        {
            get
            {
                return Telefone2;
            }

            set
            {
                Telefone2 = value;
            }
        }

        public string Municipio1
        {
            get
            {
                return Municipio;
            }

            set
            {
                Municipio = value;
            }
        }

        public string Provincia1
        {
            get
            {
                return Provincia;
            }

            set
            {
                Provincia = value;
            }
        }

        public string Comuna1
        {
            get
            {
                return Comuna;
            }

            set
            {
                Comuna = value;
            }
        }
    }
}
