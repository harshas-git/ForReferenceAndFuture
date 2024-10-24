using CalculatorApp.Pages;
using FluentAssertions;
using FluentAssertions.Execution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp.Tests
{
    [TestFixture]
    public class CalculatorTests : BaseTest
    {
        [Test]
        public void AdditionTest()
        {
            CalculatorPage calculator = new CalculatorPage(appiumDriver);
            calculator.ClickNumberOne();
            calculator.PerformAddition();
            calculator.ClickNumberTwo();
            calculator.ClickOnEqualTo();

            using(new AssertionScope())
            {
                calculator.ReadCalculatorResult().Should().Be("3");
            }
        }

        [Test]
        public void SubtractionTest()
        {
            CalculatorPage calculator = new CalculatorPage(appiumDriver);
            calculator.ClickNumberOne();
            calculator.PerformSubtraction();
            calculator.ClickNumberTwo();
            calculator.ClickOnEqualTo();

            using (new AssertionScope())
            {
                calculator.ReadCalculatorResult().Should().Be("-1");
            }

        }


        [Test]
        public void MultiplicationTest()
        {
            CalculatorPage calculator = new CalculatorPage(appiumDriver);
            calculator.ClickNumberOne();
            calculator.PerformMultiplication();
            calculator.ClickNumberTwo();
            calculator.ClickOnEqualTo();
            using (new AssertionScope())
            {
                calculator.ReadCalculatorResult().Should().Be("2");
            }
        }

        [Test]
        public void DivisonTest()
        {
            CalculatorPage calculator = new CalculatorPage(appiumDriver);
            calculator.ClickNumberOne();
            calculator.PerformDivision();
            calculator.ClickNumberTwo();
            calculator.ClickOnEqualTo();

            using (new AssertionScope())
            {
                calculator.ReadCalculatorResult().Should().Be("0.5");
            }
        }
             
    }
}
