using SuperCalculadora;

internal class Program
{
    public static void Main(string[] args)
    {
        double resultado;
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

                Console.WriteLine();
                break;
            case "s":
                Console.WriteLine();
                break;
            case "m":
                resultado = multiplicacao.Calcular(num1,num2);
                Console.WriteLine($"O resultado da Multiplicação é: {resultado}");
                break;
            case "d":
                Console.WriteLine();
                break;
            default:
                Console.WriteLine("Entrada invalida");
                break;
        }

    }
}