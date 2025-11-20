// See https://aka.ms/new-console-template for more information

using FactoryV2.Factory.Models;

StartTransport(new UberTransport(TypeVehicle.Car));

Console.WriteLine();

StartTransport(new NineNineTransport(TypeVehicle.Aircraft));

Console.WriteLine();

StartTransport(new NineNineTransport(TypeVehicle.Motorcycle));

Console.ReadKey();


static void StartTransport(TransportFactory transport)
{
    try
    {
        transport.CreateTransport();
        transport.StartTransport();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Falha na criação do transporte!\n{ex.Message}");
    }
}