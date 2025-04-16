using CommunityToolkit.Mvvm.ComponentModel;

namespace Pennerooney_Cookbook.Models;

public partial class Instruction : ObservableObject
{
    [ObservableProperty]
    private int _id;
    
    [ObservableProperty]
    private string _step;

    public Instruction(int id, string step)
    {
        Id = id;
        Step = step;
    }
}