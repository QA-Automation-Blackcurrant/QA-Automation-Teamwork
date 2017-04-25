namespace Tests.Pages.CreateArticlePage
{
    using NUnit.Framework;

    public static class CreateArticlePageAsserter
    {
        public static void AssertThatPageIsOpened(this CreateArticlePage page)
        {
            Assert.IsTrue(page.Driver.Url.Contains(Constants.CREATE_ARTICLE_URL));
        }
        
    }
}
