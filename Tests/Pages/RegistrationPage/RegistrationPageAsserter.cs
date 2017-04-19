namespace Tests.Pages.RegistrationPage
{
    using NUnit.Framework;

    public static class RegistrationPageAsserter
    {       
        public static void AssertInvalidEmailErrorMessage(this RegistrationPage page)
        {
            Assert.IsTrue(page.Elements.ErrorMessagesForEmail.Displayed);
            StringAssert.Contains(Constants.ERROR_EMAIL, page.Elements.ErrorMessagesForEmail.Text);
        }

        public static void AssertEmailErrorMessage(this RegistrationPage page)
        {
            Assert.IsTrue(page.Elements.ErrorMessagesForEmail.Displayed);
            StringAssert.Contains(Constants.ERROR_REQUIRED, page.Elements.ErrorMessagesForEmail.Text);
        }
    }
}
