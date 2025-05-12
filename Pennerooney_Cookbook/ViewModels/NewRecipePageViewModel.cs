using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Pennerooney_Cookbook.Data;
using Pennerooney_Cookbook.Models;

namespace Pennerooney_Cookbook.ViewModels;

public partial class NewRecipePageViewModel : PageViewModel
{
    [ObservableProperty] private ObservableCollection<Genre> _genres;
    [ObservableProperty] private ObservableCollection<Method> _methods;
    [ObservableProperty] private ObservableCollection<Purpose> _purposes;

    public NewRecipePageViewModel() : base(PageNames.NewRecipe)
    {
        GetMethods();
        GetGenres();
        GetPurposes();
    }
    
    [RelayCommand]
    private void GetMethods()
    {
        // TODO: Send this logic to a service to pull methods from db
        Methods =
        [
            new Method(0, "InstaPot"),
            new Method(1, "Stove")
        ];
    }    
    
    [RelayCommand]
    private void GetGenres()
    {
        // TODO: Send this logic to a service to pull genres from db
        Genres =
        [
            new Genre(0, "Mexican"),
            new Genre(1, "American")
        ];
    }    
    
    [RelayCommand]
    private void GetPurposes()
    {
        // TODO: Send this logic to a service to pull purposes from db
        Purposes =
        [
            new Purpose(0, "Entree"),
            new Purpose(1, "Dessert")
        ];
    }
}