using MobCatcher.GameData.Characters.Mobs;
using MobCatcher.GameData.Characters.Mobs.MobTypes;
using MobCatcher.GameData.Characters.Mobs.StatProperties;
using MobCatcher.GameData.Items;
using MobCatcher.GameGraphics;
using System;
using System.Collections.Generic;
using System.IO;

namespace MobCatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            GameMenu menu = new GameMenu();
            StatCalculation statCalculation = new StatCalculation();
            MobGenerator mobGenerator = new MobGenerator();
            ItemGenerator itemGenerator = new ItemGenerator();
            ExperinceCalculation calculation = new ExperinceCalculation();
            /*
            for (int i = 1; i <= 50; i++)
            {
                Mob mob = mobGenerator.GenerateRandomEnemyMob(i);
                statCalculation.SpeedStatModifier(mob);
                statCalculation.DefenceStatModifier(mob);
                statCalculation.HealthStatModifier(mob);
                statCalculation.AttackModifier(mob);
                Console.WriteLine("Speed = " + mob.Speed + " Level = " + i);
                Console.WriteLine("Defence = " + mob.Defence + " Level = " + i);
                Console.WriteLine("Health = " + mob.Health + " Level = " + i);
                Console.WriteLine("MinAttack = " + mob.Attack[0] + " MaxAttack = " + mob.Attack[1]);
                Console.WriteLine();
            }
            */
            #region StatCheck with mob lvl
            //List<StatCheck> statChecks = new List<StatCheck>();
            //for (int i = 0; i < 100; i++)
            //{
            //    StatCheck statCheck = new StatCheck();
            //    Mob testMob = mobGenerator.GenerateMob("Testie");
            //    Mob testEnemy = mobGenerator.GenerateRandomEnemyMob(50);

            //    mobGenerator.GainExperince(testMob, testEnemy);
            //    statCheck.NumberOfNegativeStats = testMob.NegativeStats.Count;
            //    statCheck.NumberOfPositiveStats = testMob.PositiveStats.Count;
            //    statChecks.Add(statCheck);
            //}
            //int greenCount = 0, yellowCount = 0, redCount = 0;
            //foreach (var item in statChecks)
            //{
            //    if (item.NumberOfPositiveStats == 4)
            //    {
            //        Console.ForegroundColor = ConsoleColor.Green;
            //        greenCount++;
            //    }
            //    else if (item.NumberOfPositiveStats >= 2)
            //    {
            //        Console.ForegroundColor = ConsoleColor.Yellow;
            //        yellowCount++;
            //    }
            //    else
            //    {
            //        Console.ForegroundColor = ConsoleColor.Red;
            //        redCount++;
            //    }
            //    Console.WriteLine($"PositiveStats = {item.NumberOfPositiveStats}   NegativeStats = {item.NumberOfNegativeStats}");

            //}
            //Console.ForegroundColor = ConsoleColor.White;
            //Console.WriteLine($"Green = {greenCount} Yellow = {yellowCount} Red = {redCount}");
            #endregion
            
            #region ItemGenerator test
            for (int i = 0; i < 50; i++)
            {
                ItemProperty item = itemGenerator.GenerateRandomItem();
                Console.WriteLine("Name: " + item.Name);
                Console.WriteLine("itemID: " + item.ItemID);
                foreach(var stat in item.Stats)
                {
                    Console.WriteLine("Health: " + stat.Health);
                    Console.WriteLine("Attack: " + stat.Attack);
                    Console.WriteLine("Defence: " + stat.Defence);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
            #endregion

            //int PCount = 0, NCount = 0, EvenCount = 0, GoodCount = 0, MediumCount = 0, BadCount = 0;
            #region Statcheck Test 1
            //for (int i = 0; i < 100; i++)
            //{
            //    statCheck = calculation.GetRandomStat(mob1);
            //    Console.WriteLine($"Negative = {statCheck.NumberOfNegativeStats} Positive = {statCheck.NumberOfPositiveStats} |Mob lvl 8 - 15");
            //    Console.WriteLine("-----------------------------------------------");
            //    if(statCheck.NumberOfPositiveStats == 1)
            //    {
            //        PCount++;
            //    }
            //    else
            //    {
            //        NCount++;
            //    }

            //    statCheck = calculation.GetRandomStat(mob2);
            //    Console.WriteLine($"Negative = {statCheck.NumberOfNegativeStats} Positive = {statCheck.NumberOfPositiveStats} |Mob lvl 16 - 23");
            //    Console.WriteLine("-----------------------------------------------");

            //    statCheck = calculation.GetRandomStat(mob3);
            //    Console.WriteLine($"Negative = {statCheck.NumberOfNegativeStats} Positive = {statCheck.NumberOfPositiveStats} |Mob lvl 24 - 31");
            //    Console.WriteLine("-----------------------------------------------");

            //    statCheck = calculation.GetRandomStat(mob4);
            //    Console.WriteLine($"Negative = {statCheck.NumberOfNegativeStats} Positive = {statCheck.NumberOfPositiveStats}  |Mob lvl 32 - 39");
            //    Console.WriteLine("-----------------------------------------------");

            //    statCheck = calculation.GetRandomStat(mob5);
            //    Console.WriteLine($"Negative = {statCheck.NumberOfNegativeStats} Positive = {statCheck.NumberOfPositiveStats}  |Mob lvl 40 - 47");
            //    Console.WriteLine("-----------------------------------------------");

            //    statCheck = calculation.GetRandomStat(mob6);
            //    Console.WriteLine($"Negative = {statCheck.NumberOfNegativeStats} Positive = {statCheck.NumberOfPositiveStats}  |Mob lvl 48 - 50");
            //    Console.WriteLine("-----------------------------------------------");
            //    Console.WriteLine();
            //}
            //Console.WriteLine($"Positive Count {PCount}\nNegative Count {NCount}");
            #endregion
            #region StatCheck Test 2
            //for (int i = 0; i < 1000000; i++)
            //{
            //    Console.WriteLine($"Test number {i}");
            //    for (int j = 0; j < 100; j++)
            //    {
            //        statCheck = calculation.GetRandomStat(mob2);
            //        if (statCheck.NumberOfNegativeStats == 2)
            //        {
            //            NCount++;
            //        }
            //        else if (statCheck.NumberOfPositiveStats == 2)
            //        {
            //            PCount++;
            //        }
            //        else
            //        {
            //            EvenCount++;
            //        }
            //    }
            //    if(NCount < 25)
            //    {
            //        Console.ForegroundColor = ConsoleColor.Green;
            //        GoodCount++;
            //    }
            //    else if (PCount > 25 && PCount < 50)
            //    {
            //        Console.ForegroundColor = ConsoleColor.Yellow;
            //        MediumCount++;
            //    }
            //    else
            //    {
            //        Console.ForegroundColor = ConsoleColor.Red;
            //        BadCount++;
            //    }
            //    Console.WriteLine($"Positive Count {PCount}\nNegative Count {NCount}\nEven Count {EvenCount}\n");
            //    Console.WriteLine($"Good {GoodCount}\nMedium {MediumCount}\nBad {BadCount}\n");
            //    PCount = 0;
            //    NCount = 0;
            //    EvenCount = 0;
            //}


            #endregion
            #region StatCheck Test 3
            //for (int i = 0; i < 1000000; i++)
            //{
            //    Console.WriteLine($"Test number {i}");
            //    for (int j = 0; j < 100; j++)
            //    {
            //        statCheck = calculation.GetRandomStat(mob2);
            //        if (statCheck.NumberOfNegativeStats == 3)
            //        {
            //            NCount++;
            //        }
            //        else if (statCheck.NumberOfPositiveStats == 3)
            //        {
            //            PCount++;
            //        }
            //        else
            //        {
            //            EvenCount++;
            //        }
            //    }
            //    if (EvenCount == 100)
            //    {
            //        Console.ForegroundColor = ConsoleColor.Green;
            //        GoodCount++;
            //    }
            //    else if (EvenCount < 100 && EvenCount > 95)
            //    {
            //        Console.ForegroundColor = ConsoleColor.Yellow;
            //        MediumCount++;
            //    }
            //    else
            //    {
            //        Console.ForegroundColor = ConsoleColor.Red;
            //        BadCount++;
            //    }
            //    Console.WriteLine($"Positive Count {PCount}\nNegative Count {NCount}\nEven Count {EvenCount}\n");
            //    Console.WriteLine($"Good {GoodCount}\nMedium {MediumCount}\nBad {BadCount}\n");
            //    PCount = 0;
            //    NCount = 0;
            //    EvenCount = 0;
            // }
            #endregion
            // menu.Print();
        }
    }
}