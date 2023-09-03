namespace EmptyFridge.Services;

using EmptyFridge.Data;
using EmptyFridge.Models;

using Microsoft.EntityFrameworkCore;

public interface IIngredientService
{
    public IEnumerable<Ingredient> GetAll();
    public Ingredient? GetById(int id);
    public Ingredient Create(Ingredient newIngredient);

}

public class IngredientService : IIngredientService
{
    private readonly FoodContext _ctx;

    public IngredientService(FoodContext context)
    {
        _ctx = context;
    }

    public IEnumerable<Ingredient> GetAll()
    {
        return _ctx.Ingredients
            .AsNoTracking()
            .Include(i => i.FoodGroup)
            .Include(i => i.AmountMeasure)
            .ThenInclude(amountMeasure => amountMeasure.MeasureUnit)
            .ToList();
    }

    public Ingredient? GetById(int id)
    {
        return _ctx.Ingredients
            .Include(p => p.FoodGroup)
            .Include(p => p.AmountMeasure)
            .ThenInclude(amountMeasure => amountMeasure.MeasureUnit)
            .AsNoTracking()
            .SingleOrDefault(p => p.Id == id);
    }

    public Ingredient Create(Ingredient newIngredient)
    {
        _ctx.Ingredients.Add(newIngredient);
        _ctx.SaveChanges();

        return newIngredient;
    }
}
