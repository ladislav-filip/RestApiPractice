using CarSeller.Contracts;
using Swashbuckle.AspNetCore.Filters;

namespace CarSeller.Examples;

public class UpdateCarExample : IExamplesProvider<UpdateCar>
{
    public UpdateCar GetExamples()
    {
        return new UpdateCar
        {
            Desc = "Poznamka ke změně",
            Model = "Ford",
            Name = "Ford escort jako novy",
            Price = 250_000,
            Year = 2021
        };
    }
}