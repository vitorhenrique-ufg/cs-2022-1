using exercicio1.Ordenacao;
using System.Diagnostics;

namespace exercicio1
{
    public static class Program
    {
        private static readonly Random _random = new();

        static void Main(string[] args)
        {
            int[] cemNumeros = new int[100];
            int[] cemNumeros2 = new int[100];
            int[] milNumeros = new int[1000];
            int[] milNumeros2 = new int[1000];
            int[] dezMilNumeros = new int[10000];
            int[] dezMilNumeros2 = new int[10000];

            MergeSort mergeSort = new();
            MergeSortRecursivo mergeSortRecursivo = new();

            PopuleLista(cemNumeros);
            PopuleLista(cemNumeros2);
            PopuleLista(milNumeros);
            PopuleLista(milNumeros2);
            PopuleLista(dezMilNumeros);
            PopuleLista(dezMilNumeros2);

            Stopwatch stopWatch = new();
            stopWatch.Start();
            mergeSort.OrdeneLista(cemNumeros);
            stopWatch.Stop();
            TimeSpan tempo100 = stopWatch.Elapsed;
            Console.WriteLine($"Tempo para 100 números interativo: {tempo100}");

            stopWatch.Reset();
            stopWatch.Start();
            cemNumeros2 = mergeSortRecursivo.OrdeneLista(cemNumeros2.ToList()).ToArray();
            stopWatch.Stop();
            TimeSpan tempo100Recursivo = stopWatch.Elapsed;
            Console.WriteLine($"Tempo para 100 números recursivo: {tempo100Recursivo}\n");

            stopWatch.Reset();
            stopWatch.Start();
            mergeSort.OrdeneLista(milNumeros);
            stopWatch.Stop();
            TimeSpan tempo1000 = stopWatch.Elapsed;
            Console.WriteLine($"Tempo para 1000 números interativo: {tempo1000}");

            stopWatch.Start();
            milNumeros2 = mergeSortRecursivo.OrdeneLista(milNumeros2.ToList()).ToArray();
            stopWatch.Stop();
            TimeSpan tempo1000Recursivo = stopWatch.Elapsed;
            Console.WriteLine($"Tempo para 1000 números recursivo: {tempo1000Recursivo}\n");

            stopWatch.Reset();
            stopWatch.Start();
            mergeSort.OrdeneLista(dezMilNumeros);
            stopWatch.Stop();
            TimeSpan tempo10000 = stopWatch.Elapsed;
            Console.WriteLine($"Tempo para 10000 números interativo: {tempo10000}");

            stopWatch.Start();
            dezMilNumeros2 =  mergeSortRecursivo.OrdeneLista(dezMilNumeros2.ToList()).ToArray();
            stopWatch.Stop();
            TimeSpan tempo10000Recursivo = stopWatch.Elapsed;
            Console.WriteLine($"Tempo para 10000 números recursivo: {tempo10000Recursivo}");
        }

        private static void PopuleLista(int[] lista)
        {
            for (int i = 0; i < lista.Length; i++)
            {
                lista[i] = _random.Next(0, lista.Length);
            }
        }
    }
}