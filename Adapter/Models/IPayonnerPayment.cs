namespace Adapter.Models
{
    /// <summary>
    /// Interface da biblioteca de terceiros Payonner
    /// Esta API é DIFERENTE da nossa interface padrão (IPayPalPayment)
    /// - Usa objetos complexos em vez de parâmetros simples
    /// - Tem nomes de métodos diferentes
    /// - Retorna objetos de resposta em vez de void
    /// 
    /// Este é o cenário REAL: bibliotecas de terceiros têm APIs diferentes!
    /// </summary>
    internal interface IPayonnerPayment
    {
        Token GetAuthToken();

        /// <summary>
        /// API do Payonner usa um objeto PaymentRequest em vez de parâmetros simples
        /// </summary>
        PaymentResponse SendPayment(PaymentRequest request);

        /// <summary>
        /// API do Payonner também usa objeto para receber pagamentos
        /// </summary>
        PaymentResponse ReceivePayment(PaymentRequest request);
    }
}
