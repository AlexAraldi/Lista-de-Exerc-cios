using System.Runtime.Intrinsics.X86;

namespace Exercicio1
{
    internal class Program
    {

            // 1. Crie um programa para calcular o volume de uma caixa retangular
        static void Main(string[] args)
        {

            Console.Write("Digite o comprimento da caixa: ");
            decimal comprimento = Convert.ToDecimal( Console .ReadLine());

            Console.Write("Digite o largura da caixa: ");
            decimal largura = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Digite o altura da caixa: ");
            decimal altura = Convert.ToDecimal(Console.ReadLine());

            decimal resultado = comprimento * largura * altura;
            Console.WriteLine($"O volume da caixa é: {resultado} cm³.");
            Console.ReadLine();

        }
    }
}
