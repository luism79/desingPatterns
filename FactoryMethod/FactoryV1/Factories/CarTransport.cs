using FactoryMethod.Vehicles;

namespace FactoryMethod.Factories
{
    internal class CarTransport : Transport
    {
        protected override IVehicles CreateTransport()
        {
            return new Car();
        }
    }
}
