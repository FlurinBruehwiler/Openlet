using System.ComponentModel.DataAnnotations;

namespace Openlet.Models;

public class StudySet
{
    public StudySet(string name, User user)
    {
        Name = name;
        User = user;
    }

    public StudySet()
    {
    }

    public int StudySetId { get; set; }
    
    [Required, StringLength(60, MinimumLength = 3)]
    public string Name { get; set; } = null!;

    public User User { get; set; } = null!;
    public int UserId { get; set; }

    public List<Learn>? Learns { get; set; }

    public List<Card> Cards { get; set; } = new();
}