using System.Collections.Immutable;
using FightingFlowDotNet.Models;

namespace FightingFlowDotNet.Resources;

public static class MortalKombat1
{
    public static readonly List<Fighter> Fighters =
   [
        new Fighter { Name = "Ashrah", ImageId = "ashrah", FightingStyle = "Krabi-Krabong", Game = "Mortal Kombat 1", CombosById = [] },
        new Fighter { Name = "Baraka", ImageId = "baraka", FightingStyle = "Silat, Hung Gar", Game = "Mortal Kombat 1", CombosById = [] },
        new Fighter { Name = "Conan", ImageId = "conan", FightingStyle = "Barbarian", Game = "Mortal Kombat 1", CombosById = [] },
        new Fighter { Name = "Cyrax", ImageId = "cyrax", FightingStyle = "Tekunin", Game = "Mortal Kombat 1", CombosById = [] },
        new Fighter { Name = "Ermac", ImageId = "ermac", FightingStyle = "Telekinesis", Game = "Mortal Kombat 1", CombosById = [] },
        new Fighter { Name = "General Shao", ImageId = "generalshao", FightingStyle = "Axe Fighting", Game = "Mortal Kombat 1", CombosById = [] },
        new Fighter { Name = "Geras", ImageId = "geras", FightingStyle = "Temporal", Game = "Mortal Kombat 1", CombosById = [] },
        new Fighter { Name = "Ghostface", ImageId = "ghostface", FightingStyle = "Stealth", Game = "Mortal Kombat 1", CombosById = [] },
        new Fighter { Name = "Havik", ImageId = "havik", FightingStyle = "Agonizing Style", Game = "Mortal Kombat 1", CombosById = [] },
        new Fighter { Name = "Homelander", ImageId = "homelander", FightingStyle = "Viltrumite-like Abilities", Game = "Mortal Kombat 1", CombosById = [] },
        new Fighter { Name = "Johnny Cage", ImageId = "johnnycage", FightingStyle = "Jeet Kune Do, Shorin-Ryu Karate", Game = "Mortal Kombat 1", CombosById = [] },
        new Fighter { Name = "Kenshi", ImageId = "kenshi", FightingStyle = "Tai Chi Chuan", Game = "Mortal Kombat 1", CombosById = [] },
        new Fighter { Name = "Kitana", ImageId = "kitana", FightingStyle = "Eagle Claw, Ba Gua Zhang", Game = "Mortal Kombat 1", CombosById = [] },
        new Fighter { Name = "Kung Lao", ImageId = "kunglao", FightingStyle = "Shaolin Kung Fu, Wing Chun", Game = "Mortal Kombat 1", CombosById = [] },
        new Fighter { Name = "Li Mei", ImageId = "limei", FightingStyle = "Shuai Jiao, Lui He Ba Fa", Game = "Mortal Kombat 1", CombosById = [] },
        new Fighter { Name = "Liu Kang", ImageId = "liukang", FightingStyle = "Jun Fan Gung Fu, Pao Chui", Game = "Mortal Kombat 1", CombosById = [] },
        new Fighter { Name = "Mileena", ImageId = "mileena", FightingStyle = "Tarkatan Fighting Style", Game = "Mortal Kombat 1", CombosById = [] },
        new Fighter { Name = "Nitara", ImageId = "nitara", FightingStyle = "Vampire Fighting Style", Game = "Mortal Kombat 1", CombosById = [] },
        new Fighter { Name = "Noob Saibot", ImageId = "noobsaibot", FightingStyle = "Shadow", Game = "Mortal Kombat 1", CombosById = [] },
        new Fighter { Name = "Omni-Man", ImageId = "omniman", FightingStyle = "Viltrumite Martial Arts", Game = "Mortal Kombat 1", CombosById = [] },
        new Fighter { Name = "Peacemaker", ImageId = "peacemaker", FightingStyle = "Hand-to-Hand Combat, Firearms", Game = "Mortal Kombat 1", CombosById = [] },
        new Fighter { Name = "Quan Chi", ImageId = "quanchi", FightingStyle = "Netherealm Sorcery", Game = "Mortal Kombat 1", CombosById = [] },
        new Fighter { Name = "Raiden", ImageId = "raiden", FightingStyle = "Nan Chuan, Staff Fighting", Game = "Mortal Kombat 1", CombosById = [] },
        new Fighter { Name = "Rain", ImageId = "rain", FightingStyle = "Jeet Kune Do, Tae Kwon Do", Game = "Mortal Kombat 1", CombosById = [] },
        new Fighter { Name = "Reiko", ImageId = "reiko", FightingStyle = "Commando", Game = "Mortal Kombat 1", CombosById = [] },
        new Fighter { Name = "Reptile", ImageId = "reptile", FightingStyle = "Hung Gar, Lizard Style", Game = "Mortal Kombat 1", CombosById = [] },
        new Fighter { Name = "Scorpion", ImageId = "scorpion", FightingStyle = "Hapkido, Pi Gua Quan", Game = "Mortal Kombat 1", CombosById = [] },
        new Fighter { Name = "Sektor", ImageId = "sektor", FightingStyle = "Tekunin", Game = "Mortal Kombat 1", CombosById = [] },
        new Fighter { Name = "Shang Tsung", ImageId = "shangtsung", FightingStyle = "Snake Fist, Crane Style", Game = "Mortal Kombat 1", CombosById = [] },
        new Fighter { Name = "Sindel", ImageId = "sindel", FightingStyle = "Zha Quan", Game = "Mortal Kombat 1", CombosById = [] },
        new Fighter { Name = "Smoke", ImageId = "smoke", FightingStyle = "Mime", Game = "Mortal Kombat 1", CombosById = [] },
        new Fighter { Name = "Sub-Zero", ImageId = "subzero", FightingStyle = "Shotokan Karate, Cryomancy", Game = "Mortal Kombat 1", CombosById = [] },
        new Fighter { Name = "Takeda", ImageId = "takeda", FightingStyle = "Lasher, Ronin", Game = "Mortal Kombat 1", CombosById = [] },
        new Fighter { Name = "T-1000", ImageId = "t1000", FightingStyle = "Mimicry", Game = "Mortal Kombat 1", CombosById = [] },
        new Fighter { Name = "Tanya", ImageId = "tanya", FightingStyle = "Zi Ran Men", Game = "Mortal Kombat 1", CombosById = [] }
   ];

    public static readonly List<Move> Moves =
    [
        new Move(name: "one_mk", notation: "1", type: "Input", character: "Generic", game: "Mortal Kombat 1"),
        new Move(name: "two_mk", notation: "2", type: "Input", character: "Generic", game: "Mortal Kombat 1"),
        new Move(name: "three_mk", notation: "3", type: "Input", character: "Generic", game: "Mortal Kombat 1"),
        new Move(name: "four_mk", notation: "4", type: "Input", character: "Generic", game: "Mortal Kombat 1"),
        new Move(name: "ex", notation: "ex", type: "Input", character: "Generic", game: "Mortal Kombat 1"),
        
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

        // Mechanics
        new Move(name: "Block", notation: "block", type: "Text Input", character: "Generic", game: "Mortal Kombat 1"),
        new Move(name: "Stance", notation: "stance", type: "Text Input", character: "Generic", game: "Mortal Kombat 1"),
        new Move(name: "Throw", notation: "throw", type: "Mechanic", character: "Generic", game: "Mortal Kombat 1"),
        new Move(name: "Kameo", notation: "kameo", type: "Mechanic", character: "Generic", game: "Mortal Kombat 1"),
        new Move(name: "Hold", notation: "hold", type: "Mechanic", character: "Generic", game: "Mortal Kombat 1"),
        new Move(name: "Air", notation: "air", type: "Mechanic", character: "Generic", game: "Mortal Kombat 1"), 
        // Ashrah
        new Move(name: "Invoking The Light", notation: "Invoking The Light", type: "Special", character: "Ashrah", game: "Mortal Kombat 1"),
        new Move(name: "Heaven's Beacon", notation: "Heaven's Beacon", type: "Special", character: "Ashrah", game: "Mortal Kombat 1"),
        new Move(name: "Astral Projection", notation: "Astral Projection", type: "Special", character: "Ashrah", game: "Mortal Kombat 1"),
        new Move(name: "God's Wrath", notation: "God's Wrath", type: "Special", character: "Ashrah", game: "Mortal Kombat 1"),
        new Move(name: "Light Ascension", notation: "Light Ascension", type: "Special", character: "Ashrah", game: "Mortal Kombat 1"),
        new Move(name: "Dark Shift", notation: "Dark Shift", type: "Special", character: "Ashrah", game: "Mortal Kombat 1"),
        new Move(name: "Hell Mode", notation: "Hell Mode", type: "Special", character: "Ashrah", game: "Mortal Kombat 1"),
        new Move(name: "Summoning The Darkness", notation: "Summoning The Darkness", type: "Special", character: "Ashrah", game: "Mortal Kombat 1"),
        new Move(name: "Hell's Pillar", notation: "Hell's Pillar", type: "Special", character: "Ashrah", game: "Mortal Kombat 1"),
        new Move(name: "Astral Manifestation", notation: "Astral Manifestation", type: "Special", character: "Ashrah", game: "Mortal Kombat 1"),
        new Move(name: "Demon's Wrath", notation: "Demon's Wrath", type: "Special", character: "Ashrah", game: "Mortal Kombat 1"),
        new Move(name: "Dark Ascension", notation: "Dark Ascension", type: "Special", character: "Ashrah", game: "Mortal Kombat 1"),
        new Move(name: "Pinned Down", notation: "Pinned Down", type: "Fatal Blow", character: "Ashrah", game: "Mortal Kombat 1"),

        // Baraka
        new Move(name: "Bleeding Blade", notation: "Bleeding Blade", type: "Special", character: "Baraka", game: "Mortal Kombat 1"),
        new Move(name: "Stab Stab", notation: "Stab Stab", type: "Special", character: "Baraka", game: "Mortal Kombat 1"),
        new Move(name: "Baraka Barrage", notation: "Baraka Barrage", type: "Special", character: "Baraka", game: "Mortal Kombat 1"),
        new Move(name: "Chop Chop", notation: "Chop Chop", type: "Special", character: "Baraka", game: "Mortal Kombat 1"),
        new Move(name: "Shishkabob", notation: "Shishkabob", type: "Fatal Blow", character: "Baraka", game: "Mortal Kombat 1"),

        // Conan the Barbarian
        new Move(name: "Camel Counter", notation: "Camel Counter", type: "Special", character: "Conan the Barbarian", game: "Mortal Kombat 1"),
        new Move(name: "Atlantean Bulwark", notation: "Atlantean Bulwark", type: "Special", character: "Conan the Barbarian", game: "Mortal Kombat 1"),
        new Move(name: "Skyward Guardian", notation: "Skyward Guardian", type: "Special", character: "Conan the Barbarian", game: "Mortal Kombat 1"),
        new Move(name: "Cimmerian Rising", notation: "Cimmerian Rising", type: "Special", character: "Conan the Barbarian", game: "Mortal Kombat 1"),
        new Move(name: "Destroyer's Drop", notation: "Destroyer's Drop", type: "Special", character: "Conan the Barbarian", game: "Mortal Kombat 1"),
        new Move(name: "Barbarian Blitz", notation: "Barbarian Blitz", type: "Special", character: "Conan the Barbarian", game: "Mortal Kombat 1"),
        new Move(name: "Barbarian Blade", notation: "Barbarian Blade", type: "Special", character: "Conan the Barbarian", game: "Mortal Kombat 1"),
        new Move(name: "Berserker's March", notation: "Berserker's March", type: "Special", character: "Conan the Barbarian", game: "Mortal Kombat 1"),
        new Move(name: "Crom's Curse", notation: "Crom's Curse", type: "Special", character: "Conan the Barbarian", game: "Mortal Kombat 1"),
        new Move(name: "Thief's Catapult", notation: "Thief's Catapult", type: "Special", character: "Conan the Barbarian", game: "Mortal Kombat 1"),
        new Move(name: "This You Can Trust", notation: "This You Can Trust", type: "Fatal Blow", character: "Conan the Barbarian", game: "Mortal Kombat 1"),

        // Cyrax
        new Move(name: "Capture Foam", notation: "Capture Foam", type: "Special", character: "Cyrax", game: "Mortal Kombat 1"),
        new Move(name: "Bomb", notation: "Bomb", type: "Special", character: "Cyrax", game: "Mortal Kombat 1"),
        new Move(name: "Saw Drone", notation: "Saw Drone", type: "Special", character: "Cyrax", game: "Mortal Kombat 1"),
        new Move(name: "Bomb Mistwalk", notation: "Bomb Mistwalk", type: "Special", character: "Cyrax", game: "Mortal Kombat 1"),
        new Move(name: "Mistwalk", notation: "Mistwalk", type: "Special", character: "Cyrax", game: "Mortal Kombat 1"),
        new Move(name: "Mistwalk Friction Boot Parkour", notation: "Mistwalk Friction Boot Parkour", type: "Special", character: "Cyrax", game: "Mortal Kombat 1"),
        new Move(name: "Friction Assist Dive Kick", notation: "Friction Assist Dive Kick", type: "Special", character: "Cyrax", game: "Mortal Kombat 1"),
        new Move(name: "Sawtooth Kick", notation: "Sawtooth Kick", type: "Special", character: "Cyrax", game: "Mortal Kombat 1"),
        new Move(name: "Cyberdriver Slam", notation: "Cyberdriver Slam", type: "Fatal Blow", character: "Cyrax", game: "Mortal Kombat 1"),

        // Ermac
        new Move(name: "Spirit Punch", notation: "Spirit Punch", type: "Special", character: "Ermac", game: "Mortal Kombat 1"),
        new Move(name: "Witch Slam", notation: "Witch Slam", type: "Special", character: "Ermac", game: "Mortal Kombat 1"),
        new Move(name: "Behind You", notation: "Behind You", type: "Special", character: "Ermac", game: "Mortal Kombat 1"),
        new Move(name: "Too Late", notation: "Too Late", type: "Special", character: "Ermac", game: "Mortal Kombat 1"),
        new Move(name: "Suspended Animation", notation: "Suspended Animation", type: "Special", character: "Ermac", game: "Mortal Kombat 1"),
        new Move(name: "Shrieking Souls", notation: "Shrieking Souls", type: "Special", character: "Ermac", game: "Mortal Kombat 1"),
        new Move(name: "Death Embrace", notation: "Death Embrace", type: "Special", character: "Ermac", game: "Mortal Kombat 1"),
        new Move(name: "Hungry Hands", notation: "Hungry Hands", type: "Special", character: "Ermac", game: "Mortal Kombat 1"),
        new Move(name: "Shifting Spirits", notation: "Shifting Spirits", type: "Special", character: "Ermac", game: "Mortal Kombat 1"),
        new Move(name: "The Many", notation: "The Many", type: "Fatal Blow", character: "Ermac", game: "Mortal Kombat 1"),

        // General Shao
        new Move(name: "Dark Energy", notation: "Dark Energy", type: "Special", character: "General Shao", game: "Mortal Kombat 1"),
        new Move(name: "Devastator", notation: "Devastator", type: "Special", character: "General Shao", game: "Mortal Kombat 1"),
        new Move(name: "Death Quake", notation: "Death Quake", type: "Special", character: "General Shao", game: "Mortal Kombat 1"),
        new Move(name: "Power Strike", notation: "Power Strike", type: "Special", character: "General Shao", game: "Mortal Kombat 1"),
        new Move(name: "Axe Recall", notation: "Axe Recall", type: "Special", character: "General Shao", game: "Mortal Kombat 1"),
        new Move(name: "Klassic Khan", notation: "Klassic Khan", type: "Special", character: "General Shao", game: "Mortal Kombat 1"),
        new Move(name: "Reverse Treechopper", notation: "Reverse Treechopper", type: "Special", character: "General Shao", game: "Mortal Kombat 1"),
        new Move(name: "Treechopper", notation: "Treechopper", type: "Special", character: "General Shao", game: "Mortal Kombat 1"),
        new Move(name: "Axe Quake", notation: "Axe Quake", type: "Special", character: "General Shao", game: "Mortal Kombat 1"),
        new Move(name: "War God", notation: "War God", type: "Fatal Blow", character: "General Shao", game: "Mortal Kombat 1"),

        // Geras
        new Move(name: "Time Stop", notation: "Time Stop", type: "Special", character: "Geras", game: "Mortal Kombat 1"),
        new Move(name: "History Lesson", notation: "History Lesson", type: "Special", character: "Geras", game: "Mortal Kombat 1"),
        new Move(name: "Follow-Up Exam", notation: "Follow-Up Exam", type: "Special", character: "Geras", game: "Mortal Kombat 1"),
        new Move(name: "Redo", notation: "Redo", type: "Special", character: "Geras", game: "Mortal Kombat 1"),
        new Move(name: "Double Time", notation: "Double Time", type: "Special", character: "Geras", game: "Mortal Kombat 1"),
        new Move(name: "Countdown", notation: "Countdown", type: "Special", character: "Geras", game: "Mortal Kombat 1"),
        new Move(name: "Inevitable", notation: "Inevitable", type: "Special", character: "Geras", game: "Mortal Kombat 1"),
        new Move(name: "Fixed Point", notation: "Fixed Point", type: "Special", character: "Geras", game: "Mortal Kombat 1"),
        new Move(name: "Denial", notation: "Denial", type: "Special", character: "Geras", game: "Mortal Kombat 1"),
        new Move(name: "Sandstorm", notation: "Sandstorm", type: "Special", character: "Geras", game: "Mortal Kombat 1"),
        new Move(name: "Colliding Worlds", notation: "Colliding Worlds", type: "Fatal Blow", character: "Geras", game: "Mortal Kombat 1"),

        // Ghost Face
        new Move(name: "Father Death", notation: "Father Death", type: "Special", character: "Ghostface", game: "Mortal Kombat 1"),
        new Move(name: "Backstage Pass", notation: "Backstage Pass", type: "Special", character: "Ghostface", game: "Mortal Kombat 1"),
        new Move(name: "Psychotic Rush", notation: "Psychotic Rush", type: "Special", character: "Ghostface", game: "Mortal Kombat 1"),
        new Move(name: "Always Outnumbered", notation: "Always Outnumbered", type: "Special", character: "Ghostface", game: "Mortal Kombat 1"),
        new Move(name: "Psychotic Dive", notation: "Psychotic Dive", type: "Special", character: "Ghostface", game: "Mortal Kombat 1"),
        new Move(name: "Ghost Face Killer Swap", notation: "Ghost Face Killer Swap", type: "Special", character: "Ghostface", game: "Mortal Kombat 1"),
        new Move(name: "Horror Show Act 1", notation: "Horror Show Act 1", type: "Special", character: "Ghostface", game: "Mortal Kombat 1"),
        new Move(name: "Horror Show Act 2", notation: "Horror Show Act 2", type: "Special", character: "Ghostface", game: "Mortal Kombat 1"),
        new Move(name: "Horror Show Act 3", notation: "Horror Show Act 3", type: "Special", character: "Ghostface", game: "Mortal Kombat 1"),
        new Move(name: "Black Dragon Smash", notation: "Black Dragon Smash", type: "Special", character: "Ghostface", game: "Mortal Kombat 1"),
        new Move(name: "Windmill Kick", notation: "Windmill Kick", type: "Special", character: "Ghostface", game: "Mortal Kombat 1"),
        new Move(name: "Knife Toss", notation: "Knife Toss", type: "Special", character: "Ghostface", game: "Mortal Kombat 1"),
        new Move(name: "Black Dragon Ball", notation: "Black Dragon Ball", type: "Special", character: "Ghostface", game: "Mortal Kombat 1"),
        new Move(name: "Nightshade", notation: "Nightshade", type: "Special", character: "Ghostface", game: "Mortal Kombat 1"),
        new Move(name: "Flick Of The Wrist", notation: "Flick Of The Wrist", type: "Fatal Blow", character: "Ghostface", game: "Mortal Kombat 1"),

        // Havik
        new Move(name: "Neoplasm", notation: "Neoplasm", type: "Special", character: "Havik", game: "Mortal Kombat 1"),
        new Move(name: "Helping Hand", notation: "Helping Hand", type: "Special", character: "Havik", game: "Mortal Kombat 1"),
        new Move(name: "Blood Bath", notation: "Blood Bath", type: "Special", character: "Havik", game: "Mortal Kombat 1"),
        new Move(name: "Corpse Taunt", notation: "Corpse Taunt", type: "Special", character: "Havik", game: "Mortal Kombat 1"),
        new Move(name: "Seeking Neoplasm", notation: "Seeking Neoplasm", type: "Special", character: "Havik", game: "Mortal Kombat 1"),
        new Move(name: "Twisted Torso", notation: "Twisted Torso", type: "Special", character: "Havik", game: "Mortal Kombat 1"),
        new Move(name: "Disarmed and Dangerous", notation: "Disarmed and Dangerous", type: "Fatal Blow", character: "Havik", game: "Mortal Kombat 1"),

        // Homelander
        new Move(name: "Laser Eyes", notation: "Laser Eyes", type: "Special", character: "Homelander", game: "Mortal Kombat 1"),
        new Move(name: "Dirty Trick", notation: "Dirty Trick", type: "Special", character: "Homelander", game: "Mortal Kombat 1"),
        new Move(name: "Diabolical Dash", notation: "Diabolical Dash", type: "Special", character: "Homelander", game: "Mortal Kombat 1"),
        new Move(name: "Blast Off", notation: "Blast Off", type: "Special", character: "Homelander", game: "Mortal Kombat 1"),
        new Move(name: "Low Laser Eyes", notation: "Low Laser Eyes", type: "Special", character: "Homelander", game: "Mortal Kombat 1"),
        new Move(name: "Sky Laser Eyes", notation: "Sky Laser Eyes", type: "Special", character: "Homelander", game: "Mortal Kombat 1"),
        new Move(name: "Sweeping Laser Eyes", notation: "Sweeping Laser Eyes", type: "Special", character: "Homelander", game: "Mortal Kombat 1"),
        new Move(name: "God Complex", notation: "God Complex", type: "Special", character: "Homelander", game: "Mortal Kombat 1"),
        new Move(name: "Flight", notation: "Flight", type: "Special", character: "Homelander", game: "Mortal Kombat 1"),
        new Move(name: "I Can Do Whatever I Want", notation: "I Can Do Whatever I Want", type: "Fatal Blow", character: "Homelander", game: "Mortal Kombat 1"),

        // Johnny Cage
        new Move(name: "Ball Buster", notation: "Ball Buster", type: "Special", character: "Johnny Cage", game: "Mortal Kombat 1"),
        new Move(name: "Show Off", notation: "Show Off", type: "Special", character: "Johnny Cage", game: "Mortal Kombat 1"),
        new Move(name: "Throwing Shade", notation: "Throwing Shade", type: "Special", character: "Johnny Cage", game: "Mortal Kombat 1"),
        new Move(name: "Rising Star", notation: "Rising Star", type: "Special", character: "Johnny Cage", game: "Mortal Kombat 1"),
        new Move(name: "Shadow Dash", notation: "Shadow Dash", type: "Special", character: "Johnny Cage", game: "Mortal Kombat 1"),
        new Move(name: "Shadow Kick", notation: "Shadow Kick", type: "Special", character: "Johnny Cage", game: "Mortal Kombat 1"),
        new Move(name: "Hype", notation: "Hype", type: "Special", character: "Johnny Cage", game: "Mortal Kombat 1"),
        new Move(name: "Wowing Out", notation: "Wowing Out", type: "Special", character: "Johnny Cage", game: "Mortal Kombat 1"),
        new Move(name: "That's All Folks", notation: "That's All Folks", type: "Fatal Blow", character: "Johnny Cage", game: "Mortal Kombat 1"),

        // Kenshi
        new Move(name: "Ancestral Guard", notation: "Ancestral Guard", type: "Special", character: "Kenshi", game: "Mortal Kombat 1"),
        new Move(name: "Soul Charge", notation: "Soul Charge", type: "Special", character: "Kenshi", game: "Mortal Kombat 1"),
        new Move(name: "Demon Drop", notation: "Demon Drop", type: "Special", character: "Kenshi", game: "Mortal Kombat 1"),
        new Move(name: "Rising Karma", notation: "Rising Karma", type: "Special", character: "Kenshi", game: "Mortal Kombat 1"),
        new Move(name: "Force Push", notation: "Force Push", type: "Special", character: "Kenshi", game: "Mortal Kombat 1"),
        new Move(name: "Summon Ancestor", notation: "Summon Ancestor", type: "Special", character: "Kenshi", game: "Mortal Kombat 1"),
        new Move(name: "Two Heavens Assault", notation: "Two Heavens Assault", type: "Fatal Blow", character: "Kenshi", game: "Mortal Kombat 1"),

        // Kitana
        new Move(name: "Fan Toss", notation: "Fan Toss", type: "Special", character: "Kitana", game: "Mortal Kombat 1"),
        new Move(name: "Fan-Nado", notation: "Fan-Nado", type: "Special", character: "Kitana", game: "Mortal Kombat 1"),
        new Move(name: "Princess Pirouette", notation: "Princess Pirouette", type: "Special", character: "Kitana", game: "Mortal Kombat 1"),
        new Move(name: "Square Wave", notation: "Square Wave", type: "Special", character: "Kitana", game: "Mortal Kombat 1"),
        new Move(name: "Fancy Flick", notation: "Fancy Flick", type: "Special", character: "Kitana", game: "Mortal Kombat 1"),
        new Move(name: "Wind Bomb", notation: "Wind Bomb", type: "Special", character: "Kitana", game: "Mortal Kombat 1"),
        new Move(name: "Stepping Up", notation: "Stepping Up", type: "Fatal Blow", character: "Kitana", game: "Mortal Kombat 1"),

        // Kung Lao
        new Move(name: "Buzz Saw", notation: "Buzz Saw", type: "Special", character: "Kung Lao", game: "Mortal Kombat 1"),
        new Move(name: "Hat Toss", notation: "Hat Toss", type: "Special", character: "Kung Lao", game: "Mortal Kombat 1"),
        new Move(name: "Shaolin Shimmy", notation: "Shaolin Shimmy", type: "Special", character: "Kung Lao", game: "Mortal Kombat 1"),
        new Move(name: "Kung-Kussion", notation: "Kung-Kussion", type: "Special", character: "Kung Lao", game: "Mortal Kombat 1"),
        new Move(name: "Shaolin Spin", notation: "Shaolin Spin", type: "Special", character: "Kung Lao", game: "Mortal Kombat 1"),
        new Move(name: "Soaring Monk", notation: "Soaring Monk", type: "Special", character: "Kung Lao", game: "Mortal Kombat 1"),
        new Move(name: "Practiced And Perfected", notation: "Practiced And Perfected", type: "Fatal Blow", character: "Kung Lao", game: "Mortal Kombat 1"),

        // Li Mei
        new Move(name: "Nova Blast", notation: "Nova Blast", type: "Special", character: "Li Mei", game: "Mortal Kombat 1"),
        new Move(name: "Sky Lantern", notation: "Sky Lantern", type: "Special", character: "Li Mei", game: "Mortal Kombat 1"),
        new Move(name: "Shi Zi Lion", notation: "Shi Zi Lion", type: "Special", character: "Li Mei", game: "Mortal Kombat 1"),
        new Move(name: "Chain Reaction", notation: "Chain Reaction", type: "Special", character: "Li Mei", game: "Mortal Kombat 1"),
        new Move(name: "Lion's Feast", notation: "Lion's Feast", type: "Fatal Blow", character: "Li Mei", game: "Mortal Kombat 1"),

        // Liu Kang
        new Move(name: "Cosmic Flame", notation: "Cosmic Flame", type: "Special", character: "Liu Kang", game: "Mortal Kombat 1"),
        new Move(name: "Low Dragon", notation: "Low Dragon", type: "Special", character: "Liu Kang", game: "Mortal Kombat 1"),
        new Move(name: "Dragon's Tail", notation: "Dragon's Tail", type: "Special", character: "Liu Kang", game: "Mortal Kombat 1"),
        new Move(name: "Dancing Dragon", notation: "Dancing Dragon", type: "Special", character: "Liu Kang", game: "Mortal Kombat 1"),
        new Move(name: "Dragon's Breath", notation: "Dragon's Breath", type: "Special", character: "Liu Kang", game: "Mortal Kombat 1"),
        new Move(name: "Mark Of The Creator", notation: "Mark Of The Creator", type: "Fatal Blow", character: "Liu Kang", game: "Mortal Kombat 1"),

        // Mileena
        new Move(name: "Straight Sai", notation: "Straight Sai", type: "Special", character: "Mileena", game: "Mortal Kombat 1"),
        new Move(name: "Teleport Down", notation: "Teleport Down", type: "Special", character: "Mileena", game: "Mortal Kombat 1"),
        new Move(name: "Teleport Up", notation: "Teleport Up", type: "Special", character: "Mileena", game: "Mortal Kombat 1"),
        new Move(name: "Low Sai", notation: "Low Sai", type: "Special", character: "Mileena", game: "Mortal Kombat 1"),
        new Move(name: "Roll", notation: "Roll", type: "Special", character: "Mileena", game: "Mortal Kombat 1"),
        new Move(name: "Ball", notation: "Ball", type: "Special", character: "Mileena", game: "Mortal Kombat 1"),
        new Move(name: "Seeking Tarkat", notation: "Seeking Tarkat", type: "Fatal Blow", character: "Mileena", game: "Mortal Kombat 1"),

        // Nitara
        new Move(name: "Bad Blood", notation: "Bad Blood", type: "Special", character: "Nitara", game: "Mortal Kombat 1"),
        new Move(name: "Quick Taste", notation: "Quick Taste", type: "Special", character: "Nitara", game: "Mortal Kombat 1"),
        new Move(name: "Leap of Faith", notation: "Leap of Faith", type: "Special", character: "Nitara", game: "Mortal Kombat 1"),
        new Move(name: "Bloody Bolt", notation: "Bloody Bolt", type: "Special", character: "Nitara", game: "Mortal Kombat 1"),
        new Move(name: "Dark Plunge", notation: "Dark Plunge", type: "Special", character: "Nitara", game: "Mortal Kombat 1"),
        new Move(name: "Blood Sacrifice", notation: "Blood Sacrifice", type: "Special", character: "Nitara", game: "Mortal Kombat 1"),
        new Move(name: "Terror From Above", notation: "Terror From Above", type: "Fatal Blow", character: "Nitara", game: "Mortal Kombat 1"),

        // Noob Saibot
        new Move(name: "Ghost Ball", notation: "Ghost Ball", type: "Special", character: "Noob Saibot", game: "Mortal Kombat 1"),
        new Move(name: "Exorcism", notation: "Exorcism", type: "Special", character: "Noob Saibot", game: "Mortal Kombat 1"),
        new Move(name: "Embrace Chaos", notation: "Embrace Chaos", type: "Special", character: "Noob Saibot", game: "Mortal Kombat 1"),
        new Move(name: "Netherrealm Summons", notation: "Netherrealm Summons", type: "Special", character: "Noob Saibot", game: "Mortal Kombat 1"),
        new Move(name: "Netherrealm Portal", notation: "Netherrealm Portal", type: "Special", character: "Noob Saibot", game: "Mortal Kombat 1"),
        new Move(name: "Shadow Tackle", notation: "Shadow Tackle", type: "Special", character: "Noob Saibot", game: "Mortal Kombat 1"),
        new Move(name: "Shadow Slicer", notation: "Shadow Slicer", type: "Special", character: "Noob Saibot", game: "Mortal Kombat 1"),
        new Move(name: "Shadow Slide", notation: "Shadow Slide", type: "Special", character: "Noob Saibot", game: "Mortal Kombat 1"),
        new Move(name: "Saibot Slide", notation: "Saibot Slide", type: "Special", character: "Noob Saibot", game: "Mortal Kombat 1"),
        new Move(name: "Shadow Sweep", notation: "Shadow Sweep", type: "Special", character: "Noob Saibot", game: "Mortal Kombat 1"),
        new Move(name: "Shadow Kick", notation: "Shadow Kick", type: "Special", character: "Noob Saibot", game: "Mortal Kombat 1"),
        new Move(name: "Shadow Dive", notation: "Shadow Dive", type: "Special", character: "Noob Saibot", game: "Mortal Kombat 1"),
        new Move(name: "Dive Kick", notation: "Dive Kick", type: "Special", character: "Noob Saibot", game: "Mortal Kombat 1"),
        new Move(name: "Shadow Plunge", notation: "Shadow Plunge", type: "Special", character: "Noob Saibot", game: "Mortal Kombat 1"),
        new Move(name: "Tele-Slam", notation: "Tele-Slam", type: "Special", character: "Noob Saibot", game: "Mortal Kombat 1"),
        new Move(name: "Khaotic Eclipse", notation: "Khaotic Eclipse", type: "Special", character: "Noob Saibot", game: "Mortal Kombat 1"),

        // Omni-Man
        new Move(name: "Mega Clap", notation: "Mega Clap", type: "Special", character: "Omni-Man", game: "Mortal Kombat 1"),
        new Move(name: "Giblet Maker", notation: "Giblet Maker", type: "Special", character: "Omni-Man", game: "Mortal Kombat 1"),
        new Move(name: "Viltrumite Stance", notation: "Viltrumite Stance", type: "Special", character: "Omni-Man", game: "Mortal Kombat 1"),
        new Move(name: "Invincible Rush", notation: "Invincible Rush", type: "Special", character: "Omni-Man", game: "Mortal Kombat 1"),
        new Move(name: "The Thinker", notation: "The Thinker", type: "Fatal Blow", character: "Omni-Man", game: "Mortal Kombat 1"),

        // Peacemaker
        new Move(name: "Silent and Deadly", notation: "Silent and Deadly", type: "Special", character: "Peacemaker", game: "Mortal Kombat 1"),
        new Move(name: "Force Multiplier", notation: "Force Multiplier", type: "Special", character: "Peacemaker", game: "Mortal Kombat 1"),
        new Move(name: "Activate Human Torpedo", notation: "Activate Human Torpedo", type: "Special", character: "Peacemaker", game: "Mortal Kombat 1"),
        new Move(name: "Activate Anti-Gravity", notation: "Activate Anti-Gravity", type: "Special", character: "Peacemaker", game: "Mortal Kombat 1"),
        new Move(name: "Activate Force Field", notation: "Activate Force Field", type: "Special", character: "Peacemaker", game: "Mortal Kombat 1"),
        new Move(name: "Activate Sonic Boom", notation: "Activate Sonic Boom", type: "Special", character: "Peacemaker", game: "Mortal Kombat 1"),
        new Move(name: "Ground-Air Offensive", notation: "Ground-Air Offensive", type: "Special", character: "Peacemaker", game: "Mortal Kombat 1"),
        new Move(name: "Beautiful Bird Bullet", notation: "Beautiful Bird Bullet", type: "Special", character: "Peacemaker", game: "Mortal Kombat 1"),
        new Move(name: "The Ultimate Ally", notation: "The Ultimate Ally", type: "Special", character: "Peacemaker", game: "Mortal Kombat 1"),
        new Move(name: "Eat Peace!", notation: "Eat Peace!", type: "Fatal Blow", character: "Peacemaker", game: "Mortal Kombat 1"),

        // Quan Chi
        new Move(name: "Head Rush", notation: "Head Rush", type: "Special", character: "Quan Chi", game: "Mortal Kombat 1"),
        new Move(name: "Psycho Skull", notation: "Psycho Skull", type: "Special", character: "Quan Chi", game: "Mortal Kombat 1"),
        new Move(name: "Psycho Skull Volley", notation: "Psycho Skull Volley", type: "Special", character: "Quan Chi", game: "Mortal Kombat 1"),
        new Move(name: "Field of Bones", notation: "Field of Bones", type: "Special", character: "Quan Chi", game: "Mortal Kombat 1"),
        new Move(name: "Zone of Power", notation: "Zone of Power", type: "Special", character: "Quan Chi", game: "Mortal Kombat 1"),
        new Move(name: "Zone of Fear", notation: "Zone of Fear", type: "Special", character: "Quan Chi", game: "Mortal Kombat 1"),
        new Move(name: "Falling Death", notation: "Falling Death", type: "Special", character: "Quan Chi", game: "Mortal Kombat 1"),
        new Move(name: "From The Fog", notation: "From The Fog", type: "Special", character: "Quan Chi", game: "Mortal Kombat 1"),
        new Move(name: "Journey Through Hell", notation: "Journey Through Hell", type: "Fatal Blow", character: "Quan Chi", game: "Mortal Kombat 1"),

        // Raiden
        new Move(name: "Electric Orb", notation: "Electric Orb", type: "Special", character: "Raiden", game: "Mortal Kombat 1"),
        new Move(name: "Razzle Dazzle", notation: "Razzle Dazzle", type: "Special", character: "Raiden", game: "Mortal Kombat 1"),
        new Move(name: "Shocker", notation: "Shocker", type: "Special", character: "Raiden", game: "Mortal Kombat 1"),
        new Move(name: "Electric Fly", notation: "Electric Fly", type: "Special", character: "Raiden", game: "Mortal Kombat 1"),
        new Move(name: "Electromagnetic Storm", notation: "Electromagnetic Storm", type: "Special", character: "Raiden", game: "Mortal Kombat 1"),
        new Move(name: "Lightning Port", notation: "Lightning Port", type: "Special", character: "Raiden", game: "Mortal Kombat 1"),
        new Move(name: "Raijin' Raidens", notation: "Raijin' Raidens", type: "Fatal Blow", character: "Raiden", game: "Mortal Kombat 1"),

        // Rain
        new Move(name: "Water Beam", notation: "Water Beam", type: "Special", character: "Rain", game: "Mortal Kombat 1"),
        new Move(name: "Upflow", notation: "Upflow", type: "Special", character: "Rain", game: "Mortal Kombat 1"),
        new Move(name: "Water Gate", notation: "Water Gate", type: "Special", character: "Rain", game: "Mortal Kombat 1"),
        new Move(name: "Water Gate TP", notation: "Water Gate TP", type: "Special", character: "Rain", game: "Mortal Kombat 1"),
        new Move(name: "Confluence Beam", notation: "Confluence Beam", type: "Special", character: "Rain", game: "Mortal Kombat 1"),
        new Move(name: "Geyser", notation: "Geyser", type: "Special", character: "Rain", game: "Mortal Kombat 1"),
        new Move(name: "Water Shield", notation: "Water Shield", type: "Special", character: "Rain", game: "Mortal Kombat 1"),
        new Move(name: "Ancient Trap", notation: "Ancient Trap", type: "Special", character: "Rain", game: "Mortal Kombat 1"),
        new Move(name: "Rain God", notation: "Rain God", type: "Special", character: "Rain", game: "Mortal Kombat 1"),
        new Move(name: "Water God's Judgement", notation: "Water God's Judgement", type: "Fatal Blow", character: "Rain", game: "Mortal Kombat 1"),

        // Reiko
        new Move(name: "Retaliation", notation: "Retaliation", type: "Special", character: "Reiko", game: "Mortal Kombat 1"),
        new Move(name: "Pale Rider", notation: "Pale Rider", type: "Special", character: "Reiko", game: "Mortal Kombat 1"),
        new Move(name: "Assassin Throwing Stars", notation: "Assassin Throwing Stars", type: "Special", character: "Reiko", game: "Mortal Kombat 1"),
        new Move(name: "Charging Pain", notation: "Charging Pain", type: "Special", character: "Reiko", game: "Mortal Kombat 1"),
        new Move(name: "Tactical Takedown", notation: "Tactical Takedown", type: "Special", character: "Reiko", game: "Mortal Kombat 1"),
        new Move(name: "The Soldier's Spearit", notation: "The Soldier's Spearit", type: "Fatal Blow", character: "Reiko", game: "Mortal Kombat 1"),

        // Reptile
        new Move(name: "Acid Spit", notation: "Acid Spit", type: "Special", character: "Reptile", game: "Mortal Kombat 1"),
        new Move(name: "Dash Attack", notation: "Dash Attack", type: "Special", character: "Reptile", game: "Mortal Kombat 1"),
        new Move(name: "Force Ball", notation: "Force Ball", type: "Special", character: "Reptile", game: "Mortal Kombat 1"),
        new Move(name: "Death Roll", notation: "Death Roll", type: "Special", character: "Reptile", game: "Mortal Kombat 1"),
        new Move(name: "Invisibility", notation: "Invisibility", type: "Special", character: "Reptile", game: "Mortal Kombat 1"),
        new Move(name: "Falling Fangs", notation: "Falling Fangs", type: "Special", character: "Reptile", game: "Mortal Kombat 1"),
        new Move(name: "The Beast Unleashed", notation: "The Beast Unleashed", type: "Fatal Blow", character: "Reptile", game: "Mortal Kombat 1"),

        // Scorpion
        new Move(name: "Spear", notation: "Spear", type: "Special", character: "Scorpion", game: "Mortal Kombat 1"),
        new Move(name: "Blazing Charge", notation: "Blazing Charge", type: "Special", character: "Scorpion", game: "Mortal Kombat 1"),
        new Move(name: "Kyo Snag", notation: "Kyo Snag", type: "Special", character: "Scorpion", game: "Mortal Kombat 1"),
        new Move(name: "Twisted Kyo", notation: "Twisted Kyo", type: "Special", character: "Scorpion", game: "Mortal Kombat 1"),
        new Move(name: "Devouring Flame", notation: "Devouring Flame", type: "Special", character: "Scorpion", game: "Mortal Kombat 1"),
        new Move(name: "Flame Port", notation: "Flame Port", type: "Special", character: "Scorpion", game: "Mortal Kombat 1"),
        new Move(name: "Speared And Seared", notation: "Speared And Seared", type: "Fatal Blow", character: "Scorpion", game: "Mortal Kombat 1"),

        // Sektor
        new Move(name: "Unguided Rocket", notation: "Unguided Rocket", type: "Special", character: "Sektor", game: "Mortal Kombat 1"),
        new Move(name: "Sidewinder", notation: "Sidewinder", type: "Special", character: "Sektor", game: "Mortal Kombat 1"),
        new Move(name: "Flamethrower", notation: "Flamethrower", type: "Special", character: "Sektor", game: "Mortal Kombat 1"),
        new Move(name: "Burst Grenade", notation: "Burst Grenade", type: "Special", character: "Sektor", game: "Mortal Kombat 1"),
        new Move(name: "Anti-Air Flak", notation: "Anti-Air Flak", type: "Special", character: "Sektor", game: "Mortal Kombat 1"),
        new Move(name: "Blast Shield", notation: "Blast Shield", type: "Special", character: "Sektor", game: "Mortal Kombat 1"),
        new Move(name: "Tactical Redeploy", notation: "Tactical Redeploy", type: "Special", character: "Sektor", game: "Mortal Kombat 1"),
        new Move(name: "Thruster Boost", notation: "Thruster Boost", type: "Special", character: "Sektor", game: "Mortal Kombat 1"),
        new Move(name: "Massive Missile Assault", notation: "Massive Missile Assault", type: "Fatal Blow", character: "Sektor", game: "Mortal Kombat 1"),

        // Shang Tsung
        new Move(name: "Morph", notation: "Morph", type: "Special", character: "Shang Tsung", game: "Mortal Kombat 1"),
        new Move(name: "Form Stealer", notation: "Form Stealer", type: "Special", character: "Shang Tsung", game: "Mortal Kombat 1"),
        new Move(name: "Perfect Form", notation: "Perfect Form", type: "Special", character: "Shang Tsung", game: "Mortal Kombat 1"),
        new Move(name: "Straight Skull", notation: "Straight Skull", type: "Special", character: "Shang Tsung", game: "Mortal Kombat 1"),
        new Move(name: "Double Skull", notation: "Double Skull", type: "Special", character: "Shang Tsung", game: "Mortal Kombat 1"),
        new Move(name: "Triple Skull", notation: "Triple Skull", type: "Special", character: "Shang Tsung", game: "Mortal Kombat 1"),
        new Move(name: "Spinning Spikes", notation: "Spinning Spikes", type: "Special", character: "Shang Tsung", game: "Mortal Kombat 1"),
        new Move(name: "Bed Of Spikes", notation: "Bed Of Spikes", type: "Special", character: "Shang Tsung", game: "Mortal Kombat 1"),
        new Move(name: "Down Skull", notation: "Down Skull", type: "Special", character: "Shang Tsung", game: "Mortal Kombat 1"),
        new Move(name: "Ground Skull", notation: "Ground Skull", type: "Special", character: "Shang Tsung", game: "Mortal Kombat 1"),
        new Move(name: "Vicinity Slash", notation: "Vicinity Slash", type: "Special", character: "Shang Tsung", game: "Mortal Kombat 1"),
        new Move(name: "Injection", notation: "Injection", type: "Special", character: "Shang Tsung", game: "Mortal Kombat 1"),
        new Move(name: "Bad Medicine", notation: "Bad Medicine", type: "Fatal Blow", character: "Shang Tsung", game: "Mortal Kombat 1"),
        new Move(name: "Fatal Blow", notation: "Fatal Blow", type: "Fatal Blow", character: "Shang Tsung", game: "Mortal Kombat 1"),

        // Sindel
        new Move(name: "Low Hairball", notation: "Low Hairball", type: "Special", character: "Sindel", game: "Mortal Kombat 1"),
        new Move(name: "Hairball", notation: "Hairball", type: "Special", character: "Sindel", game: "Mortal Kombat 1"),
        new Move(name: "Scream", notation: "Scream", type: "Special", character: "Sindel", game: "Mortal Kombat 1"),
        new Move(name: "Levitate", notation: "Levitate", type: "Special", character: "Sindel", game: "Mortal Kombat 1"),
        new Move(name: "Inspire", notation: "Inspire", type: "Special", character: "Sindel", game: "Mortal Kombat 1"),
        new Move(name: "Queen's Kommand", notation: "Queen's Kommand", type: "Special", character: "Sindel", game: "Mortal Kombat 1"),
        new Move(name: "Kartwheel", notation: "Kartwheel", type: "Special", character: "Sindel", game: "Mortal Kombat 1"),
        new Move(name: "Snatched", notation: "Empress's Evisceration", type: "Fatal Blow", character: "Sindel", game: "Mortal Kombat 1"),

        // Smoke
        new Move(name: "Shadow Blade", notation: "Shadow Blade", type: "Special", character: "Smoke", game: "Mortal Kombat 1"),
        new Move(name: "Smoke Bomb", notation: "Smoke Bomb", type: "Special", character: "Smoke", game: "Mortal Kombat 1"),
        new Move(name: "Vicious Vapors", notation: "Vicious Vapors", type: "Special", character: "Smoke", game: "Mortal Kombat 1"),
        new Move(name: "Smoke-Port", notation: "Smoke-Port", type: "Special", character: "Smoke", game: "Mortal Kombat 1"),
        new Move(name: "Mistborn Killer", notation: "Mistborn Killer", type: "Fatal Blow", character: "Smoke", game: "Mortal Kombat 1"),

        // Sub-Zero
        new Move(name: "Ice Ball", notation: "Ice Ball", type: "Special", character: "Sub-Zero", game: "Mortal Kombat 1"),
        new Move(name: "Ice Klone", notation: "Ice Klone", type: "Special", character: "Sub-Zero", game: "Mortal Kombat 1"),
        new Move(name: "Ice Klone Charge", notation: "Ice Klone Charge", type: "Special", character: "Sub-Zero", game: "Mortal Kombat 1"),
        new Move(name: "Ice Slide", notation: "Ice Slide", type: "Special", character: "Sub-Zero", game: "Mortal Kombat 1"),
        new Move(name: "Diving Glacier", notation: "Diving Glacier", type: "Special", character: "Sub-Zero", game: "Mortal Kombat 1"),
        new Move(name: "Deadly Vapors", notation: "Deadly Vapors", type: "Special", character: "Sub-Zero", game: "Mortal Kombat 1"),
        new Move(name: "Chill Out", notation: "Chill Out", type: "Fatal Blow", character: "Sub-Zero", game: "Mortal Kombat 1"),

        // T-1000
        new Move(name: "Ballistic Suppression", notation: "Ballistic Suppression", type: "Special", character: "T-1000", game: "Mortal Kombat 1"),
        new Move(name: "Ballistic Approach", notation: "Ballistic Approach", type: "Special", character: "T-1000", game: "Mortal Kombat 1"),
        new Move(name: "Tornado Slam Emulation", notation: "Tornado Slam Emulation", type: "Special", character: "T-1000", game: "Mortal Kombat 1"),
        new Move(name: "Acute Angle Hooks", notation: "Acute Angle Hooks", type: "Special", character: "T-1000", game: "Mortal Kombat 1"),
        new Move(name: "Wrath Hammer Emulation", notation: "Wrath Hammer Emulation", type: "Special", character: "T-1000", game: "Mortal Kombat 1"),
        new Move(name: "Superfluid Matter", notation: "Superfluid Matter", type: "Special", character: "T-1000", game: "Mortal Kombat 1"),
        new Move(name: "Sacral Spike", notation: "Sacral Spike", type: "Special", character: "T-1000", game: "Mortal Kombat 1"),
        new Move(name: "Massive Droplet", notation: "Massive Droplet", type: "Special", character: "T-1000", game: "Mortal Kombat 1"),
        new Move(name: "Amorphous Step", notation: "Amorphous Step", type: "Special", character: "T-1000", game: "Mortal Kombat 1"),
        new Move(name: "Fluid Kombatant", notation: "Fluid Kombatant", type: "Fatal Blow", character: "T-1000", game: "Mortal Kombat 1"),

        // Takeda
        new Move(name: "Shooting Star", notation: "Shooting Star", type: "Special", character: "Takeda", game: "Mortal Kombat 1"),
        new Move(name: "Smart Shuriken", notation: "Smart Shuriken", type: "Special", character: "Takeda", game: "Mortal Kombat 1"),
        new Move(name: "Falling Stars", notation: "Falling Stars", type: "Special", character: "Takeda", game: "Mortal Kombat 1"),
        new Move(name: "Double Spear Ryu", notation: "Double Spear Ryu", type: "Special", character: "Takeda", game: "Mortal Kombat 1"),
        new Move(name: "Spear Ryu", notation: "Spear Ryu", type: "Special", character: "Takeda", game: "Mortal Kombat 1"),
        new Move(name: "Swift Stride", notation: "Swift Stride", type: "Special", character: "Takeda", game: "Mortal Kombat 1"),
        new Move(name: "Rushing Nimbus Technique", notation: "Rushing Nimbus Technique", type: "Special", character: "Takeda", game: "Mortal Kombat 1"),
        new Move(name: "Tornado Kick", notation: "Tornado Kick", type: "Special", character: "Takeda", game: "Mortal Kombat 1"),
        new Move(name: "Whip Art: Wretched Blow", notation: "Whip Art: Wretched Blow", type: "Special", character: "Takeda", game: "Mortal Kombat 1"),
        new Move(name: "Satsujin", notation: "Satsujin", type: "Fatal Blow", character: "Takeda", game: "Mortal Kombat 1"),

        // Tanya
        new Move(name: "Drill Kick", notation: "Drill Kick", type: "Special", character: "Tanya", game: "Mortal Kombat 1"),
        new Move(name: "Seeking Umgadi", notation: "Seeking Umgadi", type: "Special", character: "Tanya", game: "Mortal Kombat 1"),
        new Move(name: "Heavenly Handstand", notation: "Heavenly Handstand", type: "Special", character: "Tanya", game: "Mortal Kombat 1"),
        new Move(name: "Divine Protection", notation: "Divine Protection", type: "Special", character: "Tanya", game: "Mortal Kombat 1"),
        new Move(name: "Guiding Light", notation: "Guiding Light", type: "Special", character: "Tanya", game: "Mortal Kombat 1"),
        new Move(name: "Umgadi's Will", notation: "Umgadi's Will", type: "Fatal Blow", character: "Tanya", game: "Mortal Kombat 1"),
        new Move(name: "Drill Kick", notation: "Drill Kick", type: "Special", character: "Tanya", game: "Mortal Kombat 1"),
        new Move(name: "Spinning Splits Kick", notation: "Spinning Splits Kick", type: "Special", character: "Tanya", game: "Mortal Kombat 1"),
        new Move(name: "100 Hands", notation: "100 Hands", type: "Fatal Blow", character: "Tanya", game: "Mortal Kombat 1")
    ];
}