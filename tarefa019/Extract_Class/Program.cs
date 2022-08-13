using Extract_Class.AposRefatorar;

namespace tarefa019
{
    public static class Program
    {
        static void Main(string[] args)
        {
            //[TODO]
            //Extract Class é o conceito ligado ao princípio de responsabilidade única
            //Esse método de refatoração ajudará a manter a adesão ao princípio da responsabilidade unica.
            //O código de suas classes será mais óbvio e compreensível.

            //Antes da refatoracao
            Extract_Class.AntesRefatorar.Pessoa pessoaNaoRefatorada = new("Vitor Henrique");
            pessoaNaoRefatorada.DefinaLogradouro("Rua montanhola");
            pessoaNaoRefatorada.DefinaBairro("Vila Cristina");
            pessoaNaoRefatorada.DefinaCidade("Goiânia");
            Console.WriteLine(pessoaNaoRefatorada.ObtenhaEndereco());

            //Após a refatoracao
            Extract_Class.AposRefatorar.Pessoa pessoaRefatorada = new("Vitor Henrique");
            Endereco endereco = new("Rua montanhola", "Vila Cristina", "Goiânia");
            pessoaRefatorada.DefinaEndereco(endereco);
            Console.WriteLine("\n" + pessoaRefatorada.ObtenhaEndereco());
        }
    }
}