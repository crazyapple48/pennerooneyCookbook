using CommunityToolkit.Mvvm.ComponentModel;

namespace Pennerooney_Cookbook.Models;

public partial class Method : ObservableObject
{
    [ObservableProperty] private int _id;
    [ObservableProperty] private string _title;

    public Method(int id, string title)
    {
        Id = id;
        Title = title;
    }
}