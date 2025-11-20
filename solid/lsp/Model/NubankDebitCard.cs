namespace lsp.Model
{
    internal class NubankDebitCard : NubankCard
    {
        public NubankDebitCard(int id) : base(id)
        {
            CardType = CardType.Debit;
        }

        public override void Validate()
        {
            Console.WriteLine("Validando o saldo...");
            Console.WriteLine("Saldo disponível.");
        }
    }
}
