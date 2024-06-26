using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Demo_ASP.NET_RazorPages.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public string Name { get; set; }

        public void OnGet()
        {
            // This method is called when the page is loaded via a GET request.
            Name = "World";
        }

        public void OnPost()
        {
            // This method is called when the form is submitted via a POST request.
            // The Name property will be automatically bound to the form input.
        }
    }
}