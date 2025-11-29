using Builder.Components;
using Builder.Products;

namespace Builder.Builders
{
    internal interface IBuilder
    {
        Vehicle Build();
        IBuilder SetEngine(Engine engine);
        IBuilder SetSeats(int seats);
        IBuilder SetTransmition(Transmission transmission);
        IBuilder SetVehicleType(VehicleType vehicleType);
        IBuilder SetAirBags(Airbags airbags);
    }
}
