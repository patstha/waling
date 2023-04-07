using Bogus;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Waling.Models;
using static Bogus.DataSets.Name;
namespace Waling.Pages.Profile;


public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly IConfiguration _config;

    public List<WalingPerson> People { get; set; } = new();

    public IndexModel(ILogger<IndexModel> logger, IConfiguration config)
    {
        _logger = logger;
        _config = config;
    }
    public async Task OnGetAsync()
    {
        People = await GetUsers();
    }

    public async Task<List<WalingPerson>> GetUsers()
    {
        List<WalingPerson> persons = new();
        await Task.Run(async () =>
        {
            for (int i = 1; i <= 200; i++)
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