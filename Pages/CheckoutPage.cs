using Coypu;
using neocoypu.Base;

namespace coyputests.Pages
{
    public class CheckoutPage : BaseTest
    {
        public CheckoutPage(BrowserSession browser)
        {
            this.browser = browser;
        }

        public void NoCheckout(string nome, string sobrenome, string senha)
        {
            browser.FillIn("First Name").With(nome);
            browser.FillIn("Last Name").With(sobrenome);
            browser.FillIn("Zip/Postal Code").With(senha);
            browser.FindCss(".cart_button").Click();            
        }        
    }
}