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
            int composto = texto.LastIndexOf("*/");
            

            // literal caracter + separador
            if(composto== -1 && simple ==-1)
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
              if (composto >= 0)
             {
                    string comentario_composto = texto.Remove(composto);
                    string remover_caracter = comentario_composto.Replace( Token.comentarios[0],"");
                    int barra =  remover_caracter.IndexOf(">") + 1;
                    if(barra < remover_caracter.Length)
                    {
                        string separar = remover_caracter.Substring(barra);
                        retorno = remover_caracter.Replace(separar, "");
                    }
                    else
                    {
                        retorno = remover_caracter;
                    }
                  
                }
             if (simple == 0)
             {
                 string comentario_simple = texto.Substring(simple);
                string remover_caracter_simple = comentario_simple.Replace(Token.comentarios[1], "");
                    int barra_simple = remover_caracter_simple.IndexOf(">") + 1;
                    if(barra_simple <remover_caracter_simple.Length)
                    {
                        string separar_simple = remover_caracter_simple.Substring(barra_simple);
                        retorno = remover_caracter_simple.Replace(separar_simple, "");
                    }
                    else
                    {
                        retorno = remover_caracter_simple;
                    }
                    
             }
             //erro lexico
             string resposta_do_processo = Token.buscar_token(retorno);
                if (resposta_do_processo.Equals("erro lexico")) return resposta_do_processo;
                return resposta_do_processo;
            }
            
        }
    }
}
