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
        public static string buscar_token(string conca,string palavra, List<string> retorno, int i)
        {
            string letra = palavra == "\r\n"||palavra == "\r" || palavra == "\n" || palavra == "*/"|| 
                string.IsNullOrWhiteSpace(palavra)==true ? letra = null : letra =  palavra;
            switch (letra)
            {
                case "//":
                    
                    string[] barra_simple_dupla = Index.indice(letra, i);
                    retorno.Add("é comentario");
                    
                    break;
                case "/*":

                    string[] barra_simple_dupla_final = Index.indice(letra, i);
                    retorno.Add("é comentario");
                    
                    break;
                case "/**":
                    string[] barra_simples_dupla = Index.indice(letra, i);
                    retorno.Add("é comentario");
                    break;
                default:
                    if(letra != null)
                    {
                        //erro de comentario
                       
                          string erro_mentados = Token.identicadores(letra,palavra);
                            string resultado = erro_mentados != "erro metadado"&& erro_mentados !=letra ? resultado = erro_mentados : resultado = null;
                        if (resultado != null) {
                            string[] literal_carater = Index.indice(resultado, i);
                            retorno.Add( literal_carater[0] +literal_carater[1] +"valor "+literal_carater[2]);
                        }
                        
    
                    }
                  
                    break;
            }
            return letra;
        }
    }
}
