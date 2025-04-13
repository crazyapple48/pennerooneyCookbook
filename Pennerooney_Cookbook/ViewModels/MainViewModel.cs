using CommunityToolkit.Mvvm.ComponentModel;
using Pennerooney_Cookbook.Data;
using Pennerooney_Cookbook.Factories;

namespace Pennerooney_Cookbook.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    private readonly PageFactory _pageFactory;
    
    
    [ObservableProperty] private PageViewModel? _currentPage;

    public MainViewModel(PageFactory pageFactory)
    {
        _pageFactory = pageFactory;
        GoToHome();
    }

    public void GoToHome() => CurrentPage = _pageFactory.GetPageViewModel<HomePageViewModel>();
    
    public void GoToNewRecipe() => CurrentPage = _pageFactory.GetPageViewModel<NewRecipePageViewModel>();
}