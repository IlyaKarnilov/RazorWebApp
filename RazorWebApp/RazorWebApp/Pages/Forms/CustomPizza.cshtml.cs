using System.ComponentModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorWebApp.Models;

namespace RazorWebApp.Pages.Forms;

public class CustomPizza : PageModel
{
    [BindProperty] public PizzaModel? Pizza { get; set; }
    public float PizzaPrice { get; set; }
    public void OnGet()
    {
    }

    public IActionResult OnPost()
    {
        if (Pizza != null) {
            PizzaPrice = Pizza.BasePrice;
                 if (Pizza.Cheese) PizzaPrice += 1;
                 if (Pizza.Meat) PizzaPrice += 1;
                 if (Pizza.Mushrooms) PizzaPrice += 3;
                 if (Pizza.Tomato) PizzaPrice += 1;
                 return RedirectToPage("/Checkout/Checkout", new {PizzaPrice, Pizza.PizzaName});
        }
        return RedirectToPage("/Forms/CustomPizza");
    }
}