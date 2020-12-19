using EAAppAutomation.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace EAAppAutomation
{
    public class Tests : DriverHelper
    {
        [SetUp]
        public void Setup()
        {   
            DriverHelper.InitBrowser();

        }

        [Test]
        public void LogInTest()
        {
            string userName = "admin";
            string password = "password";

            Driver.Navigate().GoToUrl("http://eaapp.somee.com/");

            HomePage homePage = new HomePage();
            LogInPage loginPage = new LogInPage();

            homePage.ClickLogin();
            loginPage.EnterUserNameAndPassword(userName, password);
            loginPage.ClickLogin();

            Assert.That(homePage.IsLoggedOut, Is.True, "Cannot find the Log Off Button!");
        }
    }
}