using CarSeller.Contracts;
using Swashbuckle.AspNetCore.Filters;

namespace CarSeller.Examples;

public class CarItemDetailExample : IExamplesProvider<CarItem>
{
    public CarItem GetExamples()
    {
        return new()
        {
            Id = 1, Name = "Nove auto", Model = "Dacia", Year = 2018, Price = 100_000, Desc = "Dlouhy popisek",
            CreatedBy = new CreatedBy { FullName = "Jan Novak", DaeCreated = new DateTime(2022, 10, 11) }
        };
    }
}