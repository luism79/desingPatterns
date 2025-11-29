using Builder.Builders;
using Builder.Components;

namespace Builder.Directors
{
    internal class Director
    {
        private IBuilder? builder;
        public Director(IBuilder builder) => this.builder = builder!;
        public void ConstructorSedanCar()
        {
            builder!
                .SetVehicleType(VehicleType.Sedan)
                .SetEngine(new Engine(2000))
                .SetTransmition(Transmission.Automatic)
                .SetSeats(4);
        }
        public void ConstructorHachtCar()
        {
            builder!
                .SetVehicleType(VehicleType.Hacth)
                .SetEngine(new Engine(1600))
                .SetTransmition(Transmission.Manual)
                .SetSeats(4);
        }

        public void ConstructorSuvCar()
        {
            builder!
                .SetVehicleType(VehicleType.Suv)
                .SetEngine(new Engine(2600))
                .SetTransmition(Transmission.AutomaticSequential)
                .SetAirBags(new Airbags(4))
                .SetSeats(5);
        }

    }
}
