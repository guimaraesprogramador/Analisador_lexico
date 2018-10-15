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
       public static string[] indice(string texto, int localizado)
        {
            string[] array_lista = new string[3];
            string[] erro =  { "erro" };
            List<string> linha_posicao = new List<string>();
            array_lista[0] = " posicao " +localizado.ToString();
            
            array_lista[1] = " linha " + Convert.ToString(Form1.linha - 1);
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

                Regex regex = new Regex(@"[A-F0-9]");
                var buscar = regex.Match(validacao);
                validacao = null;
                if (buscar.Success == true)
                {
                    validacao = local;
                }
                return validacao;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            return null;
        }
       public static StringBuilder StringBuilder = new StringBuilder();
        public static string verificar_e_um_texto_comum(string campo, List<string> lista)
        {
            if (campo.ToString() == "//")
            {
                lista.Add("é comentario");
                return null;
            }
            else if (campo.ToString() == "/**/")
            {
                lista.Add("é comentario");
                return null;
            }

            else if (campo.ToString() == @"'\u") return @"'\u";
            else if (campo.ToString() == @"'\U") return @"'\U";
            else if (campo.ToString() == @"'\x") return @"'\x";
            else if (campo == "*" || campo == "/") return campo;
            return null;
        }
        public static string erros(string palavra)
        {
            if (char.IsLetter(palavra[0])) return null;
                if (palavra == "/*" )
                {
                int ultima_caracter_Especial = Comentario_fonte.texto.LastIndexOf("*");
                   
                    //nao tem outro caractar
                     if (ultima_caracter_Especial == 1)
                    {
                        StringBuilder.Append(palavra);
                        return null;
                    }

                }
            if (palavra == "*") StringBuilder.Append("/*" + palavra);
                if (palavra == "'" )
                {
                    int ultima_caracter_Especial2 = Comentario_fonte.texto.LastIndexOf("'");
                    //nao tem outro caractar
                    if (ultima_caracter_Especial2 == 1)
                    {
                        
                            StringBuilder.Append(palavra);
                            return null;
                    }

                }

            return palavra;
        }
        public static string listar_palavra_reservada()
        {
            string palavra = null;
            if(StringBuilder.ToString()!= null)
            {
                switch (StringBuilder.ToString())
                {
                    case "/*":
                        palavra = "erro de bloco";
                        StringBuilder.Clear();
                        break;
                    case "/**":
                        palavra = "erro de bloco";
                        StringBuilder.Clear();
                        break;
                    case "'":
                        palavra = "Caracter não terminado até E.O.F";
                        StringBuilder.Clear();
                        break;
                    case "'/":
                        palavra = "erro";
                        StringBuilder.Clear();
                        break;
                }
               
            }
            return palavra;
        }
    }

}
