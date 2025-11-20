using lsp.Model;

namespace lsp
{
    class Program
    {
        static void Main(string[] args)
        {
            //NubankCreditCard nubank = new(20335);
            //NubankDebitCard nubank = new(20339);
            NubankRewards nubank = new(3690255);

            Console.WriteLine(nubank.ToString());
            nubank.Validate();
            nubank.CollectPayment();

            Console.ReadLine();
        }
    }
}