using MobCatcher.GameData.Characters.Mobs.StatProperties;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobCatcher.GameData.Characters.Mobs
{
    class StatCalculation
    {
        int[] percentchance = { 4, 4, 3, 3, 2, 1 };
        private Random random { get; set; } = new Random();
        public StatCheck GetRandomStat(Mob mob)
        {
            StatCheck statCheck = new StatCheck();
            int numberofstats = mob.Level / 8;
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
        public double DefenceStatModifier(Mob mob)
        {
            for (int i = 1; i < mob.Level; i++)
            {
                double defenceGain = i * 0.05;
                mob.Defence += defenceGain;
            }
            return mob.Defence;
        }
        public int SpeedStatModifier(Mob mob)
        {
            double statgain = 1;
            for (int i = 1; i < mob.Level; i++)
            {
                statgain = 2.94 * mob.Level + mob.Speed;
            }
            mob.Speed = Convert.ToInt32(statgain);
            return mob.Speed;
        }
        public int HealthStatModifier(Mob mob)
        {
            double healthGain = mob.Health;
            for (int i = 0; i < mob.Level; i++)
            {
                healthGain += healthGain * 0.15;
            }
            mob.Health = Convert.ToInt32(healthGain);
            return mob.Health;
        }

        public int[] AttackModifier(Mob mob)
        {
            double mindamg = 0, maxdamg = 0;
            for (int i = 0; i < mob.Level; i++)
            {
                mindamg += mob.Attack[0] * 0.1;
                maxdamg += mob.Attack[1] * 0.1;
            }
            mob.Attack[0] += Convert.ToInt32(Math.Round(mindamg));
            mob.Attack[1] += Convert.ToInt32(Math.Round(maxdamg));
            return mob.Attack;
        }
    }
}
