using Coypu;
using neocoypu.Base;

namespace CoypuTests.Pages
{
    public class DetailsPage : BaseTest
    {
        public DetailsPage(BrowserSession browser)
        {
            this.browser = browser;
        }

        public void AdicionandoProduto()
        {
            browser.FindCss("#item_4_title_link").Click();
            browser.ClickButton("ADD TO CART");
            browser.FindCss(".fa-shopping-cart").Click();      
        }
    }
}