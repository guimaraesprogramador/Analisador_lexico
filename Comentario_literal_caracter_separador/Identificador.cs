using System;
using System.Collections.Generic;
using System.Globalization;
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
            string letra = conca == "/r" || conca == "\n" || conca == "*/" ? letra = null : letra =  conca;
            switch (letra)
            {
                case "//":
                    
                    List<string> barra_simple_dupla = Index.indice(letra, i);
                    retorno.Add(barra_simple_dupla[0]);
                    letra = letra.Remove(letra.Length-1);
                    break;
                case "/*":

                    List<string> barra_simple_dupla_final = Index.indice(letra, i);
                    retorno = barra_simple_dupla_final;
                    letra = letra.Remove(letra.Length - 1);
                    break;
                default:
                    if(letra != null)
                    {

                       
                           string erro_mentados = Token.identicadores(letra);
                            string resultado = erro_mentados == "erro metadado" ? resultado = erro_mentados : resultado = null;
                            if (resultado != null) retorno.Add(resultado);
    
                    }
                   /* string erros = Token.identicadores(letra);
                    if (!erros.Equals("")) retorno.Add(erros);*/
                    break;
            }
            return letra;
        }
    }
}
