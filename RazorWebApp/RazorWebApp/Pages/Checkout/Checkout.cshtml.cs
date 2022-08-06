using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorWebApp.Pages.Checkout;
[BindProperties (SupportsGet = true)]
public class Checkout : PageModel
{
    public string PizzaName { get; set; }
    public float PizzaPrice { get; set; }
    public string PizzaImage { get; set; }
    public void OnGet()
    {
        if (string.IsNullOrEmpty(PizzaName)) PizzaName = "Custom";
        if (string.IsNullOrEmpty(PizzaImage)) PizzaImage = "Create";
    }
}