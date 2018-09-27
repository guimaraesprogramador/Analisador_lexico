using System;
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
        public static string retorno = "";
        // como descuber qual lexico
        public string main()
        {
            int simple = texto.IndexOf("///");
            int composto = texto.IndexOf("/**");
            int barra_dupla = texto.IndexOf("//");
            int barra_final = texto.LastIndexOf("*/");
            /**/
            // literal caracter + separador
            if(composto == -1 && simple ==-1 && barra_dupla == -1 && barra_final ==-1)
            {
                retorno = "erro lexico";
                return retorno;
            }
            //somente comentario;
                /***/
                //erro não esta funcionado
              if (composto >= 0)
             {
                    string[] barra = Index.indice(texto,"/**");
                    if (barra.ToString() != "erro") retorno = Token.comentarios[2] + " " + "na posicao " + barra[0];
                    else retorno = "erro lexico";
                return retorno;
            }
              ///
             if (simple >= 0)
             { 
               /*  string comentario_simple = texto.Substring(simple);
                string remover_caracter_simple = comentario_simple.Replace(Token.comentarios[1], "");*/
                    string[] barra_simple = Index.indice(texto, Token.comentarios[3]);
                    if (barra_simple[0] != "erro") retorno = Token.comentarios[3] + " " + "na posicao " +barra_simple[0] + "linha "+barra_simple[1];
                    else retorno = "erro lexico";
                return retorno;
                }
             //
             //testado
             if(barra_dupla >= 0)
                {
                   /* string simple_barra = texto.Substring(barra_dupla);
                    string remover_caractet_simples_dupla = simple_barra.Replace(Token.comentarios[2], "");*/
                    string[] barra_simple_dupla = Index.indice(texto,"//");
                    if (barra_simple_dupla[0]!= "erro") retorno = Token.comentarios[0].ToString() + " " + " na posicao " + barra_simple_dupla[0]+ " linha "+barra_simple_dupla[1];
                    else retorno = "erro lexico";
                return retorno;
            }
             
             /**/
             //testado
                if (barra_final >= 0)
                {
                    string simple_barra_final = texto.Substring(barra_final);
                    string remover_caracter_simple_final = simple_barra_final.Replace(Token.comentarios[1], "");
                    string[] barra_simple_dupla_final = Index.indice(texto, Token.comentarios[1].ToString());
                    if(barra_simple_dupla_final[0] != "erro")retorno = Token.comentarios[1].ToString() + " " + " na posicao " + barra_simple_dupla_final[0] + " linha " + barra_simple_dupla_final[1];
                    else retorno = "erro lexico";
                return retorno;
            }
            return null;   
            
        }
    }
}
