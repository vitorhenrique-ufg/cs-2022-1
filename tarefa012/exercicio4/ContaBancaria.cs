using exercicio4.Exception;

namespace exercicio4
{
    public class ContaBancaria
    {
        private double Saldo { get; set; } = 0;

        public void Depositar(double valor) =>
            Saldo += valor;

        public void Sacar(double valor)
        {
            if (valor > Saldo) throw new SaldoInsuficienteException("\nSaldo insuficiente para saque!");
            Saldo -= valor;
        }

        public double SaldoRestante() => Saldo;
    }
}
