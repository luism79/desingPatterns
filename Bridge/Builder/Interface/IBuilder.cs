using Bridge.Transmissions;

namespace Bridge.Builder.Interface
{
    internal interface IBuilder
    {
        AdvancedLive Build();
        IBuilder SetSubTitle();
        IBuilder SetComments();
        IBuilder SetRecord();
    }
}
