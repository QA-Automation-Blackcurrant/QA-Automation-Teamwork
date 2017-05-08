namespace Tests.Pages.ArticleListPage
{
    using System;
    using System.Collections.Generic;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.UI;

    public class ArticleListPageMap
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        public ArticleListPageMap(IWebDriver driver)
        {
            this.driver = driver;
            this.wait = new WebDriverWait(this.driver, TimeSpan.FromSeconds(Constants.WAIT_SECCONDS));
        }

        public IList<IWebElement> Articles
        {
            get
            {
                this.wait.Until(ExpectedConditions.ElementExists(By.XPath(Constants.ARICLES_SELECTOR)));
                return this.driver.FindElement(By.XPath(Constants.ARICLES_SELECTOR)).FindElements(By.TagName(Constants.ARICLE_TAG_NAME));
            }
        }
    }
}
