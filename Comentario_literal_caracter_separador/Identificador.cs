using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comentario_literal_caracter_separador
{
   public class Identificador:Comentario_fonte
    {
        //busca identificar de comentario..
        public static string comentario_identifador(int i)
        {
            string identicado = "";
            switch (i)
            {
                case 0:
                    identicado = "Definir texto em  uma fonte de código";
                    break;
               
            }
            return identicado;
        }
    }
}
