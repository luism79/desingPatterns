using FactoryMethod.Factories;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeArg = "";

            if (args.Length > 0)
                typeArg = args[0].ToLower()
                    .Replace("-", "");

            bool locatedArg = Enum.TryParse(typeArg, true, out TypeVehicle type);
            Transport? transport = TransportFactoryDictionary.Create(type);

            if (transport != null)
                transport.StartTransport();
            else Console.WriteLine("Não foi selecionado nenhum tipo de serviço.");

            Console.ReadLine();
        }
    }
}