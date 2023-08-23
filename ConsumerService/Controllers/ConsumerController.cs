using ConsumerService.Services;
using Microsoft.AspNetCore.Mvc;

namespace ConsumerService.Controllers;
[ApiController]
[Route("[controller]")]
public class ConsumerController : ControllerBase
{
    private readonly ILogger<ConsumerController> _logger;
    private readonly FruitService _fruitService;

    public ConsumerController(ILogger<ConsumerController> logger,FruitService fruitService)
    {
        _logger = logger;
        _fruitService = fruitService;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var fruits = await _fruitService.GetFruits();
        
        
        _logger.LogInformation("Logging fruits {0}",string.Join(",", fruits));
        return Ok(fruits);
    }
    
    [HttpGet("{id:int}")]
    public async Task<IActionResult> Get(int id)
    {
        var fruit = await _fruitService.GetFruit(id);
        
        _logger.LogInformation("Logging fruit {0}",fruit);
        
        return Ok(fruit);
    }
}