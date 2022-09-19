using Microsoft.AspNetCore.Identity;

namespace Openlet.Models;

public class User : IdentityUser
{
    public List<Learn>? Learns { get; set; }
    public List<StudySet>? StudySets { get; set; }
}