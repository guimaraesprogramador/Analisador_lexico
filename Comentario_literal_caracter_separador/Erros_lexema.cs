using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comentario_literal_caracter_separador
{
    public class Erros_lexema
    {
        public static StringBuilder StringBuilder = new StringBuilder();
        public static string verificar_e_um_texto_comum(string campo, List<string> lista)
        {
            if (campo.ToString() == "//")
            {
                lista.Add("é comentario");
                return "esperado palavra";
            }
            else if (campo == "") return null;
            else if (Char.IsLetter(campo[0]))
            {
                return null;
            }
            else if (campo.ToString() == "/**/")
            {
                lista.Add("é comentario");
                return "esperado palavra";
            }
            else if (campo == "*" || campo == "/" || campo == "'" 
                || campo =="/*"|| campo=="/**") return "palavra reservada";
            else if (campo == @"'\") return "lexema";
            return "esperado palavra";
        }
        public static string erros(string palavra)
        {
            if (palavra == null || char.IsLetter(palavra[0])) return null;
            if (palavra == "/*")
            {
                int ultima_caracter_Especial = Comentario_fonte.texto.LastIndexOf("*");

                //nao tem outro caractar
                if (ultima_caracter_Especial == 1)
                {
                    StringBuilder.Append(palavra);
                    return null;
                }
               
            }
            if (palavra == "*" || palavra == "/**")
            {
                if (palavra == "*") StringBuilder.Append("/*" + palavra);
                else StringBuilder.Append(palavra);
            }
            if (palavra == "'")
            {
                int ultima_caracter_Especial2 = Comentario_fonte.texto.Length > 1 ? Comentario_fonte.texto.Length
                    : 0;
                //nao tem outro caractar
                if (ultima_caracter_Especial2 == 0)
                {
                    StringBuilder.Append(palavra);
                    return null;
                }
                else
                {
                    if (palavra == "'\\") return palavra;
                    else
                    {
                        StringBuilder.Append(palavra + "outros");
                        return null;
                    }
                }
            }


            return palavra;
        }
        public static string listar_palavra_reservada()
        {
            string palavra = null;
            if (StringBuilder.ToString() != null)
            {
                switch (StringBuilder.ToString())
                {
                    case "/*":
                        palavra = "erro de bloco";
                        StringBuilder.Clear();
                        break;
                    case "/**":
                        palavra = "erro de bloco";
                        StringBuilder.Clear();
                        break;
                    case "'":
                        palavra = "Caracter não terminado até E.O.F";
                        StringBuilder.Clear();
                        break;
                    case "'" + "outros":
                        palavra = "erro";
                        StringBuilder.Clear();
                        break;
                    case "'/":
                        palavra = "erro";
                        StringBuilder.Clear();
                        break;
                }

            }
            return palavra;
        }
    }
}
