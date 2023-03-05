using System.Net;
using System.Net.Mime;
using CarSeller.Contracts;
using CarSeller.Examples;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Filters;

[Route("api/[controller]")]
[ApiController]
[Produces(MediaTypeNames.Application.Json)]
public class CarsController : ControllerBase
{
    /// <summary>
    /// Získání seznamu dostupných vozidel
    /// </summary>
    /// <remarks>
    /// Zde může být složtější popisek i se syntaxí **Markdown**:
    /// * není implementováno stránkování
    /// * chybí zde i možnost řazení 
    /// </remarks> 
    /// <param name="year" example="2021">rok výroby vozidla</param>
    /// <param name="model" example="dacia">model vozidla</param>
    /// <returns></returns>
    [HttpGet]
    [ProducesResponseType(typeof(CarItem[]), StatusCodes.Status200OK)]
    [SwaggerResponseExample(StatusCodes.Status200OK, typeof(CarItemExample))]
    public async Task<ActionResult> Get(int? year, string? model)
    {
        return Ok(new CarItemExample().GetExamples());
    }

    /// <summary>
    /// Detailní informace o vozidle
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [HttpGet, Route("{id}")]
    [ProducesResponseType( typeof(CarItem), StatusCodes.Status404NotFound)]
    [SwaggerResponseExample(StatusCodes.Status200OK, typeof(CarItemDetailExample))]
    [SwaggerResponseExample(StatusCodes.Status404NotFound, typeof(ProblemDetail404Example))]
    public async Task<ActionResult> GetDetail(int id)
    {
        return Ok(new CarItemDetailExample().GetExamples());
    }
    
    /// <summary>
    /// Vložení nového vozidla
    /// </summary>
    /// <returns></returns>
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [SwaggerRequestExample(typeof(CreateCar), typeof(CreateCarExample))]
    [SwaggerResponseExample(StatusCodes.Status400BadRequest, typeof(ProblemDetail400Example))]
    [SwaggerResponseExample(StatusCodes.Status201Created, typeof(CarItemDetailExample))]
    public async Task<ActionResult> Create([FromBody] CreateCar model)
    {
        return CreatedAtAction(nameof(GetDetail), new { id = 1 }, new CarItemDetailExample().GetExamples());
    }

    /// <summary>
    /// Oprava údajů o vozidle
    /// </summary>
    /// <param name="id"></param>
    /// <param name="model"></param>
    /// <returns></returns>
    [HttpPut, Route("{id}")]
    [ProducesResponseType( StatusCodes.Status400BadRequest)]
    [ProducesResponseType( typeof(ProblemDetails), StatusCodes.Status404NotFound)]
    [SwaggerRequestExample(typeof(UpdateCar), typeof(UpdateCarExample))]
    [SwaggerResponseExample(StatusCodes.Status201Created, typeof(CarItemDetailExample))]
    [SwaggerResponseExample(StatusCodes.Status400BadRequest, typeof(ProblemDetail400Example))]
    [SwaggerResponseExample(StatusCodes.Status404NotFound, typeof(ProblemDetail404Example))]
    public async Task<ActionResult> Update(int id, [FromBody] UpdateCar model)
    {
        return Ok(new CarItemDetailExample().GetExamples());
    }

    /// <summary>
    /// Vloží vozidlo do prodaných vozů
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    [HttpPost, Route("sold")]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status422UnprocessableEntity)]
    [SwaggerRequestExample(typeof(CreateSoldCar), typeof(CreateSoldCarExample))]
    [SwaggerResponseExample(StatusCodes.Status201Created, typeof(CarItemDetailExample))]
    [SwaggerResponseExample(StatusCodes.Status400BadRequest, typeof(ProblemDetail400Example))]
    [SwaggerResponseExample(StatusCodes.Status404NotFound, typeof(ProblemDetail404Example))]
    [SwaggerResponseExample(StatusCodes.Status422UnprocessableEntity, typeof(ProblemDetail422Example))]
    public async Task<ActionResult> CreateSold([FromBody] CreateSoldCar model)
    {
        return CreatedAtAction(nameof(GetDetail), new { id = 1 }, new CarItemDetailExample().GetExamples());
    }
}