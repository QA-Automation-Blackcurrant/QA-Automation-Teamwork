namespace Tests
{
    using NUnit.Framework;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;

    using Tests.Pages.CreateArticlePage;
    using Tests.Pages.LoginPage;
    using Tests.Utilities;

    class BlogCreateArticleTests
    {
        private IWebDriver driver;

        [SetUp]
        public void BeforeEachTest()
        {
            this.driver = new ChromeDriver();
            this.driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void AfterEachTest()
        {
            this.driver.Log().Quit();
        }

        [Test]
        public void OpenCreateArticleFormShouldBeProccessedCorrectly()
        {
            //// Arrange
            var loginPage = new LoginPage(this.driver);
            var createArticlePage = new CreateArticlePage(this.driver);

            //// Act
            loginPage.LoginAsUser();
            createArticlePage.Open();

            //// Assert
            createArticlePage.AssertThatPageIsOpened();
        }
       
    }
}
