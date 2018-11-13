using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EazeePeazee.Pages
{
    public class TextAreaInputModel : PageModel
    {
        public string Label { get; set; }
        public string Placeholder { get; set; }
    }
}