using System;
using CommunityToolkit.Mvvm.ComponentModel;
using Pennerooney_Cookbook.Data;
using Pennerooney_Cookbook.Factories;

namespace Pennerooney_Cookbook.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    private readonly PageFactory _pageFactory;
    
    
    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(HomePageIsActive))]
    [NotifyPropertyChangedFor(nameof(NewRecipePageIsActive))]
    private PageViewModel _currentPage;

    public bool HomePageIsActive => CurrentPage.PageName == PageNames.Home;
    public bool NewRecipePageIsActive => CurrentPage.PageName == PageNames.NewRecipe;

    public MainViewModel()
    {
        CurrentPage = new HomePageViewModel();
    }
    
    public MainViewModel(PageFactory pageFactory)
    {
        _pageFactory = pageFactory ?? throw new ArgumentNullException(nameof(pageFactory));
        CurrentPage = _pageFactory.GetPageViewModel<HomePageViewModel>();
    }

    public void GoToHome() => CurrentPage = _pageFactory.GetPageViewModel<HomePageViewModel>();
    
    public void GoToNewRecipe() => CurrentPage = _pageFactory.GetPageViewModel<NewRecipePageViewModel>();
}