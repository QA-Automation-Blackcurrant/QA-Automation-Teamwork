
namespace Tests.Models
{
    public class LoginUser
    {
        public string Email { get; set; }

        public string Password { get; set; }

        public string RememberMe { get; set; }

        ////////////////////////////// Only for LoginWithCreatedArticle Test ///////////////////////////

        public string Title { get; set; }

        public string Content { get; set; }

    }   
}
