using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using PhoneAppAutomation.Pages;
using FluentAssertions.Execution;
using FluentAssertions;

namespace PhoneAppAutomation.TestsforPhone
{
    public class PhoneBaseTests : BaseTests
    {
        [Test]
        public void DialAPhone()
        {
            PhoneAppPage phoneAppPage = new PhoneAppPage(appiumDriver);
            PhoneCallPage phoneCallPage = new PhoneCallPage(appiumDriver ); 

            phoneAppPage.ClickNumberEight();
            phoneAppPage.ClickNumberFour();
            phoneAppPage.ClickNumberFive();
            phoneAppPage.ClickNumberSix();
            phoneAppPage.ClickNumberSeven();
            phoneAppPage.ClickNumberNine();
            phoneAppPage.ClickNumberFive();
            phoneAppPage.ClickOnDial();
           
            using(new AssertionScope())
            {
                phoneCallPage.EndCallButton.Displayed.Should().Be(true);
            }
           
        }
    }
}
