using dip.Payment;

namespace dip
{
    class Program
    {
        static void Main(string[] args)
        {
            PaymentProcess paymentProcess = new PaymentProcess();
            paymentProcess.Pay("A0001.6009577");

            Console.ReadLine();
        }
    }
}