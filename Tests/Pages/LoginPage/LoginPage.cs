namespace Tests.Pages.LoginPage
{
    using System.Reflection;
    using OpenQA.Selenium;
    using Utilities;

    using Tests.Models;
    using Tests.Data;

    public class LoginPage : BasePage<LoginPageMap>
    {
        public LoginPage(IWebDriver driver) : base(driver, new LoginPageMap(driver))
        {
        }

        public override string Url
        {
            get
            {
                return Constants.REGISTRATION_URL;
            }
        }

        public void LoginAsAdmin()
        {
            var dataReader = new DataReader<LoginUser>();
            var admin = dataReader.GetData(MethodBase.GetCurrentMethod().Name);

            this.Open();
            this.SubmitForm(admin);
        }

        public void LoginAsUser()
        {
            var dataReader = new DataReader<LoginUser>();
            var user = dataReader.GetData(MethodBase.GetCurrentMethod().Name);

            this.Open();
            this.SubmitForm(user);
        }

        public void SubmitForm(LoginUser user)
        {
            this.Elements.MainButton.Click();
            this.Elements.Email.Type(user.Email);
            this.Elements.Password.Type(user.Password);
            this.Elements.RememberMe.Click();
            this.Elements.LogInButton.Click();
        }
    }
}
