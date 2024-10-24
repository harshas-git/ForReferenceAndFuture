using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobiletesting.Pages
{
    public class AppLandingPage 
    {
        private readonly AppiumDriver _androidDriver;

        public AppLandingPage(AppiumDriver driver)
        {
            _androidDriver = driver;
        }

        private By WebViewDemo => By.XPath("//android.widget.TextView[@text=\"Webview Demo\"]");


        private AppiumElement ClickOnWebView => _androidDriver.FindElement(WebViewDemo);

        public  string ClickOnWebViewDemo()
        {
            ClickOnWebView.Click();
            var contexts = _androidDriver.Contexts;
            _androidDriver.Context = contexts.First(context => context.StartsWith("web", StringComparison.OrdinalIgnoreCase));
            var webViewElement = _androidDriver.FindElement(By.XPath("//h1"));
            var textInWebView= webViewElement.Text;
             return textInWebView;
        }
    }
}
