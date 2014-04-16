using System.Collections.Generic;

namespace AgatasPizzeria.Api {
    public interface IPizzaData {
        List<PizzaSize> GetSizes();
        List<PizzaTopping> GetToppings();
        bool PlaceOrder(List<Pizza> pizzas);
        bool ValidateCoupon(string couponCode);
    }
}