namespace SvgNotUpdatingRepro.Models;

public record UnitOfMeasure(UnitOfMeasureCategory Category, string Name)
{
    public override string ToString() => Name;

    public static readonly UnitOfMeasure[] Values =
    [
        new UnitOfMeasure(UnitOfMeasureCategory.Weight, "Grams (g)"),
            new UnitOfMeasure(UnitOfMeasureCategory.Weight, "Kilogram (kg)"),
            new UnitOfMeasure(UnitOfMeasureCategory.Volume, "Liters (l)"),
            new UnitOfMeasure(UnitOfMeasureCategory.Volume, "Milliliters (ml)"),
            new UnitOfMeasure(UnitOfMeasureCategory.Volume, "Microliters (µl)"),
            new UnitOfMeasure(UnitOfMeasureCategory.Temperature, "Celcius (C)"),
            new UnitOfMeasure(UnitOfMeasureCategory.Temperature, "Fahrenheit (F)"),
            new UnitOfMeasure(UnitOfMeasureCategory.Temperature, "Kelvin (K)")
    ];
}
