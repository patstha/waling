using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Waling.Pages.Program
{
    public class CreateModel : PageModel
    {
        [BindProperty, DataType(DataType.Date)]
        [Required]
        [DisplayName("Projected Date")]
        public DateOnly Projected { get; set; }

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
            _logger.LogInformation("Projected date is {projected}", Projected);
            return Redirect($"/Index?application={site}&projected={Projected}");
        }
    }
}
