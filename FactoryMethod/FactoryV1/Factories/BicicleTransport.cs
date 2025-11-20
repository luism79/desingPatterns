using FactoryMethod.Vehicles;

namespace FactoryMethod.Factories
{
    internal class BicicleTransport : Transport
    {
        protected override IVehicles CreateTransport()
        {
            return new Bicycle();
        }
    }
}
