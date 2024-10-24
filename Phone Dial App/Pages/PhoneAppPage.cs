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
    public class PhoneAppPage
    {
        private readonly AppiumDriver androidDriver;

        public PhoneAppPage(AppiumDriver androidDriver)
        {
            androidDriver=androidDriver;
        }

        private By OneNumberLocator => MobileBy.AccessibilityId("1,");

        private By TwoNumberLocator => MobileBy.AccessibilityId("2,ABC");

        private By ThreeNumberLocator => MobileBy.AccessibilityId("3,DEF");

        private By FourNumberLocator => MobileBy.AccessibilityId("4,GHI");

        private By FiveNumberLocator => MobileBy.AccessibilityId("5,JKL");

        private By SixNumberLocator => MobileBy.AccessibilityId("6,MNO");

        private By SevenNumberLocator => MobileBy.AccessibilityId("7,PQRS");

        private By EightNumberLocator => MobileBy.AccessibilityId("8,TUV");

        private By NineNumberLocator => MobileBy.AccessibilityId("9,WXYZ");

        private By DialButton => MobileBy.AccessibilityId("dial");



        private AppiumElement One => androidDriver.FindElement(OneNumberLocator);
        private AppiumElement Two => androidDriver.FindElement(TwoNumberLocator);
        private AppiumElement Three => androidDriver.FindElement(ThreeNumberLocator);
        private AppiumElement Four => androidDriver.FindElement(FourNumberLocator);
        private AppiumElement Five => androidDriver.FindElement(FiveNumberLocator);
        private AppiumElement Six => androidDriver.FindElement(SixNumberLocator);
        private AppiumElement Seven => androidDriver.FindElement(SevenNumberLocator);
        private AppiumElement Eight => androidDriver.FindElement(EightNumberLocator);
        private AppiumElement Nine => androidDriver.FindElement(NineNumberLocator);

        private AppiumElement Dial => androidDriver.FindElement(DialButton);

        

        

        public void ClickOnDial()
        {
            Dial.Click();
        }

        public void ClickNumberOne()
        {
            One.Click();
        }
        public void ClickNumberTwo()
        {
            Two.Click();
        }
        public void ClickNumberThree()
        {
            Three.Click();
        }

        public void ClickNumberFour()
        {
            Four.Click();
        }

        public void ClickNumberFive()
        {
            Five.Click();
        }

        public void ClickNumberSix()
        {
            Six.Click();
        }

        public void ClickNumberSeven()
        {
            Seven.Click();
        }

        public void ClickNumberEight()
        {
            Eight.Click();
        }

        public void ClickNumberNine()
        {
            Nine.Click();
        }

    }
}
