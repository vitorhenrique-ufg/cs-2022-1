namespace Extract_Superclass.AposRefatorar
{
    public class Aluno : Pessoa
    {
        private int matricula;

        public Aluno(string nome, int idade, int matricula) : base(nome, idade)
        {
            this.matricula = matricula;
        }
    }
}
