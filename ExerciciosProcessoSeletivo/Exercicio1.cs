using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosProcessoSeletivo
{
    public class Exercicio1
    {

        /// <summary>
        /// Retorne os functionarios ativos (em que a variavel excluido é falsa)
        /// </summary>
        /// <returns></returns>
        internal List<(string funcionario, int codigo, bool excluido)> GetFuncionarios()
        {
            var funcionariosAtivos = new List<(string funcionario, int codigo, bool excluido)>();

            var funcionariosBancoDedados = new List<(string funcionario, int codigo, bool excluido)>
            {
                ("Marcia", 1, false),
                ("Pablo", 8, false),
                ("Paulo", 2, false),
                ("Igor", 4, false),
                ("Franklien", 7, true),
                ("Pedro", 6, true),
                ("Mad", 10, true),
                ("Otto", 9, false),
            };

            foreach (var func in funcionariosBancoDedados)
            {
                while (func.excluido == true)
                {
                    funcionariosAtivos.Add(func);
                    break;
                }
            }

            //DICA USE A CLAUSULA WHERE(funcionario => funcionario)
            

            return funcionariosAtivos;
        }


    }
}
