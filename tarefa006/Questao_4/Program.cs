namespace Questao_4
{
    public class Program
    {
        private static Func<decimal, decimal> CalculeIPI => (value) => (value / 100) + 1;

        private static Func<Produto, Produto, decimal, decimal> CalculeTotalPago
            => (produto1, produto2, valorIPI)
            => ((produto1.Valor * produto1.Quantidade) + (produto2.Valor * produto2.Quantidade)) * CalculeIPI(valorIPI);

        static void Main(string[] args)
        {
            Console.WriteLine("Digite a porcentagem de IPI a ser acrescida");
            decimal valorIPI = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite o codigo da peça 1");
            int codigoPeca = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor unitário da peça 1");
            decimal valorUnitario = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite a quantidade para a peça 1");
            int quantidade = Convert.ToInt32(Console.ReadLine());

            Produto produto1 = new()
            {
                Codigo = codigoPeca,
                Valor = valorUnitario,
                Quantidade = quantidade
            };

            Console.WriteLine("Digite o codigo da peça 2");
            codigoPeca = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor unitário da peça 2");
            valorUnitario = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite a quantidade para a peça 2");
            quantidade = Convert.ToInt32(Console.ReadLine());

            Produto produto2 = new()
            {
                Codigo = codigoPeca,
                Valor = valorUnitario,
                Quantidade = quantidade
            };

            decimal valorTotalPago = CalculeTotalPago(produto1, produto2, valorIPI);
            Console.WriteLine($"O valor a ser pago é de R$ {valorTotalPago}");
        }

        private sealed class Produto
        {
            public int Codigo { get; set; }
            public decimal Valor { get; set; }
            public int Quantidade { get; set; }
        }
    }
}