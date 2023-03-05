using System.ComponentModel.DataAnnotations;

namespace CarSeller.Contracts;

public class CreateSoldCar
{
    [Required]
    public int Id { get; set; }
    [Required, Range(0, 10_000_000)]
    public decimal Price { get; set; }
    [StringLength(1000)]
    public string? Desc { get; set; }
}