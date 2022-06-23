namespace Questao_3
{
    public static class Program
    {
        static void Main(string[] args)
        {
            decimal reajuste = 0.15M;

            Console.WriteLine("Digite o valor de um saldo");
            string? valorDigitado = Console.ReadLine();
            while (!decimal.TryParse(valorDigitado, out _))
            {
                Console.WriteLine("Digite um valor válido");
                valorDigitado = Console.ReadLine();
            }

            decimal saldo = Convert.ToDecimal(valorDigitado);
            saldo += (saldo * reajuste);

            Console.WriteLine($"O valor do saldo após o reajuste de 15% foi para: {saldo}");
        }
    }
}