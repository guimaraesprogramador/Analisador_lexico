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
                ident[0] = null;
                ident[1] = null;
                ident[2] = "Descrever um tipo ou um membro de um tipo";
                ident[3] = "Definir texto em  uma fonte de código";
                ident[4] = "Definir uma ou mais linhas de código-fonte ou programa saída";
                ident[5] = "Indique um exemplo";
                ident[6] = "Identifica as exceções que um método pode lançar";
                ident[7] = "Inclui XML de um arquivo externo";
                ident[8] = "Permitir que a estrutura seja adicionada ao texto";
                ident[9] = "Identifique que uma palavra é um nome de parâmetro";
                ident[10] = "Documentar a acessibilidade de segurança de um membro";
                ident[11] = "Descrever informações adicionais sobre um tipo";
                ident[12] = "Descrever o valor de retorno de um método";
                ident[13] = "Especifique um link";
                ident[14] = "Gerar uma entrada Consulte também";
                ident[15] = "Descrever um parâmetro de tipo para um tipo genérico ou método";
                ident[16] = "Identifique que uma palavra é um nome de parâmetro de tipo";
                ident[17] = "Descreva uma propriedade";
                ident[18] = "Crie uma lista ou tabela";
                ident[19] = "Descrever um parâmetro para um método ou construtor";
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
            if (lista2 == null)
            {
                lista2 = "erro";
            }
            return lista2;
        }
    }
}
