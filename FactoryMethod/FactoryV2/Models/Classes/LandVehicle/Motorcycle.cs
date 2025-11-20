namespace FactoryV2.Models.Classes.LandVehicle
{
    internal class Motorcycle : BaseLandVehicle
    {
        public override void GetCargo()
        {
            Console.WriteLine($"[{NameCompany}] - Pegamos a encomenda!");
        }
        public override void StartRoute()
        {
            base.StartRoute();
            Console.WriteLine($"[{NameCompany}] - Iniciando a entrega.");
        }
    }
}
