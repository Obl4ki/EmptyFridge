using EmptyFridge.Models;
namespace EmptyFridge.Data;

public static class DbInitializer
{
    public static void Initialize(FoodContext context)
    {
        if (context.Ingredients.Any())
        {
            return;
        }

        FoodGroup zboza = new() { Name = "Zboża" };
        FoodGroup owoce = new() { Name = "Owoce" };

        MeasureUnit ile = new() { Unit = "Ilość" };
        MeasureUnit gramy = new() { Unit = "Gram" };


        var ingredients = new Ingredient[] {
            new Ingredient {
                Name = "",
                FoodGroup = zboza,
                AmountMeasure = new() {
                    Amount = 10,
                    MeasureUnit = ile,
                }
            },
            new Ingredient {
                Name = "Banany",
                FoodGroup = owoce,
                AmountMeasure = new() {
                    Amount = 1000,
                    MeasureUnit = gramy,
                }
            },
            new Ingredient {
                Name = "Czereśnie",
                FoodGroup = owoce,
                AmountMeasure = new() {
                    Amount = 250,
                    MeasureUnit = gramy,
                }
            },

        };

        context.Ingredients.AddRange(ingredients);
        context.SaveChanges();
    }
}