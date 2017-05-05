﻿namespace Tests.Pages.LoginPage
{
    internal static class Constants
    {
        //// Common
        internal const string REGISTRATION_URL = "Account/Register/";
        internal const int WAIT_SECCONDS = 20;

        //// Selectors
        internal const string MAINLOGIN_SELECTOR = "loginLink";
        internal const string EMAIL_SELECTOR = "Email";
        internal const string PASSWORD_SELECTOR = "Password";
        internal const string REMEMBER_ME_BUTTON_SELECTOR = "/html/body/div[2]/div/div/form/div[3]/div/div/div/label";
        internal const string LOGIN_BUTTON_SELECTOR = "/html/body/div[2]/div/div/form/div[4]/div/input";
        internal const string ERROR_EMAIL_SELECTOR = "/html/body/div[2]/div/div/form/div[1]/div/span/span";
        internal const string ERROR_PASSWORD_SELECTOR = "/html/body/div[2]/div/div/form/div[2]/div/span/span";
        internal const string ERROR_EMAIL_REQUIRED_SELECTOR = "/html/body/div[2]/div/div/form/div[1]/div/span/span";
        internal const string SUCCESSFUL_LOGIN_SELECTOR = "a[href*='/Manage']";
        internal const string INCORRECT_PASSWORD_SELECTOR = "/html/body/div[2]/div/div/form/div[1]/ul/li";
               
        //// Messages 
        internal const string ERROR_PASSWORD = "The Password field is required.";
        internal const string ERROR_EMAIL = "The Email field is not a valid e-mail address.";
        internal const string ERROR_WITHOUT_EMAIL = "The Email field is required.";
        internal const string CHECK_EMAIL = "Hello admin@admin.com!";
        internal const string INCORRECT_PASSWORD = "Invalid login attempt.";

        ////////////////////////////// Only for LoginWithCreatedArticle Test ///////////////////////////

        //// Selectors
        internal const string CREATE_ARTICLE_BUTTON_SELECTOR = "//*[@id=\"logoutForm\"]/ul/li[2]/a";
        internal const string TITLE_BUTTON_SELECTOR = "Title";
        internal const string CONTENT_BUTTON_SELECTOR = "Content";
        internal const string CREATE_BUTTON_SELECTOR = "/html/body/div[2]/div/div/form/div[4]/div/input";
        internal const string TEST_TITLE_SELECTOR = "Blackcurrant";

        //// Messages 
        internal const string CONFIRMATION_TEXT = "Blackcurrant.";



    }
}
