using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeytorcProject.Facilities
{
    public class LoginFacilities
    {
        private ChromeDriver driver;
        public LoginFacilities(ChromeDriver driver)
        {
            this.driver = driver;
        }
        public void loginAccount( String eMail, String Password)
        {
            driver.FindElement(By.XPath("//a[@class='btnSignIn']")).Click();

            driver.FindElement(By.XPath("//input[@id='email']")).Click();
            driver.FindElement(By.XPath("//input[@id='email']")).SendKeys(eMail);
            driver.FindElement(By.XPath("//input[@id='password']")).Click();
            driver.FindElement(By.XPath("//input[@id='password']")).SendKeys(Password);

            driver.FindElement(By.Id("loginButton")).Click();
        }
    }
}
