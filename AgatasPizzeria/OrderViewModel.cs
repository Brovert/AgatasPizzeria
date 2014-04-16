using System.Collections.Generic;
using Caliburn.Micro;

namespace AgatasPizzeria {
    public class OrderViewModel : Screen {
        public List<string> Pizzas { get; set; }
        public string Error { get; set; }

        public void PlaceOrder() {
            Error = "please add between 1 to 50 pizzas before place an order";
        }
    }
}
