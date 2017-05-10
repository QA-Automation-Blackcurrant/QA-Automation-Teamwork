namespace Tests
{
    using NUnit.Framework;
    using OpenQA.Selenium;

    using Tests.Pages.ArticleListPage;
    using Tests.Utilities;

    [TestFixture]
    public class BlogArticleListTests
    {
        private IWebDriver driver;

        [SetUp]
        public void BeforeEachTest()
        {
            this.driver = BrowserHost.Instance.Application.Browser;
            this.driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void AfterEachTest()
        {
            this.driver.Log().Quit();
        }

        [Test]
        public void OpenArticleListShouldProccessCorrectly()
        {
            //// Arrange
            var articleListPage = new ArticleListPage(this.driver);

            //// Act
            articleListPage.Open();

            //// Assert
            articleListPage.AssertThatPageIsOpened();
        }

        [Test]
        public void ArticleListShouldContainsSomeArticles()
        {
            //// Arrange
            var articleListPage = new ArticleListPage(this.driver);

            //// Act
            articleListPage.Open();

            //// Assert
            articleListPage.AssertThatPageContainsArticles();
        }
    }
}
