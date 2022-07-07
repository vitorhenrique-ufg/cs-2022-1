using exercicio2.Domain;

namespace exercicio2
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Agenda agenda = new();
            Contato contato1 = new()
            {
                Nome = "Contato 1",
                Email = "contato1@hotmail.com"
            };
            Contato contato2 = new()
            {
                Nome = "Contato 2",
                Email = "contato2@hotmail.com"
            };
            Contato contato3 = new()
            {
                Nome = "Contato 3",
                Email = "contato3@hotmail.com"
            };
            agenda.AdicioneContato(contato1);
            agenda.AdicioneContato(contato2);
            agenda.AdicioneContato(contato3);

            agenda.MostreContatosAgenda();
            Console.WriteLine($"-------- Removendo o contato: {contato2.Nome} --------\n");
            agenda.RemoveContato(contato2.Nome);
            Console.WriteLine($"Lista de contatos atualizada");
            agenda.MostreContatosAgenda();

            Console.WriteLine($"Pesquisando o {contato3.Nome} na lista");
            Contato? contatoEncontrado = agenda.ObtenhaContado(contato3.Nome);
            Console.WriteLine(contatoEncontrado?.Nome ?? "Não foi possível encontrar o contado acima");
        }
    }
}