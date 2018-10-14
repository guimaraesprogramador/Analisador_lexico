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
        /*public static string verificar_e_um_texto_comum(string campo)
        {
            switch (campo)
            {
                case "/":
                    return campo;
                case "*":
                    return campo;
                case "//":
                    return "comentario";
                case "/*":
                    return campo;
            }
            return campo;
        }*/
    }

}
