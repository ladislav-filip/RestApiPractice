using CarSeller.Contracts;
using Swashbuckle.AspNetCore.Filters;

namespace CarSeller.Examples;

public class CarItemExample : IExamplesProvider<CarItem[]>
{
    public CarItem[] GetExamples()
    {
        return new CarItem[]
        {
            new()
            {
                Id = 1, Name = "Nove auto", Model = "Dacia", Year = 2018, Price = 100_000, Desc = "Dlouhy popisek",
                CreatedBy = new CreatedBy { FullName = "Jan Novak", DaeCreated = new DateTime(2022, 10, 11) }
            },
            new()
            {
                Id = 2, Name = "Nakladni auto", Model = "Tatra", Year = 2018, Price = 200_000, Desc = "Lorem ipsum",
                CreatedBy = new CreatedBy { FullName = "Jan Novak", DaeCreated = new DateTime(2022, 10, 11) }
            },
            new()
            {
                Id = 3, Name = "Motorka", Model = "Jawa", Year = 2018, Price = 100_000, Desc = "Kratky popisek",
                CreatedBy = new CreatedBy { FullName = "Jan Novak", DaeCreated = new DateTime(2022, 10, 11) }
            },
        };
    }
}