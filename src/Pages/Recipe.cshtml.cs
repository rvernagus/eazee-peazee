using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EazeePeazee.Pages
{
    public class RecipeModel : PageModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";

        public void OnGet(int id)
        {
            Id = id;
            Name = "My Recipe";
        }
    }
}
