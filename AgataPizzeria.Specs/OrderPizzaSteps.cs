using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using AgatasPizzeria;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace AgataPizzeria.Specs {
    [Binding]
    public class OrderPizzaSteps {

        private OrderViewModel _viewModel;

        [Given(@"I have not added any pizzas to my order")]
        public void GivenIHaveNotAddedAnyPizzasToMyOrder() {
            _viewModel = new OrderViewModel();
        }

        [When(@"I click to place the order")]
        public void WhenIClickToPlaceTheOrder() {
            _viewModel.PlaceOrder();
        }

        [Then(@"an error should tell me ""(.*)""")]
        public void ThenAnErrorShouldTellMe(string error) {
            Assert.AreEqual(error, _viewModel.Error);
        }

    }
}
