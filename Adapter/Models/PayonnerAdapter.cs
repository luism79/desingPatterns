namespace Adapter.Models
{
    /// <summary>
    /// ADAPTER PATTERN: Converte a API do Payonner para a interface IPayPalPayment
    /// 
    /// PROBLEMA RESOLVIDO:
    /// - Payonner usa: SendPayment(PaymentRequest) → PaymentResponse
    /// - Sistema espera: ProcessPayment(decimal, string) → void
    /// 
    /// O Adapter faz a "tradução" entre as duas APIs diferentes:
    /// 1. Converte parâmetros simples (decimal, string) em objeto PaymentRequest
    /// 2. Chama o método correto da API do Payonner (SendPayment)
    /// 3. Ignora o retorno PaymentResponse (já que nossa interface retorna void)
    /// 4. Traduz GetAuthToken() para Authenticate()
    /// 
    /// Agora podemos usar Payonner como se fosse PayPal! 🎯
    /// </summary>
    internal class PayonnerAdapter : IPayPalPayment
    {
        private readonly IPayonnerPayment _payonner;

        public PayonnerAdapter(IPayonnerPayment payonner)
        {
            _payonner = payonner ?? throw new ArgumentNullException(nameof(payonner));
        }

        /// <summary>
        /// Adapta GetAuthToken() para Authenticate()
        /// </summary>
        public Token Authenticate()
        {
            return _payonner.GetAuthToken();
        }

        /// <summary>
        /// ADAPTAÇÃO PRINCIPAL:
        /// Converte ProcessPayment(decimal, string) → SendPayment(PaymentRequest)
        /// 
        /// Esta é a "mágica" do Adapter: transforma uma interface em outra!
        /// </summary>
        public void ProcessPayment(decimal amount, string recipientEmail)
        {
            // Cria o objeto PaymentRequest que a API do Payonner espera
            var request = new PaymentRequest
            {
                Amount = amount,
                Currency = "BRL",
                RecipientEmail = recipientEmail,
                Description = $"Pagamento via Adapter - {DateTime.Now:dd/MM/yyyy HH:mm}"
            };

            // Chama a API do Payonner (que retorna PaymentResponse)
            var response = _payonner.SendPayment(request);

            // Podemos logar ou tratar a resposta se necessário
            if (!response.Success)
            {
                Console.WriteLine($"⚠️ Erro no pagamento: {response.Message}");
            }
        }

        /// <summary>
        /// Adapta ReceivePayment(decimal) → ReceivePayment(PaymentRequest)
        /// </summary>
        public void ReceivePayment(decimal amount)
        {
            var request = new PaymentRequest
            {
                Amount = amount,
                Currency = "BRL",
                Description = $"Recebimento via Adapter - {DateTime.Now:dd/MM/yyyy HH:mm}"
            };

            var response = _payonner.ReceivePayment(request);

            if (!response.Success)
            {
                Console.WriteLine($"⚠️ Erro no recebimento: {response.Message}");
            }
        }
    }
}
