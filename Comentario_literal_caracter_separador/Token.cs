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
                string[] arrays = new string[20];
                arrays[0] = "/**";
                arrays[1] = "///";
                arrays[2] = "<summary>";
                arrays[3] = "<c>";
                arrays[4] = "<code>";
                arrays[5] = "<example>";
                arrays[6] = "<exception>";
                arrays[7] = "<include>";
                arrays[8] = "<para>";
                arrays[9] = "<paramref>";
                arrays[10] = "<permission>";
                arrays[11] = "<remarks>";
                arrays[12] = "<returns>";
                arrays[13] = "<see>";
                arrays[14] = "<seealso>";
                arrays[15] = "<typeparam>";
                arrays[16] = "<typeparamref>";
                arrays[17] = "<value>";
                arrays[18] = "<list>";
                arrays[19] = "<param>";
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
            for (int i = 0; i < comentarios.Length; i++)
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
            }
            return lista;
        }
        public static int contar_caracter(int numero)
        {
            int soma = 0;
            for(int o = 0; o < numero; o++)
            {
                soma += o;
                o++;
            }
            return soma;
        }
    }
}
