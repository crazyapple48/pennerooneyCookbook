using System;

namespace Pennerooney_Cookbook.Models;

public record Recipe(int Id, 
    string Title, 
    Method Method, 
    Genre Genre, 
    Purpose Purpose, 
    int Rating, 
    int Difficulty, 
    DateOnly LastCookedDate,
    bool IsFavorite, 
    Source Source,
    Ingredient[] Ingredients,
    Instruction[] Instructions);