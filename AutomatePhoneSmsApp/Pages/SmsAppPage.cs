using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatePhoneSmsApp.Pages
{
    public class SmsAppPage
    {
        private readonly AppiumDriver _androidDriver;

        public SmsAppPage(AppiumDriver androidDriver)
        {
            _androidDriver=androidDriver;
        }

        private By StartChatLocator => MobileBy.AccessibilityId("Start chat");

        private By ContinueWithOutAccountLocator => By.Id("com.google.android.apps.messaging:id/continue_as_button");

        private By ContactSearchFieldLocator => By.LinkText("Type names, phone numbers, or emails");

        private By SelectTheContactLocator => By.XPath("//android.view.View[@resource-id=\"ContactSuggestionList\"]/android.view.View");

        private AppiumElement ContinueWithOutAccount => _androidDriver.FindElement(ContinueWithOutAccountLocator);
        private AppiumElement StartChatButton => _androidDriver.FindElement(StartChatLocator);
        private AppiumElement SelectContact => _androidDriver.FindElement(SelectTheContactLocator);
        private AppiumElement ContactSearchField => _androidDriver.FindElement(ContactSearchFieldLocator);


        public void ClickOnContinueWithoutAccount()
        {
           ContinueWithOutAccount.Click();
        }

        public void ClickOnStartChat()
        {
            var contexts=_androidDriver.Contexts;
            StartChatButton.Click();
        }

        public void SearchInContactSearch(string PhoneNumber)
        {
            ContactSearchField.SendKeys(PhoneNumber);
        }

        public void SelectTheContactForChat()
        {
            SelectContact.Click();
        }
    }
}
