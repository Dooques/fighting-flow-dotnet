using FightingFlowDotNet.Models.Enums;

namespace FightingFlowDotNet.Models;

public class Move(
    string? name, 
    string? type, 
    string? notation,
    string? character, 
    Sf6Type? sf6Type =  Sf6Type.None,
    string? game = "", 
    string? id = ""
    )
{
    public string Id { get; set; } = id ?? "";
    public string Name { get; set; } = name ?? "";
    public string Type { get; set; } = type ?? "";
    public string Notation { get; set; } = notation ?? "";
    public string Character { get; set; } = character ?? "";
    public Sf6Type Sf6Type { get; set; }
    public string Game { get; set; } = game ?? "";
}