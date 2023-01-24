using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using pizzastore.model;

namespace pizzastore.Pages
{
    public class pizzasModel : PageModel
    {
        public List<PizzaModel> pizzamodel = new List<PizzaModel>()
        {
            new PizzaModel(){Imagename="Beef",Pizzaname="Beef",Pizzaprice=10,Pizzasize="large"},
            new PizzaModel(){Imagename="Cheese ",Pizzaname="Cheese",Pizzaprice=10,Pizzasize="large"},
            new PizzaModel(){Imagename="Deluxe Dr.Pizza",Pizzaname="Deluxe",Pizzaprice=10,Pizzasize="large"},
            new PizzaModel(){Imagename="Ham",Pizzaname="Ham",Pizzaprice=10,Pizzasize="large"},
            new PizzaModel(){Imagename="mushroom",Pizzaname="mushroom",Pizzaprice=10,Pizzasize="large"},
            new PizzaModel(){Imagename="pepperoni ",Pizzaname="pepperani",Pizzaprice=10,Pizzasize="large"},
            new PizzaModel(){Imagename="Tomato sauce ",Pizzaname="Tomatosauce",Pizzaprice=10,Pizzasize="large"},
            new PizzaModel(){Imagename="Tuna",Pizzaname="tuna",Pizzaprice=10,Pizzasize="large"},
            
        };

        public void OnGet()
        {
        }
    }
}
