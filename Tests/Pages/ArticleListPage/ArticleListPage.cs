namespace Tests.Pages.ArticleListPage
{
    using OpenQA.Selenium;

    public class ArticleListPage : BasePage<ArticleListPageMap>
    {
        public ArticleListPage(IWebDriver driver) : base(driver, new ArticleListPageMap(driver))
        {
        }

        public override string Url
        {
            get
            {
                return Constants.ARTICLE_LIST_URL;
            }
        }
    }
}
