using FactoryV2.Models.Interface;

namespace FactoryV2.Factory.Models
{
    public enum TypeVehicle
    {
        Car,
        Motorcycle,
        Aircraft,
        Helicopter
    }
    abstract class TransportFactory : ITransportFactory
    {
        private TypeVehicle typeVehicle;
        private IBaseVehicle? baseVehicle;
        private bool IsSupported(TypeVehicle type, out IBaseVehicle? vehicle)
        {
            vehicle = null;

            if (Factories.TryGetValue(type, out var factory))
            {
                vehicle = factory();
            }
            return vehicle != null;
        }
        protected virtual IBaseVehicle? CreateCar() => null;
        protected virtual IBaseVehicle? CreateMotorcycle() => null;
        protected virtual IBaseVehicle? CreateAircraft() => null;
        protected virtual IBaseVehicle? CreateHelicopter() => null;
        // Dictionary que mapeia o enum para funções factory
        private Dictionary<TypeVehicle, Func<IBaseVehicle?>> Factories =>
            new Dictionary<TypeVehicle, Func<IBaseVehicle?>>
            {
                { TypeVehicle.Car, () => CreateCar() },
                { TypeVehicle.Motorcycle, () => CreateMotorcycle() },
                { TypeVehicle.Aircraft, () => CreateAircraft() },
                { TypeVehicle.Helicopter, () => CreateHelicopter() }
            };
        public IBaseVehicle? CreateTransport()
        {
            if (!IsSupported(typeVehicle, out baseVehicle))
            {
                throw new NotSupportedException($"[{GetType().Name}] - O tipo de veículo '{typeVehicle}' não é suportado.");
            }            
            return baseVehicle;
        }
        public TransportFactory(TypeVehicle type) => typeVehicle = type;

        public void StartTransport()
        {
            if (baseVehicle != null)
            {
                baseVehicle.StartRoute();
            }
        }
    }
}
