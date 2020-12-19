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
            Driver = new ChromeDriver();    

        }

        [Test]
        public void Test1()
        {
            Driver.Navigate().GoToUrl("http://eaapp.somee.com/");

            Assert.Pass();
        }
    }
}