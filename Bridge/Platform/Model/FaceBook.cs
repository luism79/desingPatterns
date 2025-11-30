namespace Bridge.Platform.Model
{
    internal class FaceBook : BasePlatform
    {
        public FaceBook()
        { 
            Platform = TypePlatform.Facebook;
            Initialize();
        }
    }
}
