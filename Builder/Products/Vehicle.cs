using Builder.Components;

namespace Builder.Products
{
    internal class Vehicle
    {
        private Airbags airbags = null!;
        private Engine engine = null!;
        
        public Airbags Airbags
        {
            get => airbags;
            set => airbags = value;
        }
        public Engine Engine
        { 
            get => engine;
            set => engine = value; 
        }
        
        public VehicleType VehicleType { get; set; }
        
        public Transmission Transmission { get; set; }
        
        public int Seats { get; set; }
        
        public override string ToString()
        {
            string txt = Airbags == null ? "" :
                $"\nCount AirBags..: {Airbags.Count.ToString()}";

            return $"Class..........: {GetType().Name}\n" +
                   $"Engine.........: {Engine.Power.ToString()}\n" +
                   $"VehicleType....: {VehicleType}\n" +
                   $"Transmission...: {Transmission}\n" +
                   $"Seats..........: {Seats}" +
                   $"{txt}";
        }
    }
}
