
namespace tarefa019
{

    //[TODO]
    //Extract superclass esta relacionado com o conceito de códigos comuns compartilhados
    //Um tipo de duplicação de código ocorre quando duas classes executam tarefas semelhantes da mesma maneira
    //ou executam tarefas semelhantes de maneiras diferentes.
    //Objetos oferecem um mecanismo embutido para simplificar tais situações por meio de herança

    public static class Program
    {
        static void Main(string[] args)
        {
            //Antes da refatoracao
            Extract_Superclass.AntesRefatorar.Pessoa pessoaAluno = new("Aluno 1", 14);
            pessoaAluno.DefinaMatricula(123);

            Extract_Superclass.AntesRefatorar.Pessoa pessoaProfessor = new("Professor 1", 24);
            pessoaProfessor.DefinaSalario(3425.35M);

            //Após a refatoracao
            Extract_Superclass.AposRefatorar.Pessoa pessoaAlunoRefatorado = new Extract_Superclass.AposRefatorar.Aluno("Vitor Henrique", 21, 201910913);
            Extract_Superclass.AposRefatorar.Pessoa pessoaProfessorRefatorado = new Extract_Superclass.AposRefatorar.Professor("Professor Joaozinho", 44, 5465.59M);
        }
    }
}