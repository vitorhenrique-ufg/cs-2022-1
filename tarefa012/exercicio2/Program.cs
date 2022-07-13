namespace exercicio2
{
    public static class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            int index = 0;
            int numero = 1;
            try
            {
                while(numero != 0)
                {
                    Console.WriteLine($"Digite o {index + 1} número");
                    numero = Convert.ToInt32(Console.ReadLine());
                    array[index] = numero;
                    index++;
                }
                Console.WriteLine("\nOs seguintes números foram inseridos no array: " + String.Join(" ", array));
            }
            catch (FormatException) //No C# a exceção InputMismatchException é utilizada como FormatException
            {
                Console.WriteLine("Número digitado inválido");
                return;
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("A quantidade de elementos ultrapassou o limite do array");
            }
        }
    }
}