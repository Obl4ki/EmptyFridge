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
    public DbSet<FoodGroup> FoodGroups => Set<FoodGroup>();
    public DbSet<MeasureUnit> MeasureUnits => Set<MeasureUnit>();

}