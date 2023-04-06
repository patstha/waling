using Bogus;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Waling.Models;
using static Bogus.DataSets.Name;

namespace Waling.Pages.Program;

public class CreateModel : PageModel
{
    [BindProperty]
    [Required]
    [DisplayName("Hidden Waling Persons")]
    public string HiddenWalingPersons { get; set; } = "";

    [BindProperty]
    [Required]
    [DisplayName("Waling Person")]
    public List<string> SelectedWalingPersons { get; set; } = new();

    public IEnumerable<SelectListItem> WalingPersons {  get; set; } = new List<SelectListItem>();
    public IEnumerable<SelectListItem> ModernWalingPersons {  get; set; } = new List<SelectListItem>();

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
        WalingPersons = People.Select(po => new SelectListItem()
        {
            Text = $"{po.FullName} - {po.Email}",
            Value = po.Email
        });
        ModernWalingPersons = People.Select(po => new SelectListItem()
        {
            Text = $"{po.FullName} - {po.Email}",
            Value = po.Email
        });
    }

    public async Task<IActionResult> OnPostAsync()
    {
        IConfigurationSection publicKnowledge = await Task.Run(() => _config.GetSection("PublicKnowledge"));
        string site = publicKnowledge.GetValue<string>("ApplicationName") ?? "default name";
        _logger.LogInformation("{site}", site);
        return Redirect($"/Index?application={site}&walingperson={HiddenWalingPersons}");
    }

    public async Task<List<WalingPerson>> GetUsers()
    {
        List<WalingPerson> persons = new();
        await Task.Run(async () =>
        {
            for (int i = 1; i < 50; i++)
            {
                WalingPerson person = await GetWalingPerson(i);
                persons.Add(person);
            }
        });
        return persons.OrderBy(x => x.FullName).ThenBy(x => x.Email).ToList();
    }

    private async Task<WalingPerson> GetWalingPerson(int increment)
    {
        WalingPerson user = new(0, "");
        await Task.Run(() =>
        {
            var testUsers = new Faker<WalingPerson>()
            //Optional: Call for objects that have complex initialization
            .CustomInstantiator(f => new WalingPerson(increment, f.Random.Replace("###-##-####")))

            //Use an enum outside scope.
            .RuleFor(u => u.Gender, f => f.PickRandom<Gender>())

            //Basic rules using built-in generators
            .RuleFor(u => u.FirstName, (f, u) => f.Name.FirstName(u.Gender))
            .RuleFor(u => u.LastName, (f, u) => f.Name.LastName(u.Gender))
            .RuleFor(u => u.Avatar, f => f.Internet.Avatar())
            .RuleFor(u => u.UserName, (f, u) => f.Internet.UserName(u.FirstName, u.LastName))
            .RuleFor(u => u.Email, (f, u) => f.Internet.Email(u.FirstName, u.LastName))
            .RuleFor(u => u.SomethingUnique, f => $"Value {f.UniqueIndex}")

            //Compound property with context, use the first/last name properties
            .RuleFor(u => u.FullName, (f, u) => u.FirstName + " " + u.LastName)
            //Optional: After all rules are applied finish with the following action
            .FinishWith((f, u) =>
            {
                Console.WriteLine("User Created! Id={0}", u.Id);
            });

            user = testUsers.Generate();
        });
        return user;
    }
}
