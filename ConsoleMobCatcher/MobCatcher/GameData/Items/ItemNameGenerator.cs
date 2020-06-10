using System;
using System.Collections.Generic;
using System.Text;

namespace MobCatcher.GameData.Items
{
    public class ItemNameGenerator
    {
        ItemGenerator itemGenenerator = new ItemGenerator();

        public string GenerateItemName(int type)
        {
            string name = string.Empty;
            switch (type)
            {
                case 1:
                    name = GenerateJewelryName();
                    break;
                case 2:
                    name = GenerateHelmetName();
                    break;
                case 3:
                    name = GenerateChestName();
                    break;
                case 4:
                    name = GenerateGloveName();
                    break;
                case 5:
                    name = GenerateBootsName();
                    break;
            }
            return name;
        }

        /// <summary>
        /// Returns a randomly generated string/name for jewelry
        /// </summary>
        /// <returns></returns>
        private string GenerateJewelryName()
        {
            Random random = new Random();
            string name = string.Empty;

            var rnd = 0;
            var rnd2 = 0;
            var rnd3 = 0;
            List<string> names = new List<string>();

            var nm1 = new List<string>(new string[] {
                "Adored", "Agate", "Aged", "Amber", "Amethyst", "Ancient", "Angel", "Angelic", "Anonymous", "Antique", "Arctic", "Austere", "Azure", "Blind", "Blushing", "Brave", "Bright", "Brilliant", "Broken", "Citrine", "Colossal", "Coral", "Crisp", "Crystal", "Curly", "Curvy", "Darling", "Dearest", "Defiant", "Devoted", "Diamond", "Diligent", "Earnest", "Elated", "Elegant", "Emerald", "Enchanted", "Enchanting", "Enlightened", "Exalted", "Exotic", "Faint", "Fair", "Feline", "Flawless", "Forsaken", "Free", "Frozen", "Garnet", "Gentle", "Gifted", "Glistening", "Graceful", "Gracious", "Grand", "Grateful", "Handsome", "Happy", "Harmonious", "Heaven", "Heavenly", "Hematite", "Honest", "Humble", "Idle", "Illustrious", "Impossible", "Infinite", "Innocent", "Jade", "Jasper", "Lavish", "Lonely", "Loyal", "Luminous", "Lunar", "Lustrous", "Majestic", "Malachite", "Mellow", "Mysterious", "Obsidian", "Ocean", "Onyx", "Parallel", "Peace", "Peaceful", "Pearl", "Perfect", "Pink", "Playful", "Precious", "Pristine", "Proud", "Pure", "Purity", "Quiet", "Royal", "Ruby", "Sapphire", "Scented", "Secret", "Serene", "Serpent", "Serpentine", "Shadow", "Silent", "Sinful", "Solar", "Spinel", "Spotless", "Stunning", "Sweet", "Tempting", "Tender", "Tinted", "Unmounted", "Velvet", "Vibrant", "Violet", "Virtuous", "Worthy", "Zircon" });
            var nm2 = new List<string>(new string[]
            { "Ambition", "Aura", "Balance", "Bauble", "Beauty", "Belle", "Blessing", "Bliss", "Blossom", "Bond", "Breath", "Bubble", "Charm", "Class", "Clover", "Core", "Crescent", "Crest", "Cross", "Crux", "Desire", "Devotion", "Dewdrop", "Dream", "Drop", "Droplet", "Eye", "Fan", "Favor", "Flame", "Flower", "Focus", "Force", "Gift", "Glamour", "Globe", "Grace", "Heart", "Hope", "Hum", "Hymn", "Image", "Leaf", "Life", "Light", "Lily", "Love", "Lure", "Mark", "Memorial", "Mind", "Moon", "Oath", "Oculus", "Orb", "Palm", "Panther", "Passion", "Petal", "Pledge", "Poem", "Prayer", "Promise", "Prospect", "Rainbow", "Resolve", "Riddle", "Rock", "Root", "Scale", "Seal", "Shield", "Song", "Soul", "Spark", "Spiral", "Spirit", "Star", "Stone", "Sun", "Swan", "Tear", "Teardrop", "Tempest", "Tribute", "Trinket", "Twin", "Twins", "Twirl", "Twist", "Valor", "Vigor", "Vision", "Voice", "Vow", "Whisper", "Will", "Wing", "Wings", "Wish" });
            var nm3 = new List<string>(new string[]
            { "Tiara", "Necklace", "Amulet", "Bracelet", "Ornament", "Pendant", "Ring", "Pin", "Choker", "Anklet", "Brooch", "Necklace", "Amulet", "Bracelet", "Pendant", "Ring" });
            var nm4a = new List<string>(new string[]
            { "Âgé", "Éclairé", "Élégant", "Étourdissant", "Abandonné", "Adoré", "Ancien", "Angélique", "Anonyme", "Antique", "Arctique", "Ardent", "Austère", "Aveugle", "Azuré", "Bouclé", "Brillant", "Céleste", "Chéri", "Clair", "Colossal", "Coupable", "Courageux", "Dévoué", "Digne", "Diligent", "Donné", "Doux", "Enchanté", "Enchanteur", "Enjoué", "Exalté", "Exotique", "Félin", "Fantastique", "Fidèle", "Fier", "Généreux", "Gelé", "Gentil", "Glacé", "Gracieux", "Harmonieux", "Heureux", "Honnête", "Humble", "Illustre", "Immaculé", "Immonde", "Impeccable", "Impossible", "Inconnu", "Infini", "Innocent", "Libre", "Loyal", "Lumineux", "Lunaire", "Lustré", "Luxueux", "Mélodieux", "Méritant", "Magnifique", "Majestueux", "Modeste", "Moelleux", "Mystérieux", "Noble", "Pâle", "Paisible", "Paradisiaque", "Parallèle", "Parfait", "Parfumé", "Précieux", "Pur", "Reconnaissant", "Reluisant", "Rose", "Rougissant", "Royal", "Scintillant", "Secret", "Sensationnel", "Serein", "Silencieux", "Sincère", "Sinueux", "Solaire", "Solitaire", "Stupéfiant", "Teinté", "Tendre", "Tentant", "Tranquille", "Vaillant", "Velouté", "Vertueux", "Vibrant", "Vif", "Violet", "Virginal", "Vivant", "au Repos", "d'Émeraude", "d'Agate", "d'Améthyste", "d'Ambre", "d'Ange", "d'Hématite", "d'Obsidienne", "d'Océan", "d'Ombre", "d'Onyx", "de Citrine", "de Corail", "de Cristal", "de Défi", "de Diamant", "de Grenat", "de Jade", "de Jaspe", "de Malachite", "de Nacre", "de Paix", "de Perle", "de Pureté", "de Rubis", "de Saphir", "de Spinelle", "de Zircon" });
            var nm4b = new List<string>(new string[]
            { "Âgée", "Éclairée", "Élégante", "Étourdissante", "Abandonnée", "Adorée", "Ancienne", "Angélique", "Anonyme", "Antique", "Arctique", "Ardente", "Austère", "Aveugle", "Azurée", "Bouclée", "Brillante", "Céleste", "Chérie", "Claire", "Colossale", "Coupable", "Courageuse", "Dévouée", "Digne", "Diligente", "Donnée", "Douce", "Enchantée", "Enchanteresse", "Enjouée", "Exaltée", "Exotique", "Féline", "Fantastique", "Fidèle", "Fière", "Généreuse", "Gelée", "Gentile", "Glacée", "Gracieuse", "Harmonieuse", "Heureuse", "Honnête", "Humble", "Illustre", "Immaculée", "Immonde", "Impeccable", "Impossible", "Inconnue", "Infinie", "Innocente", "Libre", "Loyale", "Lumineuse", "Lunaire", "Lustrée", "Luxueuse", "Mélodieuse", "Méritante", "Magnifique", "Majestueuse", "Modeste", "Moelleuse", "Mystérieuse", "Noble", "Pâle", "Paisible", "Paradisiaque", "Parallèle", "Parfaite", "Parfumée", "Précieuse", "Pure", "Reconnaissante", "Reluisante", "Rose", "Rougissante", "Royale", "Scintillante", "Secrète", "Sensationnelle", "Sereine", "Silencieuse", "Sincère", "Sinueuse", "Solaire", "Solitaire", "Stupéfiante", "Teintée", "Tendre", "Tentante", "Tranquille", "Vaillante", "Veloutée", "Vertueuse", "Vibrante", "Vive", "Violette", "Virginale", "Vivante", "au Repos", "d'Émeraude", "d'Agate", "d'Améthyste", "d'Ambre", "d'Ange", "d'Hématite", "d'Obsidienne", "d'Océan", "d'Ombre", "d'Onyx", "de Citrine", "de Corail", "de Cristal", "de Défi", "de Diamant", "de Grenat", "de Jade", "de Jaspe", "de Malachite", "de Nacre", "de Paix", "de Perle", "de Pureté", "de Rubis", "de Saphir", "de Spinelle", "de Zircon" });
            var nm5 = new List<string>(new string[]
            { "d'Âme", "d'Écaille", "d'Énergie", "d'Énigme", "d'Éternité", "d'Étincelle", "d'Étoile", "d'Admiration", "d'Aile", "d'Ambition", "d'Atmosphère", "d'Aura", "d'Envie", "d'Idée", "d'Image", "d'Imagination", "d'Intelligence", "d'Origine", "de Bénédiction", "de Babiole", "de Balance", "de Beauté", "de Bravoure", "de Brise", "de Bulle", "de Chanson", "de Classe", "de Croix", "de Détermination", "de Dévotion", "de Donation", "de Félicité", "de Faveur", "de Feuille", "de Fioriture", "de Flamme", "de Fleur", "de Floraison", "de Force", "de Gouttelette", "de Grâce", "de Jumelle", "de Larme", "de Liaison", "de Lueur", "de Lumière", "de Lune", "de Mémoire", "de Marque", "de Marveille", "de Panthère", "de Passion", "de Pierre", "de Poésie", "de Prière", "de Promesse", "de Résolution", "de Rêverie", "de Racine", "de Roche", "de Séduction", "de Songerie", "de Source", "de Sphère", "de Spirale", "de Tempête", "de Terre", "de Trace", "de Valeur", "de Vie", "de Vigueur", "de Vision", "de Vivacité", "de Voix", "de Volonté", "d'Éclat", "d'Écu", "d'Œil", "d'Admirateur", "d'Amour", "d'Arc en Ciel", "d'Attrait", "d'Engagement", "d'Espoir", "d'Esprit", "d'Hommage", "d'Hymne", "d'Orage", "d'Orbe", "de Bibelot", "de Blason", "de Bonheur", "de Cœur", "de Cadeau", "de Centre", "de Cerveau", "de Chant", "de Charme", "de Courage", "de Cygne", "de Désir", "de Dévouement", "de Feu", "de Globe", "de Jumeau", "de Mémorial", "de Murmure", "de Mystère", "de Nœud", "de Pétale", "de Pacte", "de Paume", "de Poème", "de Rêve", "de Sceau", "de Serment", "de Signe", "de Soleil", "de Souffle", "de Souhait", "de Souvenir", "de Trèfle", "de Tribut", "de Vœu" });
            var nm6 = new List<string>(new string[]
            { "la Tiare", "l'Amulette", "l'Amulette", "la Bague", "la Bague", "la Broche", "le Diadème", "le Sautoir", "le Sautoir", "le Bracelet", "le Bracelet", "le Collier", "l'Ornament", "le Pendentif", "le Pendentif" });

            for (int i = 0; i < 10; i++)
            {
                var type = random.Next(10);
                if (type == 1)
                {
                    rnd = random.Next(nm6.Count | 0);
                    rnd2 = random.Next(nm4a.Count | 0);
                    if (i < 5)
                    {
                        if (rnd < 6)
                        {
                            names.Add(nm6[rnd] + " " + nm4b[rnd2]);
                        }
                        else
                        {
                            names.Add(nm6[rnd] + " " + nm4a[rnd2]);
                        }
                        ListClass.Splice(nm4a, rnd2, 1);
                        ListClass.Splice(nm4b, rnd2, 1);
                    }
                    else
                    {
                        rnd3 = random.Next(nm5.Count | 0);
                        while (rnd2 > 102)
                        {
                            rnd2 = random.Next(nm4a.Count | 0);
                        }
                        if (rnd3 < 105)
                        {
                            names.Add(nm6[rnd] + " " + nm5[rnd3] + " " + nm4b[rnd2]);
                        }
                        else
                        {
                            names.Add(nm6[rnd] + " " + nm5[rnd3] + " " + nm4a[rnd2]);
                        }
                        ListClass.Splice(nm4a, rnd2, 1);
                        ListClass.Splice(nm4b, rnd2, 1);
                        ListClass.Splice(nm5, rnd2, 1);
                    }
                }
                else
                {
                    rnd = random.Next(nm1.Count | 0);
                    rnd2 = random.Next(nm2.Count | 0);
                    if (i < 5)
                    {
                        names.Add("The " + nm1[rnd] + " " + nm2[rnd2]);
                        ListClass.Splice(nm1, rnd, 1);
                        ListClass.Splice(nm2, rnd2, 1);
                    }
                    else
                    {
                        rnd3 = random.Next(nm3.Count | 0);
                        names.Add("The " + nm1[rnd] + " " + nm2[rnd2] + " " + nm3[rnd3]);

                        ListClass.Splice(nm1, rnd, 1);
                        ListClass.Splice(nm2, rnd2, 1);
                    }
                }
            }
            return names[random.Next(names.Count)].ToString();
        }

        /// <summary>
        /// returns a randomly generated string/name for a helmet
        /// </summary>
        /// <returns></returns>
        private string GenerateHelmetName()
        {
            Random random = new Random();
            List<string> names4;
            List<string> names5;
            List<string> names6;
            var rnd0 = 0;
            var rnd1 = 0;
            var rnd2 = 0;
            var rnd3 = 0;


            List<string> names1 = new List<string>(new string[] { "Ancient", "Binding", "Blessed", "Blind", "Broken", "Burning", "Condemned", "Conquered", "Cursed", "Damned", "Dark", "Demonic", "Distant", "Divine", "Doomed", "Ending", "Endless", "Eternal", "Faded", "Fallen", "Fleeting", "Frozen", "Hallowed", "Haunted", "Hellish", "Holy", "Imminent", "Immortal", "Infernal", "Infinite", "Lost", "Ominous", "Relentless", "Sacred", "Shattered", "Silent", "Smoldering", "Timeless", "Twisted", "Unholy" });
            List<string> names2 = new List<string>(new string[] { "Ancestors", "Bloodlust", "Comrades", "Damnation", "Dreams", "Fire", "Fires", "Fortune", "Fortunes", "Freedom", "Glory", "Hell", "Hells", "Honor", "Hope", "Illusions", "Justice", "Kings", "Lands", "Magic", "Memories", "Might", "Misery", "Nightmares", "Nights", "Power", "Powers", "Protection", "Punishment", "Sorrow", "Souls", "Torment", "Trials", "Vengeance", "Visions", "Voices", "Warlords", "Wars", "Whispers", "Worlds" });
            List<string> names3 = new List<string>(new string[] { "Ancient", "Arcane", "Atuned", "Bandit's", "Baneful", "Banished", "Barbarian", "Barbaric", "Battleworn", "Blood Infused", "Blood-Forged", "Bloodcursed", "Bloodied", "Bloodlord's", "Bloodsurge", "Brutal", "Brutality", "Burnished", "Captain's", "Cataclysm", "Cataclysmic", "Challenger", "Challenger's", "Champion", "Champion's", "Cold-Forged", "Conqueror", "Conqueror's", "Corrupted", "Crazed", "Crying", "Cursed", "Defender", "Defender's", "Defiled", "Demonic", "Desire's", "Desolation", "Destiny's", "Dire", "Doom", "Doom's", "Dragon's", "Dragon", "Ebon", "Enchanted", "Engraved", "Eternal", "Exile", "Extinction", "Faith's", "Faithful", "Fearful", "Feral", "Fierce", "Fiery", "Fire Infused", "Firesoul", "Forsaken", "Fortune's", "Frenzied", "Frost", "Frozen", "Furious", "Fusion", "Ghastly", "Ghost-Forged", "Ghostly", "Gladiator", "Gladiator's", "Grieving", "Guard's", "Guardian's", "Hatred", "Haunted", "Heartless", "Hero", "Hero's", "Hollow", "Holy", "Honed", "Honor's", "Hope's", "Hopeless", "Howling", "Hungering", "Incarnated", "Infused", "Inherited", "Jade Infused", "Judgement", "Keeper's", "Knightly", "Legionnaire's", "Liar's", "Lich", "Lightning", "Lonely", "Loyal", "Lusting", "Malevolent", "Malicious", "Malignant", "Massive", "Mended", "Mercenary", "Military", "Misfortune's", "Mourning", "Nightmare", "Oathkeeper's", "Ominous", "Peacekeeper", "Peacekeeper's", "Phantom", "Possessed", "Pride's", "Primal", "Prime", "Primitive", "Promised", "Protector's", "Proud", "Recruit's", "Reforged", "Reincarnated", "Relentless", "Remorse", "Renewed", "Renovated", "Restored", "Retribution", "Ritual", "Roaring", "Ruby Infused", "Rune-Forged", "Savage", "Sentinel", "Shadow", "Silent", "Singing", "Sinister", "Soldier's", "Solitude's", "Sorrow's", "Soul", "Soul Infused", "Soul-Forged", "Soulless", "Spectral", "Spite", "Storm", "Storm-Forged", "Stormfury", "Stormguard", "Terror", "Thunder", "Thunder-Forged", "Thunderfury", "Thunderguard", "Thundersoul", "Thunderstorm", "Timeworn", "Tormented", "Trainee's", "Treachery's", "Twilight", "Twilight's", "Twisted", "Tyrannical", "Undead", "Unholy", "Vanquisher", "Vengeance", "Vengeful", "Vicious", "Victor", "Vindication", "Vindicator", "Vindictive", "War-Forged", "Warden's", "Warlord's", "Warped", "Warrior", "Warrior's", "Whistling", "Wicked", "Wind's", "Wind-Forged", "Windsong", "Woeful", "Wrathful", "Wretched", "Yearning", "Zealous", "", "", "", "", "", "", "", "", "" });
            List<string> names7 = new List<string>(new string[] { "Absorption", "the Phoenix", "Adventure", "Agony", "Ancient Power", "Ancient Powers", "Anger", "Anguish", "Annihilation", "Arcane Magic", "Arcane Power", "Arcane Resist", "Archery", "Ashes", "Assassination", "Assassins", "Assaults", "Auras", "Awareness", "Barriers", "Beginnings", "Binding", "Black Magic", "Blast Protection", "Blessed Fortune", "Blessed Fortunes", "Blessings", "Blight", "Blood", "Bloodlust", "Bloodshed", "Bravery", "Broken Bones", "Broken Dreams", "Broken Families", "Broken Worlds", "Burdens", "Carnage", "Cataclysms", "Chaos", "Clarity", "Conquered Worlds", "Corruption", "Courage", "Creation", "Cunning", "Danger", "Dark Magic", "Dark Powers", "Dark Souls", "Darkness", "Dawn", "Decay", "Deception", "Defiance", "Deflection", "Delirium", "Delusions", "Demon Fire", "Demons", "Denial", "Desecration", "Despair", "Destruction", "Devotion", "Diligence", "Discipline", "Dishonor", "Dismay", "Dominance", "Domination", "Doom", "Dragons", "Dragonsouls", "Dread", "Dreams", "Due Diligence", "Duels", "Dusk", "Echoes", "Enchantments", "Ended Dreams", "Ending Hope", "Ending Misery", "Ends", "Eternal Bloodlust", "Eternal Damnation", "Eternal Glory", "Eternal Justice", "Eternal Rest", "Eternal Sorrow", "Eternal Struggles", "Eternity", "Executions", "Extinction", "Faded Memories", "Fallen Kings", "Fallen Souls", "Fire", "Fire Magic", "Fire Power", "Fire Protection", "Fire Resist", "Fools", "Forging", "Fortitude", "Fortune", "Frost", "Frost Power", "Frost Resist", "Frozen Hells", "Fury", "Ghosts", "Giants", "Giantslaying", "Glory", "Grace", "Greed", "Grieving Widows", "Guardians", "Hate", "Hatred", "Healing", "Hell", "Hell's Games", "Hellfire", "Hellish Torment", "Heroes", "Holy Might", "Honor", "Hope", "Horrors", "Ice", "Ice Magic", "Illusions", "Immortality", "Inception", "Infinite Trials", "Infinity", "Insanity", "Justice", "Kings", "Life", "Lifemending", "Lifestealing", "Light's Hope", "Limbo", "Lost Comrades", "Lost Hope", "Lost Souls", "Lost Voices", "Lost Worlds", "Mercy", "Might", "Miracles", "Misery", "Mists", "Moonlight", "Mysteries", "Mystery", "Nature", "Necromancy", "Nightmares", "Oblivion", "Paradise", "Patience", "Phantoms", "Power", "Prayers", "Pride", "Pride's Fall", "Prophecies", "Protection", "Putrefaction", "Reckoning", "Recoil", "Redemption", "Regret", "Regrets", "Resilience", "Respect", "Riddles", "Ruins", "Runes", "Salvation", "Secrecy", "Secrets", "Serenity", "Shadows", "Shifting Sands", "Silence", "Slaughter", "Slaying", "Smite", "Solitude", "Souls", "Stealth", "Stone", "Storms", "Strength", "Subtlety", "Suffering", "Suffering's End", "Sunfire", "Sunlight", "Swordbreaking", "Tears", "Terror", "Terrors", "Thieves", "Thorns", "Thunder", "Thunders", "Titans", "Torment", "Traitors", "Trust", "Truth", "Truths", "Twilight", "Twilight's End", "Twisted Visions", "Undoing", "Unholy Blight", "Unholy Might", "Valiance", "Valor", "Vengeance", "Vigor", "Visions", "War", "Whispers", "Wisdom", "Woe", "Wonders", "Wraiths", "Zeal", "the Ancients", "the Archer", "the Banished", "the Basilisk", "the Bear", "the Beast", "the Berserker", "the Blessed", "the Boar", "the Breaking Storm", "the Brotherhood", "the Burning Sun", "the Caged Mind", "the Cataclysm", "the Champion", "the Claw", "the Corrupted", "the Covenant", "the Crown", "the Crusader", "the Damned", "the Day", "the Daywalker", "the Dead", "the Depth", "the Depths", "the Dragons", "the Dreadlord", "the Eagle", "the Earth", "the East", "the Eclipse", "the Emperor", "the End", "the Enigma", "the Fallen", "the Falling Sky", "the Flames", "the Forest", "the Forests", "the Forgotten", "the Forsaken", "the Gargoyle", "the Gladiator", "the Gods", "the Harvest", "the Hunter", "the Immortal", "the Immortals", "the Incoming Storm", "the Insane", "the Isles", "the King", "the Knight", "the Lasting Night", "the Leviathan", "the Light", "the Lion", "the Lionheart", "the Lone Victor", "the Lone Wolf", "the Lost", "the Mage", "the Moon", "the Moonwalker", "the Mountain", "the Mountains", "the Night", "the Night Sky", "the Nightstalker", "the North", "the Occult", "the Oracle", "the Phoenix", "the Plague", "the Prince", "the Princess", "the Prisoner", "the Prodigy", "the Prophecy", "the Prophet", "the Protector", "the Queen", "the Scourge", "the Seer", "the Serpent", "the Setting Sun", "the Shadows", "the Sky", "the South", "the Stars", "the Steward", "the Storm", "the Summoner", "the Sun", "the Sunwalker", "the Swamp", "the Talon", "the Titans", "the Undying", "the Victor", "the Void", "the Volcano", "the Ward", "the Warrior", "the West", "the Whale", "the Whispers", "the Wicked", "the Wind", "the Wolf", "the World", "the Wretched" });
            List<string> names = new List<string>();

            var type = random.Next(2);

            if (type == 1)
            {
                names4 = new List<string>(new string[] { "Cloth", "Heavy Hide", "Heavy Leather", "Hide", "Leather", "Linen", "Padded", "Quilted", "Rugged Leather", "Scaled", "Silk", "Wool" });
                names5 = new List<string>(new string[] { "Bandana", "Cap", "Coif", "Cowl", "Facemask", "Headguard", "Headpiece", "Helm", "Hood", "Mask" });
                names6 = new List<string>(new string[] { "Armament", "Bandana", "Bane", "Birth", "Blessing", "Blight", "Bond", "Boon", "Burden", "Call", "Cap", "Champion", "Coif", "Conqueror", "Cowl", "Crusader", "Cry", "Curator", "Dawn", "Death", "Defender", "Defiler", "Deflector", "Demise", "Destroyer", "Edge", "Emissary", "End", "Ender", "Facemask", "Fall", "Favor", "Foe", "Fortune", "Gift", "Glory", "Guard", "Guardian", "Headguard", "Headpiece", "Heirloom", "Helm", "Hero", "Hood", "Hope", "Incarnation", "Keeper", "Last Hope", "Last Stand", "Legacy", "Mask", "Memory", "Might", "Oath", "Pact", "Pledge", "Promise", "Protection", "Protector", "Reach", "Shepherd", "Soul", "Steward", "Terror", "Token", "Tribute", "Vengeance", "Vindicator", "Visage", "Voice", "Ward", "Warden", "Whisper", "Wit" });
            }
            else
            {
                names4 = new List<string>(new string[] { "Adamantite", "Plate", "Scaled", "Bone", "Bronze", "Bronzed", "Ivory", "Ebon", "Golden", "Iron", "Mithril", "Obsidian", "Silver", "Skeletal", "Steel", "Titanium", "Demon" });
                names5 = new List<string>(new string[] { "Casque", "Crown", "Faceguard", "Gaze", "Greathelm", "Headcover", "Headguard", "Helm", "Helmet", "Jaws", "Visage" });
                names6 = new List<string>(new string[] { "Armament", "Bane", "Birth", "Blessing", "Blight", "Bond", "Boon", "Burden", "Call", "Casque", "Champion", "Conqueror", "Crown", "Crusader", "Cry", "Curator", "Dawn", "Death", "Defender", "Defiler", "Deflector", "Demise", "Destroyer", "Edge", "Emissary", "End", "Ender", "Faceguard", "Fall", "Favor", "Foe", "Fortune", "Gaze", "Gift", "Glory", "Greathelm", "Guard", "Guardian", "Headcover", "Headguard", "Heirloom", "Helm", "Helmet", "Hero", "Hope", "Incarnation", "Jaws", "Keeper", "Last Hope", "Last Stand", "Legacy", "Memory", "Might", "Oath", "Pact", "Pledge", "Promise", "Protection", "Protector", "Reach", "Shepherd", "Soul", "Steward", "Terror", "Token", "Tribute", "Vengeance", "Vindicator", "Visage", "Voice", "Ward", "Warden", "Whisper", "Wit" });
            }
            for (int i = 0; i < 10; i++)
            {
                if (i < 2)
                {
                    rnd0 = random.Next(names1.Count);
                    rnd1 = random.Next(names2.Count);
                    rnd2 = random.Next(names5.Count);
                    names.Add(names5[rnd2] + " of " + names1[rnd0] + " " + names2[rnd1]);
                }
                else if (i < 4)
                {
                    rnd0 = random.Next(names1.Count);
                    rnd1 = random.Next(names2.Count);
                    rnd2 = random.Next(names4.Count);
                    rnd3 = random.Next(names5.Count);
                    names.Add(names4[rnd2] + " " + names5[rnd3] + " of " + names1[rnd0] + " " + names2[rnd1]);
                }
                else if (i < 6)
                {
                    rnd0 = random.Next(names3.Count);
                    rnd1 = random.Next(names4.Count);
                    rnd2 = random.Next(names5.Count);
                    names.Add(names3[rnd0] + " " + names4[rnd1] + " " + names5[rnd2]);
                }
                else if (i < 8)
                {
                    rnd0 = random.Next(names3.Count);
                    rnd1 = random.Next(names5.Count);
                    rnd2 = random.Next(names7.Count);
                    names.Add(names3[rnd0] + " " + names5[rnd1] + " of " + names7[rnd2]);
                }
                else
                {
                    rnd0 = random.Next(names6.Count);
                    rnd1 = random.Next(names7.Count);
                    names.Add(names6[rnd0] + " of " + names7[rnd1]);
                }
            }
            return names[random.Next(names.Count)].ToString();
        }

        /// <summary>
        /// returns a randomly generated string/name for a chestpiece
        /// </summary>
        /// <returns></returns>
        private string GenerateChestName()
        {
            Random random = new Random();
            var rnd = 0;
            var rnd2 = 0;
            var rnd3 = 0;
            var rnd4 = 0;
            List<string> nm4;
            List<string> nm5;
            List<string> nm6;

            List<string> nm1 = new List<string>(new string[] 
            { "Ancient", "Binding", "Blessed", "Blind", "Broken", "Burning", "Condemned", "Conquered", "Cursed", "Damned", "Dark", "Demonic", "Distant", "Divine", "Doomed", "Ending", "Endless", "Eternal", "Faded", "Fallen", "Fleeting", "Frozen", "Hallowed", "Haunted", "Hellish", "Holy", "Imminent", "Immortal", "Infernal", "Infinite", "Lost", "Ominous", "Relentless", "Sacred", "Shattered", "Silent", "Smoldering", "Timeless", "Twisted", "Unholy" });
            List<string> nm2 = new List<string>(new string[]
            { "Ancestors", "Bloodlust", "Comrades", "Damnation", "Dreams", "Fire", "Fires", "Fortune", "Fortunes", "Freedom", "Glory", "Hell", "Hells", "Honor", "Hope", "Illusions", "Justice", "Kings", "Lands", "Magic", "Memories", "Might", "Misery", "Nightmares", "Nights", "Power", "Powers", "Protection", "Punishment", "Sorrow", "Souls", "Torment", "Trials", "Vengeance", "Visions", "Voices", "Warlords", "Wars", "Whispers", "Worlds" });
            List<string> nm3 = new List<string>(new string[] 
            { "Ancient", "Arcane", "Atuned", "Bandit's", "Baneful", "Banished", "Barbarian", "Barbaric", "Battleworn", "Blood Infused", "Blood-Forged", "Bloodcursed", "Bloodied", "Bloodlord's", "Bloodsurge", "Brutal", "Brutality", "Burnished", "Captain's", "Cataclysm", "Cataclysmic", "Challenger", "Challenger's", "Champion", "Champion's", "Cold-Forged", "Conqueror", "Conqueror's", "Corrupted", "Crazed", "Crying", "Cursed", "Defender", "Defender's", "Defiled", "Demonic", "Desire's", "Desolation", "Destiny's", "Dire", "Doom", "Doom's", "Dragon's", "Dragon", "Ebon", "Enchanted", "Engraved", "Eternal", "Exile", "Extinction", "Faith's", "Faithful", "Fearful", "Feral", "Fierce", "Fiery", "Fire Infused", "Firesoul", "Forsaken", "Fortune's", "Frenzied", "Frost", "Frozen", "Furious", "Fusion", "Ghastly", "Ghost-Forged", "Ghostly", "Gladiator", "Gladiator's", "Grieving", "Guard's", "Guardian's", "Hatred", "Haunted", "Heartless", "Hero", "Hero's", "Hollow", "Holy", "Honed", "Honor's", "Hope's", "Hopeless", "Howling", "Hungering", "Incarnated", "Infused", "Inherited", "Jade Infused", "Judgement", "Keeper's", "Knightly", "Legionnaire's", "Liar's", "Lich", "Lightning", "Lonely", "Loyal", "Lusting", "Malevolent", "Malicious", "Malignant", "Massive", "Mended", "Mercenary", "Military", "Misfortune's", "Mourning", "Nightmare", "Oathkeeper's", "Ominous", "Peacekeeper", "Peacekeeper's", "Phantom", "Possessed", "Pride's", "Primal", "Prime", "Primitive", "Promised", "Protector's", "Proud", "Recruit's", "Reforged", "Reincarnated", "Relentless", "Remorse", "Renewed", "Renovated", "Restored", "Retribution", "Ritual", "Roaring", "Ruby Infused", "Rune-Forged", "Savage", "Sentinel", "Shadow", "Silent", "Singing", "Sinister", "Soldier's", "Solitude's", "Sorrow's", "Soul", "Soul Infused", "Soul-Forged", "Soulless", "Spectral", "Spite", "Storm", "Storm-Forged", "Stormfury", "Stormguard", "Terror", "Thunder", "Thunder-Forged", "Thunderfury", "Thunderguard", "Thundersoul", "Thunderstorm", "Timeworn", "Tormented", "Trainee's", "Treachery's", "Twilight", "Twilight's", "Twisted", "Tyrannical", "Undead", "Unholy", "Vanquisher", "Vengeance", "Vengeful", "Vicious", "Victor", "Vindication", "Vindicator", "Vindictive", "War-Forged", "Warden's", "Warlord's", "Warped", "Warrior", "Warrior's", "Whistling", "Wicked", "Wind's", "Wind-Forged", "Windsong", "Woeful", "Wrathful", "Wretched", "Yearning", "Zealous", "", "", "", "", "", "", "", "", "" });
            List<string> nm7 = new List<string>(new string[] 
            { "Absorption", "the Phoenix", "Adventure", "Agony", "Ancient Power", "Ancient Powers", "Anger", "Anguish", "Annihilation", "Arcane Magic", "Arcane Power", "Arcane Resist", "Archery", "Ashes", "Assassination", "Assassins", "Assaults", "Auras", "Awareness", "Barriers", "Beginnings", "Binding", "Black Magic", "Blast Protection", "Blessed Fortune", "Blessed Fortunes", "Blessings", "Blight", "Blood", "Bloodlust", "Bloodshed", "Bravery", "Broken Bones", "Broken Dreams", "Broken Families", "Broken Worlds", "Burdens", "Carnage", "Cataclysms", "Chaos", "Clarity", "Conquered Worlds", "Corruption", "Courage", "Creation", "Cunning", "Danger", "Dark Magic", "Dark Powers", "Dark Souls", "Darkness", "Dawn", "Decay", "Deception", "Defiance", "Deflection", "Delirium", "Delusions", "Demon Fire", "Demons", "Denial", "Desecration", "Despair", "Destruction", "Devotion", "Diligence", "Discipline", "Dishonor", "Dismay", "Dominance", "Domination", "Doom", "Dragons", "Dragonsouls", "Dread", "Dreams", "Due Diligence", "Duels", "Dusk", "Echoes", "Enchantments", "Ended Dreams", "Ending Hope", "Ending Misery", "Ends", "Eternal Bloodlust", "Eternal Damnation", "Eternal Glory", "Eternal Justice", "Eternal Rest", "Eternal Sorrow", "Eternal Struggles", "Eternity", "Executions", "Extinction", "Faded Memories", "Fallen Kings", "Fallen Souls", "Fire", "Fire Magic", "Fire Power", "Fire Protection", "Fire Resist", "Fools", "Forging", "Fortitude", "Fortune", "Frost", "Frost Power", "Frost Resist", "Frozen Hells", "Fury", "Ghosts", "Giants", "Giantslaying", "Glory", "Grace", "Greed", "Grieving Widows", "Guardians", "Hate", "Hatred", "Healing", "Hell", "Hell's Games", "Hellfire", "Hellish Torment", "Heroes", "Holy Might", "Honor", "Hope", "Horrors", "Ice", "Ice Magic", "Illusions", "Immortality", "Inception", "Infinite Trials", "Infinity", "Insanity", "Justice", "Kings", "Life", "Lifemending", "Lifestealing", "Light's Hope", "Limbo", "Lost Comrades", "Lost Hope", "Lost Souls", "Lost Voices", "Lost Worlds", "Mercy", "Might", "Miracles", "Misery", "Mists", "Moonlight", "Mysteries", "Mystery", "Nature", "Necromancy", "Nightmares", "Oblivion", "Paradise", "Patience", "Phantoms", "Power", "Prayers", "Pride", "Pride's Fall", "Prophecies", "Protection", "Putrefaction", "Reckoning", "Recoil", "Redemption", "Regret", "Regrets", "Resilience", "Respect", "Riddles", "Ruins", "Runes", "Salvation", "Secrecy", "Secrets", "Serenity", "Shadows", "Shifting Sands", "Silence", "Slaughter", "Slaying", "Smite", "Solitude", "Souls", "Stealth", "Stone", "Storms", "Strength", "Subtlety", "Suffering", "Suffering's End", "Sunfire", "Sunlight", "Swordbreaking", "Tears", "Terror", "Terrors", "Thieves", "Thorns", "Thunder", "Thunders", "Titans", "Torment", "Traitors", "Trust", "Truth", "Truths", "Twilight", "Twilight's End", "Twisted Visions", "Undoing", "Unholy Blight", "Unholy Might", "Valiance", "Valor", "Vengeance", "Vigor", "Visions", "War", "Whispers", "Wisdom", "Woe", "Wonders", "Wraiths", "Zeal", "the Ancients", "the Archer", "the Banished", "the Basilisk", "the Bear", "the Beast", "the Berserker", "the Blessed", "the Boar", "the Breaking Storm", "the Brotherhood", "the Burning Sun", "the Caged Mind", "the Cataclysm", "the Champion", "the Claw", "the Corrupted", "the Covenant", "the Crown", "the Crusader", "the Damned", "the Day", "the Daywalker", "the Dead", "the Depth", "the Depths", "the Dragons", "the Dreadlord", "the Eagle", "the Earth", "the East", "the Eclipse", "the Emperor", "the End", "the Enigma", "the Fallen", "the Falling Sky", "the Flames", "the Forest", "the Forests", "the Forgotten", "the Forsaken", "the Gargoyle", "the Gladiator", "the Gods", "the Harvest", "the Hunter", "the Immortal", "the Immortals", "the Incoming Storm", "the Insane", "the Isles", "the King", "the Knight", "the Lasting Night", "the Leviathan", "the Light", "the Lion", "the Lionheart", "the Lone Victor", "the Lone Wolf", "the Lost", "the Mage", "the Moon", "the Moonwalker", "the Mountain", "the Mountains", "the Night", "the Night Sky", "the Nightstalker", "the North", "the Occult", "the Oracle", "the Phoenix", "the Plague", "the Prince", "the Princess", "the Prisoner", "the Prodigy", "the Prophecy", "the Prophet", "the Protector", "the Queen", "the Scourge", "the Seer", "the Serpent", "the Setting Sun", "the Shadows", "the Sky", "the South", "the Stars", "the Steward", "the Storm", "the Summoner", "the Sun", "the Sunwalker", "the Swamp", "the Talon", "the Titans", "the Undying", "the Victor", "the Void", "the Volcano", "the Ward", "the Warrior", "the West", "the Whale", "the Whispers", "the Wicked", "the Wind", "the Wolf", "the World", "the Wretched" });
            List<string> names = new List<string>();

            var type = random.Next(2);
            if (type == 1)
            {
                nm4 = new List<string>(new string[] 
                { "Cloth", "Heavy Hide", "Heavy Leather", "Hide", "Leather", "Linen", "Padded", "Quilted", "Rugged Leather", "Scaled", "Silk", "Wool", "Embroided" });
                nm5 = new List<string>(new string[] 
                { "Breastplate", "Tunic", "Wraps", "Vest", "Vestment", "Robes", "Chestguard", "Jerkin", "Raiment", "Garments" });
                nm6 = new List<string>(new string[] 
                { "Armament", "Bane", "Bond", "Boon", "Call", "Champion", "Conqueror", "Crusader", "Cry", "Curator", "Dawn", "Fall", "End", "Demise", "Birth", "Death", "Edge", "Blight", "Burden", "Blessing", "Fortune", "Defender", "Defiler", "Deflector", "Destroyer", "Emissary", "Ender", "Favor", "Foe", "Gift", "Glory", "Guard", "Guardian", "Heirloom", "Hero", "Hope", "Incarnation", "Keeper", "Last Hope", "Last Stand", "Legacy", "Memory", "Might", "Oath", "Pact", "Pledge", "Promise", "Protection", "Protector", "Reach", "Shepherd", "Soul", "Steward", "Terror", "Token", "Tribute", "Vengeance", "Vindicator", "Visage", "Voice", "Ward", "Warden", "Whisper", "Wit", "Breastplate", "Tunic", "Wraps", "Vest", "Vestment", "Robes", "Chestguard", "Jerkin", "Raiment", "Garments" });
            }
            else
            {
                nm4 = new List<string>(new string[] 
                { "Adamantite", "Scaled", "Bone", "Bronze", "Bronzed", "Ivory", "Ebon", "Golden", "Iron", "Mithril", "Obsidian", "Silver", "Skeletal", "Steel", "Mail", "Chain", "Chainmail", "Titanium", "Demon" });
                nm5 = new List<string>(new string[]
                { "Vest", "Chestguard", "Armor", "Tunic", "Breastplate", "Chestplate", "Batteplate", "Chestpiece", "Cuirass", "Greatplate" });
                nm6 = new List<string>(new string[] 
                { "Armament", "Scales", "Guard", "Bastion", "Steel", "Defense", "Bane", "Bond", "Boon", "Call", "Champion", "Conqueror", "Crusader", "Cry", "Curator", "Dawn", "Fall", "End", "Demise", "Birth", "Death", "Edge", "Blight", "Burden", "Blessing", "Fortune", "Defender", "Defiler", "Deflector", "Destroyer", "Emissary", "Ender", "Favor", "Foe", "Gift", "Glory", "Guard", "Guardian", "Heirloom", "Hero", "Hope", "Incarnation", "Keeper", "Last Hope", "Last Stand", "Legacy", "Memory", "Might", "Oath", "Pact", "Pledge", "Promise", "Protection", "Protector", "Reach", "Shepherd", "Soul", "Steward", "Terror", "Token", "Tribute", "Vengeance", "Vindicator", "Visage", "Voice", "Ward", "Warden", "Whisper", "Wit", "Vest", "Chestguard", "Armor", "Tunic", "Breastplate", "Chestplate", "Batteplate", "Chestpiece", "Cuirass", "Greatplate" });
            }
            for (int i = 0; i < 10; i++)
            {
                if (i < 2)
                {
                    rnd = random.Next(nm1.Count);
                    rnd2 = random.Next(nm2.Count);
                    rnd3 = random.Next(nm5.Count);
                    names.Add(nm5[rnd3] + " of " + nm1[rnd] + " " + nm2[rnd2]);
                }
                else if (i < 4)
                {
                    rnd = random.Next(nm1.Count);
                    rnd2 = random.Next(nm2.Count);
                    rnd3 = random.Next(nm4.Count);
                    rnd4 = random.Next(nm5.Count);
                    names.Add(nm4[rnd3] + " " + nm5[rnd4] + " of " + nm1[rnd] + " " + nm2[rnd2]);
                }
                else if (i < 6)
                {
                    rnd = random.Next(nm3.Count);
                    rnd2 = random.Next(nm4.Count);
                    rnd3 = random.Next(nm5.Count);
                    names.Add(nm3[rnd] + " " + nm4[rnd2] + " " + nm5[rnd3]);
                }
                else if (i < 8)
                {
                    rnd = random.Next(nm3.Count);
                    rnd2 = random.Next(nm5.Count);
                    rnd3 = random.Next(nm7.Count);
                    names.Add(nm3[rnd] + " " + nm5[rnd2] + " of " + nm7[rnd3]);
                }
                else
                {
                    rnd = random.Next(nm6.Count);
                    rnd2 = random.Next(nm7.Count);
                    names.Add(nm6[rnd] + " of " + nm7[rnd2]);
                }
            }
            return names[random.Next(names.Count)].ToString();
        }

        /// <summary>
        /// returns a randomly generated string/name for gloves
        /// </summary>
        /// <returns></returns>
        private string GenerateGloveName()
        {
            Random random = new Random();
            var rnd = 0;
            var rnd1 = 0;
            var rnd2 = 0;
            var rnd3 = 0;
            List<string> names4;
            List<string> names5;


            List<string> names = new List<string>();

            List<string> names1 = new List<string>(new string[] 
            { "Ancient", "Binding", "Blessed", "Blind", "Broken", "Burning", "Condemned", "Conquered", "Cursed", "Damned", "Dark", "Demonic", "Distant", "Divine", "Doomed", "Ending", "Endless", "Eternal", "Faded", "Fallen", "Fleeting", "Frozen", "Hallowed", "Haunted", "Hellish", "Holy", "Imminent", "Immortal", "Infernal", "Infinite", "Lost", "Ominous", "Relentless", "Sacred", "Shattered", "Silent", "Smoldering", "Timeless", "Twisted", "Unholy" });
            List<string> names2 = new List<string>(new string[] 
            { "Ancestors", "Bloodlust", "Comrades", "Damnation", "Dreams", "Fire", "Fires", "Fortune", "Fortunes", "Freedom", "Glory", "Hell", "Hells", "Honor", "Hope", "Illusions", "Justice", "Kings", "Lands", "Magic", "Memories", "Might", "Misery", "Nightmares", "Nights", "Power", "Powers", "Protection", "Punishment", "Sorrow", "Souls", "Torment", "Trials", "Vengeance", "Visions", "Voices", "Warlords", "Wars", "Whispers", "Worlds" });
            List<string> names3 = new List<string>(new string[] 
            { "Ancient", "Arcane", "Atuned", "Bandit's", "Baneful", "Banished", "Barbarian", "Barbaric", "Battleworn", "Blood Infused", "Blood-Forged", "Bloodcursed", "Bloodied", "Bloodlord's", "Bloodsurge", "Brutal", "Brutality", "Burnished", "Captain's", "Cataclysm", "Cataclysmic", "Challenger", "Challenger's", "Champion", "Champion's", "Cold-Forged", "Conqueror", "Conqueror's", "Corrupted", "Crazed", "Crying", "Cursed", "Defender", "Defender's", "Defiled", "Demonic", "Desire's", "Desolation", "Destiny's", "Dire", "Doom", "Doom's", "Dragon's", "Dragon", "Ebon", "Enchanted", "Engraved", "Eternal", "Exile", "Extinction", "Faith's", "Faithful", "Fearful", "Feral", "Fierce", "Fiery", "Fire Infused", "Firesoul", "Forsaken", "Fortune's", "Frenzied", "Frost", "Frozen", "Furious", "Fusion", "Ghastly", "Ghost-Forged", "Ghostly", "Gladiator", "Gladiator's", "Grieving", "Guard's", "Guardian's", "Hatred", "Haunted", "Heartless", "Hero", "Hero's", "Hollow", "Holy", "Honed", "Honor's", "Hope's", "Hopeless", "Howling", "Hungering", "Incarnated", "Infused", "Inherited", "Jade Infused", "Judgement", "Keeper's", "Knightly", "Legionnaire's", "Liar's", "Lich", "Lightning", "Lonely", "Loyal", "Lusting", "Malevolent", "Malicious", "Malignant", "Massive", "Mended", "Mercenary", "Military", "Misfortune's", "Mourning", "Nightmare", "Oathkeeper's", "Ominous", "Peacekeeper", "Peacekeeper's", "Phantom", "Possessed", "Pride's", "Primal", "Prime", "Primitive", "Promised", "Protector's", "Proud", "Recruit's", "Reforged", "Reincarnated", "Relentless", "Remorse", "Renewed", "Renovated", "Restored", "Retribution", "Ritual", "Roaring", "Ruby Infused", "Rune-Forged", "Savage", "Sentinel", "Shadow", "Silent", "Singing", "Sinister", "Soldier's", "Solitude's", "Sorrow's", "Soul", "Soul Infused", "Soul-Forged", "Soulless", "Spectral", "Spite", "Storm", "Storm-Forged", "Stormfury", "Stormguard", "Terror", "Thunder", "Thunder-Forged", "Thunderfury", "Thunderguard", "Thundersoul", "Thunderstorm", "Timeworn", "Tormented", "Trainee's", "Treachery's", "Twilight", "Twilight's", "Twisted", "Tyrannical", "Undead", "Unholy", "Vanquisher", "Vengeance", "Vengeful", "Vicious", "Victor", "Vindication", "Vindicator", "Vindictive", "War-Forged", "Warden's", "Warlord's", "Warped", "Warrior", "Warrior's", "Whistling", "Wicked", "Wind's", "Wind-Forged", "Windsong", "Woeful", "Wrathful", "Wretched", "Yearning", "Zealous", "", "", "", "", "", "", "", "", "" });
            List<string> names6 = new List<string>(new string[] 
            { "Absorption", "Grips", "Tight Grips", "the Archer", "Archer", "Keen Aim", "Precision", "Perseverance", "Firmness", "Stability", "Steady Hands", "Fidelity", "Silence", "Muffled Steps", "Fleet Feet", "the Phoenix", "Adventure", "Agony", "Ancient Power", "Ancient Powers", "Anger", "Anguish", "Annihilation", "Arcane Magic", "Arcane Power", "Arcane Resist", "Archery", "Ashes", "Assassination", "Assassins", "Assaults", "Auras", "Awareness", "Barriers", "Beginnings", "Binding", "Black Magic", "Blast Protection", "Blessed Fortune", "Blessed Fortunes", "Blessings", "Blight", "Blood", "Bloodlust", "Bloodshed", "Bravery", "Broken Bones", "Broken Dreams", "Broken Families", "Broken Worlds", "Burdens", "Carnage", "Cataclysms", "Chaos", "Clarity", "Conquered Worlds", "Corruption", "Courage", "Creation", "Cunning", "Danger", "Dark Magic", "Dark Powers", "Dark Souls", "Darkness", "Dawn", "Decay", "Deception", "Defiance", "Deflection", "Delirium", "Delusions", "Demon Fire", "Demons", "Denial", "Desecration", "Despair", "Destruction", "Devotion", "Diligence", "Discipline", "Dishonor", "Dismay", "Dominance", "Domination", "Doom", "Dragons", "Dragonsouls", "Dread", "Dreams", "Due Diligence", "Duels", "Dusk", "Echoes", "Enchantments", "Ended Dreams", "Ending Hope", "Ending Misery", "Ends", "Eternal Bloodlust", "Eternal Damnation", "Eternal Glory", "Eternal Justice", "Eternal Rest", "Eternal Sorrow", "Eternal Struggles", "Eternity", "Executions", "Extinction", "Faded Memories", "Fallen Kings", "Fallen Souls", "Fire", "Fire Magic", "Fire Power", "Fire Protection", "Fire Resist", "Fools", "Forging", "Fortitude", "Fortune", "Frost", "Frost Power", "Frost Resist", "Frozen Hells", "Fury", "Ghosts", "Giants", "Giantslaying", "Glory", "Grace", "Greed", "Grieving Widows", "Guardians", "Hate", "Hatred", "Healing", "Hell", "Hell's Games", "Hellfire", "Hellish Torment", "Heroes", "Holy Might", "Honor", "Hope", "Horrors", "Ice", "Ice Magic", "Illusions", "Immortality", "Inception", "Infinite Trials", "Infinity", "Insanity", "Justice", "Kings", "Life", "Lifemending", "Lifestealing", "Light's Hope", "Limbo", "Lost Comrades", "Lost Hope", "Lost Souls", "Lost Voices", "Lost Worlds", "Mercy", "Might", "Miracles", "Misery", "Mists", "Moonlight", "Mysteries", "Mystery", "Nature", "Necromancy", "Nightmares", "Oblivion", "Paradise", "Patience", "Phantoms", "Power", "Prayers", "Pride", "Pride's Fall", "Prophecies", "Protection", "Putrefaction", "Reckoning", "Recoil", "Redemption", "Regret", "Regrets", "Resilience", "Respect", "Riddles", "Ruins", "Runes", "Salvation", "Secrecy", "Secrets", "Serenity", "Shadows", "Shifting Sands", "Silence", "Slaughter", "Slaying", "Smite", "Solitude", "Souls", "Stealth", "Stone", "Storms", "Strength", "Subtlety", "Suffering", "Suffering's End", "Sunfire", "Sunlight", "Swordbreaking", "Tears", "Terror", "Terrors", "Thieves", "Thorns", "Thunder", "Thunders", "Titans", "Torment", "Traitors", "Trust", "Truth", "Truths", "Twilight", "Twilight's End", "Twisted Visions", "Undoing", "Unholy Blight", "Unholy Might", "Valiance", "Valor", "Vengeance", "Vigor", "Visions", "War", "Whispers", "Wisdom", "Woe", "Wonders", "Wraiths", "Zeal", "the Ancients", "the Archer", "the Banished", "the Basilisk", "the Bear", "the Beast", "the Berserker", "the Blessed", "the Boar", "the Breaking Storm", "the Brotherhood", "the Burning Sun", "the Caged Mind", "the Cataclysm", "the Champion", "the Claw", "the Corrupted", "the Covenant", "the Crown", "the Crusader", "the Damned", "the Day", "the Daywalker", "the Dead", "the Depth", "the Depths", "the Dragons", "the Dreadlord", "the Eagle", "the Earth", "the East", "the Eclipse", "the Emperor", "the End", "the Enigma", "the Fallen", "the Falling Sky", "the Flames", "the Forest", "the Forests", "the Forgotten", "the Forsaken", "the Gargoyle", "the Gladiator", "the Gods", "the Harvest", "the Hunter", "the Immortal", "the Immortals", "the Incoming Storm", "the Insane", "the Isles", "the King", "the Knight", "the Lasting Night", "the Leviathan", "the Light", "the Lion", "the Lionheart", "the Lone Victor", "the Lone Wolf", "the Lost", "the Mage", "the Moon", "the Moonwalker", "the Mountain", "the Mountains", "the Night", "the Night Sky", "the Nightstalker", "the North", "the Occult", "the Oracle", "the Phoenix", "the Plague", "the Prince", "the Princess", "the Prisoner", "the Prodigy", "the Prophecy", "the Prophet", "the Protector", "the Queen", "the Scourge", "the Seer", "the Serpent", "the Setting Sun", "the Shadows", "the Sky", "the South", "the Stars", "the Steward", "the Storm", "the Summoner", "the Sun", "the Sunwalker", "the Swamp", "the Talon", "the Titans", "the Undying", "the Victor", "the Void", "the Volcano", "the Ward", "the Warrior", "the West", "the Whale", "the Whispers", "the Wicked", "the Wind", "the Wolf", "the World", "the Wretched" });

            var type = 0;
            if (type == 2)
            {
                names4 = new List<string>(new string[] 
                { "Cloth", "Heavy Hide", "Heavy Leather", "Hide", "Leather", "Linen", "Padded", "Quilted", "Rugged Leather", "Scaled", "Silk", "Wool", "Embroided" });
                names5 = new List<string>(new string[] 
                { "Gauntlets", "Grips", "Gloves", "Handguards", "Fists", "Hands", "Grasps", "Stranglers", "Handwraps", "Touch" });
            }
            else
            {
                names4 = new List<string>(new string[] 
                { "Adamantite", "Scaled", "Bone", "Bronze", "Bronzed", "Ivory", "Ebon", "Golden", "Iron", "Mithril", "Obsidian", "Silver", "Skeletal", "Steel", "Mail", "Chain", "Chainmail", "Titanium", "Demon" });
                names5 = new List<string>(new string[] 
                { "Gauntlets", "Grips", "Gloves", "Handguards", "Fists", "Hands", "Grasps", "Warfists" });
            }

            for (int i = 0; i < 10; i++)
            {
                if (i < 2)
                {
                    rnd = random.Next(names1.Count);
                    rnd1 = random.Next(names2.Count);
                    rnd2 = random.Next(names5.Count);
                    names.Add(names5[rnd2] + " of " + names1[rnd] + " " + names2[rnd1]);
                }
                else if (i < 4)
                {
                    rnd = random.Next(names1.Count);
                    rnd1 = random.Next(names2.Count);
                    rnd2 = random.Next(names4.Count);
                    rnd3 = random.Next(names5.Count);
                    names.Add(names4[rnd2] + " " + names5[rnd3] + " of " + names1[rnd] + " " + names2[rnd1]);
                }
                else if (i < 7)
                {
                    rnd = random.Next(names3.Count);
                    rnd1 = random.Next(names4.Count);
                    rnd2 = random.Next(names5.Count);
                    names.Add(names3[rnd] + " " + names4[rnd1] + " " + names5[rnd2]);
                }
                else
                {
                    rnd = random.Next(names3.Count);
                    rnd1 = random.Next(names5.Count);
                    rnd2 = random.Next(names6.Count);
                    names.Add(names3[rnd] + " " + names5[rnd1] + " of " + names6[rnd2]);
                }
            }
            return names[random.Next(names.Count)].ToString();
        }

        /// <summary>
        /// returns a randomly generated string/name for boots
        /// </summary>
        /// <returns></returns>
        private string GenerateBootsName()
        {
            Random random = new Random();
            var rnd0 = 0;
            var rnd1 = 0;
            var rnd2 = 0;
            var rnd3 = 0;
            List<string> names = new List<string>();
            List<String> names4;
            List<string> names5;

            var names1 = new List<string>(new string[] 
            { "Ancient", "Binding", "Blessed", "Blind", "Broken", "Burning", "Condemned", "Conquered", "Cursed", "Damned", "Dark", "Demonic", "Distant", "Divine", "Doomed", "Ending", "Endless", "Eternal", "Faded", "Fallen", "Fleeting", "Frozen", "Hallowed", "Haunted", "Hellish", "Holy", "Imminent", "Immortal", "Infernal", "Infinite", "Lost", "Ominous", "Relentless", "Sacred", "Shattered", "Silent", "Smoldering", "Timeless", "Twisted", "Unholy" });
            var names2 = new List<string>(new string[] 
            { "Ancestors", "Bloodlust", "Comrades", "Damnation", "Dreams", "Fire", "Fires", "Fortune", "Fortunes", "Freedom", "Glory", "Hell", "Hells", "Honor", "Hope", "Illusions", "Justice", "Kings", "Lands", "Magic", "Memories", "Might", "Misery", "Nightmares", "Nights", "Power", "Powers", "Protection", "Punishment", "Sorrow", "Souls", "Torment", "Trials", "Vengeance", "Visions", "Voices", "Warlords", "Wars", "Whispers", "Worlds" });
            var names3 = new List<string>(new string[]
            { "Ancient", "Arcane", "Atuned", "Bandit's", "Baneful", "Banished", "Barbarian", "Barbaric", "Battleworn", "Blood Infused", "Blood-Forged", "Bloodcursed", "Bloodied", "Bloodlord's", "Bloodsurge", "Brutal", "Brutality", "Burnished", "Captain's", "Cataclysm", "Cataclysmic", "Challenger", "Challenger's", "Champion", "Champion's", "Cold-Forged", "Conqueror", "Conqueror's", "Corrupted", "Crazed", "Crying", "Cursed", "Defender", "Defender's", "Defiled", "Demonic", "Desire's", "Desolation", "Destiny's", "Dire", "Doom", "Doom's", "Dragon's", "Dragon", "Ebon", "Enchanted", "Engraved", "Eternal", "Exile", "Extinction", "Faith's", "Faithful", "Fearful", "Feral", "Fierce", "Fiery", "Fire Infused", "Firesoul", "Forsaken", "Fortune's", "Frenzied", "Frost", "Frozen", "Furious", "Fusion", "Ghastly", "Ghost-Forged", "Ghostly", "Gladiator", "Gladiator's", "Grieving", "Guard's", "Guardian's", "Hatred", "Haunted", "Heartless", "Hero", "Hero's", "Hollow", "Holy", "Honed", "Honor's", "Hope's", "Hopeless", "Howling", "Hungering", "Incarnated", "Infused", "Inherited", "Jade Infused", "Judgement", "Keeper's", "Knightly", "Legionnaire's", "Liar's", "Lich", "Lightning", "Lonely", "Loyal", "Lusting", "Malevolent", "Malicious", "Malignant", "Massive", "Mended", "Mercenary", "Military", "Misfortune's", "Mourning", "Nightmare", "Oathkeeper's", "Ominous", "Peacekeeper", "Peacekeeper's", "Phantom", "Possessed", "Pride's", "Primal", "Prime", "Primitive", "Promised", "Protector's", "Proud", "Recruit's", "Reforged", "Reincarnated", "Relentless", "Remorse", "Renewed", "Renovated", "Restored", "Retribution", "Ritual", "Roaring", "Ruby Infused", "Rune-Forged", "Savage", "Sentinel", "Shadow", "Silent", "Singing", "Sinister", "Soldier's", "Solitude's", "Sorrow's", "Soul", "Soul Infused", "Soul-Forged", "Soulless", "Spectral", "Spite", "Storm", "Storm-Forged", "Stormfury", "Stormguard", "Terror", "Thunder", "Thunder-Forged", "Thunderfury", "Thunderguard", "Thundersoul", "Thunderstorm", "Timeworn", "Tormented", "Trainee's", "Treachery's", "Twilight", "Twilight's", "Twisted", "Tyrannical", "Undead", "Unholy", "Vanquisher", "Vengeance", "Vengeful", "Vicious", "Victor", "Vindication", "Vindicator", "Vindictive", "War-Forged", "Warden's", "Warlord's", "Warped", "Warrior", "Warrior's", "Whistling", "Wicked", "Wind's", "Wind-Forged", "Windsong", "Woeful", "Wrathful", "Wretched", "Yearning", "Zealous", "", "", "", "", "", "", "", "", "" });
            var names7 = new List<string>(new string[] 
            { "Absorption", "Steadiness", "Water Walking", "Perseverance", "Firmness", "Stability", "the Elephant", "the Mammoth", "Fidelity", "Silence", "Muffled Steps", "Fleet Feet", "the Phoenix", "Adventure", "Agony", "Ancient Power", "Ancient Powers", "Anger", "Anguish", "Annihilation", "Arcane Magic", "Arcane Power", "Arcane Resist", "Archery", "Ashes", "Assassination", "Assassins", "Assaults", "Auras", "Awareness", "Barriers", "Beginnings", "Binding", "Black Magic", "Blast Protection", "Blessed Fortune", "Blessed Fortunes", "Blessings", "Blight", "Blood", "Bloodlust", "Bloodshed", "Bravery", "Broken Bones", "Broken Dreams", "Broken Families", "Broken Worlds", "Burdens", "Carnage", "Cataclysms", "Chaos", "Clarity", "Conquered Worlds", "Corruption", "Courage", "Creation", "Cunning", "Danger", "Dark Magic", "Dark Powers", "Dark Souls", "Darkness", "Dawn", "Decay", "Deception", "Defiance", "Deflection", "Delirium", "Delusions", "Demon Fire", "Demons", "Denial", "Desecration", "Despair", "Destruction", "Devotion", "Diligence", "Discipline", "Dishonor", "Dismay", "Dominance", "Domination", "Doom", "Dragons", "Dragonsouls", "Dread", "Dreams", "Due Diligence", "Duels", "Dusk", "Echoes", "Enchantments", "Ended Dreams", "Ending Hope", "Ending Misery", "Ends", "Eternal Bloodlust", "Eternal Damnation", "Eternal Glory", "Eternal Justice", "Eternal Rest", "Eternal Sorrow", "Eternal Struggles", "Eternity", "Executions", "Extinction", "Faded Memories", "Fallen Kings", "Fallen Souls", "Fire", "Fire Magic", "Fire Power", "Fire Protection", "Fire Resist", "Fools", "Forging", "Fortitude", "Fortune", "Frost", "Frost Power", "Frost Resist", "Frozen Hells", "Fury", "Ghosts", "Giants", "Giantslaying", "Glory", "Grace", "Greed", "Grieving Widows", "Guardians", "Hate", "Hatred", "Healing", "Hell", "Hell's Games", "Hellfire", "Hellish Torment", "Heroes", "Holy Might", "Honor", "Hope", "Horrors", "Ice", "Ice Magic", "Illusions", "Immortality", "Inception", "Infinite Trials", "Infinity", "Insanity", "Justice", "Kings", "Life", "Lifemending", "Lifestealing", "Light's Hope", "Limbo", "Lost Comrades", "Lost Hope", "Lost Souls", "Lost Voices", "Lost Worlds", "Mercy", "Might", "Miracles", "Misery", "Mists", "Moonlight", "Mysteries", "Mystery", "Nature", "Necromancy", "Nightmares", "Oblivion", "Paradise", "Patience", "Phantoms", "Power", "Prayers", "Pride", "Pride's Fall", "Prophecies", "Protection", "Putrefaction", "Reckoning", "Recoil", "Redemption", "Regret", "Regrets", "Resilience", "Respect", "Riddles", "Ruins", "Runes", "Salvation", "Secrecy", "Secrets", "Serenity", "Shadows", "Shifting Sands", "Silence", "Slaughter", "Slaying", "Smite", "Solitude", "Souls", "Stealth", "Stone", "Storms", "Strength", "Subtlety", "Suffering", "Suffering's End", "Sunfire", "Sunlight", "Swordbreaking", "Tears", "Terror", "Terrors", "Thieves", "Thorns", "Thunder", "Thunders", "Titans", "Torment", "Traitors", "Trust", "Truth", "Truths", "Twilight", "Twilight's End", "Twisted Visions", "Undoing", "Unholy Blight", "Unholy Might", "Valiance", "Valor", "Vengeance", "Vigor", "Visions", "War", "Whispers", "Wisdom", "Woe", "Wonders", "Wraiths", "Zeal", "the Ancients", "the Archer", "the Banished", "the Basilisk", "the Bear", "the Beast", "the Berserker", "the Blessed", "the Boar", "the Breaking Storm", "the Brotherhood", "the Burning Sun", "the Caged Mind", "the Cataclysm", "the Champion", "the Claw", "the Corrupted", "the Covenant", "the Crown", "the Crusader", "the Damned", "the Day", "the Daywalker", "the Dead", "the Depth", "the Depths", "the Dragons", "the Dreadlord", "the Eagle", "the Earth", "the East", "the Eclipse", "the Emperor", "the End", "the Enigma", "the Fallen", "the Falling Sky", "the Flames", "the Forest", "the Forests", "the Forgotten", "the Forsaken", "the Gargoyle", "the Gladiator", "the Gods", "the Harvest", "the Hunter", "the Immortal", "the Immortals", "the Incoming Storm", "the Insane", "the Isles", "the King", "the Knight", "the Lasting Night", "the Leviathan", "the Light", "the Lion", "the Lionheart", "the Lone Victor", "the Lone Wolf", "the Lost", "the Mage", "the Moon", "the Moonwalker", "the Mountain", "the Mountains", "the Night", "the Night Sky", "the Nightstalker", "the North", "the Occult", "the Oracle", "the Phoenix", "the Plague", "the Prince", "the Princess", "the Prisoner", "the Prodigy", "the Prophecy", "the Prophet", "the Protector", "the Queen", "the Scourge", "the Seer", "the Serpent", "the Setting Sun", "the Shadows", "the Sky", "the South", "the Stars", "the Steward", "the Storm", "the Summoner", "the Sun", "the Sunwalker", "the Swamp", "the Talon", "the Titans", "the Undying", "the Victor", "the Void", "the Volcano", "the Ward", "the Warrior", "the West", "the Whale", "the Whispers", "the Wicked", "the Wind", "the Wolf", "the World", "the Wretched" });

            var type = random.Next(2);
            if (type == 2)
            {
                names4 = new List<string>(new string[] 
                { "Cloth", "Heavy Hide", "Heavy Leather", "Hide", "Leather", "Linen", "Padded", "Quilted", "Rugged Leather", "Scaled", "Silk", "Wool", "Embroided" });
                names5 = new List<string>(new string[] 
                { "Sprinters", "Sandals", "Boots", "Heels", "Treads", "Feet", "Footguards", "Footpads", "Walkers", "Footsteps" });
            }
            else
            {
                names4 = new List<string>(new string[] 
                { "Adamantite", "Scaled", "Bone", "Bronze", "Bronzed", "Ivory", "Ebon", "Golden", "Iron", "Mithril", "Obsidian", "Silver", "Skeletal", "Steel", "Mail", "Chain", "Chainmail", "Titanium", "Demon" });
                names5 = new List<string>(new string[] 
                { "Boots", "Greaves", "Stompers", "Greatboots", "Treads", "Spurs", "Warboots", "Sabatons", "Feet", "Walkers", "Footguards" });
            }

            for (int i = 0; i < 10; i++)
            {
                if (i < 2)
                {
                    rnd0 = random.Next(names1.Count);
                    rnd1 = random.Next(names2.Count);
                    rnd2 = random.Next(names5.Count);
                    names.Add(names5[rnd2] + " of " + names1[rnd0] + " " + names2[rnd1]);
                }
                else if (i < 4)
                {
                    rnd0 = random.Next(names1.Count);
                    rnd1 = random.Next(names2.Count);
                    rnd2 = random.Next(names4.Count);
                    rnd3 = random.Next(names5.Count);
                    names.Add(names4[rnd2] + " " + names5[rnd3] + " of " + names1[rnd0] + " " + names2[rnd1]);
                }
                else if (i < 7)
                {
                    rnd0 = random.Next(names3.Count);
                    rnd1 = random.Next(names4.Count);
                    rnd2 = random.Next(names5.Count);
                    names.Add(names3[rnd0] + " " + names4[rnd1] + " " + names5[rnd2]);
                }
                else
                {
                    rnd0 = random.Next(names3.Count);
                    rnd1 = random.Next(names5.Count);
                    rnd2 = random.Next(names7.Count);
                    names.Add(names3[rnd0] + " " + names5[rnd1] + " of " + names7[rnd2]);
                }
            }
            return names[random.Next(names.Count)].ToString();
        }
    }
}