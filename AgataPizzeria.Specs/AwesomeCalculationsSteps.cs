using AgatasPizzeria;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace AgataPizzeria.Specs {
    [Binding]
    public class AwesomeCalculationsSteps {

        private CalculatorViewModel _viewModel;

        public AwesomeCalculationsSteps() {
            
        }

        private void SetupViewModel() {
            _viewModel = new CalculatorViewModel();
        }
        
        [Given(@"I have entered a number greater than 100")]
        public void GivenIHaveEnteredANumberGreaterThan() {
            SetupViewModel();
            _viewModel.SomeNumber = 101;
        }

        [Given(@"I have entered a number not found")]
        public void GivenIHaveEnteredANumberNotFound() {
            SetupViewModel();
            _viewModel.SomeNumber = -20;
        }


        [When(@"I click the button to run the calculation")]
        public void WhenIClickTheButtonToRunTheCalculation() {
            _viewModel.RunCalculation();
        }

        [Then(@"the result will be (.*)")]
        public void ThenTheResultWillBe(int p0) {
            Assert.AreEqual(p0, _viewModel.Result);
        }

    }
}
