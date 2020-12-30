using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTests
{
    [TestFixture]
    public class Testcase3
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;

        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            baseURL = "https://www.google.com/";
            verificationErrors = new StringBuilder();
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }

        [Test]
        public void TheCase3Test()
        {
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            driver.FindElement(By.Id("user-name")).Clear();
            driver.FindElement(By.Id("user-name")).SendKeys("standard_user");
            driver.FindElement(By.Id("password")).Clear();
            driver.FindElement(By.Id("password")).SendKeys("secret_sauce");
            driver.FindElement(By.XPath("//div[2]/div[2]/div")).Click();
            driver.FindElement(By.Id("login_credentials")).Click();
            driver.FindElement(By.Id("login-button")).Click();
            driver.FindElement(By.XPath("//a[@id='item_3_title_link']/div")).Click();
            driver.FindElement(By.XPath("//div[@id='inventory_item_container']/div/div/div/button")).Click();
            driver.FindElement(By.XPath("//div[@id='inventory_item_container']/div/button")).Click();
            driver.FindElement(By.XPath("//div[@id='inventory_container']/div/div[3]/div[3]/button")).Click();
            driver.FindElement(By.CssSelector("path")).Click();
            driver.FindElement(By.XPath("//div[@id='cart_contents_container']/div/div/div[4]/div[2]/div[2]/button")).Click();
            driver.FindElement(By.XPath("//div[@id='cart_contents_container']/div/div/div[3]/div[2]/div[2]/button")).Click();
            driver.FindElement(By.LinkText("Continue Shopping")).Click();
            driver.FindElement(By.CssSelector("path")).Click();
            driver.FindElement(By.LinkText("Continue Shopping")).Click();
            driver.FindElement(By.XPath("//div[@id='header_container']/div")).Click();
            driver.FindElement(By.XPath("//div[@id='menu_button_container']/div/div[3]/div/button")).Click();
            driver.FindElement(By.Id("logout_sidebar_link")).Click();
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }
    }
}

