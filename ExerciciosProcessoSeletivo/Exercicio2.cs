using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosProcessoSeletivo
{
    public class Exercicio2
    {
        /// <summary>
        /// ORDENE EM ORDEM CRESCENTE E RETORNE A VARIAVEL CODIGOS
        /// </summary>
        /// <param name="codigos"></param>
        /// <returns></returns>
        internal List<int> GetCodigosOrdenados(List<int> codigos)
        {
            codigos = codigos.OrderBy(c => c).ToList();
            return codigos;
        }


    }
}
