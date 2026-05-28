using Microsoft.AspNetCore.Components.Web;

namespace FightingFlowDotNet.Models;

public class Combo(
    string title, 
    string character, 
    List<string> moves,
    string createdBy = "",
    string createdOn = "",
    string lastModifiedBy = "",
    int damage = 0
    )
{
    public string Id { get; set; } = "";
    public string Title { get; set; } = title;
    public string Character { get; set; } = character;
    public int Damage { get; set; } = damage;
    public string CreatedBy { get; set; } = createdBy;
    public string CreatedOn { get; set; } = createdOn;
    public string LastModifiedBy { get; set; } = lastModifiedBy;
    public  List<string> Moves { get; set; } = moves;
}

public class ComboDisplay(
    Combo combo, bool areOptionsRevealed = false, int ki = 0, int favourites = 0, 
    List<string>? comments = null
    )
{
    public Combo Combo { get; set; } = combo;
    public bool AreOptionsRevealed { get; set; } = areOptionsRevealed;
    public int Ki { get; set; } = ki;
    public int Favourites { get; set; } = favourites;
    public List<string>? Comments = comments;
}