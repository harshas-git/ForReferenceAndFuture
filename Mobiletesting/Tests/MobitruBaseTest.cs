using Mobiletesting.APIClient;
using Mobiletesting.Constants.Endpoints;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.iOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobiletesting.Tests
{
    public abstract class MobitruBaseTest
    {
        protected AppiumDriver appiumDriver;

        [SetUp]
        public void SetUp()
        {
            MobitruClient client = new MobitruClient();
            var androidDevices =  client.GetAndroidDeviceRequirements();
            AppiumOptions appiumOptions = new AppiumOptions() 
            { 
             PlatformName =androidDevices.desiredCapabilities.platformName,
             PlatformVersion =androidDevices.desiredCapabilities.platformVersion,
             DeviceName =androidDevices.desiredCapabilities.deviceName,
            };
            appiumOptions.AddAdditionalAppiumOption("udid",androidDevices.desiredCapabilities.udid);
            appiumOptions.AddAdditionalAppiumOption("dc", androidDevices.desiredCapabilities.dc);

            appiumDriver = new AndroidDriver(new Uri(Tokens.MobitruServerURL), appiumOptions);   
        }


        [TearDown]
        public void TearDown()
        {
            appiumDriver.Dispose();
        }
    }
}
