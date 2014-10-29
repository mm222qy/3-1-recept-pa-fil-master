using FiledRecipes.Domain;
using FiledRecipes.App.Mvp;
using FiledRecipes.Properties;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FiledRecipes.Views
{
    /// <summary>
    /// 
    /// </summary>
    public class RecipeView : ViewBase, IRecipeView
    {
        public void Show(IRecipe recipe)
        {
            Console.Clear();
            int count = 1;
            ShowPanel(recipe.Name, ConsoleColor.White, ConsoleColor.DarkCyan);
            Console.WriteLine();
            Console.WriteLine("Ingredienser");
            Console.WriteLine("---------------------------------");
            foreach (Ingredient ingredient in recipe.Ingredients)
            {
                Console.WriteLine(ingredient.ToString());
            }
            Console.WriteLine();
            Console.WriteLine("Gör såhär:");
            Console.WriteLine("---------------------------------");
            foreach (string instruction in recipe.Instructions)
            {
                Console.WriteLine("<{0}>", count++);
                Console.WriteLine(instruction.ToString());
            }
        }
        //Visar ett valt recept
        public void Show(IEnumerable<IRecipe> recipes)
        {
            foreach (Recipe recipe in recipes)
            {
                Console.Clear();
                                ShowPanel(recipe.Name, ConsoleColor.White, ConsoleColor.DarkCyan);
                Console.WriteLine();
                Console.WriteLine("Ingredienser");
                Console.WriteLine("---------------------------------");
                foreach (Ingredient ingredient in recipe.Ingredients)
                {
                    Console.WriteLine(ingredient.ToString());
                }
                Console.WriteLine();
                Console.WriteLine("Gör såhär:");
                Console.WriteLine("---------------------------------");
                
                int count = 1;
                foreach (string instruction in recipe.Instructions)
                {
                    Console.WriteLine("<{0}>", count++);
                    Console.WriteLine(instruction.ToString());
                }
                ContinueOnKeyPressed();
            }

        }
    }
}
