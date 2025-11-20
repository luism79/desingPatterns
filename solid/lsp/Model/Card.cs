namespace lsp.Model
{
    enum CardType
    {
        Credit,
        Debit
    }
    abstract class Card : IPaymentInstrument
    {
        private static readonly Dictionary<CardType, string> LabelCardType = new()
        {
            { CardType.Credit, "Crédito" },
            { CardType.Debit, "Débito" }
        };

        protected string BankName = "Unkown";
        protected CardType CardType;

        public Card(int id)
        {
            ID = id;
        }
        public int ID { get; }

        public override string ToString()
        {
            return $"ID: {ID}, Type: {LabelCardType[CardType]}, Bank Name: {BankName}";
        }

        public virtual void CollectPayment()
        {
            throw new NotImplementedException();
        }

        public virtual void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
