using System;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Pennerooney_Cookbook.Data;
using Pennerooney_Cookbook.Models;

namespace Pennerooney_Cookbook.ViewModels;

public partial class HomePageViewModel : PageViewModel
{
    [ObservableProperty] 
    private ObservableCollection<Recipe> _recipes;


    public HomePageViewModel() : base(PageNames.Home)
    {
        GetRecipes();
    }
    
    [RelayCommand]
    private void GetRecipes()
    {
        Recipes =
        [
            new Recipe(1, "Recipe1", 
                new Method(1, "InstaPot"), 
                new Genre(1, "Mexican"), 
                new Purpose(1, "Entree"), 
                5, 
                1, 
                "2025, 4, 15", 
                false, new Source(1, "Some Book", 
                    true, 
                    false),
                [new Ingredient(1, new IngredientName(1, "Lettuce"), new CutType(1, "Chopped"), new Unit(1, "Cup"), 2)],
                [new Instruction(1, "Step 1"), new Instruction(2, "Step 2")]),
            
            
            new Recipe(2, "Recipe2", 
                new Method(1, "InstaPot"), 
                new Genre(1, "Korean"), 
                new Purpose(1, "Dessert"), 
                5, 
                1, 
                 "2025, 4, 15", 
                true, new Source(1, "Some Book 2", 
                    true, 
                    false),
                [
                    new Ingredient(1, 
                        new IngredientName(1, "Lettuce"), 
                        new CutType(1, "Chopped"), 
                        new Unit(1, "Cup"), 
                        2)
                ],
                [new Instruction(1, "Step 1"), new Instruction(2, "Step 2")])
        ];
    }
}