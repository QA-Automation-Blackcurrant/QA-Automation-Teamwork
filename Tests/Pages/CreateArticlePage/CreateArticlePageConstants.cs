using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Pages.CreateArticlePage
{
    internal class Constants
    {
        //// Common
        internal const string CREATE_ARTICLE_URL = "Article/Create/";
        internal const int WAIT_SECCONDS = 20;

        //// Selectors
        internal const string CREATE_ARTICLE_BUTTON_SELECTOR = "/html/body/div[2]/div/div/form/div[4]/div/input";
        internal const string CANCEL_ARTICLE_BUTTON_SELECTOR = "/html/body/div[2]/div/div/form/div[4]/div/a";
        internal const string EDIT_BUTTON_SELECTOR = "/html/body/div[2]/div/article/footer/a[1]";
        internal const string DELETE_BUTTON_SELECTOR = "/html/body/div[2]/div/article/footer/a[2]";
        internal const string BACK_BUTTON_SELECTOR = "/html/body/div[2]/div/article/footer/a[3]";
        internal const string DELETE_ARTICLE_BUTTON = "/html/body/div[2]/div/div/form/div[3]/div/input";
        internal const string CANCEL_ARTICLE_BUTTON = "/html/body/div[2]/div/div/form/div[3]/div/a";
        internal const string EDIT_ARTICLE_BUTTON = "/html/body/div[2]/div/div/form/div[4]/div/input";
        internal const string TEST_ONE_BUTTON_SELECTOR = "/html/body/div[2]/div/div/div/article/header/h2/a";

        //// Messages        
        internal const string ARTICLE_INSPECTION_TEST = "TestOne";
    }
}
