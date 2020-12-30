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
    public class Testcase2
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
        public void TheCase2Test()
        {
            driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/index.php/auth/login");
            driver.FindElement(By.Id("txtUsername")).Click();
            driver.FindElement(By.Id("txtUsername")).Clear();
            driver.FindElement(By.Id("txtUsername")).SendKeys("Admin");
            driver.FindElement(By.Id("txtPassword")).Click();
            driver.FindElement(By.Id("txtPassword")).Click();
            driver.FindElement(By.Id("txtPassword")).Clear();
            driver.FindElement(By.Id("txtPassword")).SendKeys("admin123");
            driver.FindElement(By.Id("btnLogin")).Click();
            driver.FindElement(By.XPath("//div[@id='dashboard-quick-launch-panel-menu_holder']/table/tbody/tr/td/div/a/img")).Click();
            driver.FindElement(By.XPath("//a[@id='menu_time_viewTimeModule']/b")).Click();
            driver.FindElement(By.XPath("//a[@id='menu_recruitment_viewRecruitmentModule']/b")).Click();
            driver.FindElement(By.XPath("//a[@id='menu_pim_viewMyDetails']/b")).Click();
            driver.FindElement(By.Id("btnSave")).Click();
            driver.FindElement(By.Id("personal_txtEmpFirstName")).Click();
            driver.FindElement(By.Id("personal_txtEmpFirstName")).Clear();
            driver.FindElement(By.Id("personal_txtEmpFirstName")).SendKeys("Sristy");
            driver.FindElement(By.Id("personal_txtEmployeeId")).Click();
            driver.FindElement(By.Id("personal_txtEmployeeId")).Clear();
            driver.FindElement(By.Id("personal_txtEmployeeId")).SendKeys("0043");
            driver.FindElement(By.Id("personal_txtEmpMiddleName")).Click();
            driver.FindElement(By.Id("personal_txtEmpMiddleName")).Clear();
            driver.FindElement(By.Id("personal_txtEmpMiddleName")).SendKeys("Naim");
            driver.FindElement(By.Id("personal_txtEmpLastName")).Click();
            driver.FindElement(By.Id("personal_txtEmpLastName")).Clear();
            driver.FindElement(By.Id("personal_txtEmpLastName")).SendKeys("Zannatun");
            driver.FindElement(By.Id("personal_txtOtherID")).Click();
            driver.FindElement(By.Id("personal_txtOtherID")).Clear();
            driver.FindElement(By.Id("personal_txtOtherID")).SendKeys("0001");
            driver.FindElement(By.Id("personal_optGender_2")).Click();
            driver.FindElement(By.Id("personal_cmbNation")).Click();
            new SelectElement(driver.FindElement(By.Id("personal_cmbNation"))).SelectByText("Australian");
            driver.FindElement(By.Id("personal_cmbNation")).Click();
            driver.FindElement(By.Id("personal_cmbNation")).Click();
            new SelectElement(driver.FindElement(By.Id("personal_cmbNation"))).SelectByText("Bangladeshi");
            driver.FindElement(By.Id("personal_cmbNation")).Click();
            driver.FindElement(By.Id("personal_cmbMarital")).Click();
            new SelectElement(driver.FindElement(By.Id("personal_cmbMarital"))).SelectByText("Single");
            driver.FindElement(By.Id("personal_cmbMarital")).Click();
            driver.FindElement(By.XPath("//form[@id='frmEmpPersonalDetails']/fieldset/ol[3]/li[4]/img")).Click();
            driver.FindElement(By.XPath("//div[@id='ui-datepicker-div']/div/div/select[2]")).Click();
            driver.FindElement(By.LinkText("11")).Click();
            driver.FindElement(By.Id("personal_txtEmpNickName")).Click();
            driver.FindElement(By.Id("personal_txtEmpNickName")).Clear();
            driver.FindElement(By.Id("personal_txtEmpNickName")).SendKeys("Sristy");
            driver.FindElement(By.Id("btnSave")).Click();
            driver.FindElement(By.XPath("//a[@id='menu_admin_viewAdminModule']/b")).Click();
            driver.FindElement(By.XPath("//a[@id='menu_pim_viewPimModule']/b")).Click();
            driver.FindElement(By.XPath("//a[@id='menu_dashboard_index']/b")).Click();
            driver.FindElement(By.XPath("//a[@id='menu_maintenance_purgeEmployee']/b")).Click();
            driver.FindElement(By.XPath("//a[@id='menu_dashboard_index']/b")).Click();
            driver.FindElement(By.Id("welcome")).Click();
            driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[10]/ul/li[2]/a")).Click();
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

