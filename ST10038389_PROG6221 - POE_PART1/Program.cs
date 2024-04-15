using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10038389_PROG6221___POE_PART1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RecipeClass recipe = new RecipeClass();

            Console.WriteLine("Enter the Number of Ingredients:");
            int ingredientCount = Convert.ToInt32(Console.ReadLine());
            recipe.SetIngredients(ingredientCount);

            Console.WriteLine("Enter the Number of Steps:");
            int stepCount = Convert.ToInt32(Console.ReadLine());
            recipe.SetSteps(stepCount);

            recipe.DisplayRecipeClass();

            Console.WriteLine("Enter the Scaling Factor (0.5, 2, or 3):");
            double factor = Convert.ToDouble(Console.ReadLine());
            recipe.ScaleRecipeClass(factor);

            recipe.DisplayRecipeClass();
        }
        //<summary>
        //Breakdown of the code into comments of what each line is doing!
        //This Application allows users to insert ingredients and follow steps for a recipe, scale the recipe by a factor of (0.5, 2 or 3.)
        //I created a new instance of the RecipeClass to work with Recipes.
        //Allows the user to enter the Number of Ingredients into the application.
        //Reads the users inputed details and converts it to integer.
        //Sets the Number of Ingredients for the recipe.
        //Allows the user to enter the Number of steps  in the recipe.
        //Sets the steps for a step counter for the recipe.
        //Displays the overview of the recipe, viewing the entered details of the ingredients and steps taken.
        //Allows the user to enter the scaling factors.
        //Reads the users entered details and converts it to Double().
        //Scales the Recipe to a factor.
        //Displays the final scaled recipe of  what the user inserted into the application.
        //</summary>
    }
}
//----------------------------- END OF LINE ---------------------------------------//
