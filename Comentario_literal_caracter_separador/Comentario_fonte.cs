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
        public static char[] texto { get; set; }
        public static StringBuilder builder;
        // como descuber qual lexico
        public List<string> main()
        {
           
            List<string> retorno = new List<string>();
            builder = new StringBuilder();
            
            for (int i = 0; i < texto.Length; i++)
            {
                char anterior = new char();
                char proximo = new char();
                char letra = texto[i];
                //alterior
                /*if (i > 0)
                {
                    anterior = Convert.ToChar(texto[i - 1]);

                    //palavra atual 
                   
                }*/
                
                anterior = letra;

                //proximo palavra
                if (i < texto.Length - 1)
                {
                   proximo = texto[i + 1];
                  
                }
               
                // se é letra
                if (char.IsLetter(texto[i]))
                {
                  Identificador.buscar_token(anterior, proximo, retorno, i);

                }
                // se é numero
                else if ( char.IsDigit(texto[i]))
                {
                    Token.identicadores(anterior, proximo, i);
                }
                // se não é letra e numero
                else if(!char.IsDigit(texto[i]) && !char.IsLetter(texto[i]))
                {
                   Identificador.buscar_token( anterior, proximo, retorno, i);
                    

                }
            }
            Token.unir_palavra = null;
            Index.linha = 1;

            return retorno;
            
        }
    }
}
