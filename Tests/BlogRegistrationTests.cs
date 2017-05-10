namespace Tests
{
    using System;
    using System.Reflection;
    using NUnit.Framework;
    using OpenQA.Selenium;

    using Tests.Data;
    using Tests.Models;
    using Tests.Pages.RegistrationPage;
    using Tests.Utilities;

    [TestFixture]
    public class BlogRegistrationTests
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
        public void RegisterNewUserShouldProccessCorrectly()
        {
            //// Arrange
            var registrationPage = new RegistrationPage(this.driver);
            var name = Guid.NewGuid().ToString();

            //// Act
            registrationPage.RegisterUser(name);

            //// Assert
            registrationPage.AssertNewUserRegistration(name);
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

        [Test]
        public void RegistrationWithoutPassword()
        {
            //// Arrange
            var registrationPage = new RegistrationPage(this.driver);
            var dataReader = new DataReader<RegistrationUser>();
            var user = dataReader.GetData(MethodBase.GetCurrentMethod().Name);

            //// Act
            registrationPage.Open();
            registrationPage.SubmitForm(user);

            //// Assert
            registrationPage.AssertPasswordErrorMessage();
        }

        [Test]
        public void RegistrationWithDifferentPasswords()
        {
            //// Arrange
            var registrationPage = new RegistrationPage(this.driver);
            var dataReader = new DataReader<RegistrationUser>();
            var user = dataReader.GetData(MethodBase.GetCurrentMethod().Name);

            //// Act
            registrationPage.Open();
            registrationPage.SubmitForm(user);

            //// Assert
            registrationPage.AssertDifferencePasswordErrorMessage();
        }

        [Test]
        public void RegistrationWithoutFullName()
        {
            //// Arrange
            var registrationPage = new RegistrationPage(this.driver);
            var dataReader = new DataReader<RegistrationUser>();
            var user = dataReader.GetData(MethodBase.GetCurrentMethod().Name);

            //// Act
            registrationPage.Open();
            registrationPage.SubmitForm(user);

            //// Assert
            registrationPage.AssertFullNameErrorMessage();
        }

    }
}