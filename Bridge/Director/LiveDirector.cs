using Bridge.Builder.Interface;
using Bridge.Transmissions;

namespace Bridge.Director
{
    internal class LiveDirector
    {
        private readonly IBuilder? _builder;

        public LiveDirector(IBuilder? builder) => _builder = builder;

        public AdvancedLive BuildBasicLive()
        {
            return _builder!
                .SetSubTitle()
                .Build();
        }

        public AdvancedLive BuildInteractiveLive()
        {
            return _builder!
                .SetSubTitle()
                .SetComments()
                .Build();
        }

        public AdvancedLive BuildCompleteLive()
        {
            return _builder!
                .SetSubTitle()
                .SetComments()
                .SetRecord()
                .Build();
        }
    }
}
