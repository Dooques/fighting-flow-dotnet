namespace FightingFlowDotNet.Models;

public class Fighter
{
    public Fighter() { }

    public Fighter(string name, string bio, string imageId, string fightingStyle, string game)
    {
        Name = name;
        Bio = bio;
        ImageId = imageId;
        FightingStyle = fightingStyle;
        Game = game;
    }

    public string Id { get; set; } = "";
    public string Name { get; set; } = "";
    public string Bio { get; set; } = "";
    public string FightingStyle { get; set; } = "";
    public string Game { get; set; } = "";
    public string ImageId { get; set; } = "";
    public List<string> CombosById { get; set; } = [];
}