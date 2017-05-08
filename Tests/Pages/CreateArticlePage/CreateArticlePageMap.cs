namespace Tests.Pages.CreateArticlePage
{
    using System;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.UI;

    public class CreateArticlePageMap
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        public CreateArticlePageMap(IWebDriver driver)
        {
            this.driver = driver;
            this.wait = new WebDriverWait(this.driver, TimeSpan.FromSeconds(Constants.WAIT_SECCONDS));
        }

        public IWebElement Title
        {
            get
            {
                return this.driver.FindElement(By.Id(Constants.TITLE_SELECTOR));
            }
        }

        public IWebElement Content
        {
            get
            {
                return this.driver.FindElement(By.Id(Constants.CONTENT_SELECTOR));
            }
        }

        public IWebElement CreateButton
        {
            get
            {
                return this.driver.FindElement(By.XPath(Constants.CREATE_BUTTON_SELECTOR));
            }
        }
    }
}
