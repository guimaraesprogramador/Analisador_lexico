using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Windows.Forms;

namespace Comentario_literal_caracter_separador
{
   public class Index
    {
        public static int linha = 1;
       public static string[] indice(string texto, int localizado)
        {
            string[] array_lista = new string[3];
            string[] erro =  { "erro" };
            List<string> linha_posicao = new List<string>();
            array_lista[0] = " posicao " +localizado.ToString();
                array_lista[1] = " linha " + linha;
            array_lista[2] = texto;
            return array_lista;
        }
      public static string remover_r_n(char[] separador)
        {
            string concatenar = null;
            for(int i = 0; i < separador.Length; i++)
            {
                if(separador[i].ToString() == "\r"|| separador[i].ToString() == "\n")
                {
                    concatenar = null;
                }
                concatenar = concatenar + separador[i];
            }
            return concatenar;
        }
        public static string validar(string validacao, string local)
        {
            try
            {
                Regex rege2 = new Regex(@"(?<!\d)(?!0000)\d{4}(?!\d)");
                var validar = rege2.Match(validacao);
               
                if (validar.Success == true)
                {
                    Regex regex = new Regex("[A-F0-9]");
                    var buscar = regex.Match(validacao);
                    
                    if (buscar.Success == true)
                    {
                        return validacao;
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            return null;
        }
        public static string lexema(string qual)
        {
            //valido
            for (int i = 0; i < Token.eof.Length; i++)
                {
                    if (qual == Token.eof[i].ToString()+"'")
                    {
                        qual = Token.eof[i]+"'";
                        return qual;
                    }

                }
            
            return null;
        }
        public static string erro_lexema(string invalido)
        {
            //invalido
            for (int erro = 0; erro < Token.eof_invalido.Length; erro++)
            {
                //se tem '
                if (invalido == Token.eof_invalido[erro].ToString())
                {
                    invalido = Token.eof_invalido[erro];
                    return invalido;
                }
            }
            return null;
        }
        public static void lexema_unicodi(char ante,char depois)
        {
            // '                         e   \      
            if (ante.ToString() == @"'" && depois == '\\')
            {
               Token.unir_palavra = ante.ToString() + depois;
            }
            //     \                      e   a      
            if (ante.ToString() == "\\" && Index.erro_lexema(depois.ToString()) != null)
            {
                Token.unir_palavra = Token.unir_palavra + depois;
            }
            //    a                                         e       '
            if (Index.erro_lexema(ante.ToString()) != null && depois.ToString() == "'")
            {
                Token.unir_palavra = Token.unir_palavra +depois;
            }
        }
       
    }

}
