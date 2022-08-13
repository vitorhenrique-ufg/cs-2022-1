namespace Extract_Interface.AposRefatorar
{
    public class Impressora3D : IImpressora
    {
        private readonly string nome;

        public Impressora3D(string nomeImpressora)
        {
            nome = nomeImpressora;
        }

        public void Imprima()
        {
            Console.WriteLine($"A impressora {nome} está imprimindo no formato 3D\n");
        }
    }
}
