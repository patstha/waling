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

        private readonly ILogger<CreateModel> _logger;
        private readonly IConfiguration _config;

        public CreateModel(ILogger<CreateModel> logger, IConfiguration config)
        {
            _logger = logger;
            _config = config;
        }
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            IConfigurationSection publicKnowledge = await Task.Run(() => _config.GetSection("PublicKnowledge"));
            string site = publicKnowledge.GetValue<string>("ApplicationName") ?? "default name";
            return Redirect($"/Index?application={site}");
        }
    }
}
