using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comentario_literal_caracter_separador
{
   public class Identificador:Comentario_fonte
    {
        public static string[] identicado
        {
            get
            {
                string[] ident = new string[20];
                
                return ident;
            }
        }
        //busca identificar de comentario..
        public static string comentario_identifador(int i)
        {
            //string numero = pegar_identicado(i);
            return null;
        }
        public static string buscar_token(string conca, List<string> retorno, int i)
        {
            string letra = conca == "/r" || conca == "\n" || conca == "*/" || string.IsNullOrWhiteSpace (conca)==true? letra = null : letra = conca;
            switch (letra)
            {
                case "//":
                    
                    string[] barra_simple_dupla = Index.indice(texto, "//", i);
                    if (barra_simple_dupla[0] != "erro") retorno.Add(Token.comentarios[0].ToString() + " " + " na posicao " + barra_simple_dupla[0] + " linha " + barra_simple_dupla[1]);
                    else retorno[2] = "erro lexico";
                    letra = "";
                    break;
                case "/*":
                    string[] barra_simple_dupla_final = Index.indice(texto, Token.comentarios[1].ToString(), i);
                    if (barra_simple_dupla_final[0] != "erro") retorno.Add(Token.comentarios[1].ToString() + " " + " na posicao " + barra_simple_dupla_final[0] + " linha " + barra_simple_dupla_final[1]);
                    else retorno[3] = "erro lexico";
                    letra = "";
                    break;
               
            }
            return letra;
        }
    }
}
