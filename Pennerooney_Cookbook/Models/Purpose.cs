using CommunityToolkit.Mvvm.ComponentModel;

namespace Pennerooney_Cookbook.Models;

public partial class Purpose : ObservableObject
{
    [ObservableProperty] private int _id;
    [ObservableProperty] private string _title;

    public Purpose(int id, string title)
    {
        Id = id;
        Title = title;
    }
}