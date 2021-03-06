﻿namespace Tests
{
    using System.Configuration;
    using OpenQA.Selenium.Chrome;
    using TestStack.Seleno.Configuration;

    public static class BrowserHost
    {
        public static readonly SelenoHost Instance = new SelenoHost();
        public static readonly string RootUrl = $"{ConfigurationManager.AppSettings["domain"]}";

        static BrowserHost()
        {
            Instance.Run("Blog", 60634, w => w.WithRemoteWebDriver(() => new ChromeDriver()));
        }
    }
}