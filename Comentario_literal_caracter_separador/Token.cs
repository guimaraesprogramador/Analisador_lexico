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
                arrays[1] = "/*";
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
        public static char[] buscar_token(char[] cadeia)
        {

            char lista = '0';
            string concat = "";
            char[] lista_array = cadeia.ToArray();
            for(int i = 0; i < cadeia.Length; i++)
            {
                concat= concat + cadeia[i];
                if (char.IsLetter(cadeia[i]))
                {
                    lista_array[i] = lista;
                   i = i + 1;
                  
                }
                else
                {
                    switch (concat)
                    {
                        case "\r":
                            lista_array[i] = lista;
                            continue;
                        case "\n":
                            lista_array[i] = lista;
                            continue;
                        default:
                            lista_array[i] = cadeia[i];
                            break;
                    }
                }
            }
            return lista_array;
        }
    }
}
