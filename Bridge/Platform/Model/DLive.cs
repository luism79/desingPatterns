namespace Bridge.Platform.Model
{
    internal class DLive : BasePlatform
    {
        public DLive()
        {
            Platform = TypePlatform.DLive;
            Initialize();
        }
    }
}
