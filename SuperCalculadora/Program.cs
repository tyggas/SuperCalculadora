using SuperCalculadora;

internal class Program

{

    public static void Main(string[] args)

    {

        double resultado;

        Adicao adicao = new Adicao();

        Subtracao subtracao = new Subtracao();

        Divisao divisao = new Divisao();

        Multiplicacao multiplicacao = new Multiplicacao();

        Console.WriteLine("Bem vindos a super calculadora");

        Console.WriteLine("Escolha a operação" +

                          "\nAdição - a" +

                          "\nSubtração - s" +

                          "\nMultiplicação - m" +

                          "\nDivisão - d");

        string entrada = Console.ReadLine();

        Console.WriteLine("Insira o primeiro numero");

        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Insira o segundo numero");

        int num2 = int.Parse(Console.ReadLine());

        switch (entrada)

        {

            case "a":

                resultado = adicao.Calcular(num1, num2);

                Console.WriteLine($"O resultado da adição é: {resultado}");

                break;

            case "s":

                resultado = subtracao.Calcular(num1, num2);

                Console.WriteLine($"O resultado da subtração é: {resultado}");

                break;

            case "m":

                resultado = multiplicacao.Calcular(num1, num2);

                Console.WriteLine($"O resultado da Multiplicação é: {resultado}");

                break;

            case "d":

                resultado = divisao.Calcular(num1, num2);

                Console.WriteLine($"O resultado da divisão é: {resultado}");

                break;

            default:

                Console.WriteLine("Entrada invalida");

                break;

        }

    }

}
