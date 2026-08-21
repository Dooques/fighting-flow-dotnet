using FightingFlowDotNet.Models.Enums;

namespace FightingFlowDotNet.Models.State;

public class GameSelectedState(GameType gameSelected = GameType.TEKKEN8)
{
    public GameType GameType { get; set; } = gameSelected;
    public string? BackgroundImage { get; set; }
    public event Action? OnChange;

    public void SetGame(GameType gameType, string? backgroundImage)
    {
        GameType = gameType;
        BackgroundImage = backgroundImage;
        OnChange?.Invoke();
    }

    public void SetBackground(string? image)
    {
        BackgroundImage = image;
        OnChange?.Invoke();
    }
}
