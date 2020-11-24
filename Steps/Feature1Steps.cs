using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace SeleniumSpecFlowStarter.Steps
{
    [Binding]
    public class Feature1Steps
    {
        int Number1;
        int Number2;
        int AdditionResult;

        [Given(@"the first number is (.*)")]
        public void GivenTheFirstNumberIs(int Num1)
        {
            Number1 = Num1;
        }
        
        [Given(@"the second number is (.*)")]
        public void GivenTheSecondNumberIs(int Num2)
        {
            Number2 = Num2;
        }
        
        [When(@"the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            AdditionResult = Number1 + Number2;
        }
        
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int Answer)
        {
            Assert.AreEqual(AdditionResult, Answer);
        }
    }
}
