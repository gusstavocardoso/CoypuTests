using Coypu;
using Coypu.Drivers;
using neocoypu.Base;

namespace neocoypu.Pages
{    
    public class LoginPage : BaseTest
    {
        public LoginPage(BrowserSession browser)
        {
            this.browser = browser;
        }

        public void Logando(string email, string senha)
        {            
            browser.Visit("");
            browser.FillIn("Username").With(email);
            browser.FillIn("Password").With(senha);
            browser.ClickButton("LOGIN");
        }       
    }
}