using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferramenta
{
    public class SessaoUsuario
    {
        public sealed class Session
        {

            private static volatile Session instance;
            private static object sync = new Object();

            private Session() { }

            public static Session Instance
            {
                get
                {
                    if (instance == null)
                    {
                        lock (sync)
                        {
                            if (instance == null)
                            {
                                instance = new Session();
                            }
                        }
                    }
                    return instance;
                }

            }

            /// <summary>
            /// Propriedade para o ID, Nome e Grupo do usuario
            /// </summary>
            public int UsuID { get; set; }
            public string UsuNome { get; set; }

            public string perfil { get; set; }


        }
    }
}
