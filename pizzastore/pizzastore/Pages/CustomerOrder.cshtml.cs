using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using pizzastore.model;

namespace pizzastore.Pages
{
    public class CustomerOrderModel : PageModel
    {
        [BindProperty]
        public PizzaModel pizas { get; set; }

        
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {

            return RedirectToPage("./Thankyou", new{ pizas.Pizzaname, pizas.Pizzaprice, });
        }
    }
}
