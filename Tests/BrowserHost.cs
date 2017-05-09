namespace Tests
{
    using TestStack.Seleno.Configuration;

    public static class BrowserHost
    {
        public static readonly SelenoHost Instance = new SelenoHost();

        static BrowserHost()
        {
            Instance.Run("Blog", 60639, w => w.WithRemoteWebDriver(BrowserFactory.Chrome));
        }
    }
}