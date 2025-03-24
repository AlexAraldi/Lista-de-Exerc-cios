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
           
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite seu peso: ");
            double peso = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite sua altura: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            double resultIMC = peso / (altura * altura);
            Console.WriteLine($"O IMC do {nome} é: {resultIMC}");

            if (resultIMC < 18.5)
            {
                Console.WriteLine($"{nome} está abaixo do peso. ");

            }
            else if (resultIMC < 25)
            {
                Console.WriteLine($"{nome} está com o peso normal. ");


            }
            else if ( resultIMC < 30)
            {
                Console.WriteLine($"{nome} está acima do peso. ");

            }
            else
            {

                Console.WriteLine($"{nome} está obeso pare de comer. ");

            }
            Console.ReadLine();

        }
    }
}
