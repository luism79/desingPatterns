using FactoryV2.Models.Interface;

namespace FactoryV2.Models.Interface.Aircraft
{
    internal interface IAircraft : IBaseVehicle
    {
        void CheckWind();
    }
}
