using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace pizzastore.Pages
{
    [BindProperties(SupportsGet =true)]
    public class ThankyouModel : PageModel
    {
        public string pizzaname { get; set; }
        public string pizzasize { get; set; }
        public string Imagename { get; set; }
        public void OnGet()
        {
    }
    }
}
