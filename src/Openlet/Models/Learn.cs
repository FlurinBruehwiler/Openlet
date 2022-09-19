namespace Openlet.Models;

public class Learn
{
    public Learn(User user, StudySet studySet)
    {
        User = user;
        StudySet = studySet;
    }

    public Learn()
    {
        
    }

    public int LearnId { get; set; }
    
    public User User { get; set; } = null!;
    public int UserId { get; set; }
    
    public StudySet StudySet { get; set; } = null!;
    public int StudySetId { get; set; }
    
   
    public List<LearnCard> LearnCards { get; set; }
}