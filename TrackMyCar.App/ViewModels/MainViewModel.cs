using CommunityToolkit.Mvvm.ComponentModel;

namespace TrackMyCar.App.ViewModels;

public partial class MainViewModel : ObservableObject
{
    [ObservableProperty]
    private string applicationTitle = "TrackMyCar";

    [ObservableProperty]
    private string welcomeMessage =
        "Welcome to TrackMyCar!";
}