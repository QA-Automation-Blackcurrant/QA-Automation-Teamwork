
namespace Tests.Pages.LoginPage
{

    using NUnit.Framework;


    public static class LoginPageAsserter
    {
        public static void AssertEmailErrorMessage(this LoginPage page)
        {
            Assert.IsTrue(page.Elements.ErrorMessagesEmail.Displayed);
            StringAssert.Contains(Constants.ERROR_EMAIL, page.Elements.ErrorMessagesEmail.Text);
        }

        public static void AssertPasswordErrorMessage(this LoginPage page)
        {
            Assert.IsTrue(page.Elements.ErrorMessagesEmail.Displayed);
            StringAssert.Contains(Constants.ERROR_PASSWORD, page.Elements.ErrorMessagesEmail.Text);
        }
    }
}
