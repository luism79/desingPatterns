namespace FactoryMethod.Vehicles
{
    internal class Car : BaseDelivery
    {
        public override void GetCarg()
        {
            Console.WriteLine("Pegamos os passageiros!");
        }

        public override void StartRoute()
        {
            GetCarg();
            Console.WriteLine("Iniciamos o trajeto!");
        }
    }
}
