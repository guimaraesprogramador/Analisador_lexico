using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Globalization;

namespace Comentario_literal_caracter_separador
{
   public class Index
    {
       public static string[] indice(string texto, int localizado)
        {
            string[] array_lista = new string[2];
            string[] erro =  { "erro" };
            List<string> linha_posicao = new List<string>();
            array_lista[0] = localizado.ToString();
           for(int i = 0; i < Comentario_fonte.token.Length; i++)
            {
                if(Comentario_fonte.token[i] != null)
                {
                    array_lista[1] = "linha " + i;
                    Comentario_fonte.token[i] = null;
                    break;
                }
                
            }

            return array_lista;
        }
      
    }
}
