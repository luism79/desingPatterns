// See https://aka.ms/new-console-template for more information
using Bridge.Builder;
using Bridge.Director;
using Bridge.Platform.Inteface;
using Bridge.Platform.Model;
using Bridge.Transmissions;

StartInteractiveLive(new Youtube());
StartBasicLive(new TwitchTV());
StartBasicLive(new FaceBook());
StartCompleteLive(new DLive());
Console.WriteLine();
Console.ReadKey();


static void StartBasicLive(IPlatform platform)
{
    try
    {
        AdvancedLiveBuilder liveBuilder = new AdvancedLiveBuilder(platform);
        LiveDirector liveDirector = new LiveDirector(liveBuilder);

        AdvancedLive live = liveDirector.BuildBasicLive();

        ExecuteLive(live);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Falha na construção da live: {e.ToString()}");
    }
}

static void StartInteractiveLive(IPlatform platform)
{
    try
    {
        AdvancedLiveBuilder liveBuilder = new AdvancedLiveBuilder(platform);
        LiveDirector liveDirector = new LiveDirector(liveBuilder);
        AdvancedLive live = liveDirector.BuildInteractiveLive();

        ExecuteLive(live);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Falha na construção da live: {e.ToString()}");
    }
}

static void StartCompleteLive(IPlatform platform)
{
    try
    {
        AdvancedLiveBuilder liveBuilder = new AdvancedLiveBuilder(platform);
        LiveDirector liveDirector = new LiveDirector(liveBuilder);
        AdvancedLive live = liveDirector.BuildCompleteLive();

        ExecuteLive(live);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Falha na construção da live: {e.ToString()}");
    }
}

static void ExecuteLive(AdvancedLive live)
{
    Console.WriteLine("\nAguarde...");

    live.Broadcasting();
    live.SubTitle?.Invoke();
    live.Comments?.Invoke();
    live.Record?.Invoke();
    live.Result();

    Console.WriteLine();
}