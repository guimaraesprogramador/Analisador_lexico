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
        public static string erro(char letra,char letra_em_sequencia,int index)
        {
             Erros_lexema.erros(letra,letra_em_sequencia,index);

            String lista_palavra = Erros_lexema.listar_palavra_reservada();
            if (lista_palavra != null)
            {
               

                builder = builder.Clear();
                return lista_palavra;
            }
            return null;
        }
        public static char buscar_token( char palavra, char concatenacao, List<string> retorno, int i)
        {
            char letra =palavra;
            if (concatenacao == '\n') Index.linha++;
            string verifica = Erros_lexema.verificar_e_um_texto_comum(letra,concatenacao, retorno);
            if (verifica == "palavra reservada"|| verifica== null)
            {
                string linhas = erro(letra,concatenacao, i);
              if (linhas != null) retorno.Add(linhas);
                return letra;
            }
            //certo
            string erro_mentados = Token.identicadores(letra, palavra, i);
            string resultado = erro_mentados == letra.ToString() ? resultado = erro_mentados : resultado = null;
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
