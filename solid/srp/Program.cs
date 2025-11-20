using srp.Model;

namespace srp
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new(94451)
            {
                Name = "Luis",
                DateOfBirth = new DateOnly(1982, 6, 30)
            };

            client.Print();
            Console.ReadLine();
        }
    }
}
