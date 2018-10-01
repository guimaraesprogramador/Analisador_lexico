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
        // como descuber qual lexico
        public List<string> main()
        {
            List<string> retorno = new List<string>();
            char[] cadeia = texto.ToArray();
            string conca = "";
            for(int i = 0; i < cadeia.Length; i++)
            {
                    conca = conca + cadeia[i];
                if (char.IsLetter(cadeia[i]))
                {
                    conca = "";
                }
                else
                {
                    conca = Identificador.buscar_token(conca, retorno, i);
                }
            }
            return retorno;
            
        }
    }
}
