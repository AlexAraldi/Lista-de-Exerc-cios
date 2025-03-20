namespace Exercicio2
{
    internal class Program
    {
        // 2. Crie um programa para calcular o volume de um Cilindro
        // Formula V = π r² h
        static void Main(string[] args)
        {

            Console.Write("Digite o valor do raio: ");
            double raio = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor do altura: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            double volume = Math.PI * Math.Pow(raio, 2) * altura;

            Console.WriteLine($"O volume do cilindro é: {volume} cm³.");
            
            Console.ReadLine();
        }
    }
}
