using Google.Cloud.Firestore;

namespace FightingFlowDotNet.Models;

[FirestoreData]
public class UserInfo
{
    public UserInfo() {}
    [FirestoreProperty("userId")] 
    public string UserId { get; set; } = "";
    [FirestoreProperty("username")] 
    public string Username { get; set; } = "";
    [FirestoreProperty("profile_pic")] 
    public string ProfilePic { get; set; } = "";
    [FirestoreProperty("name")] 
    public string Name { get; set; } = "";
    [FirestoreProperty("date_created")] 
    public string DateCreated { get; set; } = "";
    [FirestoreProperty("dob")] 
    public string DoB { get; set; } = "";
    [FirestoreProperty("liked_combos")] 
    public List<string> LikedCombos { get; set; } = [];
    [FirestoreProperty("character_list")] 
    public List<string> CharacterList { get; set; } = [];
}

public class AuthoriseUser
{
    public UserInfo UserInfo { get; set; } = new();
    public string Password { get; set; } = "";
}