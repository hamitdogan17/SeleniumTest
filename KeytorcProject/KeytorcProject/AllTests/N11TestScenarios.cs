using KeytorcProject.Facilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KeytorcProject.AllTests
{
    [TestClass]
    public class N11TestScenarios
    {
        [TestMethod]
        [TestCategory("AllTests")]
        public void TestMethod1()
        { 
            ChromeDriver driver = new ChromeDriver(System.IO.Directory.GetCurrentDirectory());
            LoginFacilities lf = new LoginFacilities(driver);
            BaseCaseFacilities bcf = new BaseCaseFacilities(driver);
            SearchPageFacilities spf = new SearchPageFacilities(driver);
            FavorilerimFacilities ff = new FavorilerimFacilities(driver);

            driver.Navigate().GoToUrl("http://www.n11.com");
            Assert.IsTrue(driver.FindElement(By.XPath("//span[text()='alışverişin uğurlu adresi']")).Displayed);

            // Login Your Account
            lf.loginAccount("hamitdogan17@gmail.com", "1a2b3c4d5e");
            bcf.SearchProduct("samsung");
            Thread.Sleep(2000);
            spf.CheckSearchList("samsung");
            Thread.Sleep(2000);
            spf.gotoPageNumberAndCheck("2");
            
            string favoriUrun = spf.getFavoriteProduct(3);
            bcf.gotoFavorilerim(); 
            ff.CheckElementIsinFavoriteList(favoriUrun);
            ff.removeProductAndCheckInFavorilerim();

            

            
        }
    }
}
