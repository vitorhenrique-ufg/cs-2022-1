
namespace tarefa019
{
    //[TODO]
    //Extract method permite isolar os comportamentos em metodos específicos
    //no qual você possui um fragmento de código que pode ser agrupado.

    public static class Program
    {
        static void Main(string[] args)
        {
            //Antes da refatoracao
            decimal notaAValiacao1 = 6.5M;
            decimal notaAValiacao2 = 2;
            decimal notaAValiacao3 = 8.2M;

            decimal mediaAvaliacoes = (notaAValiacao1 + notaAValiacao2 + notaAValiacao3) / 3;
            Console.WriteLine($"A média final do aluno foi de: {mediaAvaliacoes:N2}");

            //Após a refatoracao
            decimal notaAValiacaoRefatorada1 = 6.5M;
            decimal notaAValiacaoRefatorada2 = 2;
            decimal notaAValiacaoRefatorada3 = 8.2M;

            decimal mediaAvaliacoesRefatorada = CalculeMedia(notaAValiacaoRefatorada1, notaAValiacaoRefatorada2, notaAValiacaoRefatorada3);
            Console.WriteLine($"A média final do aluno foi de: {mediaAvaliacoesRefatorada:N2}");
        }

        private static decimal CalculeMedia(params decimal[] notas) =>
            notas.Sum() / notas.Length;
    }
}