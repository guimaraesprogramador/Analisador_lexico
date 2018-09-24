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
       public static string indice(string texto, string indicado)
        {
            string a = "";
            switch (texto)
            {
                case "/**":
                    a = "erro";
                    break;
                case "*/":
                    a = "erro";
                    break;
                default:
                    Regex buscador2 = new Regex(indicado);
                    var math2 = buscador2.Match(texto);
                    
                    if (math2.Success == false) a = "erro";
                    else
                    {
                        while (math2.Success)
                        {
                            a = math2.Index.ToString();
                            math2 = math2.NextMatch();
                        }
                    }
                   
                    break;
            }
            return a;
        }
    }
}
