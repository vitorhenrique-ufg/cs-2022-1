namespace Extract_Interface.AntesRefatorar
{
    public class ImpressoraLaser
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
