namespace Tarefa009.Domain
{
    public abstract class Animal
    {
        public string? Nome { get; set; }

        public int Idade { get; set; }

        public string? Som { get; set; }

        public abstract string AcaoDoAnimal();

        public abstract string EmitirSom();
    }
}
