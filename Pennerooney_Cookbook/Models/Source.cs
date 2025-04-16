using CommunityToolkit.Mvvm.ComponentModel;

namespace Pennerooney_Cookbook.Models;

public partial class Source : ObservableObject
{
    [ObservableProperty]
    private int _id;
    
    [ObservableProperty]
    private string _title;
    
    [ObservableProperty]
    private bool _isWebsite;
    
    [ObservableProperty]
    private bool _containsMultipleRecipes;

    public Source(int id, string title, bool containsMultipleRecipes, bool isWebsite)
    {
        Id = id;
        Title = title;
        IsWebsite = isWebsite;
        ContainsMultipleRecipes = containsMultipleRecipes;
    }
}