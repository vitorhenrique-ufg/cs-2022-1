namespace endereco.Domain
{
    /// <summary>
    /// Classe para representar a entidade Estado
    /// Data: 15/07/2022
    /// Autor: Vitor Henrique Ferreira de Brito
    /// </summary>
    public class Estado
    {
        public string? Sigla { get; set; }
        public string? Nome { get; set; }
        public Pais? Pais { get; set; }
    }
}
