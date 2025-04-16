using CommunityToolkit.Mvvm.ComponentModel;

namespace Pennerooney_Cookbook.Models;

public partial class Genre : ObservableObject
{
    [ObservableProperty]
    private int _id;
    
    [ObservableProperty]
    private string _title;
    
    public Genre(int id, string title)
    {
        Id = id;
        Title = title;
    }
}