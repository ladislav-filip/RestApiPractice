using CarSeller.Contracts;
using Swashbuckle.AspNetCore.Filters;

namespace CarSeller.Examples;

public class CreateCarExample : IExamplesProvider<CreateCar>
{
    public CreateCar GetExamples()
    {
        return new CreateCar()
        {
            Desc = "Poznamka k vozidlu a neco dalsiho",
            Model = "Reanault",
            Name = "Renaul 302 rezavy",
            Price = 250_000,
            Year = 2021
        };
    }
}