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
                //erro de identificado
                string erros_texto = texto;
                int erro = texto.IndexOf(">") + 1;
                if (erro < erros_texto.Length)
                {//erro com alguma palavra na frente
                    string separar = erros_texto.Substring(erro);
                    retorno = erros_texto.Replace(separar, "");

                }
                else
                {
                    // erro sem palavra na frente
                    retorno = erros_texto;

                }
                return retorno;
            }
            //somente comentario;
            else
            {
                /***/
              if (composto >= 0)
             {
                    string comentario_composto = texto.Remove(composto);
                    string remover_caracter = comentario_composto.Replace( Token.comentarios[0],"");
                    string barra = Index.indice(remover_caracter, Token.comentarios[0]);
                    if (barra != "erro") retorno = Token.comentarios[0] + " " + "na posicao " + barra;
                    else retorno = "erro lexico";
                }
              ///
             if (simple == 0)
             {
                 string comentario_simple = texto.Substring(simple);
                string remover_caracter_simple = comentario_simple.Replace(Token.comentarios[1], "");
                    string barra_simple = Index.indice(texto, Token.comentarios[1]);
                    if (barra_simple != "erro") retorno = Token.comentarios[1] + " " + "na posicao " + barra_simple;
                    else retorno = "erro lexico";
                }
             //
             if(barra_dupla >= 0)
                {
                    string simple_barra = texto.Substring(barra_dupla);
                    string remover_caractet_simples_dupla = simple_barra.Replace(Token.comentarios[20], "");
                    string barra_simple_dupla = Index.indice(texto,Token.comentarios[20]);
                    if (barra_simple_dupla != "erro") retorno = Token.comentarios[20].ToString() + " " + " na posicao " + barra_simple_dupla;
                    else retorno = "erro lexico";
                }
             /**/
             //não testado
                if (barra_final == 0)
                {
                    string simple_barra_final = texto.Substring(barra_final);
                    string remover_caracter_simple_final = simple_barra_final.Replace(Token.comentarios[21], "");
                    int barra_simple_dupla_final = remover_caracter_simple_final.IndexOf(">") + 1;
                    if (barra_simple_dupla_final < remover_caracter_simple_final.Length)
                    {
                        string separar_simple_dupla_final = remover_caracter_simple_final.Substring(barra_simple_dupla_final);
                        retorno = remover_caracter_simple_final.Replace(separar_simple_dupla_final, "");
                    }
                    else
                    {
                        retorno = remover_caracter_simple_final;
                    }
                }
                //erro lexico

                return retorno;
            }
            
        }
    }
}
