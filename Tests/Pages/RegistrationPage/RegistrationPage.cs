namespace Tests.Pages.RegistrationPage
{
    using OpenQA.Selenium;
    using Models;
    using Utilities;

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
