using Avalonia;
using Avalonia.Data.Converters;
using Avalonia.Svg.Skia;
using SvgNotUpdatingRepro.Models;
using System;

namespace SvgNotUpdatingRepro.Converters;

public static class SvgResourceConverter
{
    public static FuncValueConverter<UnitOfMeasureCategory, SvgSource?> SvgCategoryConverter { get; } =
        new(key => ResolveSvg(key));

    public static FuncValueConverter<object?, SvgSource?> SvgObjectConverter { get; } =
        new(obj => ResolveSvg((obj as UnitOfMeasure)?.Category));

    private static SvgSource? ResolveSvg(UnitOfMeasureCategory? category)
    {
        var app = Application.Current ?? throw new InvalidOperationException();
        var resourceKey = category switch
        {
            UnitOfMeasureCategory.Weight => "UomMass",
            UnitOfMeasureCategory.Temperature => "UomTemp",
            _ => "UomLiquid"
        };

        return app.Resources.TryGetResource(resourceKey, app.ActualThemeVariant, out var obj)
            ? (SvgSource)obj!
            : null;
    }
}
