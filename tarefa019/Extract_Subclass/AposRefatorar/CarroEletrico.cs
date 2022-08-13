namespace Extract_Subclass.AposRefatorar
{
    public class CarroEletrico : Carro
    {
        public CarroEletrico(string nome) : base(nome)
        {
        }

        public override void Abasteca()
        {
            Console.WriteLine("Recarregando a bateria");
        }
    }
}
