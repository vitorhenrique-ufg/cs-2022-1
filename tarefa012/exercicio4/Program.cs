using exercicio4.Exception;

namespace exercicio4
{
    public static class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria contaBancaria = new();

            Console.WriteLine("Digite um valor para deposito");
            double valorDeposito = Convert.ToDouble(Console.ReadLine());
            contaBancaria.Depositar(valorDeposito);

            Console.WriteLine("Digite um valor para saque");
            try
            {
                double valorSaque = Convert.ToDouble(Console.ReadLine());
                contaBancaria.Sacar(valorSaque);
            }
            catch (SaldoInsuficienteException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            Console.WriteLine($"\nSeu saldo é de R$ {contaBancaria.SaldoRestante()}");
        }
    }
}