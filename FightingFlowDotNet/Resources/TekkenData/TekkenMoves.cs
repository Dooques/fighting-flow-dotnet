using System.Collections.Immutable;
using FightingFlowDotNet.Models;

namespace FightingFlowDotNet.Resources.TekkenData;

public static class TekkenMoves
{
    public static readonly List<Move> Moves =
    [
        new Move(name: "break", notation: "►", type: "Break", character: "Generic", game: "tekken 8"),
        new Move(name: "forward", notation: "f", type: "Movement", character: "Generic", game: "Tekken 8"),
        new Move(name: "up", notation: "u", type: "Movement", character: "Generic", game: "Tekken 8"),
        new Move(name: "up_forward", notation: "u/f", type: "Movement", character: "Generic", game: "Tekken 8"),
        new Move(name: "down_forward", notation: "d/f", type: "Movement", character: "Generic", game: "Tekken 8"),
        new Move(name: "forward_dash", notation: "F", type: "Movement", character: "Generic", game: "Tekken 8"),
        new Move(name: "back", notation: "b", type: "Movement", character: "Generic", game: "Tekken 8"),
        new Move(name: "down", notation: "d", type: "Movement", character: "Generic", game: "Tekken 8"),
        new Move(name: "up_back", notation: "u/b", type: "Movement", character: "Generic", game: "Tekken 8"),
        new Move(name: "down_back", notation: "d/b", type: "Movement", character: "Generic", game: "Tekken 8"),
        new Move(name: "neutral", notation: "n", type: "Movement", character: "Generic", game: "Tekken 8"),

        // Inputs
        new Move(name: "one", notation: "1", type: "Input", character: "Generic", game: "Tekken 8"),
        new Move(name: "two", notation: "2", type: "Input", character: "Generic", game: "Tekken 8"),
        new Move(name: "three", notation: "3", type: "Input", character: "Generic", game: "Tekken 8"),
        new Move(name: "four", notation: "4", type: "Input", character: "Generic", game: "Tekken 8"),
        new Move(name: "one_plus_two", notation: "1+2", type: "Input", character: "Generic", game: "Tekken 8"),
        new Move(name: "three_plus_four", notation: "3+4", type: "Input", character: "Generic", game: "Tekken 8"),
        new Move(name: "one_plus_three", notation: "1+3", type: "Input", character: "Generic", game: "Tekken 8"),
        new Move(name: "two_plus_four", notation: "2+4", type: "Input", character: "Generic", game: "Tekken 8"),
        new Move(name: "one_plus_four", notation: "1+4", type: "Input", character: "Generic", game: "Tekken 8"),
        new Move(name: "two_plus_three", notation: "2+3", type: "Input", character: "Generic", game: "Tekken 8"),
        new Move(name: "one_plus_two_plus_three", notation: "1+2+3", type: "Input", character: "Generic", game: "Tekken 8"),
        new Move(name: "one_plus_two_plus_four", notation: "1+2+4", type: "Input", character: "Generic", game: "Tekken 8"),
        new Move(name: "one_plus_three_plus_four", notation: "1+3+4", type: "Input", character: "Generic", game: "Tekken 8"),
        new Move(name: "two_plus_three_plus_four", notation: "2+3+4", type: "Input", character: "Generic", game: "Tekken 8"),
        new Move(name: "one_plus_two_plus_three_plus_four", notation: "1+2+3+4", type: "Input", character: "Generic", game: "Tekken 8"),

        // Modifiers
        new Move(name: "Hold", notation: "h", type: "Modifier", character: "Generic", game: "Tekken 8"),
        new Move(name: "Hold Max", notation: "H", type: "Modifier", character: "Generic", game: "Tekken 8"),
        new Move(name: "Delay", notation: "delay", type: "Modifier", character: "Generic", game: "Tekken 8"),
        new Move(name: "Just Frame", notation: "j/f", type: "Modifier", character: "Generic", game: "Tekken 8"),
        new Move(name: "Slide", notation: "(s)", type: "Modifier", character: "Generic", game: "Tekken 8"),

        // Common Stances
        new Move(name: "Side Switch", notation: "s/s", type: "Common", character: "Generic", game: "Tekken"),
        new Move(name: "Back Turned", notation: "b/t", type: "Common", character: "Generic", game: "Tekken"),
        new Move(name: "While Standing", notation: "w/s", type: "Common", character: "Generic", game: "Tekken"),
        new Move(name: "Crouch", notation: "crouch", type: "Common", character: "Generic", game: "Tekken"),
        new Move(name: "Dash", notation: "dash", type: "Common", character: "Generic", game: "Tekken"),
        new Move(name: "Sidestep Left", notation: "s/l", type: "Common", character: "Generic", game: "Tekken"),
        new Move(name: "Sidestep Right", notation: "s/r", type: "Common", character: "Generic", game: "Tekken"),
        new Move(name: "Low Parry", notation: "l/p", type: "Common", character: "Generic", game: "Tekken"),

        // Mechanics
        new Move(name: "Heat Burst", notation: "h/burst", type: "Mechanics Input", character: "Generic", game: "Tekken"),
        new Move(name: "Heat Dash", notation: "h/dash", type: "Mechanic Input", character: "Generic", game: "Tekken"),
        new Move(name: "During Heat", notation: "in heat", type: "Mechanics Input", character: "Generic", game: "Tekken"),
        new Move(name: "Rage Art", notation: "rage", type: "Mechanics Input", character: "Generic", game: "Tekken"),

        // Stage
        new Move(name: "Wall Splat", notation: "w/splat", type: "Stage", character: "Generic", game: "Tekken"),
        new Move(name: "Wall Break", notation: "w/break", type: "Stage", character: "Generic", game: "Tekken"),
        new Move(name: "Wall Blast", notation: "w/blast", type: "Stage", character: "Generic", game: "Tekken"),
        new Move(name: "Wall Bounce", notation: "w/bounce", type: "Stage", character: "Generic", game: "Tekken"),
        new Move(name: "Floor Break", notation: "f/break", type: "Stage", character: "Generic", game: "Tekken"),
        new Move(name: "Floor Blast", notation: "f/blast", type: "Stage", character: "Generic", game: "Tekken"),
        new Move(name: "Balcony Break", notation: "b/break", type: "Stage", character: "Generic", game: "Tekken"),

        // Alisa
        new Move(name: "Destructive Form", notation: "Destructive Form", type: "character", character: "Alisa"),
        new Move(name: "Boot", notation: "Boot", type: "character", character: "Alisa"),
        new Move(name: "Dual Boot", notation: "Dual Boot", type: "character", character: "Alisa"),

        // Anna
        new Move(name: "Hammer Chance", notation: "Hammer Chance", type: "character", character: "Anna"),
        new Move(name: "Chaos Judgement", notation: "Chaos Judgement", type: "character", character: "Anna"),

        //Asuka
        new Move(name: "Naniwa Gusto", notation: "Naniwa Gusto", type: "character", character: "Asuka"),
        new Move(name: "Leg Cutter", notation: "Leg Cutter", type: "character", character: "Asuka"),

        // Azucena
        new Move(name: "Libertador", notation: "Libertador", type: "character", character: "Azucena"),
        new Move(name: "Taking High Attack", notation: "Taking High Attack", type: "character", character: "Azucena"),
        new Move(name: "Taking Low Attack", notation: "Taking Low Attack", type: "character", character: "Azucena"),

        // Bryan
        new Move(name: "Snake Eyes", notation: "Snake Eyes", type: "character", character: "Bryan"),
        new Move(name: "Slither Step", notation: "Slither Step", type: "character", character: "Bryan"),

        // Claudio
        new Move(name: "Starburst", notation: "Starburst", type: "character", character: "Claudio"),

        // Clive
        new Move(name: "Phoenix Shift", notation: "Phoenix Shift", type: "character", character: "Clive"),
        new Move(name: "Wings Of Light", notation: "Wings Of Light", type: "character", character: "Clive"),
        new Move(name: "Updraft", notation: "Updraft", type: "character", character: "Clive"),
        new Move(name: "Zantetsuken", notation: "Zantetsuken", type: "character", character: "Clive"),

        // Devil Jin
        new Move(name: "Mourning Crow", notation: "Mourning Crow", type: "character", character: "Devil Jin"),
        new Move(name: "Fly", notation: "Fly", type: "character", character: "Devil Jin"),
        new Move(name: "WGS", notation: "WGS", type: "Mishima", character: "Devil Jin"),
        new Move(name: "WGF", notation: "WGF", type: "Mishima", character: "Devil Jin"),
        new Move(name: "EWGF", notation: "EWGF", type: "Mishima", character: "Devil Jin"),

        // Dragunov
        new Move(name: "Sneak", notation: "Sneak", type: "character", character: "Dragunov"),

        // Eddy
        new Move(name: "Ginga", notation: "Ginga", type: "character", character: "Eddy"),
        new Move(name: "Bananeira", notation: "Bananeira", type: "character", character: "Eddy"),
        new Move(name: "Negativa", notation: "Negativa", type: "character", character: "Eddy"),
        new Move(name: "Mandinga", notation: "Mandinga", type: "character", character: "Eddy"),

        // Feng
        new Move(name: "Deceptive Step", notation: "Deceptive Step", type: "character", character: "Feng"),
        new Move(name: "Shifting Clouds", notation: "Shifting Clouds", type: "character", character: "Feng"),

        // Heihachi
        new Move(name: "Wind God's Kamae", notation: "Wind God's Kamae", type: "character", character: "Heihachi"),
        new Move(name: "Thunder God's Kamae", notation: "Thunder God's Kamae", type: "character", character: "Heihachi"),
        new Move(name: "Warrior Instinct", notation: "Warrior Instinct", type: "character", character: "Heihachi"),
        new Move(name: "WGS", notation: "WGS", type: "Mishima", character: "Heihachi"),
        new Move(name: "WGF", notation: "WGF", type: "Mishima", character: "Heihachi"),
        new Move(name: "EWGF", notation: "EWGF", type: "Mishima", character: "Heihachi"),
        new Move(name: "TGF", notation: "TGF", type: "Mishima", character: "Heihachi"),
        new Move(name: "ETGF", notation: "ETGF", type: "Mishima", character: "Heihachi"),
        new Move(name: "BSK", notation: "BSK", type: "Mishima", character: "Heihachi"),
        new Move(name: "ESK", notation: "ESK", type: "Mishima", character: "Heihachi"),
        new Move(name: "SD", notation: "SD", type: "Mishima", character: "Heihachi"),

        // Hwoarang
        new Move(name: "Right Stance", notation: "Right Stance", type: "character", character: "Hwoarang"),
        new Move(name: "Left Stance", notation: "Left Stance", type: "character", character: "Hwoarang"),
        new Move(name: "Right Flamingo", notation: "Right Flamingo", type: "character", character: "Hwoarang"),
        new Move(name: "Left Flamingo", notation: "Left Flamingo", type: "character", character: "Hwoarang"),

        // Jack-8
        new Move(name: "Sit Down", notation: "Sit Down", type: "character", character: "Jack-8"),
        new Move(name: "Gamma Howl", notation: "Gamma Howl", type: "character", character: "Jack-8"),

        // Jin
        new Move(name: "Zenshin", notation: "Zenshin", type: "character", character: "Jin"),
        new Move(name: "WGS", notation: "WGS", type: "Mishima", character: "Jin"),
        new Move(name: "WHF", notation: "WGF", type: "Mishima", character: "Jin"),
        new Move(name: "EWHF", notation: "EWGF", type: "Mishima", character: "Jin"),

        // Jun
        new Move(name: "Izumo", notation: "Izumo", type: "character", character: "Jun"),
        new Move(name: "Genjutsu", notation: "Genjutsu", type: "character", character: "Jun"),
        new Move(name: "Miare", notation: "Miare", type: "character", character: "Jun"),

        // Kazuya
        new Move(name: "Devil Form", notation: "Devil Form", type: "character", character: "Kazuya"),
        new Move(name: "WGS", notation: "WGS", type: "Mishima", character: "Kazuya"),
        new Move(name: "WGF", notation: "WGF", type: "Mishima", character: "Kazuya"),
        new Move(name: "EWGF", notation: "EWGF", type: "Mishima", character: "Kazuya"),

        // Kuma & Panda
        new Move(name: "Hunting", notation: "Hunting", type: "character", character: "Kuma & Panda"),
        new Move(name: "Bear Sit", notation: "Bear Sit", type: "character", character: "Kuma & Panda"),
        new Move(name: "Bear Roll", notation: "Bear Roll", type: "character", character: "Kuma & Panda"),

        // Lars
        new Move(name: "Dynamic Entry", notation: "Dynamic Entry", type: "character", character: "Lars"),
        new Move(name: "Silent Entry", notation: "Silent Entry", type: "character", character: "Lars"),
        new Move(name: "Limited Entry", notation: "Limited Entry", type: "character", character: "Lars"),

        // Law
        new Move(name: "Dragon Charge", notation: "Dragon Charge", type: "character", character: "Law"),

        // Lee
        new Move(name: "Hitman", notation: "Hitman", type: "character", character: "Lee"),

        // Leo
        new Move(name: "Jin Ji Du Li", notation: "Jin Ji Du Li", type: "character", character: "Leo"),
        new Move(name: "Fo Bu", notation: "Fo Bu", type: "character", character: "Leo"),

        // Leroy
        new Move(name: "Hermit", notation: "Hermit", type: "character", character: "Leroy"),

        // Lidia
        new Move(name: "Horse Stance", notation: "Horse Stance", type: "character", character: "Lidia"),
        new Move(name: "Cat Stance", notation: "Cat Stance", type: "character", character: "Lidia"),
        new Move(name: "Heaven and Earth", notation: "Heaven and Earth", type: "character", character: "Lidia"),
        new Move(name: "Stalking Wolf Stance", notation: "Stalking Wolf Stance", type: "character", character: "Lidia"),

        // Lili
        new Move(name: "Dew Glide", notation: "Dew Glide", type: "character", character: "Lili"),

        // Raven
        new Move(name: "Soulzone", notation: "Soulzone", type: "character", character: "Raven"),

        // Reina
        new Move(name: "Unsoku", notation: "Unsoku", type: "character", character: "Reina"),
        new Move(name: "Sentai", notation: "Sentai", type: "character", character: "Reina"),
        new Move(name: "Heaven's Wrath", notation: "Heaven's Wrath", type: "character", character: "Reina"),
        new Move(name: "WGS", notation: "WGS", type: "Mishima", character: "Reina"),
        new Move(name: "WGF", notation: "WGF", type: "Mishima", character: "Reina"),
        new Move(name: "EWGF", notation: "EWGF", type: "Mishima", character: "Reina"),
        new Move(name: "WGK", notation: "WGK", type: "Mishima", character: "Reina"),
        new Move(name: "EWGK", notation: "EWGK", type: "Mishima", character: "Reina"),

        // Shaheen
        new Move(name: "Stealth Step", notation: "Stealth Step", type: "character", character: "Shaheen"),

        // Steve
        new Move(name: "Quick Spin", notation: "Quick Spin", type: "character", character: "Steve"),
        new Move(name: "Ducking", notation: "Ducking", type: "character", character: "Steve"),
        new Move(name: "Peekaboo", notation: "Peekaboo", type: "character", character: "Steve"),
        new Move(name: "Ducking In", notation: "Ducking In", type: "character", character: "Steve"),
        new Move(name: "Ducking Left", notation: "Ducking Left", type: "character", character: "Steve"),
        new Move(name: "Ducking Right", notation: "Ducking Right", type: "character", character: "Steve"),
        new Move(name: "Flicker Stance", notation: "Flicker Stance", type: "character", character: "Steve"),
        new Move(name: "Swaying", notation: "Swaying", type: "character", character: "Steve"),
        new Move(name: "Lion Heart", notation: "Lion Heart", type: "character", character: "Steve"),

        // Victor
        new Move(name: "Iai", notation: "Iai", type: "character", character: "Victor"),
        new Move(name: "Perfumer", notation: "Perfumer", type: "character", character: "Victor"),

        // Xiaoyu
        new Move(name: "Phoenix", notation: "Phoenix", type: "character", character: "Xiaoyu"),
        new Move(name: "Hypnotist", notation: "Hypnotist", type: "character", character: "Xiaoyu"),

        // Yoshimitsu
        new Move(name: "Kincho", notation: "Kincho", type: "character", character: "Yoshimitsu"),
        new Move(name: "Mutou No Kiwami", notation: "Mutou No Kiwami", type: "character", character: "Yoshimitsu"),
        new Move(name: "Manji Dragonfly", notation: "Manji Dragonfly", type: "character", character: "Yoshimitsu"),
        new Move(name: "Flea", notation: "Flea", type: "character", character: "Yoshimitsu"),
        new Move(name: "Indian Stance", notation: "Indian Stance", type: "character", character: "Yoshimitsu"),

        // Zafina
        new Move(name: "Tarantula", notation: "Tarantula", type: "character", character: "Zafina"),
        new Move(name: "Scarecrow", notation: "Scarecrow", type: "character", character: "Zafina"),
        new Move(name: "Mantis", notation: "Mantis", type: "character", character: "Zafina")
    ];
}