namespace FactoryV2.Models.Classes.Aircraft
{
    internal class Aircraft : BaseAircraft
    {
        public override void CheckWind() 
        {
            Console.WriteLine($"[{NameCompany}] - Verificando a velocidade dos ventos!");
        }
        public override void GetCargo()
        {
            Console.WriteLine($"[{NameCompany}] - Passageiros a bordo!\n" +
                              $"[{NameCompany}] - Vôo autorizado.");
        }
    }
}
