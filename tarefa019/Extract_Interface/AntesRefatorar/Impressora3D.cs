namespace Extract_Interface.AntesRefatorar
{
    public class Impressora3D
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
