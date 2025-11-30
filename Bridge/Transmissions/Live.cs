using Bridge.Platform.Inteface;

namespace Bridge.Transmissions
{
    internal class Live : ITransmission
    {
        protected IPlatform platform;

        public Live(IPlatform platform) => this.platform = platform;

        public void Broadcasting()
        {
            Console.WriteLine($"{platform.PlatformName}: Iniciando a transmissão");
        }

        public void Result()
        {
            Console.WriteLine("\n**** ON AIR ****");
        }
    }
}
