using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobiletesting.Tests
{
    public abstract class BaseTest
    {
        protected const string AppiumServerUrl = "http://localhost:4723/wd/hub";
        protected const string App = "https://github.com/cloudgrey-io/the-app/releases/download/v1.10.0/TheApp-v1.10.0.apk";
        protected AppiumDriver appiumDriver;

        [SetUp]
        public  void SetUp()
        {
            AppiumOptions options = new AppiumOptions()
            {
                PlatformName = "Android",
                PlatformVersion = "9",
                DeviceName = "emulator-5554",
                App = BaseTest.App,
                AutomationName = "UiAutomator2",
            };

             appiumDriver = new AndroidDriver(new Uri(AppiumServerUrl), options);
        }

        protected void Swipe(Point start = default, Point stop = default, int duration = 0)
        {
            var pointer = new OpenQA.Selenium.Interactions.PointerInputDevice(PointerKind.Touch, "DeviceName");
            var moveToStart = pointer.CreatePointerMove(CoordinateOrigin.Viewport, start.X, start.Y, TimeSpan.Zero);
            var pressDown = pointer.CreatePointerDown(MouseButton.Left);
            var moveToEnd = pointer.CreatePointerMove(CoordinateOrigin.Viewport, stop.X, stop.Y, TimeSpan.FromSeconds(2));
            var pressUp = pointer.CreatePointerUp(MouseButton.Left);

            var sequence = new ActionSequence(pointer, 0);
            sequence.AddAction(moveToStart)
                    .AddAction(pressDown)
                    .AddAction(moveToEnd)
                    .AddAction(pressUp);

            var sequences = new List<ActionSequence> { sequence };
            appiumDriver.PerformActions(sequences);

        }

        [TearDown]
        public void TearDown()
        {
            appiumDriver.Dispose();
        }
    }
}
