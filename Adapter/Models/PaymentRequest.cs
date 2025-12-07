namespace Adapter.Models
{
    /// <summary>
    /// Classe de requisição de pagamento usada pela API do Payonner (biblioteca de terceiros)
    /// Esta estrutura é diferente da API do PayPal, demonstrando a necessidade do Adapter
    /// </summary>
    internal class PaymentRequest
    {
        public decimal Amount { get; set; }
        public string Currency { get; set; } = "BRL";
        public string RecipientEmail { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}

