namespace RazorWebApp.Models;

public class PizzaModel
{
    public string PizzaName { get; set; }
    public string ImageTitle { get; set; }
    public float BasePrice { get; set; } = 2;
    public bool Cheese { get; set; }
    public bool Tomato { get; set; }
    public bool Meat { get; set; }
    public bool Mushrooms { get; set; }
}