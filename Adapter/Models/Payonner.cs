namespace Adapter.Models
{
    /// <summary>
    /// Implementação da biblioteca de terceiros Payonner
    /// Esta é uma biblioteca EXTERNA com API diferente da nossa
    /// 
    /// DIFERENÇAS da API do PayPal:
    /// 1. Método de autenticação: GetAuthToken() vs Authenticate()
    /// 2. Processamento: SendPayment(PaymentRequest) vs ProcessPayment(decimal, string)
    /// 3. Retorno: PaymentResponse vs void
    /// 4. Estrutura: Usa objetos complexos em vez de parâmetros simples
    /// 
    /// Este é o cenário REAL que justifica o uso do Adapter Pattern!
    /// </summary>
    internal class Payonner : IPayonnerPayment
    {
        private Token? _token = null;
        
        public Token GetAuthToken()
        {
            _token = new Token();
            Console.WriteLine("✓ Autenticado no Payonner");
            return _token;
        }

        /// <summary>
        /// API do Payonner: recebe um objeto PaymentRequest (estrutura diferente!)
        /// </summary>
        public PaymentResponse SendPayment(PaymentRequest request)
        {
            if (_token == null)
            {
                GetAuthToken();
            }
            
            Console.WriteLine($"💳 Payonner: Enviando pagamento");
            Console.WriteLine($"   Valor: {request.Currency} {request.Amount:F2}");
            Console.WriteLine($"   Destinatário: {request.RecipientEmail}");
            Console.WriteLine($"   Descrição: {request.Description}");
            Console.WriteLine($"   Token: {_token?.Value.Substring(0, 20)}...");
            
            return new PaymentResponse
            {
                Success = true,
                TransactionId = Guid.NewGuid().ToString(),
                Message = "Pagamento enviado com sucesso"
            };
        }

        public PaymentResponse ReceivePayment(PaymentRequest request)
        {
            if (_token == null)
            {
                GetAuthToken();
            }
            
            Console.WriteLine($"💰 Payonner: Recebendo pagamento de {request.Currency} {request.Amount:F2}");
            
            return new PaymentResponse
            {
                Success = true,
                TransactionId = Guid.NewGuid().ToString(),
                Message = "Pagamento recebido com sucesso"
            };
        }
    }
}
