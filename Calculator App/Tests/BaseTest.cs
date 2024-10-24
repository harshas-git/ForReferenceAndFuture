using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp.Tests
{
    public abstract class BaseTest
    {
        protected const string AppiumServerUrl = "http://localhost:4723/wd/hub";
        protected const string App = "https://github.com/cloudgrey-io/the-app/releases/download/v1.10.0/TheApp-v1.10.0.apk";
        protected AppiumDriver appiumDriver;

        [SetUp]
        public void SetUp()
        {
            AppiumOptions options = new AppiumOptions()
            {
                PlatformName = "Android",
                PlatformVersion = "9",
                DeviceName = "emulator-5554",
                AutomationName = "UiAutomator2",
            }; 

            options.AddAdditionalAppiumOption("appPackage", "com.android.calculator2");
            options.AddAdditionalAppiumOption("appActivity", "com.android.calculator2.Calculator");

            appiumDriver = new AndroidDriver(new Uri(AppiumServerUrl), options);
        }

        [TearDown]
        public void TearDown()
        {
            appiumDriver.Dispose();
            
        }

    }
}
