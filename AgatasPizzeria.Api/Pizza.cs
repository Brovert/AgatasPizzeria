using System.Collections.Generic;

namespace AgatasPizzeria.Api {
    public class Pizza {
        public Pizza() {
            Toppings = new List<string>();
        }

        public string Size { get; set; }
        public List<string> Toppings { get; set; } 
    }
}