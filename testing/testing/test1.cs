using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing
{
    class test1
    {
        IWebDriver driver;

        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void Test()
        {
            driver.Url = "https://artoftesting.com/samplesiteforselenium";
            IWebElement element=
            driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/main/article/div/div/div/div/section[4]/div/div/div/div/div/div[1]/div/p"));
            String actual = element.Text;
            String expected = "This is sample text!";
            StringAssert.AreEqualIgnoringCase(actual, expected);
        }

        [Test]
        public void Test1()
        {
            driver.Url = "https://artoftesting.com/samplesiteforselenium";
            IWebElement element =
            driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/main/article/div/div/div/div/section[4]/div/div/div/div/div/div[1]/p[1]"));
            element.Click();      
        }

        [Test]
        public void Test2()
        {
            driver.Url = "https://artoftesting.com/samplesiteforselenium";
            IWebElement element =
            driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/main/article/div/div/div/div/section[4]/div/div/div/div/div/div[1]/p[2]/input"));
            element.SendKeys("Hello everyone");
        }

        [Test]
        public void Test3()
        {
            driver.Url = "https://artoftesting.com/samplesiteforselenium";
            IWebElement element =
            driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/main/article/div/div/div/div/section[4]/div/div/div/div/div/div[2]/button"));
            element.Click();
        }

        [Test]
        public void Test4()
        {
            driver.Url = "https://artoftesting.com/samplesiteforselenium";
            IWebElement element =
            driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/main/article/div/div/div/div/section[4]/div/div/div/div/div/div[1]/form[1]"));
            Boolean status = element.Selected;
            Boolean expected = false;
            status.Equals(expected);
        }

        [Test]
        public void Test5()
        {
            driver.Url = "https://artoftesting.com/samplesiteforselenium";
            IWebElement element =
            driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/main/article/div/div/div/div/section[4]/div/div/div/div/div/div[1]/select"));
            SelectElement select = new SelectElement(element);
            select.SelectByValue("Manual");
        }

        [Test]
        public void Test6()
        {
            driver.Url = "https://artoftesting.com/samplesiteforselenium";
            IWebElement element =
            driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/main/article/div/div/div/div/section[4]/div/div/div/div/div/div[1]/form[2]"));
            element.Click();
        }

    }
}
