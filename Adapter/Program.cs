// See https://aka.ms/new-console-template for more information

using Adapter.Models;

Console.WriteLine("=== DEMONSTRAÇÃO DO PADRÃO ADAPTER ===\n");

// ============================================
// CENÁRIO 1: Usando PayPal (API nativa)
// ============================================
Console.WriteLine("📌 CENÁRIO 1: Usando PayPal (API nativa do sistema)");
Console.WriteLine("----------------------------------------");
IPayPalPayment paypalPayment = new PayPal();
paypalPayment.ProcessPayment(150.50m, "cliente@email.com");
paypalPayment.ReceivePayment(200.00m);
Console.WriteLine();

// ============================================
// CENÁRIO 2: Usando Payonner via Adapter
// ============================================
Console.WriteLine("📌 CENÁRIO 2: Usando Payonner (biblioteca de terceiros) via Adapter");
Console.WriteLine("----------------------------------------");
Console.WriteLine("⚠️ PROBLEMA: Payonner tem API diferente!");
Console.WriteLine("   - Payonner usa: SendPayment(PaymentRequest)");
Console.WriteLine("   - Sistema espera: ProcessPayment(decimal, string)");
Console.WriteLine();
Console.WriteLine("✅ SOLUÇÃO: PayonnerAdapter converte uma API na outra!");
Console.WriteLine("----------------------------------------");

// O Adapter permite usar Payonner como se fosse PayPal!
IPayPalPayment payonnerViaAdapter = new PayonnerAdapter(new Payonner());
payonnerViaAdapter.ProcessPayment(150.50m, "cliente@email.com");
payonnerViaAdapter.ReceivePayment(200.00m);
Console.WriteLine();

// ============================================
// DEMONSTRAÇÃO: Intercambiabilidade
// ============================================
Console.WriteLine("📌 CENÁRIO 3: Intercambiabilidade - Mesmo código funciona com ambos!");
Console.WriteLine("----------------------------------------");

// Função que recebe qualquer implementação de IPayPalPayment
void ProcessarPagamento(IPayPalPayment payment, string providerName)
{
    Console.WriteLine($"\n🔄 Processando com {providerName}:");
    payment.ProcessPayment(99.99m, "teste@email.com");
}

// Mesmo método funciona com PayPal OU Payonner (via Adapter)!
ProcessarPagamento(new PayPal(), "PayPal");
ProcessarPagamento(new PayonnerAdapter(new Payonner()), "Payonner (via Adapter)");

Console.WriteLine("\n=== FIM DA DEMONSTRAÇÃO ===");
Console.WriteLine("\n💡 CONCLUSÃO:");
Console.WriteLine("   O Adapter Pattern permite usar bibliotecas de terceiros");
Console.WriteLine("   (com APIs diferentes) como se fossem nossa API padrão!");
Console.WriteLine("\nPressione qualquer tecla para sair...");
Console.ReadKey();


