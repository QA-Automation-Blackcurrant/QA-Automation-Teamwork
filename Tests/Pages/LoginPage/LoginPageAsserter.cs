
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

        public static void AssertWithoutEmailErrorMessage(this LoginPage page)
        {
            Assert.IsTrue(page.Elements.ErrorMessagesWithoutEmail.Displayed);
            StringAssert.Contains(Constants.ERROR_WITHOUT_EMAIL, page.Elements.ErrorMessagesWithoutEmail.Text);
        }

        public static void AssertPasswordErrorMessage(this LoginPage page)
        {
            Assert.IsTrue(page.Elements.ErrorMessagePassword.Displayed);
            StringAssert.Contains(Constants.ERROR_PASSWORD, page.Elements.ErrorMessagePassword.Text);
        }

        public static void AssertConfirmation(this LoginPage page)
        {
            Assert.IsTrue(page.Elements.ConfirmationForLogin.Displayed);
            StringAssert.Contains(Constants.CHECK_EMAIL, page.Elements.ConfirmationForLogin.Text);
        }
    }
}
