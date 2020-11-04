using Coypu;
using neocoypu.Base;
using NUnit.Framework;

namespace coyputests.Pages
{
    public class CartPage : BaseTest
    {
        public CartPage(BrowserSession browser)
        {
            this.browser = browser;
        }

        public void NoCarrinho(string meuCarrinho)
        {
            var carrinho = browser.FindCss(".subheader");
            Assert.AreEqual(meuCarrinho, carrinho.Text);           
            browser.FindCss(".btn_action").Click();
        }   
        
    }
}