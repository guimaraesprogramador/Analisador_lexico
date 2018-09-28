﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace Comentario_literal_caracter_separador
{
   public class Comentario_fonte
    {
        public static string texto { get; set; }
        public static int token { get; set; }
        // como descuber qual lexico
        public string[] main()
        {
            string[] retorno = new string[5];
            StringBuilder builder = new StringBuilder();
            char[] cadeia = texto.ToArray();
            string conca = "";
            for(int i = 0; i < cadeia.Length; i++)
            {
                conca = conca + cadeia[i];
                if (char.IsLetter(cadeia[i]))
                {
                    i = i + 1;
                    conca = "";
                }
                else
                {
                    
                    switch (conca)
                    {
                        case "///":
                            string[] barra_simple = Index.indice(texto, Token.comentarios[3]);
                            if (barra_simple[0] != "erro") retorno[0] = Token.comentarios[3] + " " + "na posicao " + barra_simple[0] + "linha " + barra_simple[1];
                            else retorno[0] = "erro lexico";
                            conca = "";
                            continue;
                        case "/**":
                            string[] barra = Index.indice(texto, "/**");
                            if (barra.ToString() != "erro") retorno[1] = Token.comentarios[2] + " " + "na posicao " + barra[0];
                            else retorno[1] = "erro lexico";
                            conca = "";
                            continue;
                        case "//":
                            string[] barra_simple_dupla = Index.indice(texto, "//");
                            if (barra_simple_dupla[0] != "erro") retorno[2] = Token.comentarios[0].ToString() + " " + " na posicao " + barra_simple_dupla[0] + " linha " + barra_simple_dupla[1];
                            else retorno[2] = "erro lexico";
                            conca = "";
                            continue;
                        case "/*":

                            string[] barra_simple_dupla_final = Index.indice(texto, Token.comentarios[1].ToString());
                            if (barra_simple_dupla_final[0] != "erro") retorno[3] = Token.comentarios[1].ToString() + " " + " na posicao " + barra_simple_dupla_final[0] + " linha " + barra_simple_dupla_final[1];
                            else retorno[3] = "erro lexico";
                            conca = "";
                            continue;
                        case "\r":
                            conca = "";
                            continue;
                        case "\n":
                            conca = "";
                            continue;
                        default:
                            if (i == texto.Length)
                            {
                                break;
                            }
                            continue;
                    }
                }

            }
            return retorno;
            
        }
    }
}
