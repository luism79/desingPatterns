using FactoryV2.Models.Classes.Aircraft.NineNine;
using FactoryV2.Models.Classes.LandVehicle.NineNine;
using FactoryV2.Models.Interface;

namespace FactoryV2.Factory.Models
{
    internal class NineNineTransport : TransportFactory
    {
        protected override IBaseVehicle? CreateCar() => new NineNineCar();
        protected override IBaseVehicle? CreateMotorcycle() => new NineNineMotorcycle();
        protected override IBaseVehicle? CreateAircraft() => new NineNineAircraft();
        public NineNineTransport(TypeVehicle type) : base(type)
        {
        }
    }
}
