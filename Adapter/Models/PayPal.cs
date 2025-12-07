namespace Adapter.Models
{
    /// <summary>
    /// Implementação da API do PayPal - nossa API padrão
    /// Esta é a implementação "nativa" que nosso sistema usa
    /// </summary>
    internal class PayPal : IPayPalPayment
    {
        private Token? _token = null;
        
        public Token Authenticate()
        {
            _token = new Token();
            Console.WriteLine("✓ Autenticado no PayPal");
            return _token;
        }

        /// <summary>
        /// API simples: recebe parâmetros diretos (amount, email)
        /// </summary>
        public void ProcessPayment(decimal amount, string recipientEmail)
        {
            if (_token == null)
            {
                Authenticate();
            }
            
            Console.WriteLine($"💳 PayPal: Processando pagamento de R$ {amount:F2} para {recipientEmail}");
            Console.WriteLine($"   Token: {_token?.Value.Substring(0, 20)}...");
        }

        public void ReceivePayment(decimal amount)
        {
            if (_token == null)
            {
                Authenticate();
            }
            
            Console.WriteLine($"💰 PayPal: Recebendo pagamento de R$ {amount:F2}");
        }
    }
}
