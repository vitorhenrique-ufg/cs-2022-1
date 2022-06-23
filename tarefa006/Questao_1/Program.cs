namespace Questao_1
{
    public static class Program
    {
        private static int QuantidadeDiasAno => 365;
        private static int QuantidadeDiasMes => 30;

        static void Main(string[] args)
        {
            int ano;
            int mes;
            int dias;

            Console.WriteLine("-----VAMOS DESCOBRIR A IDADE DE UMA PESSOA EM DIAS.PREENCHA AS INFORMAÇÕES ABAIXO-----\n");

            Console.WriteLine("Digite a quantidade de anos");
            ano = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de meses");
            mes = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de dias");
            dias = Convert.ToInt32(Console.ReadLine());

            int quantidadeDeDias = (ano * QuantidadeDiasAno) + (mes * QuantidadeDiasMes) + dias;

            Console.WriteLine($"A pessoa com essas informações possui: {quantidadeDeDias} dias");
        }
    }
}