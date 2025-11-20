namespace ocp.Models
{
    internal class Motorcycle : Vehicle
    {
        public Motorcycle(VehicleType type, int id) : base(type, id)
        {
        }

        public override void Print()
        {
            base.Print();
            Console.Write("--------------------\n\n");
        }
    }
}
