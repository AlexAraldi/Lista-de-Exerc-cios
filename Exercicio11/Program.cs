using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Runtime.Intrinsics.X86;

namespace Exercicio11
{
    internal class Program
    {
        //11. Escreva um algoritmo para ler o nome e a idade de uma pessoa, e exibir quantos dias de vida ela possui.
        //Considere sempre anos completos, e que um ano possui 365 dias.Ex: uma pessoa com 19 anos possui 6935 dias
        //de vida; veja um exemplo de saída: MARIA, VOCÊ JÁ VIVEU 6935 DIAS.
        static void Main(string[] args)
        {
            Console.WriteLine("+++++++ Quantos dias você viveu? ----------");

            Console.WriteLine("- Qual seu nome nome?");
            Console.Write("Digite seu nome:  ");
            string nome = Console.ReadLine();
            Console.WriteLine("- Qual sua idade? ");
            Console.Write("Digite sua idade:  ");
            int idade = Convert.ToInt32(Console.ReadLine());

            int dias = idade * 365;
            Console.WriteLine($">>>> {nome} você já viveu: {dias} dias <<<<");
            Console.ReadLine();



        }
    }
}
