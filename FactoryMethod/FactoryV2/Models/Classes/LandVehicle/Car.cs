using FactoryV2.Models.Interface.LandVehicle;

namespace FactoryV2.Models.Classes.LandVehicle
{
    internal class Car : BaseLandVehicle
    {
        public override void GetCargo()
        {
            Console.WriteLine($"[{NameCompany}] - Pegamos os passageiros!!!\n" +
                              $"[{NameCompany}] - Estamos prontos para partir.");
        }
        public override void StartRoute()
        {
            base.StartRoute();
            Console.WriteLine($"[{NameCompany}] - Iniciando o trajeto.");
        }
    }
}
