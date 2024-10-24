using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobiletesting.Pages
{
    public class MobitruDevicePage
    {
        private readonly AppiumDriver _androidDriver;
        public MobitruDevicePage(AppiumDriver driver)
        {
            _androidDriver = driver;
        }

        private By PlayStoreAppLocator => By.LinkText("Play Store\r\n");

        private AppiumElement PlaystoreButton => _androidDriver.FindElement(PlayStoreAppLocator);

        public void ClickOnPlayStore()
        {
            PlaystoreButton.Click();
        }
    }
}
