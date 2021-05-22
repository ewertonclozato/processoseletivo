using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosProcessoSeletivo
{
    public class Exercicio3
    {
        /// <summary>
        /// FAÇA COM QUE O NOME DO FUNCIONARIO APAREÇA NO LUGAR DE {nome.ToUpper()}
        /// FAÇA COM QUE O A DATA APAREÇA NO LUGAR DE {data}
        /// </summary>
        /// <param name="nome"></param>
        internal string GerarClausula(string nome)
        {
            var data = DateTime.Now;


            var clausula = string.Format("O FUNCIONÁRIO {0} É CONTRATADO PELA EMPRESA YPSUM\nPARA PRESTAR SERVIÇOS DE PROGRAMADOR {1}", nome.ToUpper(), data);

            return clausula;
        }


    }
}
