using FightingFlowDotNet.Models;
using FightingFlowDotNet.Models.Enums;

namespace FightingFlowDotNet.Resources;

public static class StreetFighter6
{
    public static readonly IReadOnlyList<string> StageImages =
    [
        "stage_sf6_beach.png",
        "stage_sf6_carrier.png",
        "stage_sf6_colosseo.png",
        "stage_sf6_dhalsimer.png",
        "stage_sf6_downtown.png",
        "stage_sf6_enma.png",
        "stage_sf6_genbu.png",
        "stage_sf6_hut.png",
        "stage_sf6_london.png",
        "stage_sf6_machoring.png",
        "stage_sf6_oldtown.png",
        "stage_sf6_paopao.png",
        "stage_sf6_paris.png",
        "stage_sf6_proudspire.png",
        "stage_sf6_reniala.png",
        "stage_sf6_ruinedlab.png",
        "stage_sf6_steelworks.png",
        "stage_sf6_suvalhal.png",
        "stage_sf6_thunderfoot.png",
        "stage_sf6_tian.png",
    ];

    public static readonly List<Fighter> Fighters =
    [
new Fighter { Name = "Alex", Bio = "A New York street fighter and the original protagonist of Street Fighter III, known for his brawling power and the Prowler stance that opens up varied follow-up options.", FightingStyle = "Hybrid grappler", Game = "Street Fighter 6", ImageId = "fighter_sf6_alex", CombosById = [] },
new Fighter { Name = "A.K.I.", Bio = "A member of Shadaloo raised alongside M. Bison, trained in a poison-based fighting style by F.A.N.G. and eager to prove herself as his successor.", FightingStyle = "Snake Kung Fu", Game = "Street Fighter 6", ImageId = "fighter_sf6_aki", CombosById = [] },
new Fighter { Name = "Akuma", Bio = "A wandering martial artist consumed by the Satsui no Hado, endlessly seeking stronger opponents to push his mastery of the dark side of Ansatsuken to its limits.", FightingStyle = "Satsui no Hado, Ansatsuken", Game = "Street Fighter 6", ImageId = "fighter_sf6_akuma", CombosById = [] },
new Fighter { Name = "Blanka", Bio = "A Brazilian man who survived a plane crash as a child and grew up in the jungle, developing feral instincts and the ability to generate electricity through his body.", FightingStyle = "Feral movement, electric attacks", Game = "Street Fighter 6", ImageId = "fighter_sf6_blanka", CombosById = [] },
new Fighter { Name = "Cammy", Bio = "A former Shadaloo assassin created as one of Bison's Dolls, now working with Delta Red to atone for her past and hunt down remnants of the organization that made her.", FightingStyle = "Shadaloo fighting techniques (Shadaloo), Special Forces training (Delta Red)", Game = "Street Fighter 6", ImageId = "fighter_sf6_cammy", CombosById = [] },
new Fighter { Name = "Chun-Li", Bio = "An Interpol officer trained in Chinese martial arts who has spent years pursuing Shadaloo, seeking justice for the death of her father at M. Bison's hands.", FightingStyle = "Chinese martial arts/Kung Fu and Tai Chi", Game = "Street Fighter 6", ImageId = "fighter_sf6_chunli", CombosById = [] },
new Fighter { Name = "C. Viper", Bio = "A U.S. government agent and mother who fights with a high-tech Battle Suit, first appearing in Street Fighter IV as one of its most technically demanding characters.", FightingStyle = "Rushdown / technical battle suit", Game = "Street Fighter 6", ImageId = "fighter_sf6_c_viper", CombosById = [] },
new Fighter { Name = "Dee Jay", Bio = "A Jamaican kickboxer and musician who blends martial arts with rhythm and flair, fighting with the same showmanship he brings to his music career.", FightingStyle = "Kickboxing and break dancing", Game = "Street Fighter 6", ImageId = "fighter_sf6_deejay", CombosById = [] },
new Fighter { Name = "Dhalsim", Bio = "An Indian yoga master capable of stretching his limbs to extraordinary lengths and channeling fire, fighting to support his village and share his spiritual philosophy.", FightingStyle = "Esoteric Yoga", Game = "Street Fighter 6", ImageId = "fighter_sf6_dhalsim", CombosById = [] },
new Fighter { Name = "E. Honda", Bio = "A sumo wrestler turned chef determined to prove sumo's strength on the world stage, running his own restaurant between tournament appearances.", FightingStyle = "Sumo Wrestler Chef", Game = "Street Fighter 6", ImageId = "fighter_sf6_ehonda", CombosById = [] },
new Fighter { Name = "Ed", Bio = "A young man raised within Shadaloo who inherited Psycho Power from M. Bison's genetic experiments, now fighting to bring down the organization that created him.", FightingStyle = "Psycho Boxing", Game = "Street Fighter 6", ImageId = "fighter_sf6_ed", CombosById = [] },
new Fighter { Name = "Elena", Bio = "A princess from a fictional East African nation who fights using Capoeira, driven by her love of dance, nature, and meeting new people through combat.", FightingStyle = "Capoeira Master", Game = "Street Fighter 6", ImageId = "fighter_sf6_elena", CombosById = [] },
new Fighter { Name = "Guile", Bio = "A U.S. Air Force officer who fights to honor his fallen comrade Charlie Nash and avenge his role in Shadaloo's downfall, balancing duty with family life.", FightingStyle = "Martial arts and professional wrestling", Game = "Street Fighter 6", ImageId = "fighter_sf6_guile", CombosById = [] },
new Fighter { Name = "Ingrid", Bio = "A mysterious woman wielding solar energy, originally created for the cancelled Capcom Fighting All-Stars before being reworked into Capcom Fighting Evolution. She makes her proper Street Fighter debut in SF6.", FightingStyle = "Solar-powered energy manipulation", Game = "Street Fighter 6", ImageId = "fighter_sf6_ingrid", CombosById = [] },
new Fighter { Name = "Jamie", Bio = "A Hong Kong street performer who learned Zui Quan from an old drunken master, growing stronger and more unpredictable in battle the more he drinks.", FightingStyle = "Zui Quan (Drunken Fist) & Breakdancing", Game = "Street Fighter 6", ImageId = "fighter_sf6_jamie", CombosById = [] },
new Fighter { Name = "JP", Bio = "A wealthy, enigmatic figure secretly manipulating global events from the shadows, wielding Psycho Power and a refined fighting style rooted in Bartitsu.", FightingStyle = "Bartitsu & Psycho Power", Game = "Street Fighter 6", ImageId = "fighter_sf6_jp", CombosById = [] },
new Fighter { Name = "Juri", Bio = "A former Taekwondo prodigy whose family was destroyed by Shadaloo, now fighting with sadistic glee and ki-based attacks fueled by a desire for revenge.", FightingStyle = "Taekwondo, ki attacks", Game = "Street Fighter 6", ImageId = "fighter_sf6_juri", CombosById = [] },
new Fighter { Name = "Ken", Bio = "A wealthy martial artist and Ryu's best friend and rival, balancing family life and business with his relentless pursuit of stronger competition.", FightingStyle = "Karate based martial arts, Ansatsuken", Game = "Street Fighter 6", ImageId = "fighter_sf6_ken", CombosById = [] },
new Fighter { Name = "Kimberly", Bio = "An aspiring ninja and fashion-obsessed student of Guy, eager to prove herself as a worthy successor of Bushin-ryu Ninjutsu.", FightingStyle = "Bushin-ryu Ninjutsu", Game = "Street Fighter 6", ImageId = "fighter_sf6_kimberly", CombosById = [] },
new Fighter { Name = "Lily", Bio = "A young warrior from the Thunderfoot tribe following in the footsteps of her grandmother T. Hawk, fighting to protect her people's land and traditions.", FightingStyle = "Thunderfoot Martial Arts", Game = "Street Fighter 6", ImageId = "fighter_sf6_lily", CombosById = [] },
new Fighter { Name = "Luke", Bio = "An MMA fighter and rising star being positioned as the face of Street Fighter's new era, eager to test himself against the world's strongest fighters.", FightingStyle = "Military MMA", Game = "Street Fighter 6", ImageId = "fighter_sf6_luke", CombosById = [] },
new Fighter { Name = "M.Bison", Bio = "The megalomaniacal leader of Shadaloo, wielding Psycho Power in his quest for world domination and immortality through the transfer of his consciousness into new bodies.", FightingStyle = "Psycho Power & Lerdrit", Game = "Street Fighter 6", ImageId = "fighter_sf6_m_bison", CombosById = [] },
new Fighter { Name = "Mai", Bio = "A kunoichi of the Shiranui ninja clan and SNK crossover guest character, known for her fan-wielding fire techniques and flashy fighting style.", FightingStyle = "Shiranui-ryuu Ninjitsu", Game = "Street Fighter 6", ImageId = "fighter_sf6_mai", CombosById = [] },
new Fighter { Name = "Manon", Bio = "A French judoka and fashion model who competes both on the runway and in the ring, using elegant judo throws mixed with balletic grace.", FightingStyle = "Judo and ballet dancing", Game = "Street Fighter 6", ImageId = "fighter_sf6_manon", CombosById = [] },
new Fighter { Name = "Marisa", Bio = "A Greek fighter descended from ancient warriors, trained in Pankration by her grandmother and driven to prove herself worthy of her legendary bloodline.", FightingStyle = "Pankration", Game = "Street Fighter 6", ImageId = "fighter_sf6_marisa", CombosById = [] },
new Fighter { Name = "Rashid", Bio = "A wealthy Middle Eastern inventor and philanthropist who channels the power of wind, traveling the world with his drone MENAT to help those in need.", FightingStyle = "Wind and parkour", Game = "Street Fighter 6", ImageId = "fighter_sf6_rashid", CombosById = [] },
new Fighter { Name = "Ryu", Bio = "A wandering martial artist single-mindedly devoted to mastering the true meaning of the fist, traveling the world in search of worthy opponents while resisting the pull of the Satsui no Hado.", FightingStyle = "Ansatsuken", Game = "Street Fighter 6", ImageId = "fighter_sf6_ryu", CombosById = [] },
new Fighter { Name = "Sagat", Bio = "The former Muay Thai Emperor bearing a massive scar from his battle with Ryu, now seeking redemption and a worthy rematch to settle his lingering rivalry.", FightingStyle = "Muay Thai", Game = "Street Fighter 6", ImageId = "fighter_sf6_sagat", CombosById = [] },
new Fighter { Name = "Terry", Bio = "The Legendary Hungry Wolf and SNK crossover guest character, a wandering hero who fights with a relaxed, freewheeling style honed across the Fatal Fury and King of Fighters series.", FightingStyle = "Martial arts and Hakkyokuseiken chi techniques", Game = "Street Fighter 6", ImageId = "fighter_sf6_terry_bogard", CombosById = [] },
new Fighter { Name = "Yasmine", Bio = "A Filipino high schooler who took up Eskrima to search for her missing older brother (Kuya), guided by the fighting knowledge passed down from her grandfather.", FightingStyle = "Eskrima (karambit knife)", Game = "Street Fighter 6", ImageId = "fighter_sf6_yasmine", CombosById = [] },
new Fighter { Name = "Zangief", Bio = "A Russian wrestler and national hero renowned for his devastating grappling power, fighting to prove the strength of the Red Cyclone to the world.", FightingStyle = "Mix of Russian and American pro wrestling", Game = "Street Fighter 6", ImageId = "fighter_sf6_zangief", CombosById = [] },    ];

    public static readonly List<Move> Moves =
    [
        // Classic Inputs
        new Move(name: "lp", notation: "lp", type: "SF Classic", character: "Generic", game: "Street Fighter 6", sf6Type: Sf6Type.Classic, imageId: "move_sf6_lp"),
        new Move(name: "mp", notation: "mp", type: "SF Classic", character: "Generic", game: "Street Fighter 6", sf6Type: Sf6Type.Classic, imageId: "move_sf6_mp"),
        new Move(name: "hp", notation: "hp", type: "SF Classic", character: "Generic", game: "Street Fighter 6", sf6Type: Sf6Type.Classic, imageId: "move_sf6_hp"),
        new Move(name: "lk", notation: "lk", type: "SF Classic", character: "Generic", game: "Street Fighter 6", sf6Type: Sf6Type.Classic, imageId: "move_sf6_lk"),
        new Move(name: "mk", notation: "mk", type: "SF Classic", character: "Generic", game: "Street Fighter 6", sf6Type: Sf6Type.Classic, imageId: "move_sf6_mk"),
        new Move(name: "hk", notation: "hk", type: "SF Classic", character: "Generic", game: "Street Fighter 6", sf6Type: Sf6Type.Classic, imageId: "move_sf6_hk"),
        new Move(name: "p", notation: "p", type: "SF Classic", character: "Generic", game: "Street Fighter 6", sf6Type: Sf6Type.Classic, imageId: "move_sf6_p"),
        new Move(name: "k", notation: "k", type: "SF Classic", character: "Generic", game: "Street Fighter 6", sf6Type: Sf6Type.Classic, imageId: "move_sf6_k"),
        new Move(name: "pp", notation: "pp", type: "SF Classic", character: "Generic", game: "Street Fighter 6", sf6Type: Sf6Type.Classic, imageId: "move_sf6_pp"),
        new Move(name: "kk", notation: "kk", type: "SF Classic", character: "Generic", game: "Street Fighter 6", sf6Type: Sf6Type.Classic, imageId: "move_sf6_kk"),
        new Move(name: "ppp", notation: "ppp", type: "SF Classic", character: "Generic", game: "Street Fighter 6", sf6Type: Sf6Type.Classic, imageId: "move_sf6_ppp"),
        new Move(name: "kkk", notation: "kkk", type: "SF Classic", character: "Generic", game: "Street Fighter 6", sf6Type: Sf6Type.Classic, imageId: "move_sf6_kkk"),

        // Modern Inputs
        new Move(name: "light", notation: "light", type: "SF Modern", character: "Generic", game: "Street Fighter 6", sf6Type: Sf6Type.Modern, imageId: "move_sf6_light"),
        new Move(name: "medium", notation: "medium", type: "SF Modern", character: "Generic", game: "Street Fighter 6", sf6Type: Sf6Type.Modern, imageId: "move_sf6_medium"),
        new Move(name: "heavy", notation: "heavy", type: "SF Modern", character: "Generic", game: "Street Fighter 6", sf6Type: Sf6Type.Modern, imageId: "move_sf6_heavy"),
        new Move(name: "special", notation: "special", type: "SF Modern", character: "Generic", game: "Street Fighter 6", sf6Type: Sf6Type.Modern, imageId: "move_sf6_special"),
        new Move(name: "Auto", notation: "auto", type: "Mechanics", character: "Generic", game: "Street Fighter 6", sf6Type: Sf6Type.Modern),

        // Mechanics
        new Move(name: "Taunt", notation: "taunt", type: "Mechanics", character: "Generic", game: "Street Fighter 6"),
        new Move(name: "Throw", notation: "throw", type: "Mechanics", character: "Generic", game: "Street Fighter 6"),
        new Move(name: "DI", notation: "DI", type: "Mechanics", character: "Generic", game: "Street Fighter 6"),
        new Move(name: "Parry", notation: "Parry", type: "Mechanics", character: "Generic", game: "Street Fighter 6"),
        new Move(name: "DR", notation: "DR", type: "Mechanics", character: "Generic", game: "Street Fighter 6"),
        new Move(name: "DRC", notation: "DRC", type: "Mechanics", character: "Generic", game: "Street Fighter 6"),
        new Move(name: "DP", notation: "DP", type: "Mechanics", character: "Generic", game: "Street Fighter 6"),
        new Move(name: "OD", notation: "OD", type: "Mechanics", character: "Generic", game: "Street Fighter 6"),
        new Move(name: "Air", notation: "Air", type: "Mechanics", character: "Generic", game: "Street Fighter 6"),
        new Move(name: "Wall Bounce", notation: "WB", type: "Mechanics", character: "Generic", game: "Street Fighter 6"),

        // Stage
        new Move(name: "Wall Bounce", notation: "w/bounce", type: "Stage", character: "Generic", game: "Street Fighter 6"),

        // Movements
        new Move(name: "qcf", notation: "qcf", type: "Movement", character: "Generic", game: "Street Fighter 6", imageId: "move_sf6_qcf"),
        new Move(name: "qcb", notation: "qcb", type: "Movement", character: "Generic", game: "Street Fighter 6", imageId: "move_sf6_qcb"),
        new Move(name: "hcf", notation: "hcf", type: "Movement", character: "Generic", game: "Street Fighter 6", imageId: "move_sf6_hcf"),
        new Move(name: "hcb", notation: "bd", type: "Movement", character: "Generic", game: "Street Fighter 6", imageId: "move_sf6_hcb"),
        new Move(name: "fc", notation: "fc", type: "Movement", character: "Generic", game: "Street Fighter 6", imageId: "move_sf6_fc"),
        new Move(name: "dp", notation: "dp", type: "Movement", character: "Generic", game: "Street Fighter 6", imageId: "move_sf6_dp"),
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
        new Move(name: "Psycho Crusher Attack", notation: "Psycho Crusher Attack", type: "Special", character: "M.Bison", game: "Street Fighter 6"),
        new Move(name: "Double Knee Press", notation: "Double Knee Press", type: "Special", character: "M.Bison", game: "Street Fighter 6"),
        new Move(name: "Backfist Combo", notation: "Backfist Combo", type: "Special", character: "M.Bison", game: "Street Fighter 6"),
        new Move(name: "Shadow Rise", notation: "Shadow Rise", type: "Special", character: "M.Bison", game: "Street Fighter 6"),
        new Move(name: "Knee Press Nightmare", notation: "Knee Press Nightmare", type: "Super Art", character: "M.Bison", game: "Street Fighter 6"),
        new Move(name: "Psycho Punisher", notation: "Psycho Punisher", type: "Super Art", character: "M.Bison", game: "Street Fighter 6"),
        new Move(name: "Ultimate Psycho Crusher", notation: "Ultimate Psycho Crusher", type: "Super Art", character: "M.Bison", game: "Street Fighter 6"),

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
        new Move(name: "Bolshoi Storm Buster", notation: "Bolshoi Storm Buster", type: "Super Art", character: "Zangief", game: "Street Fighter 6"),
        
        // Yasmine
    new Move(name: "Daloy ng Tubig", notation: "236P", type: "Special", character: "Yasmine", game: "Street Fighter 6"),
    new Move(name: "Talim ng Hangin", notation: "214P", type: "Special", character: "Yasmine", game: "Street Fighter 6"),
    new Move(name: "Mukha ng Langit", notation: "236K", type: "Special", character: "Yasmine", game: "Street Fighter 6"),
    new Move(name: "Lipad ng Agila", notation: "623K", type: "Special", character: "Yasmine", game: "Street Fighter 6"),
    new Move(name: "Pangil sa Likuran", notation: "22P", type: "Special", character: "Yasmine", game: "Street Fighter 6"),
    new Move(name: "Hiwa ng Kalangitan", notation: "236236K", type: "Super", character: "Yasmine", game: "Street Fighter 6"),
    new Move(name: "Nakatagong Lakas", notation: "214214P", type: "Super", character: "Yasmine", game: "Street Fighter 6"),
    new Move(name: "Pamumukadkad ng Sampaguita", notation: "236236P", type: "Super", character: "Yasmine", game: "Street Fighter 6"),

    // Ingrid
    new Move(name: "Sun Shot", notation: "236P", type: "Special", character: "Ingrid", game: "Street Fighter 6"),
    new Move(name: "Sun Flare", notation: "214P", type: "Special", character: "Ingrid", game: "Street Fighter 6"),
    new Move(name: "Solar Burst", notation: "214P (air)", type: "Special", character: "Ingrid", game: "Street Fighter 6"),
    new Move(name: "Sun Rise", notation: "236K", type: "Special", character: "Ingrid", game: "Street Fighter 6"),
    new Move(name: "Sun Veil", notation: "22K", type: "Special", character: "Ingrid", game: "Street Fighter 6"),
    new Move(name: "Vanishing Sun", notation: "L/D/R + KKK", type: "Special", character: "Ingrid", game: "Street Fighter 6"),
    new Move(name: "Shining Sun", notation: "236236K", type: "Super", character: "Ingrid", game: "Street Fighter 6"),
    new Move(name: "Order of the Sun", notation: "214214P", type: "Super Art", character: "Ingrid", game: "Street Fighter 6"),
    new Move(name: "Cosmic Ray", notation: "236236P", type: "Super Art", character: "Ingrid", game: "Street Fighter 6"),

    // Alex
    new Move(name: "Flash Axe", notation: "236P", type: "Special", character: "Alex", game: "Street Fighter 6"),
    new Move(name: "Flash Chop", notation: "236H", type: "Special", character: "Alex", game: "Street Fighter 6"),
    new Move(name: "Aerial Knee Smash", notation: "623K", type: "Special", character: "Alex", game: "Street Fighter 6"),
    new Move(name: "Power Bomb", notation: "63214P", type: "Special", character: "Alex", game: "Street Fighter 6"),
    new Move(name: "Hyper Bomb", notation: "6 (during OD Powered Drop)", type: "Special", character: "Alex", game: "Street Fighter 6"),
    new Move(name: "Raging Spear", notation: "236236K", type: "Super Art", character: "Alex", game: "Street Fighter 6"),
    new Move(name: "Sledgecross Hammer", notation: "214214P", type: "Super Art", character: "Alex", game: "Street Fighter 6"),
    new Move(name: "Omega Wing Buster", notation: "PP (during OD Powered Drop)", type: "Super Art", character: "Alex", game: "Street Fighter 6"),
    new Move(name: "The Final Prison", notation: "236236P", type: "Super Art", character: "Alex", game: "Street Fighter 6"),

    // C. Viper
    new Move(name: "Thunder Dash", notation: "214P", type: "Special", character: "C. Viper", game: "Street Fighter 6"),
    new Move(name: "Burning Kick", notation: "236K", type: "Special", character: "C. Viper", game: "Street Fighter 6"),
    new Move(name: "Aerial Burning Kick", notation: "236K (air)", type: "Special", character: "C. Viper", game: "Street Fighter 6"),
    new Move(name: "Seismic Hammer", notation: "623P", type: "Special", character: "C. Viper", game: "Street Fighter 6"),
    new Move(name: "Focus Force", notation: "214K", type: "Special", character: "C. Viper", game: "Street Fighter 6"),
    new Move(name: "Limit Decoupler", notation: "236236K", type: "Super Art", character: "C. Viper", game: "Street Fighter 6"),
    new Move(name: "Mission Complete", notation: "214214P", type: "Super Art", character: "C. Viper", game: "Street Fighter 6"),
    new Move(name: "Hard Luck Rejector", notation: "214214K", type: "Super Art", character: "C. Viper", game: "Street Fighter 6"),
    ];
}