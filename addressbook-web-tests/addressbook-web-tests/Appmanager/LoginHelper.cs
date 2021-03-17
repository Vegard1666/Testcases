﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace AddressbookWebTests
{
    public class LoginHelper : HelperBase
    {      
        public LoginHelper(AppManager manager) : base(manager)
        {
        }

        public void Login(AccountData account)
        {            
            Type(By.Name("user"), account.Username);
            Type(By.Name("pass"), account.Password);            
            driver.FindElement(By.XPath("//input[@value='Login']")).Click();
        }

        public void Logout()
        {
            driver.FindElement(By.LinkText("Logout")).Click();
        }
    }
}

