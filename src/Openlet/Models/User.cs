namespace Openlet.Models;

public class User
{
    public User(string username, byte[] passwordHash, byte[] passwordSalt)
    {
        Username = username;
        PasswordHash = passwordHash;
        PasswordSalt = passwordSalt;
    }

    public User()
    {
    }

    public int UserId { get; set; }
    public string Username { get; set; } = null!;
    public byte[] PasswordHash { get; set; } = null!;
    public byte[] PasswordSalt { get; set; } = null!;


    public List<Learn>? Learns { get; set; }
    public List<StudySet>? StudySets { get; set; }
}