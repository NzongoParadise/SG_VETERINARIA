 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DadosDaConexao
    {
        public static string StringDeConexao
        {
            get
            {
                return @"Data Source=MAURICIO-PC\SQLEXPRESS;Initial Catalog=BD_Veterinaria;Integrated Security=True;Encrypt=False";
                //return @"Data Source=BDSERVER\SQLEXPRESS;Initial Catalog=BD_Veterinaria;Integrated Security=True";
                //return @"Data Source=tcp:BDSERVER,49500;Initial Catalog=BD_Veterinaria;Integrated Security=True";
            }
        }
    }
}
