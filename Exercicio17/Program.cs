namespace Exercicio17
{
    internal class Program
    {
        //17. Faça um algoritmo que leia dois valores inteiros A e B, se os valores forem iguais deverá se somar os dois, caso
        //contrário multiplique A por B.Ao final de qualquer um dos cálculos deve-se atribuir o resultado para uma
        //variável C e mostrar seu conteúdo na tela.
        static void Main(string[] args)
        {
            while(true) 
            {
                Console.Clear();
                Console.WriteLine("Cálculo de valores");
                Console.WriteLine("Escreva o primeiro número: ");
                int valorA = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Escreva o segundo número: ");
                int valorB = Convert.ToInt32(Console.ReadLine());

                int valorFinal = 0;
                string operacao = "";
                if (valorA == valorB)
                {
                    valorFinal = valorA + valorB;
                    operacao = "O valor foi somado: ";
                }
                else
                {
                    valorFinal = (valorA * valorB);
                    operacao = "O valor foi multiplicado: ";
                }


                Console.WriteLine(operacao + valorFinal);

                Console.WriteLine("Você quer continuar? s/N  ");


                string opcaoContinuar = Console.ReadLine().ToUpper();

                if (opcaoContinuar != "S")
                    break;
                

            }
        }
    }
}
