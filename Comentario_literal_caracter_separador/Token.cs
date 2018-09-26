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
                string[] arrays = new string[4];
                arrays[0] = "//";
                arrays[1] = "/* */";
                arrays[2] = "/**";
                arrays[3] = "///";
                return arrays;
            }
            set
            {
                comentarios = value;
            }

        }
        // busca somente comentario;
        public static string buscar_token(string retorno)
        {
           
            string lista = "";
           /* for (int i = 0; i < comentarios.Length; i++)
            {
                if (comentarios[i] == retorno)
                {
                        token = i;
                        lista = comentarios[i];
                        break;
                }

            }
            if(lista.Equals(""))
            {
                lista = "erro lexico";
                token = -1;
            }*/
            return lista;
        }
    }
}
