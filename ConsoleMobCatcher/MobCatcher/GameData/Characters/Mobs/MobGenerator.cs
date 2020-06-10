using System;
using System.Collections.Generic;
using System.Text;
using MobCatcher.GameData.Characters.Mobs.StatProperties;

namespace MobCatcher.GameData.Characters.Mobs
{
    //The number of extra is 6 if the nuber is 2 it has a 50% chance to role one negative stat
    public class MobGenerator
    {
        private NegativeStat NegativeMobStat { get; set; }
        private PositiveStat PositiveMobStat { get; set; }
        private ExperinceCalculation XpCalculation { get; set; } = new ExperinceCalculation();
        private StatCalculation StatCalculation { get; set; } = new StatCalculation();
        private StatCheck StatCheck { get; set; } 
        private Mob GenerateNewStatOnLevelUp(Mob mob)
        {
            StatCheck = StatCalculation.GetRandomStat(mob);
            int statnumber = StatCheck.NumberOfNegativeStats + StatCheck.NumberOfPositiveStats;
            int mobstats = mob.NegativeStats.Count + mob.PositiveStats.Count;
            if (mobstats < statnumber)
            {
                GenerateMobStats(mob);
            }
            return mob;
        }
        private Mob GainLevel(Mob mob)
        {
            while (mob.Xp >= XpCalculation.CalculateAmountOfXpToNextLevel(mob))
            {
                mob.Level++;
                GenerateNewStatOnLevelUp(mob);
            }
            return mob;
        }
        /// <summary>
        /// Adds the amount of xp gained from mob killed (Enemy Mob)
        /// Then checks if its enough for level up with GainLevel
        /// Returns the mob afterwards
        /// </summary>
        /// <param name="mob"></param>
        /// <param name="enemy"></param>
        /// <returns></returns>
        public Mob GainExperince(Mob mob, Mob enemy)
        {
            mob.Xp += XpCalculation.GetXpGain(enemy, mob);
            GainLevel(mob);
            return mob;
        }
        //This method should only be used for generating enemys.. 
        public Mob GenerateRandomEnemyMob(int mobLevel)
        {
            //No longer missing name Generator
            Mob enemy = GenerateMob();
            enemy.Level = mobLevel;  
            enemy.Xp = XpCalculation.CalculateAmountOfXpToNextLevel(enemy);
            GenerateMobStats(enemy);
            return enemy;
        }
      
        public Mob GenerateMob()
        {
            Mob newmob = new Mob(GenerateMobName());
            return newmob;
        }

        public int GetNumberOfExtraStats(Mob mob)
        {
            return mob.Level / 8;
        }
       
        public Mob GenerateMobStats(Mob mob)
        {
            StatCheck statCheck;
            statCheck = StatCalculation.GetRandomStat(mob);
            mob.PositiveStats = GeneratePositiveStats(statCheck);
            mob.NegativeStats = GenerateNegativeStats(statCheck);
            return mob;
        }
        public List<PositiveStat> GeneratePositiveStats(StatCheck stats)
        {
            List<PositiveStat> positiveStats = new List<PositiveStat>();
            Random random = new Random();
            for (int i = 0; i < stats.NumberOfPositiveStats; i++)
            {
                PositiveMobStat = (PositiveStat)random.Next(6);
                if (positiveStats.Contains(PositiveMobStat))
                {
                    i--;
                }
                else
                {
                    positiveStats.Add(PositiveMobStat);
                }

            }
            return positiveStats;
        }
        public List<NegativeStat> GenerateNegativeStats(StatCheck stats)
        {
            List<NegativeStat> negativeStats = new List<NegativeStat>();
            Random random = new Random();
            for (int i = 0; i < stats.NumberOfNegativeStats; i++)
            {
                NegativeMobStat = (NegativeStat)random.Next(6);
                if (negativeStats.Contains(NegativeMobStat))
                {
                    i--;
                }
                else
                {
                    negativeStats.Add(NegativeMobStat);
                }

            }
            return negativeStats;
        }

        private string GenerateMobName()
        {
            Random r = new Random();
            int length = r.Next(3, 6);
            string[] consonants = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "l", "n", "p", "q", "r", "s", "sh", "zh", "t", "v", "w", "x" };
            string[] vowels = { "a", "e", "i", "o", "u", "ae", "y" };
            string Name = string.Empty;
            Name += consonants[r.Next(consonants.Length)].ToUpper();
            Name += vowels[r.Next(vowels.Length)];
            int b = 2; //b tells how many times a new letter has been added. It's 2 right now because the first two letters are already in the name.
            while (b < length)
            {
                Name += consonants[r.Next(consonants.Length)];
                b++;
                Name += vowels[r.Next(vowels.Length)];
                b++;
            }
            return Name;
        }
    }
}