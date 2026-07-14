using FightingFlowDotNet.Models;
using FightingFlowDotNet.Models.Enums;

namespace FightingFlowDotNet.Resources;

public static class StreetFighter6
{
    public static readonly List<Fighter> Fighters =
    [
        new Fighter { Name = "A.K.I.", ImageId = "aki", FightingStyle = "Snake Kung Fu", Game = "Street Fighter 6", CombosById = [] },
        new Fighter { Name = "Akuma", ImageId = "akuma", FightingStyle = " Satsui no Hado, Ansatsuken", Game = "Street Fighter 6", CombosById = [] },
        new Fighter { Name = "Blanka", ImageId = "blanka", FightingStyle = "Feral movement, electric attacks", Game = "Street Fighter 6", CombosById = [] },
        new Fighter { Name = "Cammy", ImageId = "cammy", FightingStyle = "Shadaloo fighting techniques (Shadaloo)Special Forces training (Delta Red)", Game = "Street Fighter 6", CombosById = [] },
        new Fighter { Name = "Chun-Li", ImageId = "chunli", FightingStyle = "Chinese martial arts/Kung Fu and Tai Chi", Game = "Street Fighter 6", CombosById = [] },
        new Fighter { Name = "Dee Jay", ImageId = "deejay", FightingStyle = "Kickboxing and break dancing", Game = "Street Fighter 6", CombosById = [] },
        new Fighter { Name = "Dhalsim", ImageId = "dhalsim", FightingStyle = "Esoteric Yoga", Game = "Street Fighter 6", CombosById = [] },
        new Fighter { Name = "E. Honda", ImageId = "ehonda", FightingStyle = "Sumo Wrestler Chef", Game = "Street Fighter 6", CombosById = [] },
        new Fighter { Name = "Ed", ImageId = "ed", FightingStyle = "Psycho Boxing", Game = "Street Fighter 6", CombosById = [] },
        new Fighter { Name = "Elena", ImageId = "elena", FightingStyle = "Capoeira Master", Game = "Street Fighter 6", CombosById = [] },
        new Fighter { Name = "Guile", ImageId = "guile", FightingStyle = "Martial arts and professional wrestling", Game = "Street Fighter 6", CombosById = [] },
        new Fighter { Name = "Jamie", ImageId = "jamie", FightingStyle = "Zui Quan (Drunken Fist) & Breakdancing", Game = "Street Fighter 6", CombosById = [] },
        new Fighter { Name = "JP", ImageId = "jp", FightingStyle = "Bartitsu & Psycho Power", Game = "Street Fighter 6 6", CombosById = [] },
        new Fighter { Name = "Juri", ImageId = "juri", FightingStyle = "Taekwondo, ki attacks", Game = "Street Fighter 6", CombosById = [] },
        new Fighter { Name = "Ken", ImageId = "ken", FightingStyle = "Karate based martial arts, Ansatsuken", Game = "Street Fighter 6", CombosById = [] },
        new Fighter { Name = "Kimberly", ImageId = "kimberly", FightingStyle = "Bushin-ryu Ninjutsu", Game = "Street Fighter 6", CombosById = [] },
        new Fighter { Name = "Lily", ImageId = "lily", FightingStyle = "Thunderfoot Martial Arts", Game = "Street Fighter 6", CombosById = [] },
        new Fighter { Name = "Luke", ImageId = "luke", FightingStyle = "Military MMA", Game = "Street Fighter 6", CombosById = [] },
        new Fighter { Name = "M.Bison", ImageId = "m_bison", FightingStyle = "Psycho Power & Lerdrit", Game = "Street Fighter 6", CombosById = [] },
        new Fighter { Name = "Mai", ImageId = "mai", FightingStyle = "Shiranui-ryuu Ninjitsu", Game = "Street Fighter 6", CombosById = [] },
        new Fighter { Name = "Manon", ImageId = "manon", FightingStyle = "Judo and ballet dancing", Game = "Street Fighter 6", CombosById = [] },
        new Fighter { Name = "Marisa", ImageId = "marisa", FightingStyle = "Pankration", Game = "Street Fighter 6", CombosById = [] },
        new Fighter { Name = "Rashid", ImageId = "rashid", FightingStyle = "Wind and parkour", Game = "Street Fighter 6", CombosById = [] },
        new Fighter { Name = "Ryu", ImageId = "ryu", FightingStyle = "Ansatsuken", Game = "Street Fighter 6", CombosById = [] },
        new Fighter { Name = "Sagat", ImageId = "sagat", FightingStyle = "Muay Thai", Game = "Street Fighter 6", CombosById = [] },
        new Fighter { Name = "Terry", ImageId = "terry_bogard", FightingStyle = "Martial arts and Hakkyokuseiken chi techniques", Game = "Street Fighter 6", CombosById = [] },
        new Fighter { Name = "Zangief", ImageId = "zangief", FightingStyle = "Mix of Russian and American pro wrestling", Game = "Street Fighter 6", CombosById = [] }
    ];

    public static readonly List<Move> Moves =
    [
        // Classic Inputs
        new Move(name: "lp", notation: "lp", type: "SF Classic", character: "Generic", game: "Street Fighter 6", sf6Type: Sf6Type.Classic),
        new Move(name: "mp", notation: "mp", type: "SF Classic", character: "Generic", game: "Street Fighter 6", sf6Type: Sf6Type.Classic),
        new Move(name: "hp", notation: "hp", type: "SF Classic", character: "Generic", game: "Street Fighter 6", sf6Type: Sf6Type.Classic),
        new Move(name: "lk", notation: "lk", type: "SF Classic", character: "Generic", game: "Street Fighter 6", sf6Type: Sf6Type.Classic),
        new Move(name: "mk", notation: "mk", type: "SF Classic", character: "Generic", game: "Street Fighter 6", sf6Type: Sf6Type.Classic),
        new Move(name: "hk", notation: "hk", type: "SF Classic", character: "Generic", game: "Street Fighter 6", sf6Type: Sf6Type.Classic),
        new Move(name: "p", notation: "p", type: "SF Classic", character: "Generic", game: "Street Fighter 6", sf6Type: Sf6Type.Classic),
        new Move(name: "k", notation: "k", type: "SF Classic", character: "Generic", game: "Street Fighter 6", sf6Type: Sf6Type.Classic),
        new Move(name: "pp", notation: "pp", type: "SF Classic", character: "Generic", game: "Street Fighter 6", sf6Type: Sf6Type.Classic),
        new Move(name: "kk", notation: "kk", type: "SF Classic", character: "Generic", game: "Street Fighter 6", sf6Type: Sf6Type.Classic),
        new Move(name: "ppp", notation: "ppp", type: "SF Classic", character: "Generic", game: "Street Fighter 6", sf6Type: Sf6Type.Classic),
        new Move(name: "kkk", notation: "kkk", type: "SF Classic", character: "Generic", game: "Street Fighter 6", sf6Type: Sf6Type.Classic),

        // Modern Inputs
        new Move(name: "light", notation: "light", type: "SF Modern", character: "Generic", game: "Street Fighter 6", sf6Type: Sf6Type.Modern),
        new Move(name: "medium", notation: "medium", type: "SF Modern", character: "Generic", game: "Street Fighter 6", sf6Type: Sf6Type.Modern),
        new Move(name: "heavy", notation: "heavy", type: "SF Modern", character: "Generic", game: "Street Fighter 6", sf6Type: Sf6Type.Modern),
        new Move(name: "special", notation: "special", type: "SF Modern", character: "Generic", game: "Street Fighter 6", sf6Type: Sf6Type.Modern),
        new Move(name: "Auto", notation: "auto", type: "Mechanic", character: "Generic", game: "Street Fighter 6", sf6Type: Sf6Type.Modern),

        // Mechanics
        new Move(name: "Taunt", notation: "taunt", type: "Mechanic", character: "Generic", game: "Street Fighter 6"),
        new Move(name: "Throw", notation: "throw", type: "Mechanic", character: "Generic", game: "Street Fighter 6"),
        new Move(name: "DI", notation: "DI", type: "Mechanic", character: "Generic", game: "Street Fighter 6"),
        new Move(name: "Parry", notation: "Parry", type: "Mechanic", character: "Generic", game: "Street Fighter 6"),
        new Move(name: "DR", notation: "DR", type: "Mechanic", character: "Generic", game: "Street Fighter 6"),
        new Move(name: "DRC", notation: "DRC", type: "Mechanic", character: "Generic", game: "Street Fighter 6"),
        new Move(name: "DP", notation: "DP", type: "Mechanic", character: "Generic", game: "Street Fighter 6"),
        new Move(name: "OD", notation: "OD", type: "Mechanic", character: "Generic", game: "Street Fighter 6"),
        new Move(name: "Air", notation: "Air", type: "Mechanic", character: "Generic", game: "Street Fighter 6"),
        new Move(name: "Wall Bounce", notation: "WB", type: "Mechanic", character: "Generic", game: "Street Fighter 6"),

        // Stage
        new Move(name: "Wall Bounce", notation: "w/bounce", type: "Stage", character: "Generic", game: "Street Fighter 6"),

        // Movements
        new Move(name: "qcf", notation: "qcf", type: "Movement", character: "Generic", game: "Street Fighter 6"),
        new Move(name: "qcb", notation: "qcb", type: "Movement", character: "Generic", game: "Street Fighter 6"),
        new Move(name: "hcf", notation: "hcf", type: "Movement", character: "Generic", game: "Street Fighter 6"),
        new Move(name: "hcb", notation: "bd", type: "Movement", character: "Generic", game: "Street Fighter 6"),
        new Move(name: "fc", notation: "fc", type: "Movement", character: "Generic", game: "Street Fighter 6"),
        new Move(name: "dp", notation: "dp", type: "Movement", character: "Generic", game: "Street Fighter 6"),
        // A.K.I.
        new Move(name: "Nightshade Pulse", notation: "Nightshade Pulse", type: "Special", character: "A.K.I.", game: "Street Fighter 6"),
        new Move(name: "Orchid Spring", notation: "Orchid Spring", type: "Special", character: "A.K.I.", game: "Street Fighter 6"),
        new Move(name: "Toxic Wreath", notation: "Toxic Wreath", type: "Special", character: "A.K.I.", game: "Street Fighter 6"),
        new Move(name: "Serpent Lash", notation: "Serpent Lash", type: "Special", character: "A.K.I.", game: "Street Fighter 6"),
        new Move(name: "Cruel Fate", notation: "Cruel Fate", type: "Special", character: "A.K.I.", game: "Street Fighter 6"),
        new Move(name: "Snake Step", notation: "Snake Step", type: "Special", character: "A.K.I.", game: "Street Fighter 6"),
        new Move(name: "Sinister Slide", notation: "Sinister Slide", type: "Special", character: "A.K.I.", game: "Street Fighter 6"),
        new Move(name: "Deadly Implication", notation: "Deadly Implication", type: "Super Art", character: "A.K.I.", game: "Street Fighter 6"),
        new Move(name: "Tainted Talons", notation: "Tainted Talons", type: "Super Art", character: "A.K.I.", game: "Street Fighter 6"),
        new Move(name: "Claws of Ya Zi", notation: "Claws of Ya Zi", type: "Super Art", character: "A.K.I.", game: "Street Fighter 6"),

        // Akuma
        new Move(name: "Gou Hadoken", notation: "Gou Hadoken", type: "Special", character: "Akuma", game: "Street Fighter 6"),
        new Move(name: "Zanku Hadoken", notation: "Zanku Hadoken", type: "Special", character: "Akuma", game: "Street Fighter 6"),
        new Move(name: "Gou Shoryuken", notation: "Gou Shoryuken", type: "Special", character: "Akuma", game: "Street Fighter 6"),
        new Move(name: "Tatsumaki Zanku-kyaku", notation: "Tatsumaki Zanku-kyaku", type: "Special", character: "Akuma", game: "Street Fighter 6"),
        new Move(name: "Adamant Flame", notation: "Adamant Flame", type: "Special", character: "Akuma", game: "Street Fighter 6"),
        new Move(name: "Demon Raid", notation: "Demon Raid", type: "Special", character: "Akuma", game: "Street Fighter 6"),
        new Move(name: "Ashura Senku", notation: "Ashura Senku", type: "Special", character: "Akuma", game: "Street Fighter 6"),
        new Move(name: "Orobo Throw", notation: "Orobo Throw", type: "Special", character: "Akuma", game: "Street Fighter 6"),
        new Move(name: "Messatsu Gohado", notation: "Messatsu Gohado", type: "Super Art", character: "Akuma", game: "Street Fighter 6"),
        new Move(name: "Tenma Gozanku", notation: "Tenma Gozanku", type: "Super Art", character: "Akuma", game: "Street Fighter 6"),
        new Move(name: "Empyrean's End", notation: "Empyrean's End", type: "Super Art", character: "Akuma", game: "Street Fighter 6"),
        new Move(name: "Sip of Calamity", notation: "Sip of Calamity", type: "Super Art", character: "Akuma", game: "Street Fighter 6"),
        new Move(name: "Shun Goku Satsu", notation: "Shun Goku Satsu", type: "Super Art", character: "Akuma", game: "Street Fighter 6"),

        // Blanka
        new Move(name: "Electric Thunder", notation: "Electric Thunder", type: "Special", character: "Blanka", game: "Street Fighter 6"),
        new Move(name: "Rolling Attack", notation: "Rolling Attack", type: "Special", character: "Blanka", game: "Street Fighter 6"),
        new Move(name: "Vertical Rolling Attack", notation: "Vertical Rolling Attack", type: "Special", character: "Blanka", game: "Street Fighter 6"),
        new Move(name: "Backstep Rolling Attack", notation: "Backstep Rolling Attack", type: "Special", character: "Blanka", game: "Street Fighter 6"),
        new Move(name: "Wild Hunt", notation: "Wild Hunt", type: "Special", character: "Blanka", game: "Street Fighter 6"),
        new Move(name: "Blanka-chan Bomb", notation: "Blanka-chan Bomb", type: "Special", character: "Blanka", game: "Street Fighter 6"),
        new Move(name: "Shout of Earth", notation: "Shout of Earth", type: "Super Art", character: "Blanka", game: "Street Fighter 6"),
        new Move(name: "Lightning Beast", notation: "Lightning Beast", type: "Super Art", character: "Blanka", game: "Street Fighter 6"),
        new Move(name: "Ground Shave Cannonball", notation: "Ground Shave Cannonball", type: "Super Art", character: "Blanka", game: "Street Fighter 6"),

        // Cammy
        new Move(name: "Spiral Arrow", notation: "Spiral Arrow", type: "Special", character: "Cammy", game: "Street Fighter 6"),
        new Move(name: "Cannon Spike", notation: "Cannon Spike", type: "Special", character: "Cammy", game: "Street Fighter 6"),
        new Move(name: "Quick Spin Knuckle", notation: "Quick Spin Knuckle", type: "Special", character: "Cammy", game: "Street Fighter 6"),
        new Move(name: "Cannon Strike", notation: "Cannon Strike", type: "Special", character: "Cammy", game: "Street Fighter 6"),
        new Move(name: "Hooligan Combination", notation: "Hooligan Combination", type: "Special", character: "Cammy", game: "Street Fighter 6"),
        new Move(name: "Spin Drive Smasher", notation: "Spin Drive Smasher", type: "Super Art", character: "Cammy", game: "Street Fighter 6"),
        new Move(name: "Killer Bee Spin", notation: "Killer Bee Spin", type: "Super Art", character: "Cammy", game: "Street Fighter 6"),
        new Move(name: "Delta Red Assault", notation: "Delta Red Assault", type: "Super Art", character: "Cammy", game: "Street Fighter 6"),

        // Chun-Li
        new Move(name: "Kikoken", notation: "Kikoken", type: "Special", character: "Chun-Li", game: "Street Fighter 6"),
        new Move(name: "Hundred Lightning Kicks", notation: "Hundred Lightning Kicks", type: "Special", character: "Chun-Li", game: "Street Fighter 6"),
        new Move(name: "Spinning Bird Kick", notation: "Spinning Bird Kick", type: "Special", character: "Chun-Li", game: "Street Fighter 6"),
        new Move(name: "Hazanshu", notation: "Hazanshu", type: "Special", character: "Chun-Li", game: "Street Fighter 6"),
        new Move(name: "Tensho Kicks", notation: "Tensho Kicks", type: "Special", character: "Chun-Li", game: "Street Fighter 6"),
        new Move(name: "Kikosho", notation: "Kikosho", type: "Super Art", character: "Chun-Li", game: "Street Fighter 6"),
        new Move(name: "Hoyoku-sen", notation: "Hoyoku-sen", type: "Super Art", character: "Chun-Li", game: "Street Fighter 6"),
        new Move(name: "Soten Ranka", notation: "Soten Ranka", type: "Super Art", character: "Chun-Li", game: "Street Fighter 6"),

        // Dee Jay
        new Move(name: "Air Slasher", notation: "Air Slasher", type: "Special", character: "Dee Jay", game: "Street Fighter 6"),
        new Move(name: "Jackknife Maximum", notation: "Jackknife Maximum", type: "Special", character: "Dee Jay", game: "Street Fighter 6"),
        new Move(name: "Roll Through Feint", notation: "Roll Through Feint", type: "Special", character: "Dee Jay", game: "Street Fighter 6"),
        new Move(name: "Quick Rolling Sobat", notation: "Quick Rolling Sobat", type: "Special", character: "Dee Jay", game: "Street Fighter 6"),
        new Move(name: "Double Rolling Sobat", notation: "Double Rolling Sobat", type: "Special", character: "Dee Jay", game: "Street Fighter 6"),
        new Move(name: "Machine Gun Uppercut", notation: "Machine Gun Uppercut", type: "Special", character: "Dee Jay", game: "Street Fighter 6"),
        new Move(name: "Jus Cool", notation: "Jus Cool", type: "Special", character: "Dee Jay", game: "Street Fighter 6"),
        new Move(name: "The Greatest Sobat", notation: "The Greatest Sobat", type: "Super Art", character: "Dee Jay", game: "Street Fighter 6"),
        new Move(name: "Lowkey Sunrise Festival", notation: "Lowkey Sunrise Festival", type: "Super Art", character: "Dee Jay", game: "Street Fighter 6"),
        new Move(name: "Marvelous Sunrise Festival", notation: "Marvelous Sunrise Festival", type: "Super Art", character: "Dee Jay", game: "Street Fighter 6"),
        new Move(name: "Headliner Sunrise Festival", notation: "Headliner Sunrise Festival", type: "Super Art", character: "Dee Jay", game: "Street Fighter 6"),
        new Move(name: "Weekend Pleasure", notation: "Weekend Pleasure", type: "Super Art", character: "Dee Jay", game: "Street Fighter 6"),

        // Dhalsim
        new Move(name: "Yoga Fire", notation: "Yoga Fire", type: "Special", character: "Dhalsim", game: "Street Fighter 6"),
        new Move(name: "Yoga Arch", notation: "Yoga Arch", type: "Special", character: "Dhalsim", game: "Street Fighter 6"),
        new Move(name: "Yoga Flame", notation: "Yoga Flame", type: "Special", character: "Dhalsim", game: "Street Fighter 6"),
        new Move(name: "Yoga Blast", notation: "Yoga Blast", type: "Special", character: "Dhalsim", game: "Street Fighter 6"),
        new Move(name: "Yoga Comet", notation: "Yoga Comet", type: "Special", character: "Dhalsim", game: "Street Fighter 6"),
        new Move(name: "Yoga Float", notation: "Yoga Float", type: "Special", character: "Dhalsim", game: "Street Fighter 6"),
        new Move(name: "Yoga Teleport", notation: "Yoga Teleport", type: "Special", character: "Dhalsim", game: "Street Fighter 6"),
        new Move(name: "Yoga Inferno", notation: "Yoga Inferno", type: "Super Art", character: "Dhalsim", game: "Street Fighter 6"),
        new Move(name: "Yoga Sunburst", notation: "Yoga Sunburst", type: "Super Art", character: "Dhalsim", game: "Street Fighter 6"),
        new Move(name: "Merciless Yoga", notation: "Merciless Yoga", type: "Super Art", character: "Dhalsim", game: "Street Fighter 6"),

        // Ed
        new Move(name: "Psycho Spark", notation: "Psycho Spark", type: "Special", character: "Ed", game: "Street Fighter 6"),
        new Move(name: "Psycho Uppercut", notation: "Psycho Uppercut", type: "Special", character: "Ed", game: "Street Fighter 6"),
        new Move(name: "Psycho Blitz", notation: "Psycho Blitz", type: "Special", character: "Ed", game: "Street Fighter 6"),
        new Move(name: "Psycho Flicker", notation: "Psycho Flicker", type: "Special", character: "Ed", game: "Street Fighter 6"),
        new Move(name: "Kill Rush", notation: "Kill Rush", type: "Special", character: "Ed", game: "Street Fighter 6"),
        new Move(name: "Psycho Storm", notation: "Psycho Storm", type: "Super Art", character: "Ed", game: "Street Fighter 6"),
        new Move(name: "Psycho Cannon", notation: "Psycho Cannon", type: "Super Art", character: "Ed", game: "Street Fighter 6"),
        new Move(name: "Psycho Chamber", notation: "Psycho Chamber", type: "Super Art", character: "Ed", game: "Street Fighter 6"),

        // Elena
        new Move(name: "Scratch Wheel", notation: "Scratch Wheel", type: "Special", character: "Elena", game: "Street Fighter 6"),
        new Move(name: "Mallet Smash", notation: "Mallet Smash", type: "Special", character: "Elena", game: "Street Fighter 6"),
        new Move(name: "Spin Scythe", notation: "Spin Scythe", type: "Special", character: "Elena", game: "Street Fighter 6"),
        new Move(name: "Healing", notation: "Healing", type: "Special", character: "Elena", game: "Street Fighter 6"),
        new Move(name: "Healing Wind", notation: "Healing Wind", type: "Super Art", character: "Elena", game: "Street Fighter 6"),
        new Move(name: "Brave Dance", notation: "Brave Dance", type: "Super Art", character: "Elena", game: "Street Fighter 6"),
        new Move(name: "Skyward Dance", notation: "Skyward Dance", type: "Super Art", character: "Elena", game: "Street Fighter 6"),

        // E. Honda
        new Move(name: "Hundred Hand Slap", notation: "Hundred Hand Slap", type: "Special", character: "E. Honda", game: "Street Fighter 6"),
        new Move(name: "Sumo Headbutt", notation: "Sumo Headbutt", type: "Special", character: "E. Honda", game: "Street Fighter 6"),
        new Move(name: "Sumo Smash", notation: "Sumo Smash", type: "Special", character: "E. Honda", game: "Street Fighter 6"),
        new Move(name: "Oicho Throw", notation: "Oicho Throw", type: "Special", character: "E. Honda", game: "Street Fighter 6"),
        new Move(name: "Sumo Dash", notation: "Sumo Dash", type: "Special", character: "E. Honda", game: "Street Fighter 6"),
        new Move(name: "Neko Damashi", notation: "Neko Damashi", type: "Special", character: "E. Honda", game: "Street Fighter 6"),
        new Move(name: "Sumo Spirit", notation: "Sumo Spirit", type: "Special", character: "E. Honda", game: "Street Fighter 6"),
        new Move(name: "Show of Force", notation: "Show of Force", type: "Super Art", character: "E. Honda", game: "Street Fighter 6"),
        new Move(name: "Ultimate Killer Head Ram", notation: "Ultimate Killer Head Ram", type: "Super Art", character: "E. Honda", game: "Street Fighter 6"),
        new Move(name: "The Final Bout", notation: "The Final Bout", type: "Super Art", character: "E. Honda", game: "Street Fighter 6"),

        // Guile
        new Move(name: "Sonic Boom", notation: "Sonic Boom", type: "Special", character: "Guile", game: "Street Fighter 6"),
        new Move(name: "Somersault Kick", notation: "Somersault Kick", type: "Special", character: "Guile", game: "Street Fighter 6"),
        new Move(name: "Sonic Blade", notation: "h+u|d p", type: "Special", character: "Guile", game: "Street Fighter 6"),
        new Move(name: "Sonic Break", notation: "Sonic Break", type: "Special", character: "Guile", game: "Street Fighter 6"),
        new Move(name: "Sonic Hurricane", notation: "Sonic Hurricane", type: "Super Art", character: "Guile", game: "Street Fighter 6"),
        new Move(name: "Solid Puncher", notation: "Solid Puncher", type: "Super Art", character: "Guile", game: "Street Fighter 6"),
        new Move(name: "Crossfire Somersault", notation: "Crossfire Somersault", type: "Super Art", character: "Guile", game: "Street Fighter 6"),

        // Jamie
        new Move(name: "The De6l Inside", notation: "The De6l Inside", type: "Special", character: "Jamie", game: "Street Fighter 6"),
        new Move(name: "Freeflow Strikes", notation: "Freeflow Strikes", type: "Special", character: "Jamie", game: "Street Fighter 6"),
        new Move(name: "Freeflow Kicks", notation: "Freeflow Kicks", type: "Special", character: "Jamie", game: "Street Fighter 6"),
        new Move(name: "Swagger Step", notation: "Swagger Step", type: "Special", character: "Jamie", game: "Street Fighter 6"),
        new Move(name: "Arrow Kick", notation: "Arrow Kick", type: "Special", character: "Jamie", game: "Street Fighter 6"),
        new Move(name: "Luminous Dive Kick", notation: "Luminous Dive Kick", type: "Special", character: "Jamie", game: "Street Fighter 6"),
        new Move(name: "Bakkai", notation: "Bakkai", type: "Special", character: "Jamie", game: "Street Fighter 6"),
        new Move(name: "Tenshin", notation: "Tenshin", type: "Special", character: "Jamie", game: "Street Fighter 6"),
        new Move(name: "Breakin'", notation: "Breakin", type: "Super Art", character: "Jamie", game: "Street Fighter 6"),
        new Move(name: "The De6l's Song", notation: "The De6l's Song", type: "Super Art", character: "Jamie", game: "Street Fighter 6"),
        new Move(name: "Getsuga Saiho", notation: "Getsuga Saiho", type: "Super Art", character: "Jamie", game: "Street Fighter 6"),

        // JP
        new Move(name: "Triglav", notation: "Triglav", type: "Special", character: "JP", game: "Street Fighter 6"),
        new Move(name: "Departure", notation: "Departure", type: "Special", character: "JP", game: "Street Fighter 6"),
        new Move(name: "Stribog", notation: "Stribog", type: "Special", character: "JP", game: "Street Fighter 6"),
        new Move(name: "Torbalan", notation: "Torbalan", type: "Special", character: "JP", game: "Street Fighter 6"),
        new Move(name: "Amnesia", notation: "Amnesia", type: "Special", character: "JP", game: "Street Fighter 6"),
        new Move(name: "Torbalan", notation: "Torbalan", type: "Special", character: "JP", game: "Street Fighter 6"),
        new Move(name: "Embrace", notation: "Embrace", type: "Special", character: "JP", game: "Street Fighter 6"),
        new Move(name: "Chornobog", notation: "Chornobog", type: "Super Art", character: "JP", game: "Street Fighter 6"),
        new Move(name: "Lovushka", notation: "Lovushka", type: "Super Art", character: "JP", game: "Street Fighter 6"),
        new Move(name: "Interdiction", notation: "Interdiction", type: "Super Art", character: "JP", game: "Street Fighter 6"),

        // Juri
        new Move(name: "Fuhajin", notation: "Fuhajin", type: "Special", character: "Juri", game: "Street Fighter 6"),
        new Move(name: "Saihasho", notation: "Saihasho", type: "Special", character: "Juri", game: "Street Fighter 6"),
        new Move(name: "Ankensatsu", notation: "Ankensatsu", type: "Special", character: "Juri", game: "Street Fighter 6"),
        new Move(name: "Go Ohsatsu", notation: "Go Ohsatsu", type: "Special", character: "Juri", game: "Street Fighter 6"),
        new Move(name: "Tensesnrin", notation: "Tensesnrin", type: "Special", character: "Juri", game: "Street Fighter 6"),
        new Move(name: "Shiku-sen", notation: "Shiku-sen", type: "Special", character: "Juri", game: "Street Fighter 6"),
        new Move(name: "Sakkai Fuhazan", notation: "Sakkai Fuhazan", type: "Super Art", character: "Juri", game: "Street Fighter 6"),
        new Move(name: "Feng Shui Engine", notation: "Feng Shui Engine", type: "Super Art", character: "Juri", game: "Street Fighter 6"),
        new Move(name: "Kaisen Dankai Raku", notation: "Kaisen Dankai Raku", type: "Super Art", character: "Juri", game: "Street Fighter 6"),

        // Ken
        new Move(name: "Hadoken", notation: "Hadoken", type: "Special", character: "Ken", game: "Street Fighter 6"),
        new Move(name: "Shoryuken", notation: "Shoryuken", type: "Special", character: "Ken", game: "Street Fighter 6"),
        new Move(name: "Tatsumaki Senpu-kyaku", notation: "Tatsumaki Senpu-kyaku", type: "Special", character: "Ken", game: "Street Fighter 6"),
        new Move(name: "Dragonlash Kick", notation: "Dragonlash Kick", type: "Special", character: "Ken", game: "Street Fighter 6"),
        new Move(name: "Jinrai Kick", notation: "Jinrai Kick", type: "Special", character: "Ken", game: "Street Fighter 6"),
        new Move(name: "Kasai Thrust Kick", notation: "Kasai Thrust Kick", type: "Special", character: "Ken", game: "Street Fighter 6"),
        new Move(name: "Dragonlash Flame", notation: "Dragonlash Flame", type: "Super Art", character: "Ken", game: "Street Fighter 6"),
        new Move(name: "Shippu Jinrai-kyaku", notation: "Shippu Jinrai-kyaku", type: "Super Art", character: "Ken", game: "Street Fighter 6"),
        new Move(name: "Shinryu Reppa", notation: "Shinryu Reppa", type: "Super Art", character: "Ken", game: "Street Fighter 6"),

        // Kimberly
        new Move(name: "Bushin Senpukyaku", notation: "Bushin Senpukyaku", type: "Special", character: "Kimberly", game: "Street Fighter 6"),
        new Move(name: "Sprint", notation: "Sprint", type: "Special", character: "Kimberly", game: "Street Fighter 6"),
        new Move(name: "Vagabond Edge", notation: "Vagabond Edge", type: "Special", character: "Kimberly", game: "Street Fighter 6"),
        new Move(name: "Hidden Variable", notation: "Hidden Variable", type: "Special", character: "Kimberly", game: "Street Fighter 6"),
        new Move(name: "Genius at Play", notation: "Genius at Play", type: "Special", character: "Kimberly", game: "Street Fighter 6"),
        new Move(name: "Nue Twister", notation: "Nue Twister", type: "Special", character: "Kimberly", game: "Street Fighter 6"),
        new Move(name: "Bushin Beats", notation: "Bushin Beats", type: "Super Art", character: "Kimberly", game: "Street Fighter 6"),
        new Move(name: "Bushin Scramble", notation: "Bushin Scramble", type: "Super Art", character: "Kimberly", game: "Street Fighter 6"),
        new Move(name: "Bushin Ninjastar Cypher ", notation: "Bushin Ninjastar Cypher", type: "Super Art", character: "Kimberly", game: "Street Fighter 6"),

        // Lily
        new Move(name: "Condor Wind", notation: "Condor Wind", type: "Special", character: "Lily", game: "Street Fighter 6"),
        new Move(name: "Condor Spire", notation: "Condor Spire", type: "Special", character: "Lily", game: "Street Fighter 6"),
        new Move(name: "Tomahawk Buster", notation: "Tomahawk Buster", type: "Special", character: "Lily", game: "Street Fighter 6"),
        new Move(name: "Condor Dive", notation: "Condor Dive", type: "Special", character: "Lily", game: "Street Fighter 6"),
        new Move(name: "Mexican Typhoon", notation: "Mexican Typhoon", type: "Special", character: "Lily", game: "Street Fighter 6"),
        new Move(name: "Breezing Hawk", notation: "Breezing Hawk", type: "Super Art", character: "Lily", game: "Street Fighter 6"),
        new Move(name: "Thunderbird", notation: "Thunderbird", type: "Super Art", character: "Lily", game: "Street Fighter 6"),
        new Move(name: "Raging Typhoon", notation: "Raging Typhoon", type: "Super Art", character: "Lily", game: "Street Fighter 6"),

        // Luke
        new Move(name: "Sand Blast", notation: "Sand Blast", type: "Special", character: "Luke", game: "Street Fighter 6"),
        new Move(name: "Flash Knuckle", notation: "Flash Knuckle", type: "Special", character: "Luke", game: "Street Fighter 6"),
        new Move(name: "Avenger", notation: "Avenger", type: "Special", character: "Luke", game: "Street Fighter 6"),
        new Move(name: "Rising Uppercut", notation: "Rising Uppercut", type: "Special", character: "Luke", game: "Street Fighter 6"),
        new Move(name: "Vulcan Blast", notation: "Vulcan Blast", type: "Super Art", character: "Luke", game: "Street Fighter 6"),
        new Move(name: "Eraser", notation: "Eraser", type: "Super Art", character: "Luke", game: "Street Fighter 6"),
        new Move(name: "Pale Rider", notation: "Pale Rider", type: "Super Art", character: "Luke", game: "Street Fighter 6"),

        // Mai
        new Move(name: "Kachousen", notation: "Kachousen", type: "Special", character: "Mai", game: "Street Fighter 6"),
        new Move(name: "Ryuuenbu", notation: "Ryuuenbu", type: "Special", character: "Mai", game: "Street Fighter 6"),
        new Move(name: "Hissatsu Shinobi Bachi", notation: "Hissatsu Shinobi Bachi", type: "Special", character: "Mai", game: "Street Fighter 6"),
        new Move(name: "Hishou Ryuuenjin", notation: "Hishou Ryuuenjin", type: "Special", character: "Mai", game: "Street Fighter 6"),
        new Move(name: "Musasabi no Mai", notation: "Musasabi no Mai", type: "Special", character: "Mai", game: "Street Fighter 6"),
        new Move(name: "Kagreou no Mai", notation: "Kagreou no Mai", type: "Super Art", character: "Mai", game: "Street Fighter 6"),
        new Move(name: "Chou Hissatsu Shinobi Bachi", notation: "Chou Hissatsu Shinobi Bachi", type: "Super Art", character: "Mai", game: "Street Fighter 6"),
        new Move(name: "Enbu Ada Zakura", notation: "Enbu Ada Zakura", type: "Super Art", character: "Mai", game: "Street Fighter 6"),

        // Manon
        new Move(name: "Manegé Doré", notation: "Manegé Doré", type: "Special", character: "Manon", game: "Street Fighter 6"),
        new Move(name: "Dégagé", notation: "Dégagé", type: "Special", character: "Manon", game: "Street Fighter 6"),
        new Move(name: "Renversé", notation: "Renversé", type: "Special", character: "Manon", game: "Street Fighter 6"),
        new Move(name: "Rond-Point", notation: "Rond-Point", type: "Special", character: "Manon", game: "Street Fighter 6"),
        new Move(name: "Arabesque", notation: "Arabesque", type: "Super Art", character: "Manon", game: "Street Fighter 6"),
        new Move(name: "Étoile", notation: "Étoile", type: "Super Art", character: "Manon", game: "Street Fighter 6"),
        new Move(name: "Pas de Deux", notation: "Pas de Deux", type: "Super Art", character: "Manon", game: "Street Fighter 6"),

        // Marisa
        new Move(name: "Gladius", notation: "Gladius", type: "Special", character: "Marisa", game: "Street Fighter 6"),
        new Move(name: "Scutum", notation: "Scutum", type: "Special", character: "Marisa", game: "Street Fighter 6"),
        new Move(name: "Phalanx", notation: "Phalanx", type: "Special", character: "Marisa", game: "Street Fighter 6"),
        new Move(name: "Dimachearus", notation: "Dimachearus", type: "Special", character: "Marisa", game: "Street Fighter 6"),
        new Move(name: "Quadriga", notation: "Quadriga", type: "Special", character: "Marisa", game: "Street Fighter 6"),
        new Move(name: "Javelin of Marisa", notation: "Javelin of Marisa", type: "Super Art", character: "Marisa", game: "Street Fighter 6"),
        new Move(name: "Meteorite", notation: "Meteorite", type: "Super Art", character: "Marisa", game: "Street Fighter 6"),
        new Move(name: "Godess of the Hunt", notation: "Godess of the Hunt", type: "Super Art", character: "Marisa", game: "Street Fighter 6"),

        // M. Bison
        new Move(name: "Psycho Crusher Attack", notation: "Psycho Crusher Attack", type: "Special", character: "M. Bison", game: "Street Fighter 6"),
        new Move(name: "Double Knee Press", notation: "Double Knee Press", type: "Special", character: "M. Bison", game: "Street Fighter 6"),
        new Move(name: "Backfist Combo", notation: "Backfist Combo", type: "Special", character: "M. Bison", game: "Street Fighter 6"),
        new Move(name: "Shadow Rise", notation: "Shadow Rise", type: "Special", character: "M. Bison", game: "Street Fighter 6"),
        new Move(name: "Knee Press Nightmare", notation: "Knee Press Nightmare", type: "Super Art", character: "M. Bison", game: "Street Fighter 6"),
        new Move(name: "Psycho Punisher", notation: "Psycho Punisher", type: "Super Art", character: "M. Bison", game: "Street Fighter 6"),
        new Move(name: "Ultimate Psycho Crusher", notation: "Ultimate Psycho Crusher", type: "Super Art", character: "M. Bison", game: "Street Fighter 6"),

        // Rashid
        new Move(name: "Spinning Mixer", notation: "Spinning Mixer", type: "Special", character: "Rashid", game: "Street Fighter 6"),
        new Move(name: "Eagle Spike", notation: "Eagle Spike", type: "Special", character: "Rashid", game: "Street Fighter 6"),
        new Move(name: "Whirlwind Shot", notation: "Whirlwind Shot", type: "Special", character: "Rashid", game: "Street Fighter 6"),
        new Move(name: "Arabian Cyclone", notation: "Arabian Cyclone", type: "Special", character: "Rashid", game: "Street Fighter 6"),
        new Move(name: "Arabian Skyhigh", notation: "Arabian Skyhigh", type: "Special", character: "Rashid", game: "Street Fighter 6"),
        new Move(name: "Super Rashid Kick", notation: "Super Rashid Kick", type: "Super Art", character: "Rashid", game: "Street Fighter 6"),
        new Move(name: "Ysar", notation: "Ysar", type: "Super Art", character: "Rashid", game: "Street Fighter 6"),
        new Move(name: "Altair", notation: "Altair", type: "Super Art", character: "Rashid", game: "Street Fighter 6"),

        // Ryu
        new Move(name: "Hadoken", notation: "Hadoken", type: "Special", character: "Ryu", game: "Street Fighter 6"),
        new Move(name: "Shoryuken", notation: "Shoryuken", type: "Special", character: "Ryu", game: "Street Fighter 6"),
        new Move(name: "Tatsumaki Senpu-kyaku", notation: "Tatsumaki Senpu-kyaku", type: "Special", character: "Ryu", game: "Street Fighter 6"),
        new Move(name: "High Blade Kick", notation: "High Blade Kick", type: "Special", character: "Ryu", game: "Street Fighter 6"),
        new Move(name: "Hashogeki", notation: "Hashogeki", type: "Special", character: "Ryu", game: "Street Fighter 6"),
        new Move(name: "Denjin Charge", notation: "Denjin Charge", type: "Special", character: "Ryu", game: "Street Fighter 6"),
        new Move(name: "Shinku Hadoken", notation: "Shinku Hadoken", type: "Super Art", character: "Ryu", game: "Street Fighter 6"),
        new Move(name: "Shin Hashogeki", notation: "Shin Hashogeki", type: "Super Art", character: "Ryu", game: "Street Fighter 6"),
        new Move(name: "Shin Shoryuken", notation: "Shin Shoryuken", type: "Super Art", character: "Ryu", game: "Street Fighter 6"),

        // Terry
        new Move(name: "Power Wave", notation: "Power Wave", type: "Special", character: "Terry", game: "Street Fighter 6"),
        new Move(name: "Round Wave", notation: "Round Wave", type: "Special", character: "Terry", game: "Street Fighter 6"),
        new Move(name: "Quick Burn", notation: "Quick Burn", type: "Special", character: "Terry", game: "Street Fighter 6"),
        new Move(name: "Power Charge", notation: "Power Charge", type: "Special", character: "Terry", game: "Street Fighter 6"),
        new Move(name: "Crack Shoot", notation: "Crack Shoot", type: "Special", character: "Terry", game: "Street Fighter 6"),
        new Move(name: "Rising Tackle", notation: "Rising Tackle", type: "Special", character: "Terry", game: "Street Fighter 6"),
        new Move(name: "Buster Wolf", notation: "Buster Wolf", type: "Super Art", character: "Terry", game: "Street Fighter 6"),
        new Move(name: "Power Geyser", notation: "Power Geyser", type: "Super Art", character: "Terry", game: "Street Fighter 6"),
        new Move(name: "Rising Fang", notation: "Rising Fang", type: "Super Art", character: "Terry", game: "Street Fighter 6"),

        // Zangief
        new Move(name: "Double Lariat", notation: "Double Lariat", type: "Special", character: "Zangief", game: "Street Fighter 6"),
        new Move(name: "Screw Piledriver", notation: "Screw Piledriver", type: "Special", character: "Zangief", game: "Street Fighter 6"),
        new Move(name: "Borscht Dynamite", notation: "Borscht Dynamite", type: "Special", character: "Zangief", game: "Street Fighter 6"),
        new Move(name: "Russian Suplex", notation: "Russian Suplex", type: "Special", character: "Zangief", game: "Street Fighter 6"),
        new Move(name: "Siberian Express", notation: "Siberian Express", type: "Special", character: "Zangief", game: "Street Fighter 6"),
        new Move(name: "Tundra Storm", notation: "Tundra Storm", type: "Special", character: "Zangief", game: "Street Fighter 6"),
        new Move(name: "Aerial Russian Slam", notation: "Aerial Russian Slam", type: "Super Art", character: "Zangief", game: "Street Fighter 6"),
        new Move(name: "Cyclone Lariat", notation: "Cyclone Lariat", type: "Super Art", character: "Zangief", game: "Street Fighter 6"),
        new Move(name: "Bolshoi Storm Buster", notation: "Bolshoi Storm Buster", type: "Super Art", character: "Zangief", game: "Street Fighter 6")
    ];
}