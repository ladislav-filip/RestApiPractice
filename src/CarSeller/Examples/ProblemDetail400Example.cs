using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Filters;

namespace CarSeller.Examples;

public class ProblemDetail400Example : IExamplesProvider<ProblemDetails>
{
    public ProblemDetails GetExamples()
    {
        return new ProblemDetails()
        {
            Detail = "Chyba při validaci",
            Instance = "/api/example/path",
            Status = 400,
            Title = "Validační chyba",
            Type = "Bad Request",
            Extensions =
            {
                { "errors", new Dictionary<string, string>()
                    {
                        { "name", "Pole je povinné" }, 
                        { "year", "Rok musí být v rozmezí 2000 až 2023" }
                    } 
                }
            }
        };
    }
}