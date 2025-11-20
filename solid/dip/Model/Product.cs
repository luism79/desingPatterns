namespace dip.Model
{
    internal class Product
    {
        public Product(string id)
        {
            ID = id;
        }
        public string ID { get; }
        public string Name { get; set; } = string.Empty;

        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}";
        }
    }
}
