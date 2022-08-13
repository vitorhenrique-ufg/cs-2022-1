namespace Extract_Superclass.AntesRefatorar
{
    public class Pessoa
    {
        private string nome;
        private int idade;
        private decimal salario;
        private int matricula;

        public Pessoa(string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
        }

        public void DefinaSalario(decimal salario)
        {
            this.salario = salario;
        }

        public void DefinaMatricula(int matricula)
        {
            this.matricula = matricula;
        }
    }
}
