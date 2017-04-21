namespace Tests.Pages.LoginPage
{
    using Models;
    using OpenQA.Selenium;
    using Utilities;

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
