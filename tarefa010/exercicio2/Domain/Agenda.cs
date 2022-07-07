namespace exercicio2.Domain
{
    public class Agenda
    {
        private List<Contato> Contatos { get; } = new();

        public void AdicioneContato(Contato contado) =>
            Contatos.Add(contado);

        public Contato? ObtenhaContado(string filtroPesquisa) =>
            Contatos.FirstOrDefault(m => Equals(m.Email, filtroPesquisa) || Equals(m.Nome, filtroPesquisa));

        public void RemoveContato(string filtroPesquisa)
        {
            Contato? contato = Contatos.FirstOrDefault(m => Equals(m.Nome, filtroPesquisa));
            if(contato is not null)
            {
                Contatos.Remove(contato);
            }
        }

        public void MostreContatosAgenda()
        {
            string contatos = string.Join('\n', Contatos.Select(m => m.Nome));
            Console.WriteLine($"Contatos: \n{contatos}\nQuantidade de contatos: {Contatos.Count}\n");
        }
    }
}
