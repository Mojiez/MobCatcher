using System;
using System.Collections.Generic;
using System.Text;

namespace MobCatcher.GameData.Enviroment
{
    class EnviromentNameGenerator
    {
        /// <summary>
        /// returns a randomly generated string/name for a dungeon
        /// </summary>
        /// <returns></returns>
        public string DungeonNameGen()
        {
            Random random = new Random();
            var rnd = 0;
            var rnd2 = 0;
            var rnd3 = 0;
            var rnd4 = 0;
            List<string> names = new List<string>();

            var nm1 = new List<string>(new string[] { "Abandoned", "Abominable", "Abomination", "Abysmal", "Abyss", "Adamantine", "Adamantite", "Ancient", "Angry", "Arcane", "Arching", "Arctic", "Arid", "Bare", "Bellowing", "Black", "Black Forest", "Black Mountain", "Bleak", "Bloodfall", "Bloodlust", "Boiling", "Bottomless", "Brilliant", "Broken Bones", "Broken Curse", "Bronze", "Brutal", "Buried", "Burned", "Burning", "Burning Forest", "Buried", "Chaos", "Chaotic", "Cobalt", "Cold", "Collapsing", "Coral", "Courage", "Crescent Moon", "Crystal", "Cunning", "Cursed", "Damned", "Dancing", "Dark", "Daydream", "Dead", "Deadly", "Death Talon", "Decayed", "Decaying", "Deep", "Deepest", "Deepwood", "Delusion", "Demonic", "Depraved", "Desert", "Deserted", "Desolate", "Desolated", "Destroyed", "Destruction", "Diamond", "Dire", "Distant", "Dragon", "Dragonclaw", "Dragontooth", "Dread", "Dreaded", "Dreadful", "Dream", "Dreary", "Dry", "Dying", "Earth", "Eastern", "Eclipse", "Emerald", "Empty", "Enchanted", "Ender", "Erased", "Eternal", "Eternal Agony", "Eternal Rest", "Ethereal", "Fabled", "Fallen Legion", "False", "Feared", "Fearsome", "Fire", "Fire Mountain", "Flowing", "Foaming", "Forbidden", "Forgotten", "Forsaken", "Fractured", "Frozen", "Full Moon", "Ghost", "Glistening", "Gloomy", "Glowing", "Goblin", "Gold Mine", "Grey", "Grim", "Grizzly", "Hallucination", "Haunted", "Hidden", "Hollow", "Howling", "Hungry", "Illusion", "Infernal", "Infinite", "Invisible", "Iron", "Iron Mine", "Ironbark", "Isolated", "Jade", "Jagged", "Killing", "Laughing", "Laughing Skulls", "Lifeless", "Light", "Lion Tooth", "Living", "Living Dead", "Lonely", "Lost", "Lower", "Lucent", "Lurking Shadow", "Malicious", "Mesmerizing", "Mighty", "Mirage", "Mirrored", "Misty", "Mithril", "Mithril Mine", "Moaning", "Mocking", "Molten", "Motionless", "Mourning", "Murky", "Mysterious", "Mystic", "Narrow", "Nether", "Neverending", "Nightmare", "Northern", "Obliterated", "Oblivion", "Ogre", "Oracle", "Orc", "Overhanging", "Perfumed", "Phantom", "Phoenix", "Prisoner", "Quiet", "Raging", "Red", "Restless", "Roaring", "Rocking", "Rugged", "Sad", "Sanguine", "Savage", "Scarlet", "Scheming", "Scorching", "Screaming", "Secret", "Serene", "Shadow", "Shadowed", "Shadowy", "Shimmering", "Shrieking", "Silent", "Silver", "Sleeping", "Smoky", "Smoldering", "Sorrow", "Southern", "Specter", "Spirit", "Steel", "Sterile", "Sunken", "Swamp", "Terraced", "Thief", "Thundering", "Tormented", "Tranquil", "Turbulent", "Twilight", "Twisted", "Twisting", "Unholy", "Unknown", "Unstable", "Vicious", "Violent", "Voiceless", "Voiceless Whimpers", "Volcanic", "Wailing", "Wasted", "Watching Eyes", "Western", "Whispering", "Whispering Shadows", "White", "White Forest", "Wicked", "Wild", "Wind", "Windy", "Winter", "Withered", "Wondering", "Wraith", "Wrath", "Yawning" });
            var nm2 = new List<string>(new string[] { "Burrows", "Catacombs", "Caverns", "Cells", "Chambers", "Crypt", "Delves", "Dungeon", "Grotto", "Haunt", "Labyrinth", "Lair", "Maze", "Pits", "Point", "Quarters", "Tombs", "Tunnels", "Vault" });
            var nm3 = new List<string>(new string[] { "Black", "White", "Silver", "Golden", "Crystal", "Fallen", "Ghost", "Phantom", "Hidden", "Secret", "Hopeless", "Forsaken", "Gentle", "Chaotic", "Conquered", "Burning", "Poisoned", "Whispering", "Mourning", "Crying", "Lost", "Infernal", "Vanished", "Rejected", "Neglected", "Shunned", "Impostor", "Renegade", "Betrayed", "Vanquished", "Burning", "Frozen", "Destroyed", "Cursed", "Ancient", "Obsidian", "Ebon", "Forbidden", "Lonely", "Nameless", "Dark", "Cold", "Haunted", "Forgotten", "Scarlet", "Shrouded", "Uncanny", "Unspoken", "Vanishing", "Nightmare", "Mystic", "Mythic", "Enigmatic", "Doomed", "Death's", "Spirit", "Spirit's", "Unknown", "Shadow", "Elemental", "Savage", "Storm", "Thunder", "Barbaric", "Cruel", "Brutal", "Blooded", "Ruthless", "Raging", "Furious", "Mad", "Granite", "Dishonored", "Perished" });
            var nm4 = new List<string>(new string[] { "Arachnid", "Army", "Basilisk", "Bat", "Bear", "Cult", "Desert", "Dragon", "Eagle", "Elf", "Emperor", "Forest", "Giant", "Goblin", "Guardian", "Horsemen", "Hound", "Hunter", "Jungle", "King", "Knight", "Legion", "Leopard", "Lion", "Mage", "Marsh", "Monk", "Morass", "Mountain", "Occult", "Ogre", "Oracle", "Orc", "Paladin", "Panther", "Phoenix", "Priest", "Queen", "Raven", "Scorpion", "Serpent", "Soldier", "Spider", "Swamp", "Tiger", "Warrior", "Widow", "Witch", "Wizard", "Warlord", "Wolf" });

            for (int i = 0; i < 10; i++)
            {
                    rnd2 = random.Next(nm2.Count | 0);

                    if (i < 5)
                    {
                        rnd3 = random.Next(nm3.Count | 0);
                        rnd4 = random.Next(nm4.Count | 0);
                        names.Add(nm2[rnd2] + " of the " + nm3[rnd3] + " " + nm4[rnd4]);
                    }
                    else
                    {
                        rnd = random.Next(nm1.Count | 0);
                        names.Add("The " + nm1[rnd] + " " + nm2[rnd2]);
                    }
            }
            return names[random.Next(names.Count)].ToString();
        }

        /// <summary>
        /// returns a randomly generated string/name for a ruin
        /// </summary>
        /// <returns></returns>
        public string RuinNameGen()
        {
            Random random = new Random();
            var rnd = 0;
            var rnd2 = 0;
            List<string> names = new List<string>();

            var nm1 = new List<string>(new string[] { "Borough", "City", "Cove", "Farms", "Fields", "Forest", "Harbor", "Island", "Isle", "Labyrinth", "Lands", "Mountain", "Outpost", "Reef", "River", "Shore", "Temple", "Town", "Vault", "Village" });
            var nm2 = new List<string>(new string[] { "Ash", "Ashes", "Blight", "Bones", "Chaos", "Charcoal", "Coal", "Collapse", "Corrosion", "Cracks", "Crimson", "Crumbles", "Darkness", "Death", "Debris", "Decay", "Desertion", "Desolation", "Despair", "Dishonor", "Doom", "Dread", "Dreams", "Destruction", "Dusk", "Emptiness", "Ends", "Exiles", "Extinction", "Fire", "Fog", "Fragments", "Ghosts", "Gloom", "Graves", "Hauntings", "Ice", "Illusions", "Isolation", "Mist", "Mold", "Molten Rock", "Myths", "Necrosis", "Nightfall", "Nightmares", "Oblivion", "Obsidian", "Onyx", "Phantoms", "Pieces", "Plants", "Remains", "Remnants", "Residue", "Rot", "Rubble", "Ruination", "Ruins", "Rust", "Screams", "Shadows", "Shambles", "Shrubs", "Silence", "Silver", "Skeletons", "Skulls", "Slate", "Sleep", "Smoke", "Solitude", "Soot", "Spirits", "Stone", "Twilight", "Undoing", "Vibrations", "Waste", "Water", "Whispers", "Wind", "Wreckages", "the Abandoned", "the Abyss", "the Broken", "the Curse", "the Damned", "the Fallen", "the Forgotten", "the Forsaken", "the Infernal", "the Inferno", "the Lost", "the Night", "the Perished", "the Scourge", "the Unknown", "the Vanquished", "the Void" });
            var nm3 = new List<string>(new string[] { "Abandoned", "Abyss", "Agony", "Ashen", "Bare", "Barren", "Bleak", "Blight", "Bone", "Broken", "Burning", "Chaos", "Charcoal", "Coal", "Cobalt", "Collapsed", "Corroded", "Cracking", "Crimson", "Crumbled", "Crumbling", "Cursed", "Damned", "Dark", "Dcayed", "Dead", "Debris", "Decaying", "Deserted", "Desolated", "Desolation", "Despair", "Destroyed", "Destruction", "Dismissed", "Doom", "Dread", "Emptied", "Empty", "End", "Ender", "Erased", "Ethereal", "Exile", "Exiled", "Extinct", "Fallen", "Fire", "Foggy", "Forgotten", "Forsaken", "Fragmented", "Frozen", "Ghost", "Gloom", "Grave", "Haunted", "Ice", "Illusion", "Infernal", "Inferno", "Isolated", "Isolation", "Lifeless", "Lonely", "Lost", "Mist", "Molded", "Molten", "Motionless", "Murky", "Mythic", "Nameless", "Necrotic", "Neglected", "Night", "Nightmare", "Nullified", "Obliterated", "Oblivion", "Obsidian", "Onyx", "Overgrown", "Perished", "Petrified", "Phantom", "Remnant", "Residue", "Rotting", "Rubble", "Ruin", "Ruined", "Rusted", "Savage", "Scorching", "Scourge", "Scream", "Screaming", "Shadow", "Shamble", "Shrub", "Silent", "Silver", "Skeleton", "Skull", "Slate", "Sleeping", "Sleepy", "Smoke", "Solitude", "Soot", "Spirit", "Stone", "Twilight", "Uncanny", "Undone", "Unknown", "Vanquished", "Vibrating", "Void", "Waste", "Wasted", "Weeping", "Whisper", "Whispering", "Windy", "Wreckage" });

            for (int i = 0; i < 10; i++)
            {
                if (i < 5)
                {
                    rnd = random.Next(nm1.Count);
                    rnd2 = random.Next(nm2.Count);
                    names.Add(nm1[rnd] + " of " + nm2[rnd2]);
                }
                else
                {
                    rnd = random.Next(nm3.Count);
                    rnd2 = random.Next(nm1.Count);
                    names.Add("The " + nm3[rnd] + " " + nm1[rnd2]);
                }
            }
            return names[random.Next(names.Count)].ToString();
        }
    }
}
