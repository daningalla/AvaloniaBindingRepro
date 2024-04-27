using CommunityToolkit.Mvvm.ComponentModel;
using SvgNotUpdatingRepro.Models;
using System.Collections.Generic;

namespace SvgNotUpdatingRepro;

public partial class MainWindowViewModel : ObservableObject
{
    [ObservableProperty, NotifyPropertyChangedFor(nameof(SelectedUnitOfMeasureCategory))]
    private UnitOfMeasure? _selectedUnitOfMeasure = UnitOfMeasure.Values[0];

    public UnitOfMeasureCategory? SelectedUnitOfMeasureCategory => SelectedUnitOfMeasure?.Category;    

    public IEnumerable<UnitOfMeasure> UnitsOfMeasure => UnitOfMeasure.Values;
}
