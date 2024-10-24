using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp.Pages
{
    internal class CalculatorPage
    {
        private readonly AppiumDriver _androidDriver;

        public CalculatorPage(AppiumDriver androidDriver)
        {
            _androidDriver=androidDriver;
        }

        private By OneNumberLocator => By.Id("com.android.calculator2:id/digit_1");

        private By TwoNumberLocator => By.Id("com.android.calculator2:id/digit_2");

        private By ThreeNumberLocator => By.Id("com.android.calculator2:id/digit_3");

        private By FourNumberLocator => By.Id("com.android.calculator2:id/digit_4");

        private By FiveNumberLocator => By.Id("com.android.calculator2:id/digit_5");

        private By SixNumberLocator => By.Id("com.android.calculator2:id/digit_6");

        private By SevenNumberLocator => By.Id("com.android.calculator2:id/digit_7");

        private By EightNumberLocator => By.Id("com.android.calculator2:id/digit_8\r\n");

        private By AdditionLocator => MobileBy.AccessibilityId("plus");

        private By SubtractionLocator => MobileBy.AccessibilityId("minus");

        private By MultiplicationLocator => MobileBy.AccessibilityId("multiply");

        private By DivisionLocator => MobileBy.AccessibilityId("divide");

        private By EqualLocator => MobileBy.AccessibilityId("equals");

        private By DeleteLocator => MobileBy.AccessibilityId("delete");

        private By ResultLocator => By.Id("com.android.calculator2:id/result\r\n");


        private AppiumElement CalculatorResult => _androidDriver.FindElement(ResultLocator);
        private AppiumElement DeleteElement => _androidDriver.FindElement(DeleteLocator);

        private AppiumElement EqualsElement=> _androidDriver.FindElement(EqualLocator);
        private AppiumElement OneNumber => _androidDriver.FindElement(OneNumberLocator);

        private AppiumElement Two => _androidDriver.FindElement(TwoNumberLocator);

        private AppiumElement Three => _androidDriver.FindElement(ThreeNumberLocator);

        private AppiumElement Four => _androidDriver.FindElement(FourNumberLocator);

        private AppiumElement Five => _androidDriver.FindElement(FiveNumberLocator);

        private AppiumElement Six => _androidDriver.FindElement(SixNumberLocator);

        private AppiumElement Seven => _androidDriver.FindElement(SevenNumberLocator);

        private AppiumElement Eight => _androidDriver.FindElement(EightNumberLocator);

        private AppiumElement Addition => _androidDriver.FindElement(AdditionLocator);
        private AppiumElement Subtraction => _androidDriver.FindElement(SubtractionLocator);
        private AppiumElement Division => _androidDriver.FindElement(DivisionLocator);
        private AppiumElement Multiplication => _androidDriver.FindElement(MultiplicationLocator);


        public string ReadCalculatorResult()
        {
           return CalculatorResult.Text;
        }


        public void ClickOnEqualTo()
        {
            EqualsElement.Click();
        }

        public void ClickOnDelete()
        {
            DeleteElement.Click();
        }

        public void PerformAddition()
        {
            Addition.Click();
        }

        public void PerformSubtraction()
        {
            Subtraction.Click();
        }

        public void PerformDivision()
        {
           Division.Click();
        }

        public void PerformMultiplication()
        {
            Multiplication.Click();
        }

        public void ClickNumberOne()
        {
            OneNumber.Click();
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


    }
}
