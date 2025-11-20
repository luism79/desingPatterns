using FactoryV2.Models.Classes.Aircraft.Uber;
using FactoryV2.Models.Classes.LandVehicle.Uber;
using FactoryV2.Models.Interface;

namespace FactoryV2.Factory.Models
{
    internal class UberTransport : TransportFactory
    {
        protected override IBaseVehicle? CreateCar() =>  new UberCar();
        protected override IBaseVehicle? CreateMotorcycle() => new UberMotorcycle();
        protected override IBaseVehicle? CreateHelicopter() => new UberHelicopter();
        public UberTransport(TypeVehicle type) : base(type)
        {
        }
        
    }
}
