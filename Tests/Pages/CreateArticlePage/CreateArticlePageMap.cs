using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Tests.Pages.CreateArticlePage
{
    public class CreateArticlePageMap
    {
        private IWebDriver driver;

        public CreateArticlePageMap(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
