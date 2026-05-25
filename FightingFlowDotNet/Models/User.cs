namespace FightingFlowDotNet.Models;

public class User
{
    public AuthDetails AuthDetails { get; set; } = new AuthDetails();
    public UserInfo UserInfo { get; set; } = new UserInfo();
}

public class AuthDetails
{
    public string Id { get; set; } = "";
    public string Username { get; set; } = "";
    public string Email { get; set; } = "";
}

public class UserInfo
{
    public string ProfileImage { get; set; } = "";
    public string Name { get; set; } = "";
    public string DoB { get; set; } = "";
    public List<string> LikedCombos { get; set; } = [];
    public List<string> CharacterList { get; set; } = [];
}

public class AuthDetailsCreation
{
    public AuthDetails AuthDetails { get; set; } = new AuthDetails();
    public string Password { get; set; } = ""; 
}

