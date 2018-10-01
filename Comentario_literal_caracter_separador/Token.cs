using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comentario_literal_caracter_separador
{
    public class Token:Comentario_fonte
    {
        public static string[] comentarios
        {
            get
            {
                string[] arrays = new string[5];
                arrays[0] = "//";
                arrays[1] = "/* */";
                arrays[2] = "/**";
                arrays[3] = "///";
                arrays[4] = "\n";
                return arrays;
            }
            set
            {
                comentarios = value;
            }

        }
        // busca somente comentario;
        public static string Idetificado(string cadeia)
        {
            string ident = cadeia != ""?ident = "erro lexico" : ident = "";
            return ident;
        }
    }
}
