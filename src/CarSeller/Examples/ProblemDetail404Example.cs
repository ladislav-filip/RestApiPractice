using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Filters;

namespace CarSeller.Examples;

public class ProblemDetail404Example : IExamplesProvider<ProblemDetails>
{
    public ProblemDetails GetExamples()
    {
        return new ProblemDetails()
        {
            Detail = "Tento záznam nebyl v databázi nalezen",
            Instance = "/api/example/path",
            Status = 404,
            Title = "Neexistující záznam",
            Type = "NotFound"
        };
    }
}