using dip.Factory;
using dip.Model;

namespace dip.Payment
{
    internal class PaymentProcess
    {
        public void Pay(string id)
        {
            ProductFactory factory = new ProductFactory();
            Product product = factory.GetProductById(id);
            Console.WriteLine($"dbName: {factory.DbName}\n"+
                              $"ProductData: {product.ToString()}");
        }
    }
}
