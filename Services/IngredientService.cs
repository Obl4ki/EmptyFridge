namespace EmptyFridge.Services;

using EmptyFridge.Data;
using EmptyFridge.Models;

using Microsoft.EntityFrameworkCore;


public class IngredientService
{
    private readonly FoodContext _context;

    public IngredientService(FoodContext context)
    {
        _context = context;
    }

    public IEnumerable<Ingredient> GetAll()
    {
        return _context.Ingredients
            .AsNoTracking()
            .ToList();
    }

    public Ingredient? GetById(int id)
    {
        return _context.Ingredients
            .Include(p => p.Name)
            .Include(p => p.FoodGroup)
            .Include(p => p.AmountMeasure)
            .AsNoTracking()
            .SingleOrDefault(p => p.Id == id);
    }

    public Ingredient Create(Ingredient newIngredient)
    {
        _context.Ingredients.Add(newIngredient);
        _context.SaveChanges();

        return newIngredient;
    }
}