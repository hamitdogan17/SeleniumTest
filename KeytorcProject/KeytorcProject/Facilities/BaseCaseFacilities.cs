using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KeytorcProject.Facilities
{
    public class BaseCaseFacilities
    {
        private ChromeDriver driver;
        public BaseCaseFacilities(ChromeDriver driver)
        {
            this.driver = driver;
        }

        public void SearchProduct( String productName)
        {
            

            driver.FindElement(By.Id("searchData")).Click();
            driver.FindElement(By.Id("searchData")).SendKeys(productName);

            Actions act = new Actions(driver);
            act.SendKeys(Keys.Enter);
            act.Perform();
        }
        public void gotoFavorilerim()
        {
            driver.FindElement(By.XPath("//a[@title='Hesabım']")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//div[@class='accNav']/ul/li[5]/a")).Click();
        }
        
    }
}
