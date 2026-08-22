using FightingFlowDotNet.Models;

namespace FightingFlowDotNet.Resources;

public static class Tekken8
{
    public static readonly IReadOnlyList<string> StageImages =
    [
        "stage_t8_arena.png",
        "stage_t8_baobab.png",
        "stage_t8_baobab_2.png",
        "stage_t8_beach.png",
        "stage_t8_coliseum.png",
        "stage_t8_descent.png",
        "stage_t8_fallen_destiny.png",
        "stage_t8_forest.png",
        "stage_t8_genmaji_2.png",
        "stage_t8_midnight_siege.png",
        "stage_t8_ortiz_farm.png",
        "stage_t8_pacman.png",
        "stage_t8_palace.png",
        "stage_t8_phoenix_gate.png",
        "stage_t8_sanctum.png",
        "stage_t8_seine.png",
        "stage_t8_stratosphere.png",
        "stage_t8_temple.png",
        "stage_t8_times_square.png",
        "stage_t8_training_ground.png",
    ];

    public static List<Fighter> Fighters { get; set; } =
    [
new(name: "Alisa", bio: "A bioweapon android built by Dr. Bosconovitch using the brain of his late daughter, fighting alongside Lars Alexandersson out of genuine loyalty and affection despite her destructive capabilities.", imageId: "fighter_t8_alisa", fightingStyle: "Thruster-Based High-Mobility Fighting Style", game: "Tekken 8"),
new(name: "Anna", bio: "Nina Williams' younger sister and lifelong rival, a former assassin who fights with cold elegance and has spent decades locked in a bitter sibling feud that spans the entire series.", imageId: "fighter_t8_anna", fightingStyle: "Aikido based techniques and Koppojutsu based Assassination Arts", game: "Tekken 8"),
new () { Name = "Armor King", Bio = "A Mexican luchador who took up his late older brother's jaguar mask and armor after he was killed by Craig Marduk, seeking to avenge him and carry on the Armor King legacy.", FightingStyle = "Professional wrestling", Game = "Tekken 8", ImageId = "fighter_t8_armor_king", CombosById = [] },
new(name: "Asuka", bio: "A hot-blooded Osaka schoolgirl and distant relative of the Kazama bloodline, fighting to protect her city and its people while butting heads with her rival Lili.", imageId: "fighter_t8_asuka", fightingStyle: "Kazama Style Traditional Martial Arts", game: "Tekken 8"),
new(name: "Azucena", bio: "A Peruvian coffee farm heiress and MMA fighter who enters the tournament to save her family's struggling business, fighting with relentless energy and a love of counter-striking.", imageId: "fighter_t8_azucena", fightingStyle: "Mixed Martial Arts (Striker)", game: "Tekken 8"),
new Fighter { Name = "Bob", Bio = "A once-overweight fighter who transformed his body through relentless training and now runs a food business, bringing his trademark blend of speed, power, and comic charm back into the ring.", FightingStyle = "Freestyle Karate", Game = "Tekken 8", ImageId = "fighter_t8_bob", CombosById = [] },
new(name: "Bryan", bio: "A cybernetically resurrected former cop turned relentless killing machine, driven by an insatiable hunger for combat after being rebuilt by Dr. Abel following his death.", imageId: "fighter_t8_bryan", fightingStyle: "Kickboxing", game: "Tekken 8"),
new(name: "Claudio", bio: "The leader of a secretive Italian exorcist organization called Sirius, wielding forbidden techniques to hunt down and destroy supernatural threats like the Devil Gene.", imageId: "fighter_t8_claudio", fightingStyle: "Sirius Exorcist Arts", game: "Tekken 8"),
new(name: "Clive", bio: "The Final Fantasy XVI protagonist and a guest character, an Archduke's son turned Dominant of the Phoenix and Ifrit who wields fire magic and swordsmanship to reshape his war-torn homeland.", imageId: "fighter_t8_clive", fightingStyle: "Dominant", game: "Tekken 8"),
new(name: "Devil Jin", bio: "The manifestation of Jin Kazama's inner devil, a nearly mindless entity born from the Devil Gene that surfaces when Jin's rage or the demon within overwhelms his humanity.", imageId: "fighter_t8_devil_jin", fightingStyle: "Unknown", game: "Tekken 8"),
new(name: "Dragunov", bio: "A Russian special forces operative known as the White Angel of Death, dispatched on classified military missions that repeatedly draw him into the King of Iron Fist Tournament.", imageId: "fighter_t8_dragunov", fightingStyle: "White Reaper", game: "Tekken 8"),
new(name: "Eddy", bio: "A Brazilian capoeira practitioner who took up the fighting style to avenge his father's murder, blending fluid, dance-like movement with devastating low sweeps.", imageId: "fighter_t8_eddy", fightingStyle: "Capoeira", game: "Tekken 8"),
new() { Name = "Fahkumram", Bio = "A former undefeated Muay Thai champion of Thailand who exposed a fixed match by corrupt military officials, only to be captured and forced to fight on their behalf, with his wife and daughter held hostage.", FightingStyle = "Muay Thai", Game = "Tekken 8", ImageId = "fighter_t8_fahkumram", CombosById = [] },
new(name: "Feng", bio: "A Chinese martial arts prodigy obsessed with surpassing his late master and achieving true enlightenment through combat, treating every fight as a step toward transcendence.", imageId: "fighter_t8_feng", fightingStyle: "Taijiquan", game: "Tekken 8"),
new(name: "Heihachi", bio: "The ruthless patriarch of the Mishima Zaibatsu, a tyrannical businessman and martial artist who has repeatedly betrayed and been betrayed by his own son and grandson in the fight for control of his empire.", imageId: "fighter_t8_heihachi", fightingStyle: "Mishima Style Fighting Karate", game: "Tekken 8"),
new(name: "Hwoarang", bio: "A hot-headed Taekwondo prodigy and former gang leader fiercely devoted to defeating his rival Jin Kazama, treating their rivalry as the defining fight of his life.", imageId: "fighter_t8_hwoarang", fightingStyle: "Taekwondo", game: "Tekken 8"),
new(name: "Jack-8", bio: "The latest in a long line of military bioweapon robots built by Jack, deployed by G Corporation and slowly developing independent thought while protecting a young girl named Alisa's creator's legacy.", imageId: "fighter_t8_jack_8", fightingStyle: "High Tech Annihilator", game: "Tekken 8"),
new(name: "Jin", bio: "The son of Kazuya Mishima and grandson of Heihachi, cursed with the Devil Gene and driven by a lifelong mission to end the bloodline's cycle of violence once and for all.", imageId: "fighter_t8_jin", fightingStyle: "Karate based on Kyokushin style infused with Devil Gene", game: "Tekken 8"),
new(name: "Jun", bio: "Jin Kazama's mother and a nature-devoted spiritual guardian, presumed dead for years before resurfacing to help her son confront the Devil Gene threatening their family.", imageId: "fighter_t8_jun", fightingStyle: "Kazama Style Traditional Martial Arts", game: "Tekken 8"),
new(name: "Kazuya", bio: "The devil-possessed son of Heihachi Mishima and CEO of Mishima Zaibatsu, driven by an insatiable hunger for power and a deep, generations-long hatred of his own family.", imageId: "fighter_t8_kazuya", fightingStyle: "Mishima Style Fighting Karate", game: "Tekken 8"),
new(name: "King", bio: "A masked luchador raised in a Mexican orphanage and trained by the original Armor King, fighting to protect the children's home that raised him and honor his mentor's legacy.", imageId: "fighter_t8_king", fightingStyle: "Pro Wrestling", game: "Tekken 8"),
new(name: "Kuma", bio: "Heihachi Mishima's loyal trained bear, fiercely devoted to his owner and known for his surprising fighting prowess despite being, unmistakably, a bear.", imageId: "fighter_t8_kuma", fightingStyle: "Heihachi-style Improved Kuma Shinken", game: "Tekken 8"),
new Fighter { Name = "Kunimitsu", Bio = "A masked thief posing undercover at the Mishima Polytechnical School, secretly working with Reina to hunt down the Kuatatou, nine cursed blades, in her quest to steal the Cursed Blade Yoshimitsu from her mother's sworn enemy.", FightingStyle = "Ninjutsu", Game = "Tekken 8", ImageId = "fighter_t8_kunimitsu", CombosById = [] },
new(name: "Lars", bio: "A former Tekken Force commander and illegitimate son of Heihachi Mishima, who led a rebellion against the Mishima Zaibatsu and now fights to protect Alisa and end the family's tyranny.", imageId: "fighter_t8_lars", fightingStyle: "Tekken Forces Martial Arts", game: "Tekken 8"),
new(name: "Law", bio: "A hot-blooded martial artist and old friend of Paul Phoenix, running a driving school while chasing tournament glory and looking after his young son Forest.", imageId: "fighter_t8_law", fightingStyle: "Martial Arts", game: "Tekken 8"),
new(name: "Lee", bio: "Heihachi Mishima's adopted son and a sharp corporate rival, a smooth-talking industrialist who competes with the Mishima family for control of their business empire.", imageId: "fighter_t8_lee", fightingStyle: "Martial Arts", game: "Tekken 8"),
new(name: "Leo", bio: "A German martial artist trained in Baji Quan, entering the tournament to clear their father's name after he was framed for a crime tied to the Mishima Zaibatsu.", imageId: "fighter_t8_leo", fightingStyle: "Baji Quan", game: "Tekken 8"),
new(name: "Leroy", bio: "An aging former gang enforcer and master of Wing Chun, drawn out of quiet retirement after decades to settle old scores from his criminal past.", imageId: "fighter_t8_leroy", fightingStyle: "Wing Chun", game: "Tekken 8"),
new(name: "Lidia", bio: "The President of Poland and a skilled traditional karate practitioner, fighting to protect her nation's independence and reputation on the world stage.", imageId: "fighter_t8_lidia", fightingStyle: "Traditional Karate", game: "Tekken 8"),
new(name: "Lili", bio: "A wealthy Monégasque heiress with a self-taught, ballet-inspired fighting style, entering tournaments as much for excitement and rivalry with Asuka as for her family's oil fortune.", imageId: "fighter_t8_lili", fightingStyle: "Self-Taught Style", game: "Tekken 8"),
new Fighter { Name = "Miary Zo", Bio = "A cheerful teenager from Madagascar, revered in her village as the vessel of the Silver Fighting God. Accompanied by her ring-tailed lemur companions Vanilla and Cacao, she journeys the world to meet new 'battle friends forever.'", FightingStyle = "Moraingy and other African martial arts", Game = "Tekken 8", ImageId = "fighter_t8_miary_zo", CombosById = [] },
new(name: "Nina", bio: "An elite Irish assassin locked in a decades-long feud with her sister Anna, repeatedly drawn out of cryosleep and retirement to take on high-stakes contracts tied to the Mishima family.", imageId: "fighter_t8_nina", fightingStyle: "Assassination Arts", game: "Tekken 8"),
new(name: "Panda", bio: "Ling Xiaoyu's loyal and gentle pet panda, trained in the same bear-based fighting style as Kuma and fiercely protective of her owner.", imageId: "fighter_t8_panda", fightingStyle: "Heihachi-style Improved Kuma Shinken", game: "Tekken 8"),
new(name: "Paul", bio: "A blunt, self-proclaimed 'strongest man in the universe' and karate practitioner obsessed with proving his power, forever chasing rematches and bigger paydays alongside his rival-turned-friend Marshall Law.", imageId: "fighter_t8_paul", fightingStyle: "Integrated Martial Arts", game: "Tekken 8"),
new(name: "Raven", bio: "A mysterious operative working for a covert intelligence agency, using shadow-based ninjutsu techniques while pursuing his own hidden agenda within the tournament.", imageId: "fighter_t8_raven", fightingStyle: "Ninjutsu", game: "Tekken 8"),
new(name: "Reina", bio: "A mysterious woman with unclear ties to the Mishima bloodline, wielding a fighting style that blends Taido with Mishima-style karate as she pursues her own hidden goals.", imageId: "fighter_t8_reina", fightingStyle: "Taido and Mishima-Style Karate", game: "Tekken 8"),
new(name: "Shaheen", bio: "A Saudi Arabian former military officer seeking revenge against Kazuya Mishima, who was responsible for the death of his best friend and mentor.", imageId: "fighter_t8_shaheen", fightingStyle: "Close Quarters Combat", game: "Tekken 8"),
new(name: "Steve", bio: "A former British boxing champion pulled back into the ring after learning startling truths about his own origins tied to the Mishima Zaibatsu's genetic experiments.", imageId: "fighter_t8_steve", fightingStyle: "Boxing", game: "Tekken 8"),
new(name: "Victor", bio: "A suave French intelligence operative and master spy, entering the tournament under his own covert agenda while wielding a blade-focused close-quarters combat style.", imageId: "fighter_t8_victor", fightingStyle: "Super Spy CQB", game: "Tekken 8"),
new(name: "Xiaoyu", bio: "A cheerful Chinese schoolgirl and skilled martial artist who dreams of building an amusement park, entering the tournament for prize money and to look after her friend Jin.", imageId: "fighter_t8_xiaoyu", fightingStyle: "Chinese Martial Arts", game: "Tekken 8"),
new(name: "Yoshimitsu", bio: "The masked leader of the Manji Clan, a ninja swordsman driven by a code of honor to fight injustice and help the weak, wielding his cursed blade against evil.", imageId: "fighter_t8_yoshimitsu", fightingStyle: "Advanced Manji Ninjutsu", game: "Tekken 8"),
new(name: "Zafina", bio: "A guardian of an ancient order tasked with sealing away the demon Azazel, drawn into the tournament by visions and omens tied to the coming apocalypse.", imageId: "fighter_t8_zafina", fightingStyle: "Ancient Assassination Arts", game: "Tekken 8"),   
    ];
    
     public static readonly List<Move> Moves =
    [
        new Move(name: "break", notation: "►", type: "Break", character: "Generic", game: "tekken 8"),

        // Inputs
        new Move(name: "one", notation: "1", type: "Input", character: "Generic", game: "Tekken 8", imageId: "move_t8_one"),
        new Move(name: "two", notation: "2", type: "Input", character: "Generic", game: "Tekken 8", imageId: "move_t8_two"),
        new Move(name: "three", notation: "3", type: "Input", character: "Generic", game: "Tekken 8", imageId: "move_t8_three"),
        new Move(name: "four", notation: "4", type: "Input", character: "Generic", game: "Tekken 8", imageId: "move_t8_four"),
        new Move(name: "one_plus_two", notation: "1+2", type: "Input", character: "Generic", game: "Tekken 8", imageId: "move_t8_one_plus_two"),
        new Move(name: "three_plus_four", notation: "3+4", type: "Input", character: "Generic", game: "Tekken 8", imageId: "move_t8_three_plus_four"),
        new Move(name: "one_plus_three", notation: "1+3", type: "Input", character: "Generic", game: "Tekken 8", imageId: "move_t8_one_plus_three"),
        new Move(name: "two_plus_four", notation: "2+4", type: "Input", character: "Generic", game: "Tekken 8", imageId: "move_t8_two_plus_four"),
        new Move(name: "one_plus_four", notation: "1+4", type: "Input", character: "Generic", game: "Tekken 8", imageId: "move_t8_one_plus_four"),
        new Move(name: "two_plus_three", notation: "2+3", type: "Input", character: "Generic", game: "Tekken 8", imageId: "move_t8_two_plus_three"),
        new Move(name: "one_plus_two_plus_three", notation: "1+2+3", type: "Input", character: "Generic", game: "Tekken 8", imageId: "move_t8_one_plus_two_plus_three"),
        new Move(name: "one_plus_two_plus_four", notation: "1+2+4", type: "Input", character: "Generic", game: "Tekken 8", imageId: "move_t8_one_plus_two_plus_four"),
        new Move(name: "one_plus_three_plus_four", notation: "1+3+4", type: "Input", character: "Generic", game: "Tekken 8", imageId: "move_t8_one_plus_three_plus_four"),
        new Move(name: "two_plus_three_plus_four", notation: "2+3+4", type: "Input", character: "Generic", game: "Tekken 8", imageId: "move_t8_two_plus_three_plus_four"),
        new Move(name: "one_plus_two_plus_three_plus_four", notation: "1+2+3+4", type: "Input", character: "Generic", game: "Tekken 8", imageId: "move_t8_one_plus_two_plus_three_plus_four"),

        // Modifiers
        new Move(name: "Hold", notation: "h", type: "Modifier", character: "Generic", game: "Tekken 8"),
        new Move(name: "Hold Max", notation: "H", type: "Modifier", character: "Generic", game: "Tekken 8"),
        new Move(name: "Delay", notation: "delay", type: "Modifier", character: "Generic", game: "Tekken 8"),
        new Move(name: "Just Frame", notation: "j/f", type: "Modifier", character: "Generic", game: "Tekken 8"),
        new Move(name: "Slide", notation: "(s)", type: "Modifier", character: "Generic", game: "Tekken 8"),

        // Common Stances
        new Move(name: "Side Switch", notation: "s/s", type: "Common", character: "Generic", game: "Tekken"),
        new Move(name: "Back Turned", notation: "b/t", type: "Common", character: "Generic", game: "Tekken"),
        new Move(name: "Crouch", notation: "crouch", type: "Common", character: "Generic", game: "Tekken"),
        new Move(name: "Dash", notation: "dash", type: "Common", character: "Generic", game: "Tekken"),
        new Move(name: "Sidestep Left", notation: "s/l", type: "Common", character: "Generic", game: "Tekken"),
        new Move(name: "Sidestep Right", notation: "s/r", type: "Common", character: "Generic", game: "Tekken"),
        new Move(name: "Low Parry", notation: "l/p", type: "Common", character: "Generic", game: "Tekken"),

        // Mechanics
        new Move(name: "Heat Burst", notation: "h/burst", type: "Mechanics", character: "Generic", game: "Tekken"),
        new Move(name: "Heat Dash", notation: "h/dash", type: "Mechanics", character: "Generic", game: "Tekken"),
        new Move(name: "During Heat", notation: "in heat", type: "Mechanics", character: "Generic", game: "Tekken"),
        new Move(name: "Rage Art", notation: "rage", type: "Mechanics", character: "Generic", game: "Tekken"),
        new Move(name: "While Standing", notation: "w/s", type: "Mechanics Input", character: "Generic", game: "Tekken", imageId: "move_t8_while_standing"),
        new Move(name: "While Crouching", notation: "w/c", type: "Mechanics Input", character: "Generic", game: "Tekken", imageId: "move_t8_while_crouching"),

        // Stage
        new Move(name: "Wall Splat", notation: "w/splat", type: "Stage", character: "Generic", game: "Tekken"),
        new Move(name: "Wall Break", notation: "w/break", type: "Stage", character: "Generic", game: "Tekken"),
        new Move(name: "Wall Blast", notation: "w/blast", type: "Stage", character: "Generic", game: "Tekken"),
        new Move(name: "Wall Bounce", notation: "w/bounce", type: "Stage", character: "Generic", game: "Tekken"),
        new Move(name: "Floor Break", notation: "f/break", type: "Stage", character: "Generic", game: "Tekken"),
        new Move(name: "Floor Blast", notation: "f/blast", type: "Stage", character: "Generic", game: "Tekken"),
        new Move(name: "Balcony Break", notation: "b/break", type: "Stage", character: "Generic", game: "Tekken"),

        // Alisa
        new Move(name: "Destructive Form", notation: "Destructive Form", type: "Character", character: "Alisa"),
        new Move(name: "Boot", notation: "Boot", type: "Character", character: "Alisa"),
        new Move(name: "Dual Boot", notation: "Dual Boot", type: "Character", character: "Alisa"),

        // Anna
        new Move(name: "Hammer Chance", notation: "Hammer Chance", type: "Character", character: "Anna"),
        new Move(name: "Chaos Judgement", notation: "Chaos Judgement", type: "Character", character: "Anna"),

        //Asuka
        new Move(name: "Naniwa Gusto", notation: "Naniwa Gusto", type: "Character", character: "Asuka"),
        new Move(name: "Leg Cutter", notation: "Leg Cutter", type: "Character", character: "Asuka"),

        // Azucena
        new Move(name: "Libertador", notation: "Libertador", type: "Character", character: "Azucena"),
        new Move(name: "Taking High Attack", notation: "Taking High Attack", type: "Character", character: "Azucena"),
        new Move(name: "Taking Low Attack", notation: "Taking Low Attack", type: "Character", character: "Azucena"),

        // Bryan
        new Move(name: "Snake Eyes", notation: "Snake Eyes", type: "Character", character: "Bryan"),
        new Move(name: "Slither Step", notation: "Slither Step", type: "Character", character: "Bryan"),

        // Claudio
        new Move(name: "Starburst", notation: "Starburst", type: "Character", character: "Claudio"),

        // Clive
        new Move(name: "Phoenix Shift", notation: "Phoenix Shift", type: "Character", character: "Clive"),
        new Move(name: "Wings Of Light", notation: "Wings Of Light", type: "Character", character: "Clive"),
        new Move(name: "Updraft", notation: "Updraft", type: "Character", character: "Clive"),
        new Move(name: "Zantetsuken", notation: "Zantetsuken", type: "Character", character: "Clive"),

        // Devil Jin
        new Move(name: "Mourning Crow", notation: "Mourning Crow", type: "Character", character: "Devil Jin"),
        new Move(name: "Fly", notation: "Fly", type: "Character", character: "Devil Jin"),
        new Move(name: "WGS", notation: "WGS", type: "Mishima", character: "Devil Jin"),
        new Move(name: "WGF", notation: "WGF", type: "Mishima", character: "Devil Jin"),
        new Move(name: "EWGF", notation: "EWGF", type: "Mishima", character: "Devil Jin"),

        // Dragunov
        new Move(name: "Sneak", notation: "Sneak", type: "Character", character: "Dragunov"),

        // Eddy
        new Move(name: "Ginga", notation: "Ginga", type: "Character", character: "Eddy"),
        new Move(name: "Bananeira", notation: "Bananeira", type: "Character", character: "Eddy"),
        new Move(name: "Negativa", notation: "Negativa", type: "Character", character: "Eddy"),
        new Move(name: "Mandinga", notation: "Mandinga", type: "Character", character: "Eddy"),

        // Feng
        new Move(name: "Deceptive Step", notation: "Deceptive Step", type: "Character", character: "Feng"),
        new Move(name: "Shifting Clouds", notation: "Shifting Clouds", type: "Character", character: "Feng"),

        // Heihachi
        new Move(name: "Wind God's Kamae", notation: "Wind God's Kamae", type: "Character", character: "Heihachi"),
        new Move(name: "Thunder God's Kamae", notation: "Thunder God's Kamae", type: "Character",
            character: "Heihachi"),
        new Move(name: "Warrior Instinct", notation: "Warrior Instinct", type: "Character", character: "Heihachi"),
        new Move(name: "WGS", notation: "WGS", type: "Mishima", character: "Heihachi"),
        new Move(name: "WGF", notation: "WGF", type: "Mishima", character: "Heihachi"),
        new Move(name: "EWGF", notation: "EWGF", type: "Mishima", character: "Heihachi"),
        new Move(name: "TGF", notation: "TGF", type: "Mishima", character: "Heihachi"),
        new Move(name: "ETGF", notation: "ETGF", type: "Mishima", character: "Heihachi"),
        new Move(name: "BSK", notation: "BSK", type: "Mishima", character: "Heihachi"),
        new Move(name: "ESK", notation: "ESK", type: "Mishima", character: "Heihachi"),
        new Move(name: "SD", notation: "SD", type: "Mishima", character: "Heihachi"),

        // Hwoarang
        new Move(name: "Right Stance", notation: "Right Stance", type: "Character", character: "Hwoarang"),
        new Move(name: "Left Stance", notation: "Left Stance", type: "Character", character: "Hwoarang"),
        new Move(name: "Right Flamingo", notation: "Right Flamingo", type: "Character", character: "Hwoarang"),
        new Move(name: "Left Flamingo", notation: "Left Flamingo", type: "Character", character: "Hwoarang"),

        // Jack-8
        new Move(name: "Sit Down", notation: "Sit Down", type: "Character", character: "Jack-8"),
        new Move(name: "Gamma Howl", notation: "Gamma Howl", type: "Character", character: "Jack-8"),

        // Jin
        new Move(name: "Zenshin", notation: "Zenshin", type: "Character", character: "Jin"),
        new Move(name: "WGS", notation: "WGS", type: "Mishima", character: "Jin"),
        new Move(name: "WHF", notation: "WGF", type: "Mishima", character: "Jin"),
        new Move(name: "EWHF", notation: "EWGF", type: "Mishima", character: "Jin"),

        // Jun
        new Move(name: "Izumo", notation: "Izumo", type: "Character", character: "Jun"),
        new Move(name: "Genjutsu", notation: "Genjutsu", type: "Character", character: "Jun"),
        new Move(name: "Miare", notation: "Miare", type: "Character", character: "Jun"),

        // Kazuya
        new Move(name: "Devil Form", notation: "Devil Form", type: "Character", character: "Kazuya"),
        new Move(name: "WGS", notation: "WGS", type: "Mishima", character: "Kazuya"),
        new Move(name: "WGF", notation: "WGF", type: "Mishima", character: "Kazuya"),
        new Move(name: "EWGF", notation: "EWGF", type: "Mishima", character: "Kazuya"),

        // Kuma & Panda
        new Move(name: "Hunting", notation: "Hunting", type: "Character", character: "Kuma"),
        new Move(name: "Bear Sit", notation: "Bear Sit", type: "Character", character: "Kuma"),
        new Move(name: "Bear Roll", notation: "Bear Roll", type: "Character", character: "Kuma"),
        new Move(name: "Hunting", notation: "Hunting", type: "Character", character: "Panda"),
        new Move(name: "Bear Sit", notation: "Bear Sit", type: "Character", character: "Panda"),
        new Move(name: "Bear Roll", notation: "Bear Roll", type: "Character", character: "Panda"),

        // Lars
        new Move(name: "Dynamic Entry", notation: "Dynamic Entry", type: "Character", character: "Lars"),
        new Move(name: "Silent Entry", notation: "Silent Entry", type: "Character", character: "Lars"),
        new Move(name: "Limited Entry", notation: "Limited Entry", type: "Character", character: "Lars"),

        // Law
        new Move(name: "Dragon Charge", notation: "Dragon Charge", type: "Character", character: "Law"),

        // Lee
        new Move(name: "Hitman", notation: "Hitman", type: "Character", character: "Lee"),

        // Leo
        new Move(name: "Jin Ji Du Li", notation: "Jin Ji Du Li", type: "Character", character: "Leo"),
        new Move(name: "Fo Bu", notation: "Fo Bu", type: "Character", character: "Leo"),

        // Leroy
        new Move(name: "Hermit", notation: "Hermit", type: "Character", character: "Leroy"),

        // Lidia
        new Move(name: "Horse Stance", notation: "Horse Stance", type: "Character", character: "Lidia"),
        new Move(name: "Cat Stance", notation: "Cat Stance", type: "Character", character: "Lidia"),
        new Move(name: "Heaven and Earth", notation: "Heaven and Earth", type: "Character", character: "Lidia"),
        new Move(name: "Stalking Wolf Stance", notation: "Stalking Wolf Stance", type: "Character", character: "Lidia"),

        // Lili
        new Move(name: "Dew Glide", notation: "Dew Glide", type: "Character", character: "Lili"),

        // Raven
        new Move(name: "Soulzone", notation: "Soulzone", type: "Character", character: "Raven"),

        // Reina
        new Move(name: "Unsoku", notation: "Unsoku", type: "Character", character: "Reina"),
        new Move(name: "Sentai", notation: "Sentai", type: "Character", character: "Reina"),
        new Move(name: "Heaven's Wrath", notation: "Heaven's Wrath", type: "Character", character: "Reina"),
        new Move(name: "WGS", notation: "WGS", type: "Mishima", character: "Reina"),
        new Move(name: "WGF", notation: "WGF", type: "Mishima", character: "Reina"),
        new Move(name: "EWGF", notation: "EWGF", type: "Mishima", character: "Reina"),
        new Move(name: "WGK", notation: "WGK", type: "Mishima", character: "Reina"),
        new Move(name: "EWGK", notation: "EWGK", type: "Mishima", character: "Reina"),

        // Shaheen
        new Move(name: "Stealth Step", notation: "Stealth Step", type: "Character", character: "Shaheen"),

        // Steve
        new Move(name: "Quick Spin", notation: "Quick Spin", type: "Character", character: "Steve"),
        new Move(name: "Ducking", notation: "Ducking", type: "Character", character: "Steve"),
        new Move(name: "Peekaboo", notation: "Peekaboo", type: "Character", character: "Steve"),
        new Move(name: "Ducking In", notation: "Ducking In", type: "Character", character: "Steve"),
        new Move(name: "Ducking Left", notation: "Ducking Left", type: "Character", character: "Steve"),
        new Move(name: "Ducking Right", notation: "Ducking Right", type: "Character", character: "Steve"),
        new Move(name: "Flicker Stance", notation: "Flicker Stance", type: "Character", character: "Steve"),
        new Move(name: "Swaying", notation: "Swaying", type: "Character", character: "Steve"),
        new Move(name: "Lion Heart", notation: "Lion Heart", type: "Character", character: "Steve"),

        // Victor
        new Move(name: "Iai", notation: "Iai", type: "Character", character: "Victor"),
        new Move(name: "Perfumer", notation: "Perfumer", type: "Character", character: "Victor"),

        // Xiaoyu
        new Move(name: "Phoenix", notation: "Phoenix", type: "Character", character: "Xiaoyu"),
        new Move(name: "Hypnotist", notation: "Hypnotist", type: "Character", character: "Xiaoyu"),

        // Yoshimitsu
        new Move(name: "Kincho", notation: "Kincho", type: "Character", character: "Yoshimitsu"),
        new Move(name: "Mutou No Kiwami", notation: "Mutou No Kiwami", type: "Character", character: "Yoshimitsu"),
        new Move(name: "Manji Dragonfly", notation: "Manji Dragonfly", type: "Character", character: "Yoshimitsu"),
        new Move(name: "Flea", notation: "Flea", type: "Character", character: "Yoshimitsu"),
        new Move(name: "Indian Stance", notation: "Indian Stance", type: "Character", character: "Yoshimitsu"),

        // Zafina
        new Move(name: "Tarantula", notation: "Tarantula", type: "Character", character: "Zafina"),
        new Move(name: "Scarecrow", notation: "Scarecrow", type: "Character", character: "Zafina"),
        new Move(name: "Mantis", notation: "Mantis", type: "Character", character: "Zafina"),
        
        // Fahkumram
        new Move(name: "Garuda Force", notation: "Garuda Force", type: "Character", character: "Fahkumram"),
        new Move(name: "Rama Stance", notation: "Rama Stance", type: "Character", character: "Fahkumram"),
        new Move(name: "Avatar of Garuda", notation: "Avatar of Garuda", type: "Character", character: "Fahkumram"),

        // Armor King
        new Move(name: "Mexican Magma Drive", notation: "Mexican Magma Drive", type: "Character", character: "Armor King"),
        new Move(name: "Bad Jaguar", notation: "Bad Jaguar", type: "Character", character: "Armor King"),

        // Miary Zo
        new Move(name: "Morengy Miroso", notation: "Morengy Miroso", type: "Character", character: "Miary Zo"),
        new Move(name: "Boabab Mihira", notation: "Boabab Mihira", type: "Character", character: "Miary Zo"),
        new Move(name: "Mikiasaka Malaky", notation: "Mikiasaka Malaky", type: "Character", character: "Miary Zo"),

        // Kunimitsu
        new Move(name: "Setsunagake", notation: "Setsunagake", type: "Character", character: "Kunimitsu"),

        // Bob
        new Move(name: "Spinner Ball", notation: "Spinner Ball", type: "Character", character: "Bob"),

    ];
}