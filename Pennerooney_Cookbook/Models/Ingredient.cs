namespace Pennerooney_Cookbook.Models;

public record Ingredient(int Id, 
    IngredientName Title, 
    CutType CutType,
    Unit Unit,
    double Amount);