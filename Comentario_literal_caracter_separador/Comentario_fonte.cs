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
        public static string[] token { get; set; }
        // como descuber qual lexico
        public List<string> main()
        {
           
            List<string> retorno = new List<string>();
            StringBuilder builder = new StringBuilder();
            
            for(int i = 0; i < texto.Length; i++)
            {
                builder.Append(texto[i]);
                string demiliar = builder.ToString();
                if (char.IsLetter(demiliar[i]))
                {
                    Token.identicadores(demiliar[i].ToString(), demiliar);
                }
                if (char.IsDigit(demiliar[i]))
                {
                    Token.identicadores(demiliar[i].ToString(),demiliar);
                }
                else
                {
                   Identificador.buscar_token(demiliar[i].ToString(),demiliar, retorno, i);
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
