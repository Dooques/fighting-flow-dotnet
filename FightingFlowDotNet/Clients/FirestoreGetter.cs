using System.Text.Json;
using FightingFlowDotNet.Clients.Helper;
using FightingFlowDotNet.Models;
using Firebase.Auth;
using Google.Apis.Auth.OAuth2;
using Google.Cloud.Firestore;

namespace FightingFlowDotNet.Clients;

public class FirestoreGetter(IConfiguration configuration, IHostEnvironment env)
{
    private FirestoreDb Db { get; set; } = new FirestoreDbBuilder
    {
        ProjectId = configuration["Firebase:projectId"],
        DatabaseId = configuration["Firebase:Database"],
        Credential = GoogleCredentialFactory.Create(configuration, env)
    }.Build();
    
    

    public async Task<List<Fighter>> GetFighters(string game)
    {
        var fighterCollection = await Db.Collection("characters").GetSnapshotAsync();
        List<Fighter> fighters = [];
        fighters.AddRange(
            from document in fighterCollection.Documents 
            where document.Exists 
            select document.ConvertTo<Fighter>());
        return fighters;
    }

    public async Task<List<Combo>> GetCombos(string fighter)
    {
        var comboCollection = await Db
            .Collection("characters")
            .Document(fighter)
            .Collection("combos").GetSnapshotAsync();
        
        List<Combo> combos = [];
        combos.AddRange(
            from document in comboCollection.Documents
            where document.Exists
            select document.ConvertTo<Combo>());
        return combos;
    }

    public async Task<Combo> GetCombo(string fighter, string comboId)
    {
        var comboCollection = await Db
            .Collection("characters")
            .Document(fighter)
            .Collection("combos")
            .Document(comboId).GetSnapshotAsync();
        return comboCollection.ConvertTo<Combo>();
    }
    public async Task SaveCombo(DisplayCombo displayCombo, string fighter, string comboId)
    {
        var comboCollection = Db
            .Collection("characters")
            .Document(fighter)
            .Collection("combos")
            .Document(comboId);
        var docRef= await comboCollection.SetAsync(displayCombo);
        Console.WriteLine($"Document Saved: {docRef}");
    }
    
    public async Task<List<CustomUserInfo>> GetUsers()
    {
        var userCollection = await Db.Collection("users").GetSnapshotAsync();
        List<CustomUserInfo> users = [];
        users.AddRange(
            from document in userCollection.Documents
            where document.Exists
            select  document.ConvertTo<CustomUserInfo>());
        return users;
    }

    public async Task<CustomUserInfo> PostUser(CustomUserInfo customUser)
    {
        await Db
            .Collection("users")
            .Document(customUser.UserId)
            .SetAsync(customUser);
        return customUser;
    }

    public async Task<CustomUserInfo> GetUser(string userId)
    {
        var user = await Db
            .Collection("users")
            .Document(userId)
            .GetSnapshotAsync();
        return user.ConvertTo<CustomUserInfo>();
    }

    public async Task<CustomUserInfo?> FindUserByUsername(string username)
    {
        var snapshot = await Db
            .Collection("users")
            .WhereEqualTo("username", username)
            .Limit(1)
            .GetSnapshotAsync();
        
        return snapshot.Documents
            .Single()
            .ConvertTo<CustomUserInfo>();
    }
}