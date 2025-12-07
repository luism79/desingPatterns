namespace Adapter.Models
{
    /// <summary>
    /// Interface padrão do sistema - API do PayPal
    /// Esta é a interface que nosso sistema espera usar
    /// </summary>
    internal interface IPayPalPayment
    {
        //Token Authenticate();
        Token Authenticate();
        
        /// <summary>
        /// Processa um pagamento - API simples com parâmetros diretos
        /// </summary>
        void ProcessPayment(decimal amount, string recipientEmail);

        /// <summary>
        /// Recebe um pagamento
        /// </summary>
        void ReceivePayment(decimal amount);
    }
}
