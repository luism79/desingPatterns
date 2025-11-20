namespace FactoryV2.Models.Classes.Aircraft
{
    internal class Helicopter : BaseAircraft
    {
        public override void CheckWind()
        {
            Console.WriteLine($"[{NameCompany}] - Verificando vento!\n" +
                              $"[{NameCompany}] - Vento sudeste...ventos ok");
        }
        public override void GetCargo()
        {
            Console.WriteLine($"[{NameCompany}] - Passageiros a bordo!\n" +
                              $"[{NameCompany}] - Ligando as hélices.");
        }
    }
}
