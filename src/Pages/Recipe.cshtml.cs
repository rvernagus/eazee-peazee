using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EazeePeazee.Pages
{
    public class RecipeModel : PageModel
    {
        public string Name { get; set; } = "";

        public void OnGet(string id)
        {
            Name = id;
        }
    }
}
