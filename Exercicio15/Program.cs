namespace Exercicio15
{
    internal class Program
    {
        // 15. O IMC – Índice de Massa Corporal é um critério da Organização Mundial de Saúde para dar uma indicação sobre
        // a condição de peso de uma pessoa adulta.A fórmula é IMC = peso / (altura) ². Elabore um algoritmo que leia o
        // peso e a altura de um adulto e mostre sua condição de acordo com a listagem abaixo:
        // ● IMC em adultos Condição
        // ● Abaixo de 18,5
        // ● Abaixo do peso
        // ● Entre 18,5 e 25 Peso normal
        // ● Entre 25 e 30
        // ● Acima do peso
        // ● Acima de 30 obeso
        static void Main(string[] args)
        {
            Console.WriteLine(">>>>>>>>>>> Calculadora de IMC.");
            string nome;
            Console.WriteLine(" Digite seu nome: ");

            Console.WriteLine(" Digite seu peso: ");
            double peso = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" Digite sua altura: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            

        }
    }
}
