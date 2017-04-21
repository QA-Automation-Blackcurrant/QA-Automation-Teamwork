using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Reflection;
using Tests.Data;
using Tests.Models;
using Tests.Pages.LoginPage;

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

        //[TearDown]
        // public void AfterEachTest()
        // {
        //     this.driver.Log().Quit();
        // }

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
            loginPage.AssertEmailErrorMessage();
        }

    }
}
