using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Pennerooney_Cookbook.Models;

public partial class Recipe : ObservableObject
{
    [ObservableProperty] private int _id;
    [ObservableProperty] private string _title = "";
    [ObservableProperty] private Method _method;
    [ObservableProperty] private Genre _genre;
    [ObservableProperty] private Purpose _purpose;
    [ObservableProperty] private int _rating;
    [ObservableProperty] private int _difficulty;
    [ObservableProperty] private string _lastCooked;
    [ObservableProperty] private bool _isFavorite;
    [ObservableProperty] private Source _source;
    [ObservableProperty] private ObservableCollection<Ingredient> _ingredients;
    [ObservableProperty] private ObservableCollection<Instruction> _instructions;


    public Recipe(
        int id,
        string title,
        Method method,
        Genre genre,
        Purpose purpose,
        int rating,
        int difficulty,
        string lastCooked,
        bool isFavorite,
        Source source,
        ObservableCollection<Ingredient> ingredients,
        ObservableCollection<Instruction> instructions)
    {
        Id = id;
        Title = title;
        Method = method;
        Genre = genre;
        Purpose = purpose;
        Rating = rating;
        Difficulty = difficulty;
        LastCooked = lastCooked;
        IsFavorite = isFavorite;
        Source = source;
        Ingredients = ingredients;
        Instructions = instructions;
    }
    
}