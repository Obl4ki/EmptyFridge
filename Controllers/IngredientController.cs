using EmptyFridge.Models;
using EmptyFridge.Services;
using Microsoft.AspNetCore.Mvc;

namespace EmptyFridge.Controllers;

[ApiController]
[Route("[controller]")]
public class IngredientController : ControllerBase
{
    private readonly IIngredientService _service;

    public IngredientController(IIngredientService service)
    {
        _service = service;
    }

    [HttpGet]
    public IEnumerable<Ingredient> GetAll()
    {
        return _service.GetAll();

    }

    [HttpGet("{id}")]
    public ActionResult<Ingredient> GetById(int id)
    {
        var res = _service.GetById(id);
        if (res == null)
        {
            return NotFound();
        }

        return Ok(res);
    }

    [HttpPut("{id}")]
    public IActionResult Put(int id, Ingredient? item)
    {
        if (item is null || id != item.Id)
        {
            return BadRequest("There is a difference between item.id and query id.");
        }

        _service.Create(item);
        return NoContent();
    }
}
