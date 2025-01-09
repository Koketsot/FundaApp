using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundaAPP.Principal
{
    internal class principal_testcase
    {
        [TestFixture]

        public class Principal : Tests
        {
            private IWebDriver _driver;
            [SetUp]

            public void startBrowser()
            {
                SiteConnection();
            }

            [Test, Order(1)]
            public void principalTest()
            {
                Delay(2);
                //Test1();
                //Test2();

                Delay(2);

            }

            [Description("Verify Dashboard Elements Post Login")]

      
            [TearDown]
            public void closeBrowser()
            {
                base.DisconnectBrowser();
            }

        }

    }
}
