namespace Extract_Interface.AntesRefatorar
{
    public class ImpressoraNormal
    {
        private readonly string nome;

        public ImpressoraNormal(string nomeImpressora)
        {
            nome = nomeImpressora;
        }

        public void Imprima()
        {
            Console.WriteLine($"A impressora {nome} está imprimindo no formato normal\n");
        }
    }
}
