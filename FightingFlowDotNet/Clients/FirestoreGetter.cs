using FightingFlowDotNet.Models;
using Google.Cloud.Firestore;

namespace FightingFlowDotNet.Clients;

public class FirestoreGetter(IConfiguration configuration)
{
    private FirestoreDb Db { get; set; } = new FirestoreDbBuilder
    {
        ProjectId = configuration["Firebase:projectId"],
        DatabaseId = configuration["Firebase:Database"]
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
        var comboCollection = Db.Collection("characters")
            .Document(fighter).Collection("combos").Document(comboId);
        var docRef= await comboCollection.SetAsync(displayCombo);
        Console.WriteLine($"Document Saved: {docRef}");
    }
    
    public async Task<List<UserInfo>> GetUsers()
    {
        var userCollection = await Db.Collection("users").GetSnapshotAsync();
        List<UserInfo> users = [];
        users.AddRange(
            from document in userCollection.Documents
            where document.Exists
            select  document.ConvertTo<UserInfo>());
        return users;
    }
}