namespace Extract_Class.AposRefatorar
{
    public class Endereco
    {
        private string logradouro;
        private string bairro;
        private string cidade;

        public Endereco(string logradouro, string bairro, string cidade)
        {
            this.logradouro = logradouro;
            this.bairro = bairro;
            this.cidade = cidade;
        }

        public override string ToString() =>
            $"Logradouro: {logradouro}\nBairro: {bairro}\nCidade: {cidade}";
    }
}
