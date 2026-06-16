using System.Text.Json.Serialization;
using Google.Cloud.Firestore;
using Microsoft.AspNetCore.Components.Web;

namespace FightingFlowDotNet.Models;

[FirestoreData]
public class Combo
{
    public Combo() {}
    
    [FirestoreDocumentId] public string Id { get; set; } = "";
    [FirestoreProperty("title")] public string Title { get; set; } = "";
    [FirestoreProperty("character")] public string Character { get; set; } = "";
    [FirestoreProperty("game")] public string Game { get; set; } = "";
    [FirestoreProperty("damage")] public int Damage { get; set; } = 0;
    [FirestoreProperty("created_by")] public string CreatedBy { get; set; } = "";
    [FirestoreProperty("date_created")] public string CreatedOn { get; set; } = "";
    [FirestoreProperty("control_type")] public string ControlType { get; set; } = "";
    [FirestoreProperty("tags")] public string Tags { get; set; } = "";
    [FirestoreProperty("moves")] public List<string> Moves { get; set; } = [];
}

public class ComboDisplay(Combo combo)
{
    public Combo Combo { get; set; } = combo;
    public bool AreOptionsRevealed { get; set; }
    public int Ki { get; set; }
    public int Favourites { get; set; }
    public List<string>? Comments { get; set; }
}