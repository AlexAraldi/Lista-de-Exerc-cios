namespace Exercicio7
{
    internal class Program
    {

        // 7. Crie um programa para calcular a média ponderada de duas provas realizadas por um aluno
        // Média ponderada = (nota1 x peso1 + nota2 x peso2) / (peso1 + peso2) 
        static void Main(string[] args)
        {
            Console.WriteLine(" ****** Calculadora de Ponderada ******");

            int[] notaPonderada = new int[5];
            Console.Write("Digite a primeira nota: ");
            notaPonderada[0] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            notaPonderada[1] = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Digite a terceira nota: ");
            notaPonderada[2] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a quarta nota: ");
            notaPonderada[3] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a quinta nota: ");
            notaPonderada[4] = Convert.ToInt32(Console.ReadLine());



            double resultado = (notaPonderada[0] * 1 + notaPonderada[1] * 1 + notaPonderada[2] * 1 + notaPonderada[3] * 1 + notaPonderada[4] * 1) / notaPonderada.Length;

            Console.WriteLine($"A média ponderada é: ({resultado})");

            Console.ReadLine();






        }
    }
}
