using Xunit;
using TechTalk.SpecFlow;

namespace TestAddition.Steps
{
    [Binding]
    public sealed class StepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;
        private int num1 {get; set;}
        private int num2 {get; set;}

        public StepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }           

        [When("i add (.*) and (.*)")]
        public void WhenAddingNumbers(int num1, int num2)
        {
            num1 = 1;
            num2 = 2;
        }     

        [Then("result will be (.*)")]
        public void ThenResultIs(int result)
        {
            Assert.Equal((num1 + num2), result);
        }

    }
}