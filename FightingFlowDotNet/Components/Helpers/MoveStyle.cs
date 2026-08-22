using Blazorise;

namespace FightingFlowDotNet.Components.Helpers;


/// <summary>
/// Single source of truth for how a Move's Type is colored. Used by every place that renders a
/// move as a colored badge (the move selector, the combo display in the editor, and the read-only
/// combo viewer) so they can never drift apart from each other again.
/// </summary>
public static class MoveStyle
{
    private static readonly HashSet<string> ColoredTypes =
    [
        "Character", "Mishima", "Special", "Modifier", "Mechanics",
        "Common", "Stage", "Super Art", "Fatal Blow"
    ];

    public static bool IsColored(string? type) => type is not null && ColoredTypes.Contains(type);

    public static Background GetBackground(string? type) => type switch
    {
        "Character" or "Mishima" or "Super Art" or "Fatal Blow" => Background.Primary,
        "Special" => Background.Secondary,
        "Modifier" => Background.Dark,
        "Break" => Background.Info,
        "Stage" => Background.Warning,
        "Mechanics" => Background.Success,
        "Common" => Background.Danger,
        _ => Background.Dark
    };

    public static string GetToneClass(string? type) => type switch
    {
        "Modifier" => "move-btn-modifier",
        "Stage" => "move-btn-stage",
        _ => ""
    };

    // Custom hex overrides for types where the plain Bootstrap Background.* class isn't the look we
    // want. Types not listed here rely purely on GetBackground's Bootstrap class.
    public static string GetToneStyle(string? type) => type switch
    {
        "Modifier" => "background-color: #5c636a !important; border-color: #565c62 !important;",
        "Break" => "background-color: #0a8fab !important; border-color: #087d96 !important;",
        "Stage" => "background-color: #146c43 !important; border-color: #125f3b !important;",
        "Mechanics" => "background-color: #379450 !important; border-color: #2a7a40 !important;",
        "Common" => "background-color: #c73545 !important; border-color: #ad2e3b !important;",
        _ => ""
    };

    public static TextColor GetTextColor(string? type) => type switch
    {
        "Modifier" => TextColor.Dark,
        "Stage" => TextColor.Dark,
        "Break" => TextColor.Dark,
        _ => TextColor.Light
    };

    // Icon-only moves are stored as snake_case identifiers (e.g. "up_forward"); this turns
    // them into a readable label ("Up Forward") for tooltips/alt text. Names that are already
    // display-ready (no underscores) pass through unchanged.
    public static string FormatName(string? name)
    {
        if (string.IsNullOrEmpty(name)) return "";

        return string.Join(" ", name
            .Split('_', StringSplitOptions.RemoveEmptyEntries)
            .Select(word => char.ToUpper(word[0]) + word[1..]));
    }
}
