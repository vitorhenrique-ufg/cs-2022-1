namespace Questao_2
{
    public static class Program
    {
        static void Main(string[] args)
        {
            decimal mediaSeteOitoNove = CalculeMedia(7,8,9);
            decimal mediaQuatroCincoSeis = CalculeMedia(4,5,6);
            decimal somaDuasMedias = mediaSeteOitoNove + mediaQuatroCincoSeis;
            decimal mediaDasMedias = CalculeMedia(mediaSeteOitoNove, mediaQuatroCincoSeis);

            Console.WriteLine($@"
Média aritimética dos número 7,8,9: {mediaSeteOitoNove}
Média aritimética dos número 4,5,6: {mediaQuatroCincoSeis}
Soma das duas médias: {somaDuasMedias}
Média das médias: {mediaDasMedias}");
        }

        static decimal CalculeMedia(params decimal[] numeros)
        {
            int quantidadeNumeros = numeros.Length;
            return quantidadeNumeros > 0 ? numeros.Sum() / quantidadeNumeros : 0;
        }
    }
}