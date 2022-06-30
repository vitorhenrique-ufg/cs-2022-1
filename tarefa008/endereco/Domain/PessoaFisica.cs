namespace endereco.Domain
{
    public class PessoaFisica
    {
        public string? Nome { get; set; }
        public string? Sexo { get; set; }
        public DateTime DataNascimento { get; set; }
        public List<Endereco> Enderecos { get; set; } = new();
    }
}
