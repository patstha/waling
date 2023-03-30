using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Waling.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet(string? application, DateOnly? projected)
    {
        _logger.LogInformation("{application} - {projectedYear}-{projectedMonth}-{projectedDate} (in YYYY-mm-dd format)", 
            application, projected?.Year, projected?.Month, projected?.Day);
    }
}