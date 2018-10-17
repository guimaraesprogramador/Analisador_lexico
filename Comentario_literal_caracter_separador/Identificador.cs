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
        public static string erro(string letra)
        {
             Erros_lexema.erros(letra);

            String lista_palavra = Erros_lexema.listar_palavra_reservada();
            if (lista_palavra != null)
            {
               

                builder = builder.Clear();
                return lista_palavra;
            }
            return null;
        }
        public static string buscar_token(string conca,string palavra, List<string> retorno, int i)
        {
            string letra = conca== "\r\n"||conca == "\r" || conca == "\n"||
                string.IsNullOrWhiteSpace(conca)==true ? letra =null : letra =palavra;
            if (conca == "\n") Index.linha++;
            string verifica = Erros_lexema.verificar_e_um_texto_comum(letra, retorno);
            if (verifica == null) builder = builder.Clear();
            if (verifica == "palavra reservada")
            {
                string linhas = erro(letra);
              if (linhas != null) retorno.Add(linhas);

            }
            //certo
            string erro_mentados = Token.identicadores(letra, palavra, i);
                string resultado = erro_mentados == letra ? resultado = erro_mentados : resultado = null;
                if (resultado != null)
                {
                    string[] literal_carater = Index.indice(resultado, i);
                    retorno.Add(literal_carater[0] + literal_carater[1] + " valor " + literal_carater[2]);
                
                    builder = builder.Clear();
                }
            return letra;
        }
    }
}
