﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace Comentario_literal_caracter_separador
{
   public class Index
    {
       public static string[] indice(string texto, string lexico, int localizado)
        {
            string[] a = new string[2];
            string[] erro =  { "erro" };
            /*       Regex buscador2 = new Regex(lexico);
            var math2 = buscador2.Match(texto);

            if (math2.Success == false) return a = erro;
            else
            {
                while (math2.Success)
                {
                    a[0] = math2.Index.ToString();
                    math2 = math2.NextMatch();
                }
                
                   
            }*/
            a[0] = localizado.ToString();
            
            for(int linha = 0; linha < texto.Length; linha++)
            {
                if(linha == localizado)
                {
                    a[1] = linha.ToString();
                }
            }
            return a;
        }
    }
}
