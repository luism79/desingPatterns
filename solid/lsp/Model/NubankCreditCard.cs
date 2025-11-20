namespace lsp.Model
{
    internal class NubankCreditCard : NubankCard
    {
        public NubankCreditCard(int id) : base(id)
        {
            CardType = CardType.Credit;
        }

        public override void Validate()
        {
            Console.WriteLine("Valiando o limite...");
            Console.WriteLine("Limite Ok.");
        }
    }
}
