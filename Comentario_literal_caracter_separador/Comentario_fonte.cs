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
        public static StringBuilder[] retorno = new StringBuilder[5];
        // como descuber qual lexico
        public string main()
        {
            StringBuilder builder = new StringBuilder();
            for(int i = 0; i < texto.Length; i++)
            {
                builder.Append(texto[i]);
                string a = builder.ToString();
                switch (a)
                {
                    case "///":
                        string[] barra_simple = Index.indice(texto, Token.comentarios[3]);
                        if (barra_simple[0] != "erro") retorno[0].Append(Token.comentarios[3] + " " + "na posicao " + barra_simple[0] + "linha " + barra_simple[1]);
                        else retorno[0].Append("erro lexico");
                        builder.Clear();
                        break;
                    case "/**":
                        string[] barra = Index.indice(texto, "/**");
                        if (barra.ToString() != "erro") retorno[1].Append(Token.comentarios[2] + " " + "na posicao " + barra[0]);
                        else retorno[1].Append("erro lexico");
                        builder.Clear();
                        break;
                    case "//":
                        string[] barra_simple_dupla = Index.indice(texto, "//");
                        if (barra_simple_dupla[0] != "erro") retorno[2].Append(Token.comentarios[0].ToString() + " " + " na posicao " + barra_simple_dupla[0] + " linha " + barra_simple_dupla[1]);
                        else retorno[2].Append("erro lexico");
                        builder.Clear();
                        break;
                    case "*/":
 
                        string[] barra_simple_dupla_final = Index.indice(texto, Token.comentarios[1].ToString());
                        if (barra_simple_dupla_final[0] != "erro") retorno[3].Append(Token.comentarios[1].ToString() + " " + " na posicao " + barra_simple_dupla_final[0] + " linha " + barra_simple_dupla_final[1]);
                        builder.Clear();
                        break;
                }
            }
            return null;   
            
        }
    }
}
