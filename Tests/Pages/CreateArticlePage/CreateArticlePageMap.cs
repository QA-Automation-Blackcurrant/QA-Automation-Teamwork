using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Tests.Pages.CreateArticlePage
{
    public class CreateArticlePageMap
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        public CreateArticlePageMap(IWebDriver driver)
        {
            this.driver = driver;
            this.wait = new WebDriverWait(this.driver, TimeSpan.FromSeconds(Constants.WAIT_SECCONDS));
        }
               
    }
}
