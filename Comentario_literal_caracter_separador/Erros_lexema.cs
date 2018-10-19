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
        private static string concatena = "";
        public static string verificar_e_um_texto_comum(char campo,char proximo,  List<string> lista)
        {
            
            if(campo=='/'&& proximo == '/')
            {
                concatena = campo.ToString() + proximo.ToString();
            }
            if (campo == '\0') return null;

             if (campo=='/'&&proximo=='*')
            {
                concatena = "/" + "*";
                
            }
            if (campo=='*'&& proximo=='/')
            {
                concatena = concatena + "*" + "/";
            }
            if(concatena == "/**/")
            {
                
                lista.Add("é comentario");
                concatena = null;
                return "esperado palavra";
            }
            else if (concatena == "//")
            {
                lista.Add("é comentario");
                concatena = null;
                return "esperado palavra";
            }
            else if (campo.ToString() == "*" || campo.ToString() == "/" || campo.ToString() == "'"
                || campo.ToString() == "/*" || campo.ToString() == "/**" ||
                campo.ToString() == @"'\" || Index.erro_lexema(proximo.ToString()) != null
              || Index.lexema(proximo.ToString()) != null || proximo == 'u'
|| proximo == 'U' || proximo == 'x') return "palavra reservada";
            return "esperado palavra";
        }
        public static string erros(char palavra, char proxima_letra ,int o)
        {
            char elemento = new char();
            if (palavra.ToString() == "/*")
            {
                int ultima_caracter_Especial = palavra;

                //nao tem outro caractar
                if (ultima_caracter_Especial == 1)
                {
                    StringBuilder.Append(palavra);
                    return null;
                }
               
            }
            // erro /**
            else if (palavra.ToString() == "/**")
            {
                int barra_final = palavra;
                // erro /**
                if (barra_final == 0)
                {
                    StringBuilder.Append(palavra);
                    return null;
                }

            }
            // ' erro
            else if (palavra.ToString() ==@"'"&& proxima_letra != '\\' && proxima_letra != '\0' 
&& Comentario_fonte.texto.Length>1)
            {
                
                    elemento = Comentario_fonte.texto[o - 1];
                int ultima_caracter_Especial2 =  elemento.ToString() != @"'\" &&
                     Index.erro_lexema(elemento.ToString())== null 
                     
                    ? Comentario_fonte.texto.Length
                    : 0;
                //nao tem outro caractar
                if (ultima_caracter_Especial2 != 0)
                {
                    StringBuilder.Append(palavra+ "outros");
                    return null;
                }
            }
            //erro de Caracter não terminado até E.O.F"
             if (palavra.ToString() == "'" && proxima_letra=='\0')
            {
                if (o>0)
                {
                    elemento = Comentario_fonte.texto[o];
                }
                if(elemento == palavra && palavra.ToString() == "'")
                {
                    StringBuilder.Append(palavra);
                    return null;
                }
               
            }
            // Erro de '\
           if(proxima_letra == '\\'&& palavra.ToString()=="'")
            {
                if (o > 0)
                {
                    elemento = Comentario_fonte.texto[o];
                }
                if (o == 0) elemento = '\\';
                if (elemento == proxima_letra)
                {
                    StringBuilder.Append(palavra+ "outros");
                    return null;
                }
            }
            // erro de ' no final do lexema separador
             else if(Index.erro_lexema(palavra.ToString()) != null&& palavra.ToString() != "'\\")
            {
                int aspas_simpes = palavra;
                if(aspas_simpes == 0)
                {
                    StringBuilder.Append("erro de metadados");
                    return null;
                }
              
                
            }
            
            // erro de \u 
            else if (@"'\u" == unicodio(palavra, proxima_letra))
            {
                var pesquisar_ultima_aspas = Comentario_fonte.texto.Length - 1;
                int ultima_aspas = pesquisar_ultima_aspas.ToString().LastIndexOf("'");
                if(ultima_aspas == -1)
                {
                    StringBuilder.Append("erro");
                    return null;
                }
            }
            //erro de \U
           /* if (@"'\U" == unicodio(palavra))
            {
                int pesquisar_no_u_maisculo_aspas_simples = palavra;
                if(pesquisar_no_u_maisculo_aspas_simples == 0)
                {
                    StringBuilder.Append("erro");
                    return null;
                }
            }*/
            // erro de \x
            /*if (@"'\x" == palavra)
            {
                
            }*/
            return palavra.ToString();
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
                    case @"'\"+ "outros":
                        palavra = "erro";
                        StringBuilder.Clear();
                        break;
                    case "erro de metadados":
                        palavra = "erro de metadados";
                        StringBuilder.Clear();
                        break;
                    case "erro":
                        palavra = "erro";
                        StringBuilder.Clear();
                        break;
                }
            }
            return palavra;
        }
        private static string concatena_unico = null;
        public static string unicodio(char palavra_anterior, char proxima_l)
        {
            if(palavra_anterior.ToString() == "'"&& proxima_l.ToString()==@"\")
            {
                concatena_unico = palavra_anterior.ToString() +proxima_l;
                return concatena_unico;
            }
            
            else if(proxima_l == 'u')
            {
                concatena_unico = concatena_unico + proxima_l;
                return concatena_unico;
            }
            
            return null;
        }
    }
}
