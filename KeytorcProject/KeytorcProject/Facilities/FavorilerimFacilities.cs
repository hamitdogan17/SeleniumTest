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
    public class FavorilerimFacilities
    {
        private ChromeDriver driver;
        public FavorilerimFacilities(ChromeDriver driver)
        {
            this.driver = driver;
        }
        public void CheckElementIsinFavoriteList( String favoriUrun)
        {
            Assert.IsTrue(driver.FindElement(By.XPath("//td[@class='productTitle']/p/a")).Text.Contains(favoriUrun));
        }
        public void removeProductAndCheckInFavorilerim()
        {
            driver.FindElement(By.XPath("//a[@class='removeSelectedProduct']")).Click();
            Assert.IsTrue(driver.FindElement(By.XPath(("//div[@class='emptyWatchList hiddentext']"))).Text.Contains("ürün bulunmamaktadır"));
        }
    }
}
