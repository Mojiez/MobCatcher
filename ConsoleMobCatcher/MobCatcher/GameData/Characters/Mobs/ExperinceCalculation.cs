using MobCatcher.GameData.Characters.Mobs.StatProperties;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobCatcher.GameData.Characters.Mobs
{
    public class ExperinceCalculation
    {
        /// <summary>
        /// Will take in a mob depending on level it will calculate the amount of experince needed for next lvl and return it
        /// </summary>
        /// <param name="mob"></param>
        /// <returns></returns>
        public double CalculateAmountOfXpToNextLevel(Mob mob)
        {
            int timestocalculate = mob.Level;
            double xpneeded = 1200;
            for (int i = 1; i < timestocalculate; i++)
            {
                xpneeded += Math.Round(xpneeded * 0.2);
            }
            return xpneeded;
        }
       /// <summary>
       /// Will calculate the amount of experince subtration for the mob when it kills another mob
       /// </summary>
       /// <param name="level"></param>
       /// <returns></returns>
        private double XpGainModifier(int level)
        {
            double modifier = 0.1, modified = 0.7;
            for (int i = 0; i < level; i++)
            {
                if(modifier > 0.005)
                {
                    modifier = modifier * modified;
                }
                if(level > 20 && level < 30)
                {
                    modifier = modifier * modified;
                }
            }
            return modifier;
        }
        /// <summary>
        /// Takes in the mob that kills and the mob killed then use the XpGainModifier method to calculate what amount of experince the killed would yield
        /// </summary>
        /// <param name="killedmob"></param>
        /// <param name="mobGainXp"></param>
        /// <returns></returns>
        private double CalculateXpGain(Mob killedmob, Mob mobGettingXp)
        {
            return killedmob.Xp * XpGainModifier(mobGettingXp.Level); 
        }
        public double GetXpGain(Mob killedMob, Mob mobGettingXp)
        {
            return CalculateXpGain(killedMob, mobGettingXp); 
        }
    }
}
