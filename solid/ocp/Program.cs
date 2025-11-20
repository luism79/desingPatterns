using ocp.Models;

namespace ocp
{
    class Program
    {
        static void Main(string[] args)
        {
            Car vehicle = new(VehicleType.Car, 1)
            {
                Color = "Blue",
                Year = 2024,
            };

            Motorcycle moto = new(VehicleType.MotorCycle, 1)
            { 
                Color = "Black"
            };

            vehicle.Print();
            moto.Print();

            Console.ReadLine();
        }
    }
}
