namespace Extract_Subclass.AposRefatorar
{
    public abstract class Carro
    {
        private readonly string nome;

        public Carro(string nome)
        {
            this.nome = nome;
        }

        public abstract void Abasteca();
    }
}
