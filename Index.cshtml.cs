using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GreetingApp.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public string FirstName { get; set; }

        [BindProperty]
        public string LastName { get; set; }

        public string FullName { get; set; }

        public void OnPost()
        {
            FullName = $"{FirstName} {LastName}";
        }
    }
}
