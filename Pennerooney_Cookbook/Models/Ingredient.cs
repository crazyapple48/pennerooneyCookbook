using CommunityToolkit.Mvvm.ComponentModel;

namespace Pennerooney_Cookbook.Models;

public partial class Ingredient : ObservableObject
{
    [ObservableProperty] private int _id;
    [ObservableProperty] private IngredientName _title;
    [ObservableProperty] private CutType _cutType;
    [ObservableProperty] private Unit _unit;
    [ObservableProperty] private double _amount;


    public Ingredient(int id,
        IngredientName title,
        CutType cutType,
        Unit unit,
        double amount)
    {
        Id = id;
        Title = title;
        CutType = cutType;
        Unit = unit;
        Amount = amount;
    }
}