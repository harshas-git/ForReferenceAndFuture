using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneAppAutomation.Pages
{
    public class PhoneCallPage
    {
        private readonly AppiumDriver androidDriver;

        public PhoneCallPage(AppiumDriver androidDriver)
        {
            androidDriver=androidDriver;
        }

        private By EndCall => MobileBy.AccessibilityId("End call");

        public AppiumElement EndCallButton => androidDriver.FindElement(EndCall);

      

    }
}
