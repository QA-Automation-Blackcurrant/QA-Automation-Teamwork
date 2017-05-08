namespace Tests.Pages.CreateArticlePage
{
    using OpenQA.Selenium;

    using Tests.Models;
    using Tests.Utilities;

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

        public void SubmitForm(CreateArticle article)
        {
            this.Open();
            this.Elements.Title.Type(article.Title);
            this.Elements.Content.Type(article.Content);
            this.Elements.CreateButton.Click();
        }
    }
}
