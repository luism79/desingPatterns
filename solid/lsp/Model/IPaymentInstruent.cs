namespace lsp.Model
{
    internal interface IPaymentInstrument
    {
        public void Validate();
        public void CollectPayment();
    }   
}
