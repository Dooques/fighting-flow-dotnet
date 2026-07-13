using FightingFlowDotNet.Models;

namespace FightingFlowDotNet.Resources.TekkenData;

public class ConsoleInputs
{
    public static readonly IReadOnlyList<Move> CommonMoves = new List<Move>
    {
        new Move(name: "break", type: "Break", notation: "►", character: "Generic"),
        new Move(name: "o_parenthesis", type: "Misc", notation: "{", character: "Generic"),
        new Move(name: "c_parenthesis", type: "Misc", notation: "}", character: "Generic"),
        new Move(name: "o_hold", type: "Misc", notation: "[", character: "Generic"),
        new Move(name: "c_hold", type: "Misc", notation: "]", character: "Generic"),
        new Move(name: "plus", type: "Misc", notation: "+", character: "Generic"),
        new Move(name: "slide", type: "Misc", notation: "/", character: "Generic"),
    }.AsReadOnly();

    public static readonly IReadOnlyList<Move> PlaystationInputs = new List<Move>
    {
        new Move(name: "square", type: "Console", notation: "□", character: "Character"),
        new Move(name: "triangle", type: "Console", notation: "△", character: "Character"),
        new Move(name: "cross", type: "Console", notation: "×", character: "Character"),
        new Move(name: "circle", type: "Console", notation: "○", character: "Character"),
        new Move(name: "R1", type: "Console Text", notation: "R1", character: "Character"),
        new Move(name: "R2", type: "Console Text", notation: "R2", character: "Character"),
        new Move(name: "R3", type: "Console Text", notation: "R3", character: "Character"),
        new Move(name: "L1", type: "Console Text", notation: "L1", character: "Character"),
        new Move(name: "L2", type: "Console Text", notation: "L2", character: "Character"),
        new Move(name: "L3", type: "Console Text", notation: "L3", character: "Character"),
    }.AsReadOnly();

    public static readonly IReadOnlyList<Move> XboxInputs = new List<Move>
    {
        new Move(name: "x_xbox", type: "Console", notation: "X", character: "Character"),
        new Move(name: "y_xbox", type: "Console", notation: "Y", character: "Character"),
        new Move(name: "a_xbox", type: "Console", notation: "A", character: "Character"),
        new Move(name: "b_xbox", type: "Console", notation: "B", character: "Character"),
        new Move(name: "RB", type: "Console Text", notation: "RB", character: "Character"),
        new Move(name: "RT", type: "Console Text", notation: "RT", character: "Character"),
        new Move(name: "RS", type: "Console Text", notation: "RS", character: "Character"),
        new Move(name: "LB", type: "Console Text", notation: "LB", character: "Character"),
        new Move(name: "LT", type: "Console Text", notation: "LT", character: "Character"),
        new Move(name: "LS", type: "Console Text", notation: "LS", character: "Character"),
    }.AsReadOnly();

    public static readonly IReadOnlyList<Move> NintendoInputs = new List<Move>
    {
        new Move(name: "y_nintendo", type: "Console", notation: "Y", character: "Character"),
        new Move(name: "x_nintendo", type: "Console", notation: "X", character: "Character"),
        new Move(name: "b_nintendo", type: "Console", notation: "B", character: "Character"),
        new Move(name: "a_nintendo", type: "Console", notation: "A", character: "Character"),
        new Move(name: "R", type: "Console Text", notation: "R", character: "Character"),
        new Move(name: "ZR", type: "Console Text", notation: "ZR", character: "Character"),
        new Move(name: "RS", type: "Console Text", notation: "RS", character: "Character"),
        new Move(name: "L", type: "Console Text", notation: "L", character: "Character"),
        new Move(name: "ZL", type: "Console Text", notation: "ZL", character: "Character"),
        new Move(name: "LS", type: "Console Text", notation: "LS", character: "Character"),
    }.AsReadOnly();

    public static readonly IReadOnlyList<string> ConvertibleInputRef = new List<string>
    {
        "one", "one_mk", "two", "two_mk", "three", "three_mk", "four", "four_mk", "two_plus_three",
        "three_plus_four", "Heat Burst", "one_plus_four", "one_plus_two", "Rage Art", "Kameo", "Block",
        "Throw", "Stance", "lp", "mp", "lk", "mk", "hp", "hk", "light", "special", "medium", "heavy",
        "Parry", "Assist", "Drive Impact", "Throw"
    }.AsReadOnly();

    public static readonly IReadOnlyList<string> ConsoleInputRef = new List<string>
    {
        "square", "triangle", "cross", "circle", "R1", "R2", "R3", "L1", "L2", "L3", "x_xbox", "y_xbox",
        "a_xbox", "b_xbox", "RB", "RT", "RS", "LB", "LT", "LS", "y_nintendo", "x_nintendo",
        "b_nintendo", "a_nintendo", "R", "ZR", "RS", "L", "ZL", "LS",
    }.AsReadOnly(); 
}