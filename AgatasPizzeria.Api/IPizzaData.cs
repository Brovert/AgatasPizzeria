using System.Collections.Generic;

namespace AgatasPizzeria.Api {
    public interface IPizzaData {
        List<PizzaSize> GetSizes();
        List<PizzaTopping> GetToppings();
        bool PlaceOrder();
        bool ValidateCoupon();
    }
}