using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosProcessoSeletivo
{
    class Program
    {
        /// <summary>
        /// Mostre o resultado de cada Exercicio na tela
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //DICA: USE UM LOOP DE REPETIÇÃO PARA MOSTRAR O NOME DE CADA FUNCIONARIO
            var ex1 = new Exercicio1();
            var funcionarios = ex1.GetFuncionarios();

            Console.WriteLine("Exercicio 1:\n");
            for (int i = 0; i < funcionarios.Count; i++)
            {
                Console.WriteLine(funcionarios[i].funcionario);
            }
            Console.WriteLine("------------------------------------\n");

            //DICA: USE UM LOOP DE REPETIÇÃO PARA MOSTRAR OS CODIGOS ORDENADOS NA TELA
            Console.WriteLine("Exercicio 2:\n");
            var ex2 = new Exercicio2();
            var codigos = funcionarios.Select(x => x.codigo).ToList();
            var codigosOrdenados = ex2.GetCodigosOrdenados(codigos);

            for (int i = 0; i < codigosOrdenados.Count; i++)
            {
                Console.WriteLine(codigosOrdenados[i].ToString());
            }
            Console.WriteLine("------------------------------------\n");
            Console.WriteLine("Exercicio 3:\n");
            var ex3 = new Exercicio3();
            //Descomente a linha a baixo, passe o nome do funcionario como parametro e mostre a clausula na tela
            foreach (var funcionario in funcionarios)
            {
                var clausula = ex3.GerarClausula(funcionario.funcionario);
                Console.WriteLine(clausula + "\n");
            }
            Console.ReadKey();

        }
    }
}
