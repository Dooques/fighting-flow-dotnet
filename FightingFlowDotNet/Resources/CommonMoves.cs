using FightingFlowDotNet.Models;

namespace FightingFlowDotNet.Resources.TekkenData;

public static class CommonMoves
{
    public static readonly List<Move> Moves =
    [
        new Move(name: "break", type: "Break", notation: "►", character: "Generic"),
        new Move(name: "o_parenthesis", type: "Misc", notation: "{", character: "Generic"),
        new Move(name: "c_parenthesis", type: "Misc", notation: "}", character: "Generic"),
        new Move(name: "o_hold", type: "Misc", notation: "[", character: "Generic"),
        new Move(name: "c_hold", type: "Misc", notation: "]", character: "Generic"),
        new Move(name: "plus", type: "Misc", notation: "+", character: "Generic"),
        new Move(name: "slide", type: "Misc", notation: "/", character: "Generic")
    ];
}