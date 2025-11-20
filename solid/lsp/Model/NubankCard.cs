namespace lsp.Model
{
    abstract class NubankCard : Card
    {
        private const string BANK = "Nubank";

        public NubankCard(int id) : base(id)
        {
            BankName = BANK;
        }
        public override void CollectPayment()
        {
            Console.WriteLine("Pagamento realizado!");
        }
    }
}
