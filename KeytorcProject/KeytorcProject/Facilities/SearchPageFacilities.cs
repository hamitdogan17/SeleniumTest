using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeytorcProject.Facilities
{
    public class SearchPageFacilities
    {
        private ChromeDriver driver;
        public SearchPageFacilities(ChromeDriver driver)
        {
            this.driver = driver;
        }

        public void gotoPageNumberAndCheck(string pageNumber)
        {
            string pageURL = driver.FindElement(By.XPath("//div[@class='pagination']/a[" + pageNumber + "]")).GetAttribute("href");
            // driver.FindElement(By.XPath("//div[@class='pagination']/a[2]")).Click(); 
            driver.Navigate().GoToUrl(pageURL);
            Assert.IsTrue(driver.FindElement(By.Id("currentPage")).GetAttribute("value").Contains(pageNumber));
        }

        public void CheckSearchList(string productName)
        {
            IList<IWebElement> searchList = driver.FindElements(By.XPath("//h3[@class='productName ']"));

            for (int i = 1; i <= searchList.Count; i++)
               Assert.IsTrue(driver.FindElement(By.XPath("//h3[@class='productName ']")).Text.ToLower().Contains(productName.ToLower()));
            // Assert.IsTrue(driver.FindElement(By.XPath("//div[@id='view']/ul/li[" + i + "]/div/div[2]/a/h3/span")).Text.ToLower().Contains(productName.ToLower()));

        }
        public string getFavoriteProduct(int whichProduct)
        {
            string favoriUrun = driver.FindElement(By.XPath("//div[@id='view']/ul/li[" + whichProduct + "]/div/div/a/h3")).Text.Replace("\n", "");
            // driver.FindElement(By.XPath("//div[@id='view']/ul/li[" + whichProduct + "]/div/div[2]/span[@class='textImg followBtn']")).Click();
         
            driver.FindElements(By.XPath("//span[@class='textImg followBtn']"))[2].Click();
                        
            return favoriUrun;
        }
    }
}
