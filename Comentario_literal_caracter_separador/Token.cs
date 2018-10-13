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
                string[] eof_array = new string[13];
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
                eof_array[10] = @"'\u";
                eof_array[11] = @"'\U";
                eof_array[12] = @"'\x";
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
            char[] divitir_primeiro_numero;
            char[] divitir_por_ultimo;
            string resultado_primeiro = null;
            string resultado_ultimo = null;
            string a = posicao_do_elemento(posicao);
            string u_minusculo = eof[10] + buscar_single_character.ToString().Trim() + "'";
            string u_maisculo = eof[11] + buscar_single_character.ToString().Trim() + "'";
            string x = eof[12] + buscar_single_character.ToString().Trim() + "'";
            int espaço = cadeia.IndexOf("\r\n");
            
            if (espaço >= 0)
            {
                var separar = cadeia.Replace("\r\n", string.Empty);
                
                divitir_primeiro_numero = separar.ToString().Take(separar.Length /conta ).ToArray();
                divitir_por_ultimo = separar.ToString().Skip(separar.Length / conta).ToArray();
                resultado_primeiro =  Index.remover_r_n(divitir_primeiro_numero);
                resultado_ultimo = Index.remover_r_n(divitir_por_ultimo);
            }
            
            if (cadeia == u_minusculo|| cadeia==u_maisculo)
            {
                buscar_single_character.Clear();
                return Index.validar(cadeia, posicao);
            }
            else if(u_maisculo ==resultado_primeiro|| u_minusculo==resultado_primeiro)
            {
                buscar_single_character.Clear();
                return Index.validar(resultado_primeiro, posicao);
            }
            else if(u_maisculo == resultado_ultimo || u_minusculo ==resultado_ultimo)
            {
                buscar_single_character.Clear();
                return Index.validar(resultado_ultimo, posicao);
            }
           else if(cadeia == x)
            {
                return Index.validar(x, posicao);
            }
            else
            {
                for (int i = 0; i < eof.Length; i++)
                {
                    if (cadeia == eof[i].ToString())
                    {
                        cadeia = eof[i];
                        return cadeia;
                    }

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
