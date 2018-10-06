using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace Comentario_literal_caracter_separador
{
   public class Index
    {
       public static List<string> indice(string texto, int localizado)
        {
            List<string> array_lista = new List<string>();
            string restaura_texto = null;
            string[] erro =  { "erro" };
            int eol = texto.IndexOf("\\") == 0 ? eol = 0 : eol = -1;
            if (eol == 0) {
               string caracter = restaura_texto = texto.Substring(eol);
                array_lista.Add(caracter + " posicao " + localizado);
            }
            else
            {

            }

               
            
            return a;
        }
    }
}
