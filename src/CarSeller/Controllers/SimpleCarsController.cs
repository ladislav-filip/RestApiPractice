[Route("api/v2/cars"), ApiController, Produces(MediaTypeNames.Application.Json)]
public class SimpleCarsController : ControllerBase
{
    [HttpGet] public async Task<ActionResult> Get(int? year, string? model) => Ok(new CarItemExample().GetExamples());
    
    [HttpGet, Route("{id}")] public async Task<ActionResult> GetDetail(int id) => Ok(new CarItemDetailExample().GetExamples());
    
    [HttpPost] public async Task<ActionResult> Create([FromBody] CreateCar model) => CreatedAtAction(nameof(GetDetail), new { id = 1 }, new CarItemDetailExample().GetExamples());
    
    [HttpPut, Route("{id}")] public async Task<ActionResult> Update(int id, [FromBody] UpdateCar model) => Ok(new CarItemDetailExample().GetExamples());
    
    [HttpPost, Route("sold")] public async Task<ActionResult> CreateSold([FromBody] CreateSoldCar model) => CreatedAtAction(nameof(GetDetail), new { id = 1 }, new CarItemDetailExample().GetExamples());
}