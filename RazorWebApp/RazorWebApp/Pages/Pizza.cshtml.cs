using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorWebApp.Models;

namespace RazorWebApp.Pages;

public class Pizza : PageModel
{
    public List<PizzaModel> PizzaDB = new List<PizzaModel>()
    {
        new PizzaModel(){PizzaName = "Bolognese", ImageTitle = "Bolognese", Cheese = true, Meat = true, Mushrooms = false, Tomato = true, BasePrice = 12 },
        new PizzaModel(){PizzaName = "Carbonara", ImageTitle = "Carbonara", Cheese = true, Meat = false, Mushrooms = false, Tomato = true, BasePrice = 9 },
        new PizzaModel(){PizzaName = "Hawaiian", ImageTitle = "Hawaiian", Cheese = false, Meat = true, Mushrooms = true, Tomato = true, BasePrice = 11},
        new PizzaModel(){PizzaName = "Margerita", ImageTitle = "Margerita", Cheese = true, Meat = true, Mushrooms = false, Tomato = true, BasePrice = 12},
        new PizzaModel(){PizzaName = "MeatFeast", ImageTitle = "MeatFeast", Cheese = true, Meat = true, Mushrooms = false, Tomato = false, BasePrice = 10},
        new PizzaModel(){PizzaName = "Vegetarian", ImageTitle = "Vegetarian", Cheese = false, Meat = false, Mushrooms = true, Tomato = true, BasePrice = 8}
    };
    public void OnGet()
    {
        
    }
}