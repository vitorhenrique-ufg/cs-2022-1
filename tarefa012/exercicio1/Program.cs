namespace exercicio1
{
    public static class Program
    {
        private static readonly Func<int, int, decimal> Divida = (valor1, valor2) => valor1 / valor2;

        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro número");
            int numero1;
            int numero2;
            try
            {
                numero1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite o segundo número");
                numero2 = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException) //No C# a exceção InputMismatchException é utilizada como FormatException
            {
                Console.WriteLine("Número digitado inválido");
                return;
            }

            try
            {
                decimal resultado = Divida(numero1, numero2);
                Console.WriteLine($"\nO resultado da divisão é {resultado}");
            }
            catch (ArithmeticException)
            {
                Console.WriteLine("Não é possível fazer uma divisão por 0");
            }
        }
    }
}