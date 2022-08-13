namespace Extract_Subclass.AposRefatorar
{
    public class CarroGasolina : Carro
    {
        public CarroGasolina(string nome) : base(nome)
        {
        }
        public override void Abasteca()
        {
            Console.WriteLine("Abastecendo com gasolina");
        }
    }
}
