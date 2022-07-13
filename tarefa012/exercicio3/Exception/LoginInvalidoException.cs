namespace exercicio3.Exception
{
    public class LoginInvalidoException : SystemException
    {
        public LoginInvalidoException(string mensagem) : base(mensagem)
        { }
    }
}
