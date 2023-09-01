using System.ComponentModel.DataAnnotations;

namespace EmptyFridge.Models;


public class Ingredient
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public FoodGroup? FoodGroup { get; set; }
    public AmountMeasure? AmountMeasure { get; set; }
}

public class AmountMeasure
{
    public int Id { get; set; }

    public decimal Amount { get; set; }
    public MeasureUnit? MeasureUnit { get; set; }
}

public class MeasureUnit
{
    public int Id { get; set; }
    public string? Unit { get; set; }
}

public class FoodGroup
{
    public int Id { get; set; }
    public string? Name { get; set; }
}