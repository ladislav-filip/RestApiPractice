using System.Net.Mime;
using CarSeller.Contracts;
using Microsoft.AspNetCore.Mvc;


[Route("api/[controller]")]
[ApiController]
[Produces(MediaTypeNames.Application.Json)]
public class CarsController : ControllerBase
{
    /// <summary>
    /// Získání seznamu dostupných vozidel
    /// </summary>
    /// <param name="year" example="2021">rok výroby vozidla</param>
    /// <param name="model" example="dacia">model vozidla</param>
    /// <returns></returns>
    [HttpGet]
    [ProducesResponseType(typeof(CarItem[]), StatusCodes.Status200OK)]
    public async Task<ActionResult> Get(int? year, string? model)
    {
        return Ok();
    }

    [HttpGet, Route("{id}")]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult> GetDetail(int id)
    {
        return Ok();
    }
    
    /// <summary>
    /// Vložení nového vozidla
    /// </summary>
    /// <returns></returns>
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult> Create([FromBody] CreateCar model)
    {
        return CreatedAtAction(nameof(GetDetail), new { id = 1 });
    }
    
    [HttpPut, Route("{id}")]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult> Update(int id)
    {
        return Ok();
    }

    [HttpPost, Route("sold")]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status422UnprocessableEntity)]
    public async Task<ActionResult> CreateSold()
    {
        return CreatedAtAction(nameof(GetDetail), new { id = 1 });
    }
}