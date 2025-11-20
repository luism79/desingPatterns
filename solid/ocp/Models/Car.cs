namespace ocp.Models
{
    internal class Car : Vehicle
    {
        public int Doors { get; set; } = 4;

        public Car(VehicleType type, int id) : base(type, id)
        {

        }

        public override void Print()
        {
            base.Print();
            Console.Write($"Doors.: {Doors}\n");
            Console.Write("--------------------\n\n");
        }
    }
}
