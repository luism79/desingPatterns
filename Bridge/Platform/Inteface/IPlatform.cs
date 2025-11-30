namespace Bridge.Platform.Inteface
{
    internal interface IPlatform
    {
        string PlatformName { get;  }

        void ConfigureRMTP();

        bool Authenticate();
    }
}
