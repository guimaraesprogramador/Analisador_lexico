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
        public static StringBuilder builder;
        // como descuber qual lexico
        public List<string> main()
        {
           
            List<string> retorno = new List<string>();
            builder = new StringBuilder();
            string demiliar = "";
            string remover = texto;
            for (int i = 0; i < remover.Length; i++)
            {
                builder.Append(remover[i]);
                demiliar = builder.ToString();
                if (char.IsLetter(remover[i]))
                {
                    demiliar = Identificador.buscar_token(remover[i].ToString(), demiliar, retorno, i);
                    //demiliar =  Token.identicadores(remover[i].ToString(), demiliar, i);
                }
                else if ( char.IsDigit(remover[i]))
                {
                  demiliar =   Token.identicadores(remover[i].ToString(), demiliar, i);
                }
                else if(!char.IsDigit(remover[i])&& !char.IsLetter(texto[i]))
                {
                  demiliar =   Identificador.buscar_token(remover[i].ToString(), demiliar, retorno, i);
                }
            }

            //char[] cadeia = texto.ToArray();

            /* for (int i = 0; i < cadeia.Length; i++)
             {
                 concatena = concatena + cadeia[i];
                 if (char.IsLetter(cadeia[i]))
                 {
                     concatena = Token.identicadores(concatena);                    
                 }
                 if (char.IsDigit(cadeia[i]))
                 {
                     concatena = Token.identicadores(concatena);
                 }
                 else
                 {
                     concatena = Identificador.buscar_token(concatena, retorno, i);
                 }


             }*/
            builder.Clear();
            return retorno;
            
        }
    }
}
