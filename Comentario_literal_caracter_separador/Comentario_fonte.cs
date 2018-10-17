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
            string demiliar = null;
            for (int i = 0; i < texto.Length; i++)
            {
                
                demiliar =texto[i].ToString();
                    builder.Append(demiliar);
                if (char.IsLetter(texto[i]))
                {
                    demiliar = Identificador.buscar_token(texto[i].ToString(), builder.ToString(), retorno, i);
                    //demiliar =  Token.identicadores(remover[i].ToString(), demiliar, i);
                }
                else if ( char.IsDigit(texto[i]))
                {
                  demiliar =   Token.identicadores(texto[i].ToString(), builder.ToString(), i);
                }
                else if(!char.IsDigit(texto[i]) && !char.IsLetter(texto[i]))
                {
                  demiliar =   Identificador.buscar_token(texto[i].ToString(), builder.ToString(), retorno, i);
                }
            }
            builder.Clear();
            Index.linha = 1;
            return retorno;
            
        }
    }
}
