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
       // como descuber qual token
        public string main()
        {
            int simple = texto.IndexOf("///");
            int composto = texto.IndexOf("/**/");  
            string retorno = "";
            // literal caracter + separador
            if(composto != 0 && simple !=0)
            {
                retorno = "erro";
                return retorno;
            }
            //somente comentario;
            else
            {
              if (composto == 0)
             {
                 string comentario_composto = texto.Substring(composto);
                 retorno = comentario_composto.Replace(Token.comentarios[0], "");
             }
             if (simple == 0)
             {
                 string comentario_simple = texto.Substring(simple);
                 retorno = comentario_simple.Replace(Token.comentarios[1], "");
             }
                return Token.buscae_token(retorno);
            }
            
        }
    }
}
