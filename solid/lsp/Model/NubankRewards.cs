namespace lsp.Model
{
    internal class NubankRewards : IPaymentInstrument
    {
        private const string BANK = "Nubank Rewards";
        public NubankRewards(int id)
        { 
            ID = id;
        }

        public int ID { get; }

        public void CollectPayment()
        {
            Console.WriteLine("Pagamento realizado com sucesso...");
            Console.WriteLine("Pontuação creditada.");
        }

        public void Validate()
        {
            Console.WriteLine("Limite OK...");
        }

        public override string ToString()
        {
            return $"ID: {ID}, Type: Rewards, Bank Name: {BANK}";
        }
    }
}
