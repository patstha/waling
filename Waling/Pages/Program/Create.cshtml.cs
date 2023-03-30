using Bogus;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Waling.Models;
using static Bogus.DataSets.Name;

namespace Waling.Pages.Program;

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

    public List<WalingPerson> People { get; set; } = new();

    public CreateModel(ILogger<CreateModel> logger, IConfiguration config)
    {
        _logger = logger;
        _config = config;
    }
    public async Task OnGetAsync()
    {
        People = await GetUsers();
    }

    public async Task<IActionResult> OnPostAsync()
    {
        IConfigurationSection publicKnowledge = await Task.Run(() => _config.GetSection("PublicKnowledge"));
        string site = publicKnowledge.GetValue<string>("ApplicationName") ?? "default name";
        _logger.LogInformation("Projected date old is {projectedold}", ProjectedOld);
        _logger.LogInformation("Projected date new is {projectednew}", ProjectedNew);
        return Redirect($"/Index?application={site}&projectedold={ProjectedOld}&projectednew={ProjectedNew}");
    }

    public async Task<List<WalingPerson>> GetUsers()
    {
        List<WalingPerson> persons = new();
        await Task.Run(async () =>
        {
            for (int i = 1; i < 10; i++)
            {
                WalingPerson person = await GetWalingPerson(i);
                persons.Add(person);
            }
        });
        return persons;
    }

    private async Task<WalingPerson> GetWalingPerson(int increment)
    {
        WalingPerson user = new();
        await Task.Run(() =>
        {
            Faker<WalingPerson> testUsers = new Faker<WalingPerson>()
            //Optional: Call for objects that have complex initialization
            .CustomInstantiator(f => new WalingPerson())

            //Basic rules using built-in generators
            .RuleFor(u => u.LegalName, (f, u) => $"{f.Name.FirstName(Gender.Male)} {f.Name.LastName(Gender.Male)}")
            .RuleFor(u => u.PrimaryEmail, (f, u) => f.Internet.Email(uniqueSuffix: increment.ToString()));
            WalingPerson user = testUsers.Generate();
        });
        return user;
    }
}
