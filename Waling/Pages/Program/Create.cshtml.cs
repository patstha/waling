using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Waling.Pages.Program
{
    public class CreateModel : PageModel
    {
        [BindProperty, DataType(DataType.Date)]
        [Required]
        [DisplayName("Projected Date")]
        public DateTime Projected { get; set; }
        public void OnGet()
        {
        }
    }
}
