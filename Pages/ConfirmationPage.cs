using Coypu;
using neocoypu.Base;
using NUnit.Framework;

namespace CoypuTests.Pages
{
    public class ConfirmationPage : BaseTest
    {
        public ConfirmationPage(BrowserSession browserSession){
            this.browser = browserSession;
        }

        public void Confirmando(string confirmacao){
            browser.FindCss(".cart_button").Click();
            var confirmacaoPedido = browser.FindCss(".complete-header");
            Assert.AreEqual(confirmacao, confirmacaoPedido.Text);
        }        
    }
}