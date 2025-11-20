namespace ocp.Models
{  
    enum VehicleType
    {
        Car,
        MotorCycle,
        Truck
    }

    internal class Vehicle
    {
        private static readonly Dictionary<VehicleType, string> LableVehicleType = new()
        {
            { VehicleType.Car, "Car" },
            { VehicleType.MotorCycle, "Motorcycle" },
            { VehicleType.Truck, "Truck" }
        };

        private string GetLableType()
        {
            return LableVehicleType[Type];
        }

        public Vehicle(VehicleType type, int id)
        {
            Type = type;
            ID = id;
        }

        public int ID { get; }
        public VehicleType Type { get; }
        public string Color { get; set; } = "";
        public int Year { get; set; } = DateTime.Now.Year;
        public virtual void Print()
        {
            Console.Write($"ID....: {ID}\n" +
                          $"Type..: {GetLableType()}\n" +
                          $"Color.: {Color}\n" +
                          $"Year..: {Year}\n");
        }
    }
}
