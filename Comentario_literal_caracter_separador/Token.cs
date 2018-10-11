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
        public static string[] eof
        {
            get
            {
                string[] eof_array = new string[11];
                eof_array[0] = "\'";
                eof_array[1] = "\''";
                eof_array[2] = "\\";
                eof_array[3] = "\0";
                eof_array[4] = "''";
                eof_array[5] = "\a";
                eof_array[6] = "\b";
                eof_array[7] = "\f";
                eof_array[8] = "\r";
                eof_array[9] = "\t";
                eof_array[10] = "\v";
                return eof_array;
               
            }
           set {
                eof = value;
            }
        }
        // busca somente comentario;
        public static string identicadores(string cadeia)
        {
            string ident = null;
            for (int i = 0; i < eof.Length; i++)
            {
                if (cadeia == eof[i])
                {
                    ident = eof[i];
                    break;
                }
            }
            
            return ident;
        }
    }
}
