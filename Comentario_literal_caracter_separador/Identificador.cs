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
        public static string comentario_identifador(string i)
        {

            string comentario = "";
            int procurar_comentario = i.IndexOf("//") == 0 || i.IndexOf("/*")==0 ? procurar_comentario = 0 : procurar_comentario = -1;
            if (procurar_comentario == 0) comentario = "comentario";
            else comentario = null;
            return comentario;
        }
        public static string buscar_token(string conca, List<string> retorno, int i)
        {
            string letra = conca == "/r" || conca == "\n" || conca == "*/" || string.IsNullOrWhiteSpace (conca)==true|| string.IsNullOrEmpty(conca) == true? letra = null : letra = conca;
            switch (letra)
            {
                case "//":
                    
                    List<string> barra_simple_dupla = Index.indice(letra, i);
                    if (barra_simple_dupla[0] != "erro") retorno.Add(barra_simple_dupla[0]);
                    else retorno[2] = "erro lexico";
                    letra = "";
                    break;
                case "/*":
                    List<string> barra_simple_dupla_final = Index.indice(letra, i);
                    if (barra_simple_dupla_final[0] != "erro") retorno.Add(barra_simple_dupla_final[0]);
                    else retorno[3] = "erro lexico";
                    letra = "";
                    break;
                default:
                    string p = letra == "\\" ? p = letra : letra = null;
                    if (p != null)
                    {
                                List<string> caracter = Index.indice(texto, i);
                                if (caracter[0] != "erro") retorno.Add( caracter[0]);
                                break;  
                    }
                   /* string erros = Token.identicadores(letra);
                    if (!erros.Equals("")) retorno.Add(erros);*/
                    break;
            }
            return letra;
        }
    }
}
