namespace Tests.Pages.ArticleListPage
{
    using NUnit.Framework;

    public static class ArticleListPageAsserter
    {
        public static void AssertThatPageIsOpened(this ArticleListPage page)
        {
            Assert.IsTrue(page.Driver.Url.Contains(Constants.ARTICLE_LIST_URL));
        }

        public static void AssertThatPageContainsArticles(this ArticleListPage page)
        {
            Assert.IsTrue(page.Elements.Articles.Count > 0);
        }
    }
}
