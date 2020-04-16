using MobCatcher.GameData.Characters.Mobs.StatProperties;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobCatcher.GameData.Characters.Mobs
{
    class StatCalculation
    {
        int[] percentchance = { 2, 4, 5, 6, 7, 5 };
        public StatCheck GetRandomStat(Mob mob)
        {
            Random random = new Random();
            StatCheck statCheck = new StatCheck();
            int numberofstats = mob.Level / 8;
            int mobstats = mob.NegativeStats.Count + mob.PositiveStats.Count; 
            for (int i = 0; i < numberofstats; i++)
            {
                int chanceNumber = random.Next(1, 11);
                if (chanceNumber <= percentchance[numberofstats - 1])
                {
                    statCheck.NumberOfNegativeStats++;
                }
                else
                {
                    statCheck.NumberOfPositiveStats++;
                }
            }
            return statCheck;
        }
      
        public int SpeedStatModifier(Mob mob)
        {
            return mob.Level;
        }
    }
}
