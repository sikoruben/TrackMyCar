using System.Windows;
using TrackMyCar.App.ViewModels;

namespace TrackMyCar.App;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new MainViewModel();
    }
}