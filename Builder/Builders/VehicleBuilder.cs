using Builder.Components;
using Builder.Products;

namespace Builder.Builders
{
    internal class VehicleBuilder : IBuilder
    {
        private Engine? engine;
        private VehicleType vehicleType;
        private Transmission transmission;
        private int seats;
        private Airbags? airbags;
        public Vehicle Build()
        {
            return new Vehicle()
            {
                Engine = engine!,
                VehicleType = vehicleType,
                Transmission = transmission,
                Seats = seats,
                Airbags = airbags!
            };
        }

        public IBuilder SetAirBags(Airbags airbags)
        {
            this.airbags = airbags!;
            return this;
        }

        public IBuilder SetEngine(Engine engine)
        {
            this.engine = engine;
            return this;
        }

        public IBuilder SetSeats(int seats)
        {
            this.seats = seats;
            return this;
        }

        public IBuilder SetTransmition(Transmission transmission)
        {
            this.transmission = transmission;
            return this;
        }

        public IBuilder SetVehicleType(VehicleType vehicleType)
        {
            this.vehicleType = vehicleType;
            return this;
        }
    }
}
