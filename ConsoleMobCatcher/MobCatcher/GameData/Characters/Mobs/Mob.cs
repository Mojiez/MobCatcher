using System;
using System.Collections.Generic;
using System.Text;
using MobCatcher.GameData.Characters.Mobs.StatProperties;

namespace MobCatcher.GameData.Characters.Mobs
{
    public class Mob
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public double Xp { get; set; }
        public int Health { get; set; }
        public int Defence { get; set; }
        public int Speed { get; set; }
        public int[] Attack { get; set; } = new int[2];
        public List<PositiveStat> PositiveStats { get; set; } = new List<PositiveStat>();
        public List<NegativeStat> NegativeStats { get; set; } = new List<NegativeStat>();
        public Mob(string name)
        {
            Name = name;
            Level = 1;
            Xp = 0;
            Health = 25;
            Defence = 1;
            Speed = 1;
            Attack[0] = 2;
            Attack[1] = 10;
        }
        public override string ToString()
        {
            StringBuilder positiveBuilder = new StringBuilder();
            StringBuilder negativeBuilder = new StringBuilder();
            foreach (var item in PositiveStats)
            {
                positiveBuilder.Append($"{item}\n");
            }
            foreach (var item in NegativeStats)
            {
                negativeBuilder.Append($"{item}\n");
            }

            return $"Name = {Name}\nLevel = {Level}\nHealth = {Health}\nDefence = {Defence}\nSpeed = {Speed}\nMin Attack = {Attack[0]}  Max = {Attack[1]}\n\nPositive Stats\n{positiveBuilder} \n\nNegative Stats\n{negativeBuilder}";
        }
    }
}
