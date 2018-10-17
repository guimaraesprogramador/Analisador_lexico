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
            if (campo == null) return null;
            if (campo.ToString() == "//")
            {
                lista.Add("é comentario");
                return "esperado palavra";
            }
            
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
                || campo =="/*"|| campo=="/**"||
                campo == @"'\"|| Index.erro_lexema(campo) != null
              ||  Index.lexema(campo)!= null ||campo == @"'\u"
|| campo==@"'\U"|| campo ==@"'\x") return "palavra reservada";
            return "esperado palavra";
        }
        public static string erros(string palavra)
        {
            
            // /*
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
            // erro /**
            if (palavra == "/**")
            {
                int barra_final = Comentario_fonte.texto.LastIndexOf("/");
                // erro /**
                if (barra_final == 0)
                {
                    StringBuilder.Append(palavra);
                    return null;
                }

            }
            // ' erro
            if (palavra == "'"&& Comentario_fonte.texto.Length>1)
            {
                int ultima_caracter_Especial2 = Comentario_fonte.texto.Length > 1&&
                     palavra != @"'\u"&& palavra != @"\U" &&
                    palavra != @"\x" && palavra != @"'\" && Index.lexema(palavra)!= null
                    || Comentario_fonte.texto.IndexOf("'")>=1
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
             if (palavra == "'" && Comentario_fonte.texto.Length== 1)
            {
                StringBuilder.Append(palavra);
                return null;
            }
            // Erro de '\
            if(palavra == @"'\"&& Comentario_fonte.texto.Length==2)
            {
                    int procura_elemento = palavra.Length== 2 ? 1 : 0;
                if (procura_elemento == 1)
                {
                    StringBuilder.Append(palavra+ "outros");
                    return null;
                }
            }
            // erro de ' no final do lexema separador
             if(Index.erro_lexema(palavra) != null&& palavra !="'\\")
            {
                int aspas_simples = Comentario_fonte.texto.LastIndexOf("'");
                if (aspas_simples == 0)
                {
                    StringBuilder.Append("erro de metadados");
                    return null;
                }
            }
            // erro de \u 
            if (@"'\u" ==palavra)
            {
                int pesquisar_ultima_aspas = Comentario_fonte.texto.LastIndexOf("'");
                if(pesquisar_ultima_aspas == 0)
                {
                    StringBuilder.Append("erro");
                    return null;
                }
            }
            //erro de \U
            if (@"'\U" == palavra)
            {
                int pesquisar_no_u_maisculo_aspas_simples = Comentario_fonte.texto.LastIndexOf("'");
                if(pesquisar_no_u_maisculo_aspas_simples == 0)
                {
                    StringBuilder.Append("erro");
                    return null;
                }
            }
            // erro de \x
            /*if (@"'\x" == palavra)
            {
                
            }*/
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
    }
}
