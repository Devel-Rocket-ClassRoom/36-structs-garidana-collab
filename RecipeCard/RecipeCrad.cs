using System;
using System.Collections.Generic;
using System.Text;


struct RecipeCard
{
    public string Name;
    public int Servings;
    public Ingredient[] Ingredients;  // Ingredient 구조체를 RecipeCard의 매개변수로
    

    public RecipeCard(string name, int servings, Ingredient[] ingredients)
    {
        Name = name;
        Servings = servings;
        Ingredients = ingredients;
        
    }

    public void PrintRecipe()
    {
        // Name과 Servings가 현재 구조체안에 이미 존재함으로 RecipeCard.Name 이렇게 할 필요가 없음
        Console.WriteLine($"[{Name}] ({Servings}인분)");
        Console.WriteLine("재료: ");
        for (int i = 0; i < Ingredients.Length; i++)
        {
            Console.WriteLine($"- {Ingredients[i].Name}: {Ingredients[i].Amount}{Ingredients[i].Unit}");
        }
    }

    public RecipeCard ScaleRecipe(int newServings)
    {
        Servings = newServings / 2;
        for (int i = 0; i < Ingredients.Length; i++)
        {
            Ingredients[i].Amount *= Servings;
        }
        return new RecipeCard(Name, newServings, Ingredients); // 새로운 RecipeCard를 반환하기 위해서는 새로운 매개변수가 필요함?
    }
}
