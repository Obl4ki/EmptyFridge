using Microsoft.EntityFrameworkCore;
using EmptyFridge.Models;

namespace EmptyFridge.Data;

public class FoodContext : DbContext
{
    public FoodContext(DbContextOptions<FoodContext> options)
        : base(options)
    {
    }

    public DbSet<Ingredient> Ingredients => Set<Ingredient>();
}