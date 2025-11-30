namespace Bridge.Platform.Model
{
    internal class TwitchTV : BasePlatform
    {
        public TwitchTV()
        {
            Platform = TypePlatform.TwitchTV;
            Initialize();
        }
    }
}
