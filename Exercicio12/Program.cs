using System.ComponentModel.DataAnnotations;

namespace Exercicio12
{
    internal class Program
    {
        //12. Faça um algoritmo para ler o salário de um funcionário e aumentá-lo em 15%. Após o aumento, desconte 8% de
        //impostos.Imprima o salário inicial, o salário com o aumento e o salário final.
        static void Main(string[] args)
        {
            Console.WriteLine("<<<<<<Calculadora salarial>>>>>>");

            Console.Write("Escreva o salário inicial: R$  ");

            double salario1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"O salario base é R$ {salario1}.");

            double salario2 = (salario1 * 0.15) + salario1;
            Console.WriteLine($"O salário com bonificação é: R$ {salario2}.");

            double salario3 = (salario2 * 0.8);
            Console.WriteLine($"O salário final é: R$ {salario3}.");

            Console.ReadLine();

        }
    }
}
