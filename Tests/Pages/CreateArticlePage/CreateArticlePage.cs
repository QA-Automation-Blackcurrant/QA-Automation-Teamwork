using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Tests.Pages.CreateArticlePage
{
    public class CreateArticlePage : BasePage<CreateArticlePageMap>
    {
        public CreateArticlePage(IWebDriver driver) : base(driver, new CreateArticlePageMap(driver))
        {
        }

        public override string Url
        {
            get
            {
                return Constants.CREATE_ARTICLE_URL;
            }
        }
    }
}
