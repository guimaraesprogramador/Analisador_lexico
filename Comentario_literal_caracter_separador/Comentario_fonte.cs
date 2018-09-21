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
                retorno = "erro";
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
                    string separar = remover_caracter.Substring(barra);
                    retorno = remover_caracter.Replace(separar, "");
                }
             if (simple >= 0)
             {
                 string comentario_simple = texto.Substring(simple);
                string remover_caracter_simple = comentario_simple.Replace(Token.comentarios[1], "");
                    int barra_simple = remover_caracter_simple.IndexOf(">") + 1;
                    string separar_simple = remover_caracter_simple.Substring(barra_simple);
                    retorno = remover_caracter_simple.Replace(separar_simple, "");
             }
                return Token.buscae_token(retorno);
            }
            
        }
    }
}
