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
        [DisplayName("Projected Date New")]
        public DateOnly ProjectedNew { get; set; }

        [BindProperty, DataType(DataType.Date)]
        [Required]
        [DisplayName("Projected Date Old")]
        public DateTime ProjectedOld { get; set; }


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
            _logger.LogInformation("Projected date old is {projectedold}", ProjectedOld);
            _logger.LogInformation("Projected date new is {projectednew}", ProjectedNew);
            return Redirect($"/Index?application={site}&projectedold={ProjectedOld}&projectednew={ProjectedNew}");
        }
    }
}
