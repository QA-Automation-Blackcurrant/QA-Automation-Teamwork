

namespace Tests.Pages.LoginPage
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.UI;
    using System;

    public class LoginPageMap
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        public LoginPageMap(IWebDriver driver)
        {
            this.driver = driver;
            this.wait = new WebDriverWait(this.driver, TimeSpan.FromSeconds(Constants.WAIT_SECCONDS));
        }

        public IWebElement MainButton
        {
            get
            {
                return this.driver.FindElement(By.Id(Constants.MAINLOGIN_SELECTOR));
            }
        }


        public IWebElement Email
        {
            get
            {
                return this.driver.FindElement(By.Id(Constants.EMAIL_SELECTOR));
            }
        }

        public IWebElement Password
        {
            get
            {
                return this.driver.FindElement(By.Id(Constants.PASSWORD_SELECTOR));
            }
        }

        public IWebElement RememberMe
        {
            get
            {
                return this.driver.FindElement(By.XPath(Constants.REMEMBER_ME_BUTTON_SELECTOR));
            }
        }

        public IWebElement LogInButton
        {
            get
            {
                return this.driver.FindElement(By.XPath(Constants.LOGIN_BUTTON_SELECTOR));
            }
        }

        public IWebElement ErrorMessagesEmail
        {
            get
            {
                this.wait.Until(ExpectedConditions.ElementExists(By.XPath(Constants.ERROR_EMAIL_SELECTOR)));
                return this.driver.FindElement(By.XPath(Constants.ERROR_EMAIL_SELECTOR));
            }
        }

        public IWebElement ErrorMessagesWithoutEmail
        {
            get
            {
                this.wait.Until(ExpectedConditions.ElementExists(By.XPath(Constants.ERROR_EMAIL_SELECTOR)));
                return this.driver.FindElement(By.XPath(Constants.ERROR_EMAIL_SELECTOR));
            }
        }

        public IWebElement ErrorMessagePassword
        {
            get
            {
                this.wait.Until(ExpectedConditions.ElementExists(By.XPath(Constants.ERROR_PASSWORD_SELECTOR)));
                return this.driver.FindElement(By.XPath(Constants.ERROR_PASSWORD_SELECTOR));
            }
        }

        public IWebElement ConfirmationForLogin
        {
            get
            {
                this.wait.Until(ExpectedConditions.ElementExists(By.CssSelector(Constants.SUCCESSFUL_LOGIN_SELECTOR)));
                return this.driver.FindElement(By.CssSelector(Constants.SUCCESSFUL_LOGIN_SELECTOR));
            }
        }

        public IWebElement PromptForIncorrectPassword
        {
            get
            {
                this.wait.Until(ExpectedConditions.ElementExists(By.XPath(Constants.INCORRECT_PASSWORD_SELECTOR)));
                return this.driver.FindElement(By.XPath(Constants.INCORRECT_PASSWORD_SELECTOR));
            }
        }
    }
}
