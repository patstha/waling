using static Bogus.DataSets.Name;

namespace Waling.Models;

public class WalingPerson
{
    public WalingPerson(int increment, string socialSecurityNumber)
    {
        Id = increment;
        SocialSecurityNumber = socialSecurityNumber;
    }

    public int Id { get; set; }
    public string SocialSecurityNumber { get; set; }
    public string FirstName { get; set; } = "";
    public string LastName { get; set; } = "";
    public string PrimaryEmail { get; set; } = "";
    public Gender Gender { get; set; }
    public string Avatar { get; set; } = "";
    public string UserName { get; set; } = "";
    public string Email { get; set; } = "";
    public string SomethingUnique { get; set; } = "";
    public string FullName { get; set; } = "";

}
