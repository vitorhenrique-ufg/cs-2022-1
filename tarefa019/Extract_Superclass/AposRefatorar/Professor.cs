namespace Extract_Superclass.AposRefatorar
{
    public class Professor : Pessoa
    {
        private decimal salario;

        public Professor(string nome, int idade, decimal salario) : base(nome, idade)
        {
            this.salario = salario;
        }
    }
}
