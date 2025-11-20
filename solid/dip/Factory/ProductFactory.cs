using dip.Model;
using Microsoft.Extensions.Configuration;

namespace dip.Factory
{
    internal class ProductFactory
    {
        private string dbName = string.Empty;

        public void LoadSettingsDB()
        {
            var config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appSettings.json", optional: false, reloadOnChange: true)
            .Build();

            dbName = config["AppSettings:DB"];

        }
        public ProductFactory() 
        { 
            LoadSettingsDB();
        }
        public string DbName => dbName;
        public Product GetProductById(string id)
        {
            Product product = new(id);
            product.Name = "Test product";
            return product;
        }
    }
}
