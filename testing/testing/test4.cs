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
    class test4
    {
        IWebDriver driver;
        [SetUp]
        public void StartBrowser()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void login()
        {
            driver.Url = "https://www.saucedemo.com/";
            IWebElement element = driver.FindElement(By.Name("user-name"));
            element.SendKeys("standard_user");

            IWebElement password = driver.FindElement(By.Name("password"));
            password.SendKeys("secret_sauce");
            IWebElement button1 = driver.FindElement(By.XPath("/html/body/div[2]/div[1]/div/div/form/input[3]"));
            button1.Submit();
        }

        [Test]
        public void addproducttocart()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(40);
            login();
            IWebElement button2 = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/div/div[2]/div/div[3]/div[3]/button"));
            button2.Click();

            IWebElement dropdown = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/div/div[1]/div[3]/select"));
            SelectElement select = new SelectElement(dropdown);
            select.SelectByValue("az");
            select.SelectByText("Price (low to high)");

            IWebElement button3 = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/div/div[2]/div/div[6]/div[3]/button"));
            button3.Click();

            IWebElement button4 = driver.FindElement(By.XPath("/html/body/div/div[2]/div[1]/div[2]/a"));
            button4.Click();

            IWebElement button5 = driver.FindElement(By.XPath("/html/body/div/div[2]/div[3]/div/div[1]/div[3]/div[2]/div[2]/button"));
            button5.Click();

            IWebElement button6 = driver.FindElement(By.XPath("/html/body/div/div[2]/div[3]/div/div[2]/a[1]"));
            button6.Click();

            IWebElement button7 = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/div/div[2]/div/div[3]/div[3]/button"));
            button7.Click();

            IWebElement button8 = driver.FindElement(By.XPath("/html/body/div/div[2]/div[1]/div[2]/a"));
            button8.Click();

            IWebElement button9 = driver.FindElement(By.XPath("/html/body/div/div[2]/div[3]/div/div[2]/a[2]"));
            button9.Click();


            IWebElement Fname = driver.FindElement(By.XPath("/html/body/div/div[2]/div[3]/div/form/div[1]/input[1]"));
            Fname.SendKeys("standard_user");

            IWebElement Lname = driver.FindElement(By.XPath("/html/body/div/div[2]/div[3]/div/form/div[1]/input[2]"));
            Lname.SendKeys("secret");

            IWebElement Zip = driver.FindElement(By.XPath("/html/body/div/div[2]/div[3]/div/form/div[1]/input[3]"));
            Zip.SendKeys("sauce");

            IWebElement button10 = driver.FindElement(By.XPath("/html/body/div/div[2]/div[3]/div/form/div[2]/input"));
            button10.Submit();

            IWebElement text = driver.FindElement(By.XPath("/html/body/div/div[2]/div[3]/div/div[2]/div[2]"));
            String contain = text.Text;
            String expected = "SauceCard #31337";
            StringAssert.AreEqualIgnoringCase(contain, expected);

            IWebElement text2 = driver.FindElement(By.XPath("/html/body/div/div[2]/div[3]/div/div[2]/div[4]"));
            String contain2 = text2.Text;
            String expected2 = "FREE PONY EXPRESS DELIVERY!";
            StringAssert.AreEqualIgnoringCase(expected2, contain2);

            IWebElement button11 = driver.FindElement(By.XPath("/html/body/div/div[2]/div[3]/div/div[2]/div[8]/a[2]"));
            button11.Click();

            driver.Navigate().Back();
            driver.Navigate().Forward();
            driver.Close();

        }
    }
}
