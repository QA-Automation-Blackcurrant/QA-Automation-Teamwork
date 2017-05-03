namespace Tests.Pages.RegistrationPage
{
    using System.Reflection;
    using OpenQA.Selenium;

    using Tests.Data;
    using Tests.Models;
    using Tests.Utilities;
    using System;

    public class RegistrationPage : BasePage<RegistrationPageMap>
    {
        public RegistrationPage(IWebDriver driver) : base(driver, new RegistrationPageMap(driver))
        {
        }

        public override string Url
        {
            get
            {
                return Constants.REGISTRATION_URL;
            }
        }

        public void RegisterUser(string name)
        {
            var dataReader = new DataReader<RegistrationUser>();
            var user = dataReader.GetData(MethodBase.GetCurrentMethod().Name);

            user.Email = user.Email.Replace(nameof(name), name);
            user.FullName = user.FullName.Replace(nameof(name), name);

            this.Open();
            this.SubmitForm(user);
        }

        public void SubmitForm(RegistrationUser user)
        {
            this.Elements.Email.Type(user.Email);
            this.Elements.FullName.Type(user.FullName);
            this.Elements.Password.Type(user.Password);
            this.Elements.ConfirmPassword.Type(user.ConfirmPassword);
            this.Elements.SubmitButton.Click();
        }
    }
}
