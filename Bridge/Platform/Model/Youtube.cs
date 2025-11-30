namespace Bridge.Platform.Model
{
    internal class Youtube : BasePlatform
    {
        public Youtube()
        {
            Platform = TypePlatform.Youtube;
            Initialize();
        }
    }
}
