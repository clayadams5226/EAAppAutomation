using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace EAAppAutomation.Pages
{
    public class HomePage : DriverHelper
    {

        IWebElement lnkLogin => Driver.FindElement(By.LinkText("Login"));

        IWebElement lnkLogOut => Driver.FindElement(By.LinkText("Log off"));

        //public void ClickLogin() => lnkLogin.Click();
        public void ClickLogin()
        {
            lnkLogin.Click();
        }

        public bool IsLoggedOut() => lnkLogOut.Displayed;
        
    }
}
