using Avalonia.Controls;

namespace SvgNotUpdatingRepro;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new MainWindowViewModel();
    }
}