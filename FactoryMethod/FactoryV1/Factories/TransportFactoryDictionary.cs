namespace FactoryMethod.Factories
{
    public enum TypeVehicle
    {
        Uber,
        Motorcycle,
        Bicycle
    }
    /// <summary>
    /// Simple Factory usando Dictionary - mapeia enum para factories
    /// </summary>
    internal static class TransportFactoryDictionary
    {
        // Dictionary que mapeia o enum para funções factory
        private static readonly Dictionary<TypeVehicle, Func<Transport>> _factories = new()
        {
            { TypeVehicle.Uber, () => new CarTransport() },
            { TypeVehicle.Motorcycle, () => new MotorcycleTransport() },
            { TypeVehicle.Bicycle, () => new BicicleTransport() }
        };

        /// <summary>
        /// Cria uma instância de Transport usando Dictionary
        /// </summary>
        public static Transport? Create(TypeVehicle type)
        {
            if (_factories.TryGetValue(type, out var factory))
            {
                return factory();
            }
            return null;
        }

        /// <summary>
        /// Retorna todos os tipos disponíveis
        /// </summary>
        //public static IEnumerable<TypeVehicle> GetAvailableTypes()
        //{
        //    return _factories.Keys;
        //}
    }
}
