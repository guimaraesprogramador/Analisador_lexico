using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace Comentario_literal_caracter_separador
{
   public class Index:Comentario_fonte
    {
       public static string indice(string indicado, string texto)
        {
            Regex buscador = new Regex(texto);
            var math = buscador.Match(indicado);
            string a = "";
            while (math.Success)
            {
                a = math.Index.ToString();
               math =  math.NextMatch();
            }
            
            return a;
        }
    }
}
