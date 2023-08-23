using FruitService.DataBase;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Routing.Template;

namespace FruitService.Controllers;

[ApiController]
[Route("[controller]")]
public class FruitController: ControllerBase
{
    private readonly ILogger<FruitController> _logger;
    private readonly IFruitData _fruitData;

    public FruitController(ILogger<FruitController> logger, IFruitData fruitData)
    {
        _logger = logger;
        _fruitData = fruitData;
    }

    [HttpGet("{id:int}")]
    public IActionResult  Get(int id)
    {
        var fruit = _fruitData.GetById(id);
        if (fruit is null) return NotFound();
        
        return Ok(_fruitData.GetById(id));
    }
    
    [HttpGet()]
    public IActionResult  Get()
    {
        var fvm = new FruitViewModel();
        fvm.Fruits = _fruitData.GetAll().ToArray();
        return Ok(fvm);
    }

}