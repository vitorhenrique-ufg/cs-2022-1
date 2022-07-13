namespace exercicio4.Exception
{
    public class SaldoInsuficienteException : SystemException
    {
        public SaldoInsuficienteException(string mensagem) : base(mensagem)
        { }
    }
}
