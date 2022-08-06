using System.Text.RegularExpressions;

namespace tarefa015
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Regex regexLogin = new("^(?=.*[@!#$%^&*.~()\\])(?=.*[0-9])(?=.*[A-z])[@!#$%^&*.~()\\a-zA-Z0-9]{5,30}$", RegexOptions.Compiled);
            Regex regexSenha = new("^(?=.*[@!#$%^&*.~()\\])(?=.*[0-9])(?=.*[A-Z])[@!#$%^&*.~()\\a-zA-Z0-9]{8,12}$", RegexOptions.Compiled);

            Console.WriteLine("Digite um login:");
            string? login = Console.ReadLine();

            string mensagemValidacao;
            if (!regexLogin.IsMatch(login!))
            {
                mensagemValidacao = @"
Para o login ser válido ele precisa satisfazer as seguintes regras:
- Possuir o tamanho de 5 a 30 caracteres.
- Possuir letras, números e caracteres especiais.
";
                Console.WriteLine(mensagemValidacao);
                return;
            }

            Console.WriteLine("Digite uma senha:");
            string? senha = Console.ReadLine();

            if (!regexSenha.IsMatch(senha!))
            {
                mensagemValidacao = @"
Para a senha ser válida ela precisa satisfazer as seguintes regras:
- Possuir o tamanho de 8 a 12 caracteres.
- Possuir letras, números e caracteres especiais.
- Possuir pelo menos uma letra maiúscula, um número e um caractere especial
";
                Console.WriteLine(mensagemValidacao);
                return;
            }

            Console.WriteLine("Login e senha informados estão válidos");
        }
    }
}