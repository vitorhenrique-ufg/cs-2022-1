namespace endereco.Domain
{
    /// <summary>
    /// Classe para representar a entidade PessoaFisica
    /// Data: 15/07/2022
    /// Autor: Vitor Henrique Ferreira de Brito
    /// </summary>
    public class PessoaFisica
    {
        public string? Nome { get; set; }
        public string? Sexo { get; set; }
        public DateTime DataNascimento { get; set; }
        public List<Endereco> Enderecos { get; set; } = new();
    }
}
