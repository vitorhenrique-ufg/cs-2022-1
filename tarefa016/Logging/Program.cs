namespace Tarefa016
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Logger logger = new();
            int[] array = new int[5];
            int index = 0;
            int numero = 1;
            while (numero != 0)
            {
                try
                {
                    Console.WriteLine("Digite um numero: ");
                    numero = Convert.ToInt32(Console.ReadLine());
                    array[index] = numero;
                    index++;
                }
                catch(Exception ex)
                {
                    logger.Log(ex.Message);
                    Environment.Exit(1);
                }
            }
        }
    }

    public abstract class LogBase
    {
        public abstract void Log(string Messsage);
    }

    public class Logger : LogBase
    {
        private string CurrentDirectory { get; set; }

        private string FileName { get; set; }

        private string FilePath { get; set; }

        public Logger()
        {
            CurrentDirectory = Directory.GetCurrentDirectory();
            FileName = "Log.txt";
            FilePath = $"{CurrentDirectory}/{FileName}";
        }

        public override void Log(string Messsage)
        {
            using StreamWriter w = File.AppendText(FilePath);
            w.Write("\r\nLog de erros: ");
            w.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            w.WriteLine("{0}", Messsage);
            w.WriteLine("-----------------------------------------------");
        }
    }
}

