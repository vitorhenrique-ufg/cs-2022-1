namespace Extract_Subclass.AntesRefatorar
{
    public class Carro
    {
        private readonly string nome;
        private readonly bool ehCarroEletrico;

        public Carro(string nome, bool ehCarroEletrico)
        {
            this.nome = nome;
            this.ehCarroEletrico = ehCarroEletrico;
        }

        public void Abasteca()
        {
            Console.WriteLine(ehCarroEletrico ? "Recarregando a bateria" : "Abastecendo com gasolina");
        }
    }
}
