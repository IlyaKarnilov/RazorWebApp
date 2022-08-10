using Microsoft.EntityFrameworkCore;
using RazorWebApp.Models;

namespace RazorWebApp.DB;


public class ApplicationContext: DbContext
{
    public DbSet<PizzaOrder> PizzaOrders { get; set; }

    public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
    {
        
    }
}