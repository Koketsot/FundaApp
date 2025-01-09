using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;

namespace FundaAPP
{
    public class Tests
    {

        private ChromeOptions _chromeOptions;
        public IWebDriver _driver;
        private string _userName;
        private string _password;

        [OneTimeSetUp]
        public void StartBrowser()
        {
            _chromeOptions = new ChromeOptions();
            _chromeOptions.AddArguments("--incognito");
            _chromeOptions.AddArguments("--ignore-certificate-errors");
            _driver = new ChromeDriver("C:/Users/KoketsoTinyane/source/repos/WorldOfImpact/WorldOfImpact/bin/Debug/Drivers");
        }

        public IWebDriver SiteConnection()
        {
            _driver.Url = "https://fundaapp-app-qa-za.azurewebsites.net/";

            _userName = "8601016828185";
            _password = "Funda123";
            _driver.Manage().Window.Maximize();
            System.Threading.Thread.Sleep(4000);

            IWebElement loginTextBox = _driver.FindElement(By.XPath("/html/body/div/ion-app/ion-router-outlet/div/div[3]/div/form/div/div[1]/div/input"));
            IWebElement passwordTextBox = _driver.FindElement(By.XPath("/html/body/div/ion-app/ion-router-outlet/div/div[3]/div/form/div/div[2]/div/div/input"));
            IWebElement loginBtn = _driver.FindElement(By.Id("gtm-login"));
            loginTextBox.SendKeys(_userName);
            System.Threading.Thread.Sleep(6000);
            passwordTextBox.SendKeys(_password);
            System.Threading.Thread.Sleep(4000);

            Delay(9);
       
            loginBtn.Click();
            Delay(30);

            return _driver;
        }

        [OneTimeTearDown]
        public void DisconnectBrowser()
        {
            if (_driver != null)
            {
                _driver.Quit();
                _driver.Dispose();
                _driver = null; // Ensure it’s reset for each test
            }
        }

        public void Delay(int delaySeconds)
        {
            Thread.Sleep(delaySeconds * 10000);
        }

    }
}