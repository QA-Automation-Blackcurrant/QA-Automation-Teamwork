using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Reflection;
using Tests.Data;
using Tests.Models;
using Tests.Pages.LoginPage;
using Tests.Utilities;

namespace Tests
{
    [TestFixture]
    public class BlogLoginTests
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

        [Test]
        public void LoginWithCreatedArticle()
        {
            //// Arrange
            var loginPage = new LoginPage(this.driver);
            var dataReader = new DataReader<LoginUser>();
            var user = dataReader.GetData(MethodBase.GetCurrentMethod().Name);

            //// Act
            loginPage.Open();
            loginPage.SubmitForm(user);

            //// Assert
            loginPage.AssertConfirmTitle();
        }
    }
}
