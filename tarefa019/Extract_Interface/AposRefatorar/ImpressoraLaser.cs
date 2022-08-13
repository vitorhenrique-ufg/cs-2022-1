namespace Extract_Interface.AposRefatorar
{
    public class ImpressoraLaser : IImpressora
    {
        private readonly string nome;

        public ImpressoraLaser(string nomeImpressora)
        {
            nome = nomeImpressora;
        }

        public void Imprima()
        {
            Console.WriteLine($"A impressora {nome} está imprimindo no formato a laser\n");
        }
    }
}
