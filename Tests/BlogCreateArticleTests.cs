namespace Tests
{
    using System;
    using NUnit.Framework;
    using OpenQA.Selenium;

    using Tests.Models;
    using Tests.Pages.ArticleListPage;
    using Tests.Pages.CreateArticlePage;
    using Tests.Pages.LoginPage;
    using Tests.Utilities;

    [TestFixture]
    class BlogCreateArticleTests
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
            this.driver.Log();
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

        [Test]
        public void CreatingNewArticleShouldProccessCorrectly()
        {
            //// Arrange
            var loginPage = new LoginPage(this.driver);
            var articleListPage = new ArticleListPage(this.driver);
            var createArticlePage = new CreateArticlePage(this.driver);
            var article = new CreateArticle() { Title = Guid.NewGuid().ToString(), Content = Guid.NewGuid().ToString() };

            //// Act
            loginPage.LoginAsUser();
            var expectedArticlesCount = articleListPage.Elements.Articles.Count + 1;
            createArticlePage.SubmitForm(article);
            var actualArticlesCount = articleListPage.Elements.Articles.Count;

            //// Assert
            Assert.AreEqual(expectedArticlesCount, actualArticlesCount);
        }
    }
}
