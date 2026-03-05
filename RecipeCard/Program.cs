using System;
using static System.Console;

// README.md를 읽고 코드를 작성하세요.



WriteLine("=== 원본 레시피 ===");



Ingredient[] ingredients = new Ingredient[]
{
    new Ingredient ("스파게티면", 200, "g"),
    new Ingredient ("토마토소스", 150, "ml"),
    new Ingredient ("양파", 1, "개"),
    new Ingredient ("마늘", 3, "쪽")
};

RecipeCard recipecard = new RecipeCard("토마토 파스타", 2, ingredients);
recipecard.PrintRecipe();
recipecard.ScaleRecipe(4);
WriteLine();
WriteLine("=== 4인분으로 변환 ===");
recipecard.PrintRecipe();

// issue : 인분이 4인분으로 안변함