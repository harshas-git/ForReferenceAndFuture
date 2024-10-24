using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using Mobiletesting.Pages;
using Mobiletesting.APIClient;

namespace Mobiletesting.Tests
{
    internal class AppLandingPageTests : BaseTest
    {
        [Test]
        public void VerifyElememts()
        {
            WebDriverWait webDriverWait = new WebDriverWait(appiumDriver, TimeSpan.FromSeconds(15));
            webDriverWait.IgnoreExceptionTypes(typeof(WebDriverException));

            var elements = webDriverWait.Until(d=>appiumDriver.FindElements(By.XPath("//android.widget.TextView")));
        }

        [Test]
        public void PerformBasicOperations()
        {
            LoginScreenPage lockScreenPage = new LoginScreenPage(appiumDriver);

            lockScreenPage.ClickLockScreen();
            lockScreenPage.EnterUserName("Harsha");
            lockScreenPage.ClearUserName();
            lockScreenPage.EnterUserName("myUsername");
            lockScreenPage.EnterPassword("AppPassword");
            lockScreenPage.ClickLoginButton();
        }

        [Test]
        public void SwipeTest()
        {
            LoginScreenPage lockScreenPage = new LoginScreenPage(appiumDriver);
            var startPoint = lockScreenPage.GetLockScreenCordinates();
            var stopPoint = lockScreenPage.GetVerifyPhoneCoordinates();
            Swipe(startPoint, stopPoint);

        }

        [Test]
        public void WebViewDeomPageTest()
        {
            AppLandingPage appLandingPage = new AppLandingPage(appiumDriver);
            var textInsideView=  appLandingPage.ClickOnWebViewDemo();
            Console.WriteLine(textInsideView);
        }
    }
}
