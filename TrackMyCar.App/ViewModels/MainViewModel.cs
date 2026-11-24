using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace TrackMyCar.App.ViewModels;

public partial class MainViewModel : ObservableObject
{
    [ObservableProperty]
    private string applicationTitle = "TrackMyCar";

    [ObservableProperty]
    private ObservableObject currentViewModel;

    public DashboardViewModel DashboardViewModel { get; }

    public CarsViewModel CarsViewModel { get; }

    public FuelViewModel FuelViewModel { get; }

    public ServicesViewModel ServicesViewModel { get; }

    public StatisticsViewModel StatisticsViewModel { get; }

    public SettingsViewModel SettingsViewModel { get; }

    public MainViewModel()
    {
        DashboardViewModel = new DashboardViewModel();
        CarsViewModel = new CarsViewModel();
        FuelViewModel = new FuelViewModel();
        ServicesViewModel = new ServicesViewModel();
        StatisticsViewModel = new StatisticsViewModel();
        SettingsViewModel = new SettingsViewModel();

        currentViewModel = DashboardViewModel;
    }

    [RelayCommand]
    private void ShowDashboard()
    {
        CurrentViewModel = DashboardViewModel;
    }

    [RelayCommand]
    private void ShowCars()
    {
        CurrentViewModel = CarsViewModel;
    }

    [RelayCommand]
    private void ShowFuel()
    {
        CurrentViewModel = FuelViewModel;
    }

    [RelayCommand]
    private void ShowServices()
    {
        CurrentViewModel = ServicesViewModel;
    }

    [RelayCommand]
    private void ShowStatistics()
    {
        CurrentViewModel = StatisticsViewModel;
    }

    [RelayCommand]
    private void ShowSettings()
    {
        CurrentViewModel = SettingsViewModel;
    }
}