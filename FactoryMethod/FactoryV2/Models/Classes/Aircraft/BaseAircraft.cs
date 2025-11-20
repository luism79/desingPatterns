using FactoryV2.Models.Classes.LandVehicle;
using FactoryV2.Models.Interface.Aircraft;

namespace FactoryV2.Models.Classes.Aircraft
{
    abstract class BaseAircraft : IAircraft
    {
        public virtual string NameCompany => "Unknown";
        public abstract void CheckWind();
        public abstract void GetCargo();
        public virtual void StartRoute()
        {
            Console.WriteLine($"[{NameCompany}] - {GetType().Name}");
            CheckWind();
            GetCargo();
            Console.WriteLine($"[{NameCompany}] - Iniciando a decolagem.");
        }
    }
}
