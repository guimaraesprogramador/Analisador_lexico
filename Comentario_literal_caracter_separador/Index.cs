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
       public static List<string> indice(string texto, int localizado)
        {
            string[] array_lista = new string[2];
            string[] erro =  { "erro" };
            List<string> linha_posicao = new List<string>();
            string concatena = "";
            for(int i = 0; i < Comentario_fonte.token.Length; i++)
            {
                if(Comentario_fonte.token[i] != null)
                {
                    int separa = Comentario_fonte.token[i].IndexOf("//");
                    linha_posicao.Add("posicao " + localizado.ToString() + "linha " + separa);
                    i++;
                }
                Comentario_fonte.token[i] = null;
            }
            
           
            return linha_posicao;
        }
      
    }
}
