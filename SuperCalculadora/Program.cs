using SuperCalculadora;

internal class Program
{
    public static void Main(string[] args)
    {

        double resultado;
        string entrada;

        do
        {

            Adicao adicao = new Adicao();
            Subtracao subtracao = new Subtracao();
            Multiplicacao multiplicacao = new Multiplicacao();
            Divisao divisao = new Divisao();

            Console.WriteLine("Bem vindos a super calculadora");
            Console.WriteLine("Escolha a operação" +
                              "\nAdição - a" +
                              "\nSubtração - s" +
                              "\nMultiplicação - m" +
                              "\nDivisão - d" +
                              "\nPara sair do programa - f");
            entrada = Console.ReadLine();

            if (entrada == "f")
            {
                break;
            }
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

        }while (true);
        }
}