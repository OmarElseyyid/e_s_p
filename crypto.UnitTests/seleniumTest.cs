using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace crypto.UnitTests
{
    /// <summary>
    /// Summary description for seleniumTest
    /// </summary>
    [TestClass]
    public class seleniumTest
    {
        [TestClass]
        public class UnitTest1 // test sınfıımız 
        {
            IWebDriver driver = new FirefoxDriver("C:\\Users\\Mahmud\\Desktop\\e_s_p\\crypto.UnitTests\\driver");//
            
            [TestMethod] //bu ifade bize bu metodun test metodu olduğunu gösterir
            public void SiteyeGiris() // test metodumuz
            {

                driver.Navigate().GoToUrl("http://www.yazilimcilardunyasi.com/");
            }
            [TestMethod]
            public void sitedeAramaYap() // sitede arama yapan fonksiyonu test eden metodumuz
            {
                SiteyeGiris();
                System.Threading.Thread.Sleep(1000);
                driver.FindElement(By.Name("q")).SendKeys("Yazılım Test");
                System.Threading.Thread.Sleep(1000);
                driver.FindElement(By.XPath("/html/body/div[4]/div[2]/div[2]/div[2]/div[2]/div[2]/div[2]/div/div[4]/div[2]/div/aside/div/div[4]/div[1]/div/form/table/tbody/tr/td[2]/input")).Click();
                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}
