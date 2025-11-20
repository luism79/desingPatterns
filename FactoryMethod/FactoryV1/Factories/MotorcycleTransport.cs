using FactoryMethod.Vehicles;

namespace FactoryMethod.Factories
{
    internal class MotorcycleTransport : Transport
    {
        protected override IVehicles CreateTransport()
        {
            return new Motorcycle();
        }
    }
}
