namespace Generics
{
    public class Concessionaria<T>
        where T : Carro, new()
    {
        private readonly List<T> carros = new();

        public void FabriqueCarro<TTipo>()
            where TTipo : T, new()
        {
            TTipo carro = new();
            carros.Add(carro);
        }

        public void PubliqueAnuncios()
        {
            foreach (T carro in carros)
            {
                carro.ObtenhaDetalhesCarro();
                Console.WriteLine("----------------------//----------------------\n");
            }
        }
    }
}
