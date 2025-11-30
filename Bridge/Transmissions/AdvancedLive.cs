using Bridge.Platform.Inteface;

namespace Bridge.Transmissions
{
    internal class AdvancedLive : Live
    {
        public AdvancedLive(IPlatform platform) : base(platform)
        {
        }

        //public void ShowSubTitle()
        //{
            //Invoke(SubTitle!);
        //}

        //public void Comments()
        //{
        //    Console.WriteLine($"{platform.PlatformName}: Comentários liberados na live.");
        //}

        //public void Record()
        //{
        //    Console.WriteLine($"{platform.PlatformName}: Gravando a transmissão da live.");
        //}

        public Action? SubTitle { get; set; }

        public Action? Comments { get; set; }

        public Action? Record { get; set; }
    }
}
