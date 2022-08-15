namespace Tarefa016
{
    public static class Program
    {
        private static readonly Func<decimal, decimal, decimal> CalculeSalario = (valorSalario, valorImposto) =>
        {
            decimal descontoImposto = valorSalario * (valorImposto) / 100;
            return valorSalario - descontoImposto;
        };

        public abstract class Pessoa
        {
            private readonly string nome;
            private readonly decimal salario;

            public Pessoa(string nome, decimal salario)
            {
                this.nome = nome;
                this.salario = salario;
            }
            public decimal ObtenhaSalario() => salario;

            public string ObtenhaNome() => nome;
        }

        public class Advogado : Pessoa
        {
            public Advogado(string nome, decimal salario) : base(nome, salario)
            {
            }
        }

        public class Medico : Pessoa
        {
            public Medico(string nome, decimal salario) : base(nome, salario)
            {
            }
        }

        static void Main(string[] args)
        {
            Pessoa advogado = new Advogado("Vitor Henrique", 8000);
            Pessoa medico = new Medico("Lucas Oliveira", 15635.45M);

            decimal salarioAdvogado = CalculeSalario(advogado.ObtenhaSalario(), 30);
            decimal salarioMedico = CalculeSalario(medico.ObtenhaSalario(), 35);

            Console.WriteLine($"O Advogado {advogado.ObtenhaNome()} recebe um salário de R$ {salarioAdvogado:N2}\n\n");
            Console.WriteLine($"O Médico {medico.ObtenhaNome()} recebe um salário de R$ {salarioMedico:N2}\n\n");
        }
    }
}