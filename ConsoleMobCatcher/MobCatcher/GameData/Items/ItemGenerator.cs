using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace MobCatcher.GameData.Items
{
    public class ItemGenerator
    {
        /// <summary>
        /// randomly generates an item/weapon and gives it name and  itemID
        /// </summary>
        /// <returns></returns>
        public ItemProperty GenerateRandomItem()
        {
            ItemNameGenerator itemNameGenerator = new ItemNameGenerator();
            WeaponNameGenerator weaponnameGenerator = new WeaponNameGenerator();
            Random random = new Random();
            ItemProperty item = new ItemProperty();

            if (random.Next(2) == 1)
            {
                item.ItemID = random.Next(1, 6);
                item.Name = itemNameGenerator.GenerateItemName(item.ItemID);
            }
            else
            {
                item.ItemID = random.Next(6, 11);
                item.Name = weaponnameGenerator.GenerateRandomWeaponName(item.ItemID);
            }
            
            
            item.Stats = GenerateItemStats();
            
            return item;
        }

        /// <summary>
        /// gives an item/weapon a random list of stats
        /// </summary>
        /// <returns></returns>
        private List<PrimaryItemStat> GenerateItemStats()
        {
            List<PrimaryItemStat> temp = new List<PrimaryItemStat>();
            Random random = new Random();
            temp.Add(new PrimaryItemStat { Attack = random.Next(50, 150), Defence = random.Next(50, 150), Health = random.Next(150, 500), speed = random.Next(1,15)});

            return temp;
        }
    }
}