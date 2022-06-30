using endereco.Enum;

namespace endereco.Domain
{
    public class Endereco
    {
        public int Numero { get; set; }
        public string? Complemento { get; set; }
        public int CEP { get; set; }
        public Bairro? Bairro { get; set; }
        public TipoEndereco TipoEndereco { get; set; }
        public Logradouro? Logradouro { get; set; }
    }
}
