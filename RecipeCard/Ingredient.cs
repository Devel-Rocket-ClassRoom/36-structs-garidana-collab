using System;
using System.Collections.Generic;
using System.Text;

struct Ingredient
{
    public string Name;
    public double Amount;
    public string Unit;

    public Ingredient (string name, double amount, string unit)
    {
        Name = name;
        Amount = amount;
        Unit = unit;
    }

}

struct RecipeCard
{
    public string Name;
    public int Servings;
    Ingredient[] Ingredients = new Ingredient[3];
  

    public RecipeCard(string name, int servings, Ingredient[] ingredients)
    {
        Name = name;
        Servings = servings;
        Ingredients = ingredients;
    }
}
