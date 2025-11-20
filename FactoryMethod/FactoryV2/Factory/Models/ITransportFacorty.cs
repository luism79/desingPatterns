using FactoryV2.Models.Interface;

namespace FactoryV2.Factory.Models
{
    internal interface ITransportFactory
    {
        public IBaseVehicle? CreateTransport();
    }
}
