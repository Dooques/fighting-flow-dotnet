using FightingFlowDotNet.Models;

namespace FightingFlowDotNet.Resources;

public static class CommonMoves
{
    public static readonly List<Move> Moves =
    [
        new(name: "break", type: "Break", notation: "►", character: "Generic"),
        new(name: "o_parenthesis", type: "Misc", notation: "{", character: "Generic", imageId: "move_common_o_parenthesis"),
        new(name: "c_parenthesis", type: "Misc", notation: "}", character: "Generic", imageId: "move_common_c_parenthesis"),
        new(name: "o_hold", type: "Misc", notation: "[", character: "Generic", imageId: "move_common_o_hold"),
        new(name: "c_hold", type: "Misc", notation: "]", character: "Generic", imageId: "move_common_c_hold"),
        new(name: "plus", type: "Misc", notation: "+", character: "Generic", imageId: "move_common_plus"),
        new(name: "slide", type: "Misc", notation: "/", character: "Generic", imageId: "move_common_slide"),

        // Movement (shared across every game)
        new(name: "forward", notation: "f", type: "Movement", character: "Generic", imageId: "move_common_forward"),
        new(name: "up", notation: "u", type: "Movement", character: "Generic", imageId: "move_common_up"),
        new(name: "up_forward", notation: "u/f", type: "Movement", character: "Generic", imageId: "move_common_up_forward"),
        new(name: "down_forward", notation: "d/f", type: "Movement", character: "Generic", imageId: "move_common_down_forward"),
        new(name: "forward_dash", notation: "F", type: "Movement", character: "Generic", imageId: "move_common_forward_dash"),
        new(name: "back", notation: "b", type: "Movement", character: "Generic", imageId: "move_common_back"),
        new(name: "down", notation: "d", type: "Movement", character: "Generic", imageId: "move_common_down"),
        new(name: "up_back", notation: "u/b", type: "Movement", character: "Generic", imageId: "move_common_up_back"),
        new(name: "down_back", notation: "d/b", type: "Movement", character: "Generic", imageId: "move_common_down_back"),
        new(name: "neutral", notation: "n", type: "Movement", character: "Generic", imageId: "move_common_neutral")
    ];
}