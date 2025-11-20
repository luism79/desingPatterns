namespace FactoryMethod.Vehicles
{
    internal class BaseDelivery : IVehicles
    {
        public virtual void GetCarg()
        {
            Console.WriteLine($"Veículo {GetType().Name} - Pegamos a encomenda!");
        }

        public virtual void StartRoute()
        {
            GetCarg();
            Console.WriteLine("Iniciamos a entrega!");
        }
    }
}
