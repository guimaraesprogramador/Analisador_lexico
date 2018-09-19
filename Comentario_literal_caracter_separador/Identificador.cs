using System;
using System.Collections.Generic;
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
                ident[4] = "Definir texto em  uma fonte de código";
                ident[3] = "erro";
                return ident;
            }
        }
        //busca identificar de comentario..
        public static string comentario_identifador(int i)
        {
            string numero = pegar_identicado(i);
            return numero;
        }
        public static string pegar_identicado(int x)
        {
            string lista2 = "";
            for (int j = 0; j < identicado.Length; j++)
            {
              if(x == j)
                {
                   lista2 =  identicado[j];
                    break;
                }

            }
            if (lista2.Equals(""))
            {
                lista2 = identicado[3].ToString();
            }
            return lista2;
        }
    }
}
