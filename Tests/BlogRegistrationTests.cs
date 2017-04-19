namespace Tests
{
    using System.Reflection;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using Data;
    using Models;
    using Pages.RegistrationPage;
    using Tests.Utilities;

    [TestFixture]
    public class BlogRegistrationTests
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
        public void RegistrationWithoutEmailShoulNotBeProcessed()
        {
            //// Arrange
            var registrationPage = new RegistrationPage(this.driver);
            var dataReader = new DataReader<RegistrationUser>();
            var user = dataReader.GetData(MethodBase.GetCurrentMethod().Name);

            //// Act
            registrationPage.Open();
            registrationPage.SubmitForm(user);

            //// Assert
            registrationPage.AssertEmailErrorMessage();
        }

        [Test]
        public void RegistrationWithInvalidEmailShoulNotBeProcessed()
        {
            //// Arrange
            var registrationPage = new RegistrationPage(this.driver);
            var dataReader = new DataReader<RegistrationUser>();
            var user = dataReader.GetData(MethodBase.GetCurrentMethod().Name);

            //// Act
            registrationPage.Open();
            registrationPage.SubmitForm(user);

            //// Assert
            registrationPage.AssertInvalidEmailErrorMessage();
        }
    }
}