namespace Generics
{
    public class Corolla : Carro
    {
        public override void ObtenhaDetalhesCarro()
        {
            Console.WriteLine($"Carro: Corolla\nMarca: Toyota\nPreço: R$ 150.000,00");
        }
    }
}
