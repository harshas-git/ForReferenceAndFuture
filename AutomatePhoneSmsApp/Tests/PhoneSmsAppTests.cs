using AutomatePhoneSmsApp.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatePhoneSmsApp.Tests
{
    public class PhoneSmsAppTests : PhoneSmsBaseTests
    {
        [Test]
        public void SendAMessage()
        {
            SmsAppPage smsAppPage = new SmsAppPage(appiumDriver);
            var wait = new WebDriverWait(appiumDriver, TimeSpan.FromSeconds(10));


            smsAppPage.ClickOnContinueWithoutAccount();
            smsAppPage.ClickOnStartChat();
            smsAppPage.SearchInContactSearch("9182342265");
            smsAppPage.SelectTheContactForChat();

             wait = new WebDriverWait(appiumDriver, TimeSpan.FromSeconds(10));
            string currentActivity = appiumDriver.ExecuteScript("mobile: currentActivity").ToString();

            wait.Until(d =>
            {
                return currentActivity.Contains("");
            });



        }
    

    }
    
}
