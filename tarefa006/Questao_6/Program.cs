namespace Questao_6
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro");
            int numeroInteiro = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(@$"
Antecessor do número digitado: {numeroInteiro - 1}
Sucessor do número digitado: {numeroInteiro + 1}");
        }
    }
}