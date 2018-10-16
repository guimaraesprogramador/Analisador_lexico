using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
namespace Comentario_literal_caracter_separador
{
    public class Token:Comentario_fonte
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
                string[] eof_array = new string[10];
                eof_array[0] = @"'\'";
                eof_array[1] = @"'\\''";
                eof_array[2] = @"'\'";
                eof_array[3] = @"'\0'";
                eof_array[4] = @"'\a'";
                eof_array[5] = @"'\b'";
                eof_array[6] = @"'\f'";
                eof_array[7] = @"'\r'";
                eof_array[8] = @"'\t'";
                eof_array[9] = @"'\v'";
                return eof_array;
               
            }
           set {
                eof = value;
            }
        }
        private static StringBuilder buscar_single_character = new StringBuilder();
        // busca somente comentario;
       
        public static string identicadores(string posicao,string cadeia, int index)
        {
            string a = posicao_do_elemento(posicao);
            string u_minusculo = @"'\u" + buscar_single_character.ToString() + "'";
            string u_maisculo = @"'\U" + buscar_single_character.ToString() + "'";
            string x = @"'\x" + buscar_single_character.ToString() + "'";
            if (cadeia == u_minusculo|| cadeia==u_maisculo)
            {
                buscar_single_character.Clear();
                return Index.validar(cadeia, posicao);
            }
           else if(cadeia == x)
            {
                buscar_single_character.Clear();
                return Index.validar(x, posicao);
            }
            else
            {
                string procurar = Index.lexema(cadeia);
                if (procurar!= null)
                {
                    buscar_single_character.Clear();
                    return procurar;
                }
            }

            return null;
        }
        public static string posicao_do_elemento(string posicao)
        {
            
            for (int i = 0; i < single_character.Length; i++)
            {
                if(single_character[i] == posicao)
                {
                    buscar_single_character.Append(posicao);
                    return posicao;
                }
            }
            

            return null;
        }
        
        
    }
   
}
