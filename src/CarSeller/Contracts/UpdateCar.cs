using System.ComponentModel.DataAnnotations;

namespace CarSeller.Contracts;

public class UpdateCar
{
    [Required, StringLength(100)]
    public string Name { get; set; }
    [Required, StringLength(50)]
    public string Model { get; set; }
    [Required, Range(2000,2023)]
    public int Year { get; set; }
    [Required, Range(0, 10_000_000)]
    public decimal Price { get; set; }
    [StringLength(1000)]
    public string? Desc { get; set; }
}