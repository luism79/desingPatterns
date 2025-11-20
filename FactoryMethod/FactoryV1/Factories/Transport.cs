using FactoryMethod.Vehicles;

namespace FactoryMethod.Factories
{
    abstract class Transport
    {
        protected abstract IVehicles CreateTransport();
        public void StartTransport()
        {
            IVehicles vehicle = CreateTransport();
            vehicle.StartRoute();

        }
    }
}
