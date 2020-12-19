using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace EAAppAutomation.Pages
{
    class LogInPage : DriverHelper
    {

        IWebElement txtUserName => Driver.FindElement(By.Id("UserName"));
        IWebElement txtPassword => Driver.FindElement(By.Id("Password"));

        IWebElement btnLogin => Driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[4]/div/input"));

        public void EnterUserNameAndPassword(string userName, string password)
        {
            txtUserName.Clear();
            txtPassword.Clear();
            txtUserName.SendKeys(userName);
            txtPassword.SendKeys(password);
        }

        public void ClickLogin()
        {
            btnLogin.Click();
        }
    }
}
