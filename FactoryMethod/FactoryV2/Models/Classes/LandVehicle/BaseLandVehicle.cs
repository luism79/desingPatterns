using FactoryV2.Models.Interface.LandVehicle;

namespace FactoryV2.Models.Classes.LandVehicle
{
    abstract class BaseLandVehicle : ILandVehicle
    {
        public virtual string NameCompany => "Unknown";
        public abstract void GetCargo();
        public virtual void StartRoute()
        {
            Console.WriteLine($"[{NameCompany}] - {GetType().Name}");
            GetCargo();
        }
    }
}
