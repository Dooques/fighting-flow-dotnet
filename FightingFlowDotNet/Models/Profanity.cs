namespace FightingFlowDotNet.Models;

public class Profanity
{
    public string Notes { get; set; } = "";
    public int Severity { get; set; } = 0;
    public List<string> Tags { get; set; } = [];
    public List<ProfanityWord> Dictionary { get; set; } = [];
}

public abstract class ProfanityWord
{
    public string Id { get; set; } = "";
    public string Match { get; set; } = "";
    public bool AllowPartial { get; set; } = false;
    public List<string> Exceptions { get; set; } = [];
}