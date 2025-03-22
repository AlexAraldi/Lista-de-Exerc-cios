using static System.Reflection.Metadata.BlobBuilder;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;

namespace Exercicio10
{
    internal class Program
    {
        // 10. A padaria Hotpão vende uma certa quantidade de pães franceses e uma quantidade de broas a cada dia.Cada
        // pãozinho custa R$ 0,12 e a broa custa R$ 1,50. Ao final do dia, o dono quer saber quanto arrecadou com a
        // venda dos pães e broas (juntos), e quanto deve guardar numa conta de poupança (10% do total arrecadado).
        // Você foi contratado para fazer os cálculos para o dono.Com base nestes fatos, faça um algoritmo para ler as
        // quantidades de pães e de broas, e depois calcular os dados solicitados.
        static void Main(string[] args)
        {
            Console.WriteLine("°°°°°°° Calculadora de vendas - HotPão °°°°°°°°\n");

            Console.Write("Informe a quantidade de pães vendidos: ");
            // valor unidade 0,12
            int pao = Convert.ToInt32(Console.ReadLine());
            // valor unidade 1,50
            Console.Write("Informe a quantidade de broas vendidas: ");
            int broa = Convert.ToInt32(Console.ReadLine());

            double totalPao = pao * 0.12;
            double totalBroa = broa * 1.5;

            Console.WriteLine($"O valor total de pãe vendidos foi: R${totalPao}.");
            Console.WriteLine($"O valor total de broas vendidos foi: R${totalBroa}.");

            Console.ReadLine();
        }
    }
}
