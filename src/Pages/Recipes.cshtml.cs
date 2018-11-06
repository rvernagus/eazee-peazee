using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EazeePeazee.Pages
{
    public class Recipe
    {
        public string Name { get; set; } = "";
    }

    public class RecipesModel : PageModel
    {
        public RecipesModel()
        {
            Recipes.Add(new Recipe { Name = "Roasted Chicken" });
            Recipes.Add(new Recipe { Name = "Instant Pot Chicken Marinara" });
        }

        public IList<Recipe> Recipes { get; private set; } = new List<Recipe>();
    }
}