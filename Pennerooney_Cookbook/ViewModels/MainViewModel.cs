using CommunityToolkit.Mvvm.ComponentModel;

namespace Pennerooney_Cookbook.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    [ObservableProperty] private string _greeting = "Welcome to Avalonia!";
}