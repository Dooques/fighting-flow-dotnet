namespace FightingFlowDotNet.Models;

public class Combo
{
    public string Id { get; set; } = "";
    public string Title { get; set; } = "";
    public string Character { get; set; } = "";
    public int Damage { get; set; } = 0;
    public string CreatedBy { get; set; } = "";
    public string CreatedOn { get; set; } = "";
    public string LastModifiedBy { get; set; } = "";
    public List<string> Moves = [];
}

public class ComboDisplay
{
    public Combo Combo { get; set; } = new Combo();
    public bool AreOptionsRevealed { get; set; } = false;
    public int Chi { get; set; } = 0;
    public int Favourites { get; set; } = 0;
    public List<string> Comments = [];
}