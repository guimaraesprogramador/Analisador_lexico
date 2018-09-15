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
                    identicado = string.Format("Definir texto em {0} uma fonte de código", Environment.NewLine);
                    break;
            }
            if(i == -1)
            {
                identicado = "Novo tipo de identificador";
            }
            return identicado;
        }
    }
}
