using Swashbuckle.AspNetCore.Filters;

namespace CarSeller.Examples;

public class CreateSoldCarExample : IExamplesProvider<CreateSoldCar>
{
    public CreateSoldCar GetExamples()
    {
        return new CreateSoldCar()
        {
            Desc = "Auto prodano v popode",
            Price = 225_000,
            Id = 2
        };
    }
}