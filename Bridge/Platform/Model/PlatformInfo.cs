namespace Bridge.Platform.Model
{
    enum TypePlatform
    {
        None,
        Youtube,
        TwitchTV,
        Facebook,
        DLive
    }
    static class PlatformInfo
    {
        private static Dictionary<TypePlatform, string> Caption = new()
        {
            { TypePlatform.None, "None" },
            { TypePlatform.Youtube, "YouTube" },
            { TypePlatform.TwitchTV, "TwitchTV" },
            { TypePlatform.Facebook, "FaceBook" },
            { TypePlatform.DLive, "DLive" }
        };

        public static bool IsValidPlatfomr(TypePlatform platform) => Caption.ContainsKey(platform);
        public static string CaptionPlatform(TypePlatform platform) => Caption
            .TryGetValue(platform, out var value) ? value : "Plataforma não encontrada";
        
    }
}
