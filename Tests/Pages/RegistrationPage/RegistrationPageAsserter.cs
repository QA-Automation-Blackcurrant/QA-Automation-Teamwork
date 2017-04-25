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

        public static void AssertPasswordErrorMessage(this RegistrationPage page)
        {
            Assert.IsTrue(page.Elements.ErrorMessagesForPassword.Displayed);
            StringAssert.Contains(Constants.ERROR_PASSWORD, page.Elements.ErrorMessagesForPassword.Text);
        }

        public static void AssertDifferencePasswordErrorMessage(this RegistrationPage page)
        {
            Assert.IsTrue(page.Elements.ErrorMessagesForDifferencePassword.Displayed);
            StringAssert.Contains(Constants.DIFFERENCE_BETWEEN_PASSWORDS, page.Elements.ErrorMessagesForDifferencePassword.Text);
        }

        public static void AssertFullNameErrorMessage(this RegistrationPage page)
        {
            Assert.IsTrue(page.Elements.ErrorMessagesForMissingFullName.Displayed);
            StringAssert.Contains(Constants.ERROR_FULL_NAME, page.Elements.ErrorMessagesForMissingFullName.Text);
        }
    }
}
