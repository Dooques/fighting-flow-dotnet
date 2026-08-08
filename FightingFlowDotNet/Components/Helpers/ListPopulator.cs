using FightingFlowDotNet.Models;
using FightingFlowDotNet.Resources;

namespace FightingFlowDotNet.Components.Helpers;

public static class ListPopulator
{
    public static List<Move> ReturnMoveList(string game)
    {
        List<Move> moveList = game switch
        {
            "Tekken 8" => [..Tekken8.Moves],
            "Street Fighter 6" => [..StreetFighter6.Moves],
            "Mortal Kombat 1" => [..MortalKombat1.Moves],
            _ => throw new ArgumentOutOfRangeException(nameof(game), game, null)
        };

        if (!CommonMoves.Moves.All(moveList.Contains))
            moveList.AddRange(CommonMoves.Moves);
        
        return moveList;
    }

    public static List<string> ReturnTypes(string game)
    {
        return game switch
        {
            "Tekken 8" => ["Misc", "Movement", "Input", "Character", "Stances", "Mechanics", "Stage", "Modifier"],
            "Street Fighter 6" => ["Movement", "SF Classic", "SF Modern", "Mechanic", "Stage", "Special", "Super Art"],
            "Mortal Kombat 1" => ["Input", "Movement", "Text Input", "Special", "Fatal Blow"],
            _ => throw new ArgumentOutOfRangeException(nameof(game), game, null)
        };
    }
}