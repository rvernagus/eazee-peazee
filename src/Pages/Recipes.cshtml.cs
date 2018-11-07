using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EazeePeazee.Pages
{
    public class RecipesModel : PageModel
    {
        public RecipesModel()
        {
            Recipes.Add(new RecipeModel { Name = "Roasted Chicken" });
            Recipes.Add(new RecipeModel { Name = "Instant Pot Chicken Marinara" });
        }

        public IList<RecipeModel> Recipes { get; private set; } = new List<RecipeModel>();
    }
}