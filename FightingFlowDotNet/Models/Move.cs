namespace FightingFlowDotNet.Models;

public class Move(
    string? name, 
    string? type, 
    string? notation,
    string? character, 
    string? game = "", 
    string? id = ""
    )
{
    public string Id { get; set; } = id ?? "";
    public string Name { get; set; } = name ?? "";
    public string Type { get; set; } = type ?? "";
    public string Notation { get; set; } = notation ?? "";
    public string Character { get; set; } = character ?? "";
    public string Game { get; set; } = game ?? "";
}