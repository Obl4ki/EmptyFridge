using Microsoft.AspNetCore.Mvc;

namespace EmptyFridge.Controllers;

[ApiController]
[Route("[controller]")]
public class IngredientController : ControllerBase
{
    private readonly ILogger<IngredientController> _logger;

    public IngredientController(ILogger<IngredientController> logger)
    {
        _logger = logger;
    }

    // [HttpGet(Name = "GetWeatherForecast")]
    // public IEnumerable<WeatherForecast> GetAllIngredients()
    // {

    // }
}
