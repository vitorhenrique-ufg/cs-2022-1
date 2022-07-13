using exercicio3.Exception;

namespace exercicio3
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o Usuário");
            string? usuario = Console.ReadLine();
            Console.WriteLine("Digite a Senha");
            string? senha = Console.ReadLine();

            Login login = new();
            try
            {
                login.FazerLogin(usuario!, senha!);
            }
            catch (LoginInvalidoException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            Console.WriteLine("\nLogado com sucesso!");
        }
    }
}