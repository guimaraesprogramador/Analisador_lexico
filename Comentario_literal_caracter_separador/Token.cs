using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
namespace Comentario_literal_caracter_separador
{
    public class Token
    {
      public static string[] single_character
        {
            get
            {
                string[] arrays = new string[16];
                arrays[0] = "0";
                arrays[1] = "1";
                arrays[2] = "2";
                arrays[3] = "3";
                arrays[4] = "4";
                arrays[5] = "5";
                arrays[6] = "6";
                arrays[7] = "7";
                arrays[8] = "8";
                arrays[9] = "9";
                arrays[10] = "A";
                arrays[11] = "B";
                arrays[12] = "C";
                arrays[13] = "D";
                arrays[14] = "E";
                arrays[15] = "F";
                return arrays;
            }
            set
            {
                single_character = value;
            }

        }
        public static string[] eof
        {
            get
            {
                string[] eof_array = new string[11];
                eof_array[0] = @"'\";
                eof_array[1] = @"'\\";
                eof_array[2] = @"'\"+'"';
                eof_array[3] = @"'\0";
                eof_array[4] = @"'\a";
                eof_array[5] = @"'\b";
                eof_array[6] = @"'\f";
                eof_array[7] = @"'\r";
                eof_array[8] = @"'\t";
                eof_array[9] = @"'\v";
                eof_array[10] = @"'\n";
                return eof_array;
               
            }
           set {
                eof = value;
            }
        }
        public static string[] eof_invalido
        {
            get
            {
                string[] eof_array = new string[11];
                eof_array[0] = @"\";
                eof_array[1] = @"\\";
                eof_array[2] = Convert.ToString('"');
                eof_array[3] = @"0";
                eof_array[4] = @"a";
                eof_array[5] = @"b";
                eof_array[6] = @"f";
                eof_array[7] = @"r";
                eof_array[8] = @"t";
                eof_array[9] = @"v";
                eof_array[10] = @"n";
                return eof_array;
            }
        }
       
        public static string identicadores(char posicao,char cadeia, int index)
        {
            /* posicao_do_elemento(posicao);
            barra(posicao, cadeia);
            unic(cadeia);
            string u_minusculo =  concatena_unico2+unir_palavra+concar+ "'";
            string u_maisculo = concatena_unico2 +U+concar+ "'";
            string x_palavra = concatena_unico2 + x +concar+ "'";
            if (cadeia.ToString() == u_minusculo|| cadeia.ToString() == u_maisculo)
            {
                
                u_maisculo = null;
                u_maisculo = null;
                x = null;
                Comentario_fonte.builder = Comentario_fonte.builder.Clear();
                return Index.validar(cadeia.ToString(), posicao.ToString());
            }
           else if(cadeia.ToString() == x_palavra)
            {
               
                u_maisculo = null;
                u_maisculo = null;
                x = null;
                Comentario_fonte.builder = Comentario_fonte.builder.Clear();
                string palavras =  Index.validar(x, posicao.ToString());
            }
            else
            {*/
                Index.lexema_unicodi(posicao, cadeia);
                if (unir_palavra != null)
                {
                    string procurar = Index.lexema(unir_palavra);
                    if (procurar != null)
                    {
                        
                        unir_palavra = null;
                        return procurar;
                    }
                }
                
                
           // }

            return null;
        }
       public static string unir_palavra = null;
        private static string concar = null;
        public static string posicao_do_elemento(char posicao)
        {
            
            for (int i = 0; i < single_character.Length; i++)
            {
                if(single_character[i] == posicao.ToString())
                {
                    concar = concar+posicao.ToString();
                    return posicao.ToString();
                }
            }
            return null;
        }
        private static string concatena_unico2 = null;
        private static string uni_u = null;
        public static void barra(char palavra_anterior, char proxima_letra)
        {
            if (palavra_anterior.ToString() == "'" && proxima_letra.ToString() == @"\")
            {
                concatena_unico2 = palavra_anterior.ToString() + proxima_letra;
                
            }
            
        }
        private static string U = null;
        private static string x = null;
        public  static string unic(char proxima_u)
        {
            if(proxima_u == 'u')
            {
                uni_u = @"u";
                return uni_u;
            }
            else if(proxima_u == 'U')
            {
                return U = "U";
            }
            else if(proxima_u == 'x')
            {
                return x = "x";
            }
            return null;
        }
        
    }
   
}
