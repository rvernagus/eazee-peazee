using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EazeePeazee.Pages
{
    public class TextInputModel : PageModel
    {
        public string Label { get; set; }
        public string Placeholder { get; set; }
    }
}