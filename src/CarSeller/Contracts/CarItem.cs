
namespace CarSeller.Contracts;

public class CarItem
{
    public int Id { get; set; }
    /// <summary>
    /// Název prodávaného vozidla
    /// <example>Škoda Octavia</example>
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// Model vozidla
    /// <example>dacia</example>
    /// </summary>
    public string Model { get; set; }
    public int Year { get; set; }
    public decimal Price { get; set; }
    public string? Desc { get; set; }
    /// <summary>
    /// Osoba, která záznam vytvořila
    /// </summary>
    public CreatedBy CreatedBy { get; set; }
}