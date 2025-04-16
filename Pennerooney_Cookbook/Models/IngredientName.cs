using CommunityToolkit.Mvvm.ComponentModel;

namespace Pennerooney_Cookbook.Models;

public partial class IngredientName : ObservableObject
{
    [ObservableProperty]
    private int _id;
    
    [ObservableProperty]
    private string _title;

    public IngredientName(int id, string title)
    {
        Id = id;
        Title = title;
    }
}