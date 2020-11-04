using neocoypu.Base;
using neocoypu.Pages;
using NUnit.Framework;

namespace neocoypu.Tests
{
    public class TestLogin : BaseTest
    {
        public LoginPage login;

        [SetUp]
        public void Start()
        {
            login = new LoginPage(browser);
        }
       
        [Test]
        public void LoginSucess()
        {
            login.Logando("standard_user", "secret_sauce"); 

        }          
    }
}