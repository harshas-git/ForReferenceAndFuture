using OpenQA.Selenium.Appium;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Mobiletesting.Pages
{
    public class LoginScreenPage
    {
        private readonly AppiumDriver _androidDriver;
        public LoginScreenPage(AppiumDriver driver)
        {
            _androidDriver = driver;
        }

        private By VerifyPhoneLocator => By.LinkText("Verify Phone Number");

        private By LockScreenLocator => By.XPath("//android.widget.TextView[@text='Login Screen']");

        private AppiumElement VerifyPhoneNumber => _androidDriver.FindElement(VerifyPhoneLocator);
        private By UserNameFieldLocator => MobileBy.AccessibilityId("username");
        private By PasswordFieldLocator => MobileBy.AccessibilityId("password");
        private By LoginButtonLocator => By.XPath("(//android.widget.TextView[@text='Login'])[2]");


        private AppiumElement LockScreenElement => _androidDriver.FindElement(LockScreenLocator);

        private AppiumElement UserNameFieldElement => _androidDriver.FindElement(UserNameFieldLocator);

        private AppiumElement PasswordFieldElement => _androidDriver.FindElement(PasswordFieldLocator);

        private AppiumElement LoginButtonElement => _androidDriver.FindElement(LoginButtonLocator);

        public Point GetLockScreenCordinates()
        {
            return LockScreenElement.Location;
        }

        public Point GetVerifyPhoneCoordinates()
        {
            return VerifyPhoneNumber.Location;
        }
        public void ClickLockScreen()
        {
            LockScreenElement.Click();
        }

        public void EnterUserName(string userName)
        {
            UserNameFieldElement.Clear();
            UserNameFieldElement.SendKeys(userName);
        }

        public void ClearUserName()
        {
            UserNameFieldElement.Clear();
        }

        public void EnterPassword(string password)
        {
            PasswordFieldElement.Clear();
            PasswordFieldElement.SendKeys(password);
        }

        public void ClickLoginButton()
        {
            LoginButtonElement.Click();
        }

    }
}
