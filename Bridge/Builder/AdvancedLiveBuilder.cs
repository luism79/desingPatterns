using Bridge.Builder.Interface;
using Bridge.Platform.Inteface;
using Bridge.Transmissions;

namespace Bridge.Builder
{
    internal class AdvancedLiveBuilder : IBuilder
    {
        private readonly IPlatform? _platform;
        private Action? _subtitle;
        private Action? _comments;
        private Action? _record;

        private void SetActionValue(out Action? actionValue, string text)
        {
            actionValue = () => Console.Write($"{_platform!.PlatformName}: {text}\n");
        }

        public AdvancedLiveBuilder(IPlatform platform)
        {
            if (platform == null)
            {
                throw new InvalidOperationException("A plataforma não pode ser nula!");
            }

            _platform = platform;
        }

        public AdvancedLive Build()
        {
            AdvancedLive advancedLive = new AdvancedLive(_platform!);
            advancedLive.SubTitle = _subtitle;
            advancedLive.Comments = _comments;
            advancedLive.Record = _record;

            return advancedLive;
        }

        public IBuilder SetComments()
        {
            SetActionValue(out _comments, "Legendas ativadas na transmissão.");
            return this;
        }

        public IBuilder SetRecord()
        {
            SetActionValue(out _record, "A gravação liberada na live.");
            return this;
        }

        public IBuilder SetSubTitle()
        {
            SetActionValue(out _subtitle, "Comentários liberados na live.");
            return this;
        }
    }
}
