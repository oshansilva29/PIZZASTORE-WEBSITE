using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pizzastore.model
{
   

    public class PizzaModel
    {
        public string Imagename { get; set; }

        public string Pizzaname { get; set; }

        public string Pizzasize { get; set; }

        public float Pizzaprice { get; set; }
        public bool Beef { get; set; }
        public bool  Cheese { get; set; }
        public bool Deluxe { get; set; }
        public bool ham { get; set; }
        public bool mushroom { get; set; }
        public bool pepperoni { get; set; }
        public bool pineapple { get; set; }
        public bool tomatosouce { get; set; }
        public bool tuna { get; set; }

       
    }
}
