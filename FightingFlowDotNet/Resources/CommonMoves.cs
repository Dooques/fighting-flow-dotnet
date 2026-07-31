using FightingFlowDotNet.Models;

namespace FightingFlowDotNet.Resources;

public static class CommonMoves
{
    public static readonly List<Move> Moves =
    [
        new(name: "break", type: "Break", notation: "►", character: "Generic"),
        new(name: "o_parenthesis", type: "Misc", notation: "{", character: "Generic"),
        new(name: "c_parenthesis", type: "Misc", notation: "}", character: "Generic"),
        new(name: "o_hold", type: "Misc", notation: "[", character: "Generic"),
        new(name: "c_hold", type: "Misc", notation: "]", character: "Generic"),
        new(name: "plus", type: "Misc", notation: "+", character: "Generic"),
        new(name: "slide", type: "Misc", notation: "/", character: "Generic")
    ];
}