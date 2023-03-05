using Swashbuckle.AspNetCore.Filters;

namespace CarSeller.Examples;

public class ProblemDetail422Example : IExamplesProvider<ProblemDetails>
{
    public ProblemDetails GetExamples()
    {
        return new ProblemDetails()
        {
            Detail = "Vozidlo nelze prodat, protoze to neni spravne",
            Instance = "/api/example/path",
            Status = 422,
            Title = "Neočekávaná chyba",
            Type = "UnprocessableEntity"
        };
    }
}