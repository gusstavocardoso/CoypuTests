using coyputests.Pages;
using CoypuTests.Pages;
using neocoypu.Base;
using neocoypu.Pages;
using NUnit.Framework;

namespace CoypuTests.Tests
{
    public class TestCompra : BaseTest
    {
        public LoginPage login;
        public CheckoutPage checkout;
        public CartPage carrinho;
        public ConfirmationPage confirmacao;
        public DetailsPage detalhes;

        [SetUp]
        public void StartObjects()
        {
            login = new LoginPage(browser);
            checkout = new CheckoutPage(browser);
            carrinho = new CartPage(browser);
            confirmacao = new ConfirmationPage(browser);
            detalhes = new DetailsPage(browser);
        }
       
        [Test]        
        public void DeveComprarProduto()
        {            
            login.Logando("standard_user", "secret_sauce");             

            detalhes.AdicionandoProduto();
            
            carrinho.NoCarrinho("Your Cart");
            
            checkout.NoCheckout("Copypu", "Framework", "12345678");
            
            confirmacao.Confirmando("THANK YOU FOR YOUR ORDER");
        }             
    }
}