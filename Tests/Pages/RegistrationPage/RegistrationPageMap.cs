namespace Tests.Pages.RegistrationPage
{
    using System;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.UI;

    public class RegistrationPageMap
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        public RegistrationPageMap(IWebDriver driver)
        {
            this.driver = driver;
            this.wait = new WebDriverWait(this.driver, TimeSpan.FromSeconds(Constants.WAIT_SECCONDS));
        }
        

        public IWebElement FullName
        {
            get
            {
                return this.driver.FindElement(By.Id(Constants.FULL_NAME_SELECTOR));
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

        public IWebElement ConfirmPassword
        {
            get
            {
                return this.driver.FindElement(By.Id(Constants.CONFIRM_PASSWORD_SELECTOR));
            }
        }

        public IWebElement SubmitButton
        {
            get
            {
                return this.driver.FindElement(By.XPath(Constants.REGISTER_BUTTON_SELECTOR));
            }
        }

        public IWebElement ErrorMessagesForEmail
        {
            get
            {
                this.wait.Until(ExpectedConditions.ElementExists(By.XPath(Constants.ERROR_EMAIL_SELECTOR)));
                return this.driver.FindElement(By.XPath(Constants.ERROR_EMAIL_SELECTOR));
            }
        }

        public IWebElement ErrorMessagesForPassword
        {
            get
            {
                this.wait.Until(ExpectedConditions.ElementExists(By.XPath(Constants.ERROR_PASSWORD_SELECTOR)));
                return this.driver.FindElement(By.XPath(Constants.ERROR_PASSWORD_SELECTOR));
            }
        }

        public IWebElement ErrorMessagesForDifferencePassword
        {
            get
            {
                this.wait.Until(ExpectedConditions.ElementExists(By.XPath(Constants.DIFFERENCE_BETWEEN_PASSWORDS_SELECTOR)));
                return this.driver.FindElement(By.XPath(Constants.DIFFERENCE_BETWEEN_PASSWORDS_SELECTOR));
            }
        }

        public IWebElement ErrorMessagesForMissingFullName
        {
            get
            {
                this.wait.Until(ExpectedConditions.ElementExists(By.XPath(Constants.ERROR_FULL_NAME_SELECTOR)));
                return this.driver.FindElement(By.XPath(Constants.ERROR_FULL_NAME_SELECTOR));
            }
        }
    }
}


