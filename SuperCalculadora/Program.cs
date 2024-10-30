using SuperCalculadora;

internal class Program
{
    public static void Main(string[] args)
    {
        Multiplicacao multiplicacao = new Multiplicacao();
        Console.WriteLine("Bem vindos a super calculadora");

        //teste multiplicação
        double resultado = multiplicacao.Calcular(1, 2);
        Console.WriteLine($"o resultado é: {resultado}");

    }
}