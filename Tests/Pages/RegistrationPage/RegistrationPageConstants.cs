namespace Tests.Pages.RegistrationPage
{
    internal static class Constants
    {
        //// Common
        internal const string REGISTRATION_URL = "Account/Register/";
        internal const int WAIT_SECCONDS = 20;

        //// Selectors
        internal const string EMAIL_SELECTOR = "Email";
        internal const string FULL_NAME_SELECTOR = "FullName";
        internal const string PASSWORD_SELECTOR = "Password";
        internal const string CONFIRM_PASSWORD_SELECTOR = "ConfirmPassword";
        internal const string REGISTER_BUTTON_SELECTOR = "/html/body/div[2]/div/div/form/div[6]/div/input";
        internal const string ERROR_EMAIL_SELECTOR = "/html/body/div[2]/div/div/form/div[1]/ul/li[1]";
        internal const string ERROR_PASSWORD_SELECTOR = "/html/body/div[2]/div/div/form/div[1]/ul/li";
        internal const string DIFFERENCE_BETWEEN_PASSWORDS_SELECTOR = "/html/body/div[2]/div/div/form/div[1]/ul/li";
        //// Messages
        internal const string ERROR_REQUIRED = "The Email field is required.";
        internal const string ERROR_EMAIL = "The Email field is not a valid e-mail address.";
        internal const string ERROR_PASSWORD = "The Password field is required.";
        internal const string DIFFERENCE_BETWEEN_PASSWORDS = "The password and confirmation password do not match.";
    }
}
