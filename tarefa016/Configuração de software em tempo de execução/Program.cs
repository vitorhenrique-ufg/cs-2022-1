using System.Configuration;

namespace Tarefa016
{
    public static class Program
    {
        static void Main(string[] args)
        {
            string connectionStringConfiguration = ConfigurationManager.AppSettings["connectionString"];
            string connectionString = string.Format(connectionStringConfiguration, "conexao1");

            Console.WriteLine($"A string de conexão com o banco de dados é: \n{connectionString}");
        }
    }
}