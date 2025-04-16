using CommunityToolkit.Mvvm.ComponentModel;

namespace Pennerooney_Cookbook.Models;

public partial class Unit : ObservableObject
{
    [ObservableProperty] private int _id;
    [ObservableProperty] private string _title;

    public Unit(int id, string title)
    {
        Id = id;
        Title = title;
    }
}