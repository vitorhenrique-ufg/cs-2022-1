using exercicio3.Exception;

namespace exercicio3
{
    public class Login
    {
        private readonly Dictionary<string, string> _storageLogin = new()
        {
            ["usuario"] = "senha"
        };

        private string? Usuario { get; set; }

        private string? Senha { get; set; }

        public bool FazerLogin(string usuario, string senha)
        {
            bool possuiLogin = _storageLogin.ContainsKey(usuario) && _storageLogin[usuario] == senha;
            if (!possuiLogin) throw new LoginInvalidoException("\nLogin ou senha incorreto");

            return possuiLogin;
        }
    }
}
