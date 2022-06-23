namespace Questao_5
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor de um salário minímo");
            decimal valorSalarioMinimo = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite o valor do salário de um usuário");
            decimal valorSalarioUsuario = Convert.ToDecimal(Console.ReadLine());

            decimal quantidadeDeSalarioMinimo = valorSalarioUsuario / valorSalarioMinimo;
            Console.WriteLine($"{decimal.Round(quantidadeDeSalarioMinimo, 2)}SM = R$ {decimal.Round(valorSalarioUsuario, 2)}");
        }
    }
}