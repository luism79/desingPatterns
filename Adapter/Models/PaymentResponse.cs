namespace Adapter.Models
{
    /// <summary>
    /// Resposta de pagamento da API do Payonner
    /// </summary>
    internal class PaymentResponse
    {
        public bool Success { get; set; }
        public string TransactionId { get; set; } = string.Empty;
        public string Message { get; set; } = string.Empty;
    }
}

