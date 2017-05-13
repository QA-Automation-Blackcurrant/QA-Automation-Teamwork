namespace Tests
{
    using System.Reflection;
    using NUnit.Framework;
    using OpenQA.Selenium;

    using Tests.Data;
    using Tests.Models;
    using Tests.Pages.LoginPage;
    using Tests.Utilities;

    [TestFixture]
    public class BlogLoginTests
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
        public void LoginAsAdmin()
        {
            //// Arrange
            var loginPage = new LoginPage(this.driver);
            var dataReader = new DataReader<LoginUser>();
            var user = dataReader.GetData(MethodBase.GetCurrentMethod().Name);

            //// Act
            loginPage.Open();
            loginPage.SubmitForm(user);

            //// Assert
            loginPage.AssertConfirmation();
            loginPage.LogOff();
        }

        [Test]
        public void LoginWithoutEmail()
        {
            //// Arrange
            var loginPage = new LoginPage(this.driver);
            var dataReader = new DataReader<LoginUser>();
            var user = dataReader.GetData(MethodBase.GetCurrentMethod().Name);

            //// Act
            loginPage.Open();
            loginPage.SubmitForm(user);

            //// Assert
            loginPage.AssertWithoutEmailErrorMessage();
        }

        [Test]
        public void LoginWithIncorrectEmail()
        {
            //// Arrange
            var loginPage = new LoginPage(this.driver);
            var dataReader = new DataReader<LoginUser>();
            var user = dataReader.GetData(MethodBase.GetCurrentMethod().Name);

            //// Act
            loginPage.Open();
            loginPage.SubmitForm(user);

            //// Assert
            loginPage.AssertEmailErrorMessage();
        }

        [Test]
        public void LoginWithoutPassword()
        {
            //// Arrange
            var loginPage = new LoginPage(this.driver);
            var dataReader = new DataReader<LoginUser>();
            var user = dataReader.GetData(MethodBase.GetCurrentMethod().Name);

            //// Act
            loginPage.Open();
            loginPage.SubmitForm(user);

            //// Assert
            loginPage.AssertPasswordErrorMessage();
        }

        [Test]
        public void LoginWithIncorrectPassword()
        {
            //// Arrange
            var loginPage = new LoginPage(this.driver);
            var dataReader = new DataReader<LoginUser>();
            var user = dataReader.GetData(MethodBase.GetCurrentMethod().Name);

            //// Act
            loginPage.Open();
            loginPage.SubmitForm(user);

            //// Assert
            loginPage.AssertIncorrectPassword();
        }
    }
}
