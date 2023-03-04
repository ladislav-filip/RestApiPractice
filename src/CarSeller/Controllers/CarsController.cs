using Microsoft.AspNetCore.Mvc;


[Route("api/[controller]")]
[ApiController]
public class CarsController : ControllerBase
{
    /// <summary>
    /// Získání seznamu dostupných vozidel
    /// </summary>
    /// <param name="year">rok výroby vozidla</param>
    /// <param name="model">model vozidla: dacia, skoda,...</param>
    /// <returns></returns>
    [HttpGet]
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
    
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult> Create()
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